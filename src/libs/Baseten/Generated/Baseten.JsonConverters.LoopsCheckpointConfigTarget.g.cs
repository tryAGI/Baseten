#nullable enable

namespace Baseten.JsonConverters
{
    /// <inheritdoc />
    public sealed class LoopsCheckpointConfigTargetJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Baseten.LoopsCheckpointConfigTarget>
    {
        /// <inheritdoc />
        public override global::Baseten.LoopsCheckpointConfigTarget Read(
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
                        return global::Baseten.LoopsCheckpointConfigTargetExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Baseten.LoopsCheckpointConfigTarget)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Baseten.LoopsCheckpointConfigTarget);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Baseten.LoopsCheckpointConfigTarget value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Baseten.LoopsCheckpointConfigTargetExtensions.ToValueString(value));
        }
    }
}
