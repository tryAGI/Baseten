#nullable enable

namespace Baseten.JsonConverters
{
    /// <inheritdoc />
    public sealed class TrainerCheckpointTargetNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Baseten.TrainerCheckpointTarget?>
    {
        /// <inheritdoc />
        public override global::Baseten.TrainerCheckpointTarget? Read(
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
                        return global::Baseten.TrainerCheckpointTargetExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Baseten.TrainerCheckpointTarget)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Baseten.TrainerCheckpointTarget?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Baseten.TrainerCheckpointTarget? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Baseten.TrainerCheckpointTargetExtensions.ToValueString(value.Value));
            }
        }
    }
}
