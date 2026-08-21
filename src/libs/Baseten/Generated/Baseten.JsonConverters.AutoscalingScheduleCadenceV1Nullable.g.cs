#nullable enable

namespace Baseten.JsonConverters
{
    /// <inheritdoc />
    public sealed class AutoscalingScheduleCadenceV1NullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Baseten.AutoscalingScheduleCadenceV1?>
    {
        /// <inheritdoc />
        public override global::Baseten.AutoscalingScheduleCadenceV1? Read(
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
                        return global::Baseten.AutoscalingScheduleCadenceV1Extensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Baseten.AutoscalingScheduleCadenceV1)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Baseten.AutoscalingScheduleCadenceV1?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Baseten.AutoscalingScheduleCadenceV1? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Baseten.AutoscalingScheduleCadenceV1Extensions.ToValueString(value.Value));
            }
        }
    }
}
