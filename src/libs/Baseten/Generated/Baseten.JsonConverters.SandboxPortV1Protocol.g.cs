#nullable enable

namespace Baseten.JsonConverters
{
    /// <inheritdoc />
    public sealed class SandboxPortV1ProtocolJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Baseten.SandboxPortV1Protocol>
    {
        /// <inheritdoc />
        public override global::Baseten.SandboxPortV1Protocol Read(
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
                        return global::Baseten.SandboxPortV1ProtocolExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Baseten.SandboxPortV1Protocol)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Baseten.SandboxPortV1Protocol);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Baseten.SandboxPortV1Protocol value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Baseten.SandboxPortV1ProtocolExtensions.ToValueString(value));
        }
    }
}
