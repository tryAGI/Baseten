#nullable enable

namespace Baseten.JsonConverters
{
    /// <inheritdoc />
    public sealed class LoopsLoRAConfigV1ExpertLayoutJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Baseten.LoopsLoRAConfigV1ExpertLayout>
    {
        /// <inheritdoc />
        public override global::Baseten.LoopsLoRAConfigV1ExpertLayout Read(
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
                        return global::Baseten.LoopsLoRAConfigV1ExpertLayoutExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Baseten.LoopsLoRAConfigV1ExpertLayout)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Baseten.LoopsLoRAConfigV1ExpertLayout);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Baseten.LoopsLoRAConfigV1ExpertLayout value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Baseten.LoopsLoRAConfigV1ExpertLayoutExtensions.ToValueString(value));
        }
    }
}
