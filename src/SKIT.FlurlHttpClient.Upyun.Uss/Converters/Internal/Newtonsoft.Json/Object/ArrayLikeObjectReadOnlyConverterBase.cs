using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Newtonsoft.Json.Linq;

namespace Newtonsoft.Json.Converters
{
    internal static class ArrayLikeObjectReadOnlyConverterBase
    {
        public const string PROPERTY_NAME_LARRAY = "#array-like";
    }

    internal abstract partial class ArrayLikeObjectReadOnlyConverterBase<T> : JsonConverter
        where T : class, new()
    {
        private sealed class InnerTypedJsonPropertyInfo
        {
            public string PropertyName { get; }

            public PropertyInfo PropertyInfo { get; }

            public Type PropertyType { get { return PropertyInfo.PropertyType; } }

            public bool PropertyIsLArray { get; }

            public JsonConverter? JsonConverterOnRead { get; }

            public JsonConverter? JsonConverterOnWrite { get; }

            public InnerTypedJsonPropertyInfo(string propertyName, PropertyInfo propertyInfo, bool propertyIsLArray, JsonConverter? jsonReadConverter, JsonConverter? jsonWriteConverter)
            {
                PropertyName = propertyName;
                PropertyInfo = propertyInfo;
                PropertyIsLArray = propertyIsLArray;
                JsonConverterOnRead = jsonReadConverter;
                JsonConverterOnWrite = jsonWriteConverter;
            }
        }

        private const string PROPERTY_NAME_LARRAY = ArrayLikeObjectReadOnlyConverterBase.PROPERTY_NAME_LARRAY;

        private static readonly Hashtable _mappedTypeJsonProperties = new Hashtable();

        public override bool CanRead
        {
            get { return true; }
        }

        public override bool CanWrite
        {
            get { return false; }
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType.IsClass && !objectType.IsAbstract && !objectType.IsInterface;
        }

        public override object? ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null)
            {
                return existingValue;
            }
            else if (reader.TokenType == JsonToken.StartObject ||
                     reader.TokenType == JsonToken.StartArray)
            {
                bool isArrayLike = reader.TokenType == JsonToken.StartArray;

                InnerTypedJsonPropertyInfo[] typedJsonProperties = GetTypedJsonProperties(objectType);
                if (typedJsonProperties.Count(p => p.PropertyIsLArray) != 1)
                    throw new JsonSerializationException("The number of `array-like` properties must be only one.");

                T tObject = new T();

                if (isArrayLike)
                {
                    InnerTypedJsonPropertyInfo typedJsonPropertyInfo = typedJsonProperties.Single(e => e.PropertyIsLArray);
                    object? propertyValue = JToken.Load(reader).ToObject(typedJsonPropertyInfo.PropertyType, serializer);
                    typedJsonPropertyInfo.PropertyInfo.SetValue(tObject, propertyValue);
                }
                else
                {
                    JObject jObject = JObject.Load(reader);
                    foreach (JProperty jProperty in jObject.Properties())
                    {
                        InnerTypedJsonPropertyInfo? typedJsonPropertyInfo = typedJsonProperties.SingleOrDefault(e => e.PropertyName == jProperty.Name);
                        if (typedJsonPropertyInfo != null)
                        {
                            if (typedJsonPropertyInfo.PropertyIsLArray)
                                continue;

                            JsonSerializer tmpSerializer = GetClonedJsonSerializer(serializer, typedJsonPropertyInfo.JsonConverterOnRead);
                            object? propertyValue = jProperty.Value?.ToObject(typedJsonPropertyInfo.PropertyType, tmpSerializer);
                            typedJsonPropertyInfo.PropertyInfo.SetValue(tObject, propertyValue);
                        }
                        else if (serializer.MissingMemberHandling == MissingMemberHandling.Error)
                        {
                            throw new JsonSerializationException($"Could not find member `{jProperty.Name}` on object of type `{objectType.Name}`.");
                        }
                    }
                }

                return tObject;
            }

            throw new JsonSerializationException();
        }

        public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
        {
        }

        private static InnerTypedJsonPropertyInfo[] GetTypedJsonProperties(Type type)
        {
            if (type == null) throw new ArgumentNullException(nameof(type));

            string mappedKey = type.AssemblyQualifiedName ?? type.GetHashCode().ToString();
            InnerTypedJsonPropertyInfo[]? mappedValue = (InnerTypedJsonPropertyInfo[]?)_mappedTypeJsonProperties[mappedKey];

            if (mappedValue == null)
            {
                mappedValue = type.GetProperties(BindingFlags.Instance | BindingFlags.Public)
                    .Where(p =>
                    {
                        if (p.CanWrite || p.GetCustomAttributes<JsonPropertyAttribute>(inherit: true).Any())
                        {
                            return !p.GetCustomAttributes<JsonIgnoreAttribute>(inherit: false).Any();
                        }

                        return false;
                    })
                    .Select(p =>
                    {
                        string name = p.GetCustomAttribute<JsonPropertyAttribute>(inherit: true)?.PropertyName ?? p.Name;
                        IEnumerable<JsonConverter> converters = p.GetCustomAttributes<JsonConverterAttribute>(inherit: true)
                            .OrderByDescending(attr => attr.IsDefaultAttribute())
                            .Select(attr => (JsonConverter)Activator.CreateInstance(attr.ConverterType, attr.ConverterParameters)!);
                        JsonConverter? readConverter = converters.FirstOrDefault(c => c.CanRead);
                        JsonConverter? writeConverter = converters.FirstOrDefault(c => c.CanWrite);
                        return new InnerTypedJsonPropertyInfo
                        (
                            propertyName: name,
                            propertyInfo: p,
                            propertyIsLArray: PROPERTY_NAME_LARRAY.Equals(name) && p.PropertyType.IsArray,
                            jsonReadConverter: readConverter,
                            jsonWriteConverter: writeConverter
                        );
                    })
                    .OrderBy(e => e.PropertyInfo.GetCustomAttribute<JsonPropertyAttribute>(inherit: true)?.Order)
                    .ToArray();
                _mappedTypeJsonProperties[mappedKey] = mappedValue;
            }

            return mappedValue;
        }

        private static JsonSerializer GetClonedJsonSerializer(JsonSerializer serializer, JsonConverter? converter)
        {
            JsonSerializer serializerCopy = serializer;

            if (converter != null)
            {
                serializerCopy = JsonSerializer.CreateDefault(serializer.ExtractSerializerSettings());
                serializerCopy.Converters.Add(converter);
            }

            return serializerCopy;
        }
    }
}
