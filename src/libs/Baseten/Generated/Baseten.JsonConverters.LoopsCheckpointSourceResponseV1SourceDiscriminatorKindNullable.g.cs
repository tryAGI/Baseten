#nullable enable

namespace Baseten.JsonConverters
{
    /// <inheritdoc />
    public sealed class LoopsCheckpointSourceResponseV1SourceDiscriminatorKindNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Baseten.LoopsCheckpointSourceResponseV1SourceDiscriminatorKind?>
    {
        /// <inheritdoc />
        public override global::Baseten.LoopsCheckpointSourceResponseV1SourceDiscriminatorKind? Read(
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
                        return global::Baseten.LoopsCheckpointSourceResponseV1SourceDiscriminatorKindExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Baseten.LoopsCheckpointSourceResponseV1SourceDiscriminatorKind)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Baseten.LoopsCheckpointSourceResponseV1SourceDiscriminatorKind?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Baseten.LoopsCheckpointSourceResponseV1SourceDiscriminatorKind? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Baseten.LoopsCheckpointSourceResponseV1SourceDiscriminatorKindExtensions.ToValueString(value.Value));
            }
        }
    }
}
