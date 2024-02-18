using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.Json.Nodes;

namespace System.Text.Json.Serialization.Internal
{
    using SKIT.FlurlHttpClient.Upyun.Uss.Utilities;

    internal abstract partial class MaybeStringArrayLikeObjectConverterBase<TModel> : JsonConverter<TModel?>
        where TModel : class, new()
    {
        public const string STRARR_PROPERTY_JSON_NAME = "#maybe-string-array-like";

        /// <summary>
        /// 获取模型中可能为字符串数组的属性值。
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        protected abstract string[]? GetStringArrayPropertyValue(TModel model);

        /// <summary>
        /// 设置模型中可能为字符串数组的属性值。
        /// </summary>
        /// <param name="model"></param>
        /// <param name="value"></param>
        protected abstract void SetStringArrayPropertyValue(TModel model, string[]? value);

        public override bool CanConvert(Type typeToConvert)
        {
            return typeToConvert.IsClass && !typeToConvert.IsAbstract && !typeToConvert.IsInterface
                && typeof(TModel).IsAssignableFrom(typeToConvert);
        }

        public override TModel? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.Null)
            {
                return default;
            }
            else if (reader.TokenType == JsonTokenType.StartObject)
            {
                TModel outputObj = ReflectionHelper.CreateInstance<TModel>();

                JsonObject jObject = JsonObject.Parse(ref reader, new JsonNodeOptions() { PropertyNameCaseInsensitive = options.PropertyNameCaseInsensitive })!.AsObject();
                if (!jObject.Any())
                    return outputObj;

                JsonPropertyTypeInfo[] jsonPropertyTypes = JsonPropertyTypeInfoCache.GetOrAddJsonPropertyTypes(typeToConvert, options);

                foreach (KeyValuePair<string, JsonNode?> jProp in jObject)
                {
                    string propertyName = jProp.Key;

                    JsonPropertyTypeInfo? jsonPropertyType = jsonPropertyTypes.FirstOrDefault(e => propertyName == e.JsonPropertyName);
                    if (jsonPropertyType is null && options.PropertyNameCaseInsensitive)
                        jsonPropertyType = jsonPropertyTypes.FirstOrDefault(e => string.Equals(propertyName, e.JsonPropertyName, StringComparison.OrdinalIgnoreCase));

                    if (jsonPropertyType is not null)
                    {
                        object? propertyValue = jProp.Value?.Deserialize(jsonPropertyType.PropertyType, CopyJsonSerializerOptions(options, jsonPropertyType.JsonConverter));
                        ReflectionHelper.SetPropertyValue(outputObj, jsonPropertyType.Property, propertyValue);
                    }
                    else if (jsonPropertyTypes.Any(e => e.IsExtensionData))
                    {
                        throw new NotSupportedException($"'{GetType().FullName}' does not support JsonExtensionData.");
                    }
                }

                return outputObj;
            }
            else if (reader.TokenType == JsonTokenType.StartArray)
            {
                TModel outputObj = ReflectionHelper.CreateInstance<TModel>();

                SetStringArrayPropertyValue(outputObj, JsonArray.Parse(ref reader)!.Deserialize<string[]>());

                return outputObj;
            }

            throw new JsonException($"Unexpected JSON token type '{reader.TokenType}' when reading.");
        }

        public override void Write(Utf8JsonWriter writer, TModel? inputObj, JsonSerializerOptions options)
        {
            if (inputObj is null)
            {
                writer.WriteNullValue();
                return;
            }

            string[]? arrayLikeValue = GetStringArrayPropertyValue(inputObj);
            if (arrayLikeValue is null)
            {
                writer.WriteStartObject();

                JsonPropertyTypeInfo[] jsonPropertyTypes = JsonPropertyTypeInfoCache.GetOrAddJsonPropertyTypes(inputObj.GetType(), options);

                foreach (JsonPropertyTypeInfo jsonPropertyType in jsonPropertyTypes)
                {
                    if (jsonPropertyType.IsExtensionData)
                        continue;

                    string propertyName = jsonPropertyType.JsonPropertyName;
                    if (STRARR_PROPERTY_JSON_NAME.Equals(propertyName))
                    {
                        continue;
                    }

                    object? propertyValue = ReflectionHelper.GetPropertyValue<object>(inputObj, jsonPropertyType.Property);
                    if (propertyValue is null)
                    {
                        if (options.DefaultIgnoreCondition == JsonIgnoreCondition.Always || options.DefaultIgnoreCondition == JsonIgnoreCondition.WhenWritingNull)
                            continue;
                    }

                    writer.WritePropertyName(options.PropertyNamingPolicy?.ConvertName(propertyName) ?? propertyName);
                    writer.WriteRawValue(JsonSerializer.Serialize(propertyValue, CopyJsonSerializerOptions(options, jsonPropertyType.JsonConverter)), skipInputValidation: true);
                }

                if (jsonPropertyTypes.Any(e => e.IsExtensionData))
                {
                    throw new NotSupportedException($"'{GetType().FullName}' does not support JsonExtensionData.");
                }

                writer.WriteEndObject();
            }
            else
            {
                writer.WriteStartArray();

                foreach (string s in arrayLikeValue)
                {
                    if (s is null)
                        writer.WriteNullValue();
                    else
                        writer.WriteStringValue(s);
                }

                writer.WriteEndArray();
            }
        }

        private JsonSerializerOptions CopyJsonSerializerOptions(JsonSerializerOptions options, params JsonConverter?[] customConverters)
        {
            JsonSerializerOptions optionsCopy = new JsonSerializerOptions(options);
            optionsCopy.Converters.Remove(this);

            foreach (JsonConverter? converter in customConverters)
            {
                if (converter is not null)
                    optionsCopy.Converters.Add(converter);
            }

            return optionsCopy;
        }
    }

    partial class MaybeStringArrayLikeObjectConverterBase<TModel>
    {
        private class JsonPropertyTypeInfo
        {
            public PropertyInfo Property { get; }

            public Type PropertyType { get { return Property.PropertyType; } }

            public JsonIgnoreCondition JsonIgnoreCondition { get; }

            public JsonConverter? JsonConverter { get; }

            public string JsonPropertyName { get; }

            public int? JsonPropertyOrder { get; }

            public bool IsExtensionData { get; }

            public JsonPropertyTypeInfo(PropertyInfo property, JsonIgnoreCondition jsonIgnoreCondition, JsonConverter? jsonConverter, string jsonPropertyName, int? jsonPropertyOrder)
            {
                Property = property ?? throw new ArgumentNullException(nameof(property));
                JsonIgnoreCondition = jsonIgnoreCondition;
                JsonConverter = jsonConverter;
                JsonPropertyName = jsonPropertyName;
                JsonPropertyOrder = jsonPropertyOrder;
                IsExtensionData = property.IsDefined(typeof(JsonExtensionDataAttribute), inherit: true);
            }
        }

        private static class JsonPropertyTypeInfoCache
        {
            private static readonly Hashtable _cache = new Hashtable(capacity: 32);

            private static Type[] GetSortedTypeHierarchy(Type type)
            {
                if (!type.IsInterface)
                {
                    IList<Type> results = new List<Type>();
                    for (Type? current = type; current is not null; current = current.BaseType)
                    {
                        results.Add(current);
                    }

                    return results.ToArray();
                }
                else
                {
                    throw new NotSupportedException();
                }
            }

            private static PropertyInfo[] GetSerializableProperties(Type typeToConvert)
            {
                IList<PropertyInfo> results = new List<PropertyInfo>();

                foreach (PropertyInfo propertyInfo in typeToConvert.GetProperties(BindingFlags.Instance | BindingFlags.Public))
                {
                    if (propertyInfo.GetIndexParameters().Length > 0 ||
                       (propertyInfo.GetMethod?.IsAbstract == true || propertyInfo.SetMethod?.IsAbstract == true))
                    {
                        continue;
                    }

                    bool hasJsonIncludeAttribute = propertyInfo.GetCustomAttribute<JsonIncludeAttribute>(inherit: false) is not null;
                    if (propertyInfo.GetMethod?.IsPublic == true ||
                        propertyInfo.SetMethod?.IsPublic == true ||
                        hasJsonIncludeAttribute)
                    {
                        results.Add(propertyInfo);
                    }
                }

                return results.ToArray();
            }

            private static JsonIgnoreCondition GetPropertyJsonIgnoreCondition(PropertyInfo propertyInfo, JsonSerializerOptions jsonSerializerOptions)
            {
                JsonIgnoreAttribute? ignoreAttribute = propertyInfo.GetCustomAttribute<JsonIgnoreAttribute>(inherit: false);
                if (ignoreAttribute is not null)
                    return ignoreAttribute.Condition;

                return jsonSerializerOptions.DefaultIgnoreCondition;
            }

            private static JsonConverter? GetPropertyJsonConverter(PropertyInfo propertyInfo, JsonSerializerOptions jsonSerializerOptions)
            {
                JsonConverterAttribute? converterAttribute = propertyInfo.GetCustomAttribute<JsonConverterAttribute>(inherit: false);
                if (converterAttribute is null)
                    return null;

                Type? converterType = converterAttribute.ConverterType;
                if (converterType is null)
                    return converterAttribute.CreateConverter(propertyInfo.PropertyType)
                        ?? converterAttribute.CreateConverter(propertyInfo.ReflectedType ?? propertyInfo.DeclaringType!)
                        ?? jsonSerializerOptions.GetConverter(propertyInfo.PropertyType);
                else
                    return (JsonConverter)Activator.CreateInstance(converterType)!;
            }

            private static int? GetPropertyJsonOrder(PropertyInfo propertyInfo, JsonSerializerOptions jsonSerializerOptions)
            {
                JsonPropertyOrderAttribute? orderAttribute = propertyInfo.GetCustomAttribute<JsonPropertyOrderAttribute>(inherit: true);
                if (orderAttribute is not null)
                    return orderAttribute.Order;

                return null;
            }

            private static string GetPropertyJsonName(PropertyInfo propertyInfo, JsonSerializerOptions jsonSerializerOptions)
            {
                JsonPropertyNameAttribute? nameAttribute = propertyInfo.GetCustomAttribute<JsonPropertyNameAttribute>(inherit: true);
                if (nameAttribute is not null)
                    return nameAttribute.Name;
                else if (jsonSerializerOptions.PropertyNamingPolicy is not null)
                    return jsonSerializerOptions.PropertyNamingPolicy.ConvertName(propertyInfo.Name);
                else
                    return propertyInfo.Name;
            }

            public static JsonPropertyTypeInfo[] GetOrAddJsonPropertyTypes(Type typeToConvert, JsonSerializerOptions options)
            {
                JsonPropertyTypeInfo[]? results = _cache[typeToConvert] as JsonPropertyTypeInfo[];

                if (results is null)
                {
                    IList<JsonPropertyTypeInfo> temp = new List<JsonPropertyTypeInfo>();

                    foreach (Type currentType in GetSortedTypeHierarchy(typeToConvert))
                    {
                        if (currentType == typeof(Object) ||
                            currentType == typeof(ValueType))
                        {
                            break;
                        }

                        foreach (PropertyInfo propertyInfo in GetSerializableProperties(typeToConvert))
                        {
                            JsonIgnoreCondition jsonIgnoreCondition = GetPropertyJsonIgnoreCondition(propertyInfo, options);
                            JsonConverter? jsonConverter = GetPropertyJsonConverter(propertyInfo, options);
                            string jsonPropertyName = GetPropertyJsonName(propertyInfo, options);
                            int? jsonPropertyOrder = GetPropertyJsonOrder(propertyInfo, options);

                            if (!temp.Any(e => e.JsonPropertyName == jsonPropertyName))
                                temp.Add(new JsonPropertyTypeInfo(property: propertyInfo, jsonIgnoreCondition: jsonIgnoreCondition, jsonConverter: jsonConverter, jsonPropertyName: jsonPropertyName, jsonPropertyOrder: jsonPropertyOrder));
                        }
                    }

                    results = temp.OrderBy(e => e.JsonPropertyOrder).ToArray();
                    _cache[typeToConvert] = results;
                }

                return results;
            }
        }
    }
}
