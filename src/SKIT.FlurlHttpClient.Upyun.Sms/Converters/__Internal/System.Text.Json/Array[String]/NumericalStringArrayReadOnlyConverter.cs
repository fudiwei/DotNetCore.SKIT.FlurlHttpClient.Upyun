using System.Collections.Generic;
using System.Linq;

namespace System.Text.Json.Serialization.Internal
{
    internal class NumericalStringArrayReadOnlyConverter : JsonConverter<string[]?>
    {
        public override string[]? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.Null)
            {
                return null;
            }
            else if (reader.TokenType == JsonTokenType.StartArray)
            {
                IList<string> list = new List<string>();

                while (reader.Read())
                {
                    switch (reader.TokenType)
                    {
                        case JsonTokenType.Null:
                        case JsonTokenType.Comment:
                            break;

                        case JsonTokenType.Number:
                            {
                                if (reader.TryGetInt64(out long l))
                                    list.Add(l.ToString());
                                else if (reader.TryGetUInt64(out ulong ul))
                                    list.Add(ul.ToString());
                                if (reader.TryGetDouble(out double d))
                                    list.Add(d.ToString());
                                else
                                    list.Add(reader.GetDecimal().ToString());
                            }
                            break;

                        case JsonTokenType.String:
                            {
                                list.Add(reader.GetString()!);
                            }
                            break;

                        case JsonTokenType.EndArray:
                            return list.ToArray();

                        default:
                            throw new JsonException($"Unexpected JSON token type '{reader.TokenType}' when reading.");
                    }
                }
            }

            throw new JsonException($"Unexpected JSON token type '{reader.TokenType}' when reading.");
        }

        public override void Write(Utf8JsonWriter writer, string[]? value, JsonSerializerOptions options)
        {
            if (value is not null)
            {
                writer.WriteStartArray();

                foreach (string str in value)
                {
                    writer.WriteStringValue(str);
                }

                writer.WriteEndArray();
            }
            else
            {
                writer.WriteNullValue();
            }
        }
    }
}
