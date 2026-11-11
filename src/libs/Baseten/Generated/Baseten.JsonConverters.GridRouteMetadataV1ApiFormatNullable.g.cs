#nullable enable

namespace Baseten.JsonConverters
{
    /// <inheritdoc />
    public sealed class GridRouteMetadataV1ApiFormatNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Baseten.GridRouteMetadataV1ApiFormat?>
    {
        /// <inheritdoc />
        public override global::Baseten.GridRouteMetadataV1ApiFormat? Read(
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
                        return global::Baseten.GridRouteMetadataV1ApiFormatExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Baseten.GridRouteMetadataV1ApiFormat)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Baseten.GridRouteMetadataV1ApiFormat?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Baseten.GridRouteMetadataV1ApiFormat? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Baseten.GridRouteMetadataV1ApiFormatExtensions.ToValueString(value.Value));
            }
        }
    }
}
