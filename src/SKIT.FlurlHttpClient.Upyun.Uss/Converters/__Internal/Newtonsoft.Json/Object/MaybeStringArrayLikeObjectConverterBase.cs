using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;

namespace Newtonsoft.Json.Converters.Internal
{
    using SKIT.FlurlHttpClient.Upyun.Uss.Utilities;

    internal abstract class MaybeStringArrayLikeObjectConverterBase<TModel> : JsonConverter
        where TModel : class, new()
    {
        public const string STRARR_PROPERTY_JSON_NAME = "#maybe-string-array-like";

        private static JsonObjectContract ResolveJsonType(Type type, JsonSerializer serializer)
        {
            IContractResolver resolver = serializer.ContractResolver ?? JsonSerializer.CreateDefault().ContractResolver;
            return (JsonObjectContract)resolver.ResolveContract(type);
        }

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

        public override bool CanRead
        {
            get { return true; }
        }

        public override bool CanWrite
        {
            get { return true; }
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType.IsClass && !objectType.IsAbstract && !objectType.IsInterface
                && typeof(TModel).IsAssignableFrom(objectType);
        }

        public override object? ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null)
            {
                return existingValue;
            }
            else if (reader.TokenType == JsonToken.StartObject)
            {
                TModel outputObj = existingValue as TModel ?? ReflectionHelper.CreateInstance<TModel>();

                JObject jObject = JObject.Load(reader);
                if (!jObject.Properties().Any())
                    return outputObj;

                JsonObjectContract jsonContract = ResolveJsonType(objectType, serializer);

                foreach (JProperty jProp in jObject.Properties())
                {
                    string propertyName = jProp.Name!;

                    JsonProperty? jsonProperty = jsonContract.Properties.GetClosestMatchProperty(propertyName);
                    if (jsonProperty is not null)
                    {
                        if (jsonProperty.Ignored && jsonProperty.PropertyName is null)
                            continue;
                        if (jsonProperty.ShouldDeserialize is not null && !jsonProperty.ShouldDeserialize(outputObj))
                            continue;
                        if (!jsonProperty.Writable)
                            continue;

                        object? propertyValue = jProp.Value?.ToObject(jsonProperty.PropertyType, CopyJsonSerializer(serializer, jsonProperty.Converter));
                        jsonProperty.ValueProvider!.SetValue(outputObj, propertyValue);
                    }
                    else if (jsonContract.ExtensionDataSetter is not null)
                    {
                        throw new NotSupportedException($"'{GetType().FullName}' does not support JsonExtensionData.");
                    }
                }

                return outputObj;
            }
            else if (reader.TokenType == JsonToken.StartArray)
            {
                TModel outputObj = existingValue as TModel ?? ReflectionHelper.CreateInstance<TModel>();

                SetStringArrayPropertyValue(outputObj, JArray.Load(reader).ToObject<string[]>()!);

                return outputObj;
            }
            
            throw new JsonException($"Unexpected JSON token type '{reader.TokenType}' when reading.");
        }

        public override void WriteJson(JsonWriter writer, object? inputObj, JsonSerializer serializer)
        {
            if (inputObj is null)
            {
                writer.WriteNull();
                return;
            }

            string[]? arrayLikeValue = GetStringArrayPropertyValue((inputObj as TModel)!);
            if (arrayLikeValue is null)
            {
                writer.WriteStartObject();

                JsonObjectContract jsonContract = ResolveJsonType(inputObj.GetType(), serializer);

                foreach (JsonProperty jsonProperty in jsonContract.Properties.OrderBy(e => e.Order))
                {
                    if (jsonProperty.Ignored && jsonProperty.PropertyName is null)
                        continue;
                    if (jsonProperty.ShouldSerialize is not null && !jsonProperty.ShouldSerialize(inputObj))
                        continue;
                    if (!jsonProperty.Readable)
                        continue;

                    string propertyName = jsonProperty.PropertyName ?? jsonProperty.UnderlyingName!;
                    if (STRARR_PROPERTY_JSON_NAME.Equals(propertyName))
                    {
                        continue;
                    }

                    object? propertyValue = jsonProperty.ValueProvider?.GetValue(inputObj);
                    if (propertyValue is null)
                    {
                        if (serializer.NullValueHandling == NullValueHandling.Include)
                        {
                            writer.WritePropertyName(propertyName);
                            writer.WriteNull();
                        }
                    }
                    else
                    {
                        writer.WritePropertyName(propertyName);

                        if (jsonProperty.Converter is not null && jsonProperty.Converter.CanWrite)
                            jsonProperty.Converter.WriteJson(writer, propertyValue, serializer);
                        else
                            serializer.Serialize(writer, propertyValue);
                    }
                }

                if (jsonContract.ExtensionDataGetter is not null)
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
                        writer.WriteNull();
                    else
                        writer.WriteValue(s);
                }

                writer.WriteEndArray();
            }
        }

        private JsonSerializer CopyJsonSerializer(JsonSerializer serializer, params JsonConverter?[] customConverters)
        {
            JsonSerializer serializerCopy = JsonSerializer.Create(serializer.ExtractSerializerSettings());
            serializerCopy.Converters.Remove(this);

            foreach (JsonConverter? converter in customConverters)
            {
                if (converter is not null)
                    serializerCopy.Converters.Add(converter);
            }

            return serializerCopy;
        }
    }
}
