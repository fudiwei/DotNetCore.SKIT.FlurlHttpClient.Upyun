using System.Text.Json;
using System.Text.Json.Serialization;

namespace SKIT.FlurlHttpClient.Upyun.Sms.Converters.SystemTextJson
{
    internal class NumericStringListReadOnlyConverter : JsonConverter<List<string>?>
    {
        public override List<string>? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.Null)
            {
                return null;
            }
            else if (reader.TokenType == JsonTokenType.StartArray)
            {
                List<string> list = new();

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
                            return list;

                        default:
                            throw new JsonException($"Unexpected JSON token type '{reader.TokenType}' when reading.");
                    }
                }
            }

            throw new JsonException($"Unexpected JSON token type '{reader.TokenType}' when reading.");
        }

        public override void Write(Utf8JsonWriter writer, List<string>? value, JsonSerializerOptions options)
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
