#nullable enable

namespace Baseten.JsonConverters
{
    /// <inheritdoc />
    public sealed class EnvironmentAutoscalingSchedulesV1ScheduleDiscriminatorCadenceNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Baseten.EnvironmentAutoscalingSchedulesV1ScheduleDiscriminatorCadence?>
    {
        /// <inheritdoc />
        public override global::Baseten.EnvironmentAutoscalingSchedulesV1ScheduleDiscriminatorCadence? Read(
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
                        return global::Baseten.EnvironmentAutoscalingSchedulesV1ScheduleDiscriminatorCadenceExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Baseten.EnvironmentAutoscalingSchedulesV1ScheduleDiscriminatorCadence)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Baseten.EnvironmentAutoscalingSchedulesV1ScheduleDiscriminatorCadence?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Baseten.EnvironmentAutoscalingSchedulesV1ScheduleDiscriminatorCadence? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Baseten.EnvironmentAutoscalingSchedulesV1ScheduleDiscriminatorCadenceExtensions.ToValueString(value.Value));
            }
        }
    }
}
