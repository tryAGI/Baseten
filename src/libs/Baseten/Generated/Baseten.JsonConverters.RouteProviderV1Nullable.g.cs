#nullable enable

namespace Baseten.JsonConverters
{
    /// <inheritdoc />
    public sealed class RouteProviderV1NullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Baseten.RouteProviderV1?>
    {
        /// <inheritdoc />
        public override global::Baseten.RouteProviderV1? Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::Baseten.RouteProviderV1Extensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Baseten.RouteProviderV1)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Baseten.RouteProviderV1?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Baseten.RouteProviderV1? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Baseten.RouteProviderV1Extensions.ToValueString(value.Value));
            }
        }
    }
}
