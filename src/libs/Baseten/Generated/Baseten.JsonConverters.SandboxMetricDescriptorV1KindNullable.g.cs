#nullable enable

namespace Baseten.JsonConverters
{
    /// <inheritdoc />
    public sealed class SandboxMetricDescriptorV1KindNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Baseten.SandboxMetricDescriptorV1Kind?>
    {
        /// <inheritdoc />
        public override global::Baseten.SandboxMetricDescriptorV1Kind? Read(
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
                        return global::Baseten.SandboxMetricDescriptorV1KindExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Baseten.SandboxMetricDescriptorV1Kind)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Baseten.SandboxMetricDescriptorV1Kind?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Baseten.SandboxMetricDescriptorV1Kind? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Baseten.SandboxMetricDescriptorV1KindExtensions.ToValueString(value.Value));
            }
        }
    }
}
