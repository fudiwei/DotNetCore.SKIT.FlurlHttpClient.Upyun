using System.Collections;
using System.Linq;
using System.Reflection;

namespace System.Text.Json.Serialization.Internal
{
    internal static class ArrayLikeObjectReadOnlyConverterBase
    {
        public const string PROPERTY_NAME_LARRAY = "#array-like";
    }

    internal class ArrayLikeObjectReadOnlyConverterBase<T> : JsonConverter<T?>
        where T : class, new()
    {
        private sealed class InnerTypedJsonPropertyInfo
        {
            public string PropertyName { get; }

            public PropertyInfo PropertyInfo { get; }

            public Type PropertyType { get { return PropertyInfo.PropertyType; } }

            public bool PropertyIsLArray { get; }

            public JsonConverter? JsonConverter { get; }

            public InnerTypedJsonPropertyInfo(string propertyName, PropertyInfo propertyInfo, bool propertyIsLArray, JsonConverter? jsonConverter)
            {
                PropertyName = propertyName;
                PropertyInfo = propertyInfo;
                PropertyIsLArray = propertyIsLArray;
                JsonConverter = jsonConverter;
            }
        }

        private const string PROPERTY_NAME_LARRAY = ArrayLikeObjectReadOnlyConverterBase.PROPERTY_NAME_LARRAY;

        private static readonly Hashtable _mappedTypeJsonProperties = new Hashtable();

        public override bool CanConvert(Type typeToConvert)
        {
            return typeToConvert.IsClass && !typeToConvert.IsAbstract && !typeToConvert.IsInterface;
        }

        public override T? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.Null)
            {
                return default;
            }
            else if (reader.TokenType == JsonTokenType.StartObject ||
                     reader.TokenType == JsonTokenType.StartArray)
            {
                bool isArrayLike = reader.TokenType == JsonTokenType.StartArray;

                InnerTypedJsonPropertyInfo[] typedJsonProperties = GetTypedJsonProperties(typeToConvert);
                if (typedJsonProperties.Count(p => p.PropertyIsLArray) != 1)
                    throw new JsonException("The number of `array-like` properties must be only one.");

                T tObject = new T();
                JsonElement jElement = JsonDocument.ParseValue(ref reader).RootElement.Clone();

                if (isArrayLike)
                {
                    InnerTypedJsonPropertyInfo typedJsonPropertyInfo = typedJsonProperties.Single(e => e.PropertyIsLArray);
                    object? propertyValue = jElement.Deserialize(typedJsonPropertyInfo.PropertyType, GetClonedJsonSerializerOptions(options, null));
                    typedJsonPropertyInfo.PropertyInfo.SetValue(tObject, propertyValue);
                }
                else
                {
                    foreach (JsonProperty jProperty in jElement.EnumerateObject())
                    {
                        InnerTypedJsonPropertyInfo? typedJsonPropertyInfo = typedJsonProperties.SingleOrDefault(e => e.PropertyName == jProperty.Name);
                        if (typedJsonPropertyInfo is not null)
                        {
                            if (typedJsonPropertyInfo.PropertyIsLArray)
                                continue;

                            JsonSerializerOptions tmpOptions = GetClonedJsonSerializerOptions(options, typedJsonPropertyInfo.JsonConverter);
                            object? propertyValue = jProperty.Value.Deserialize(typedJsonPropertyInfo.PropertyType, tmpOptions);
                            typedJsonPropertyInfo.PropertyInfo.SetValue(tObject, propertyValue);
                        }
                    }
                }

                return tObject;
            }

            throw new JsonException();
        }

        public override void Write(Utf8JsonWriter writer, T? value, JsonSerializerOptions options)
        {
        }

        private static InnerTypedJsonPropertyInfo[] GetTypedJsonProperties(Type type)
        {
            if (type is null) throw new ArgumentNullException(nameof(type));

            string mappedKey = type.AssemblyQualifiedName ?? type.GetHashCode().ToString();
            InnerTypedJsonPropertyInfo[]? mappedValue = (InnerTypedJsonPropertyInfo[]?)_mappedTypeJsonProperties[mappedKey];

            if (mappedValue is null)
            {
                mappedValue = type.GetProperties(BindingFlags.Instance | BindingFlags.Public)
                    .Where(p =>
                    {
                        if (p.CanWrite || p.GetCustomAttributes<JsonIncludeAttribute>(inherit: true).Any())
                        {
                            return !p.GetCustomAttributes<JsonIgnoreAttribute>(inherit: false).Any();
                        }

                        return false;
                    })
                    .Select(p =>
                    {
                        string name = p.GetCustomAttribute<JsonPropertyNameAttribute>(inherit: true)?.Name ?? p.Name;
                        return new InnerTypedJsonPropertyInfo
                        (
                            propertyName: name,
                            propertyInfo: p,
                            propertyIsLArray: PROPERTY_NAME_LARRAY.Equals(name) && p.PropertyType.IsArray,
                            jsonConverter: GetTypedJsonConverter(p)
                        );
                    })
                    .OrderBy(e => e.PropertyInfo.GetCustomAttribute<JsonPropertyOrderAttribute>(inherit: true)?.Order)
                    .ToArray();
                _mappedTypeJsonProperties[mappedKey] = mappedValue;
            }

            return mappedValue;
        }

        private static JsonConverter? GetTypedJsonConverter(MemberInfo? memberInfo)
        {
            if (memberInfo is null)
                return null;

            return memberInfo.GetCustomAttributes<JsonConverterAttribute>(inherit: true)
                .OrderByDescending(attr => attr.IsDefaultAttribute())
                .Select(attr =>
                {
                    JsonConverter? converter = null;

                    if (memberInfo is Type type)
                    {
                        converter = attr.CreateConverter(type);
                    }
                    else if (memberInfo is PropertyInfo propertyInfo)
                    {
                        converter = attr.CreateConverter(propertyInfo.PropertyType);
                    }

                    if (converter is null && attr.ConverterType is not null)
                    {
                        converter = (JsonConverter)Activator.CreateInstance(attr.ConverterType)!;
                    }

                    return converter;
                })
                .FirstOrDefault(converter => converter is not null);
        }

        private static JsonSerializerOptions GetClonedJsonSerializerOptions(JsonSerializerOptions options, JsonConverter? converter)
        {
            JsonSerializerOptions optionsCopy = options;

            if (converter is not null)
            {
                optionsCopy = new JsonSerializerOptions(options);
                optionsCopy.Converters.Add(converter);
            }

            return optionsCopy;
        }
    }
}
