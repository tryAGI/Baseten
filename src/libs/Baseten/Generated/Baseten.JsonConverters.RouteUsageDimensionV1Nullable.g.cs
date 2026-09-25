#nullable enable

namespace Baseten.JsonConverters
{
    /// <inheritdoc />
    public sealed class RouteUsageDimensionV1NullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Baseten.RouteUsageDimensionV1?>
    {
        /// <inheritdoc />
        public override global::Baseten.RouteUsageDimensionV1? Read(
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
                        return global::Baseten.RouteUsageDimensionV1Extensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Baseten.RouteUsageDimensionV1)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Baseten.RouteUsageDimensionV1?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Baseten.RouteUsageDimensionV1? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Baseten.RouteUsageDimensionV1Extensions.ToValueString(value.Value));
            }
        }
    }
}
