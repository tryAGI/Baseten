#nullable enable

namespace Baseten.JsonConverters
{
    /// <inheritdoc />
    public sealed class V1InteractiveSessionTriggerNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Baseten.V1InteractiveSessionTrigger?>
    {
        /// <inheritdoc />
        public override global::Baseten.V1InteractiveSessionTrigger? Read(
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
                        return global::Baseten.V1InteractiveSessionTriggerExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Baseten.V1InteractiveSessionTrigger)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Baseten.V1InteractiveSessionTrigger?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Baseten.V1InteractiveSessionTrigger? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Baseten.V1InteractiveSessionTriggerExtensions.ToValueString(value.Value));
            }
        }
    }
}
