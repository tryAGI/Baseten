#nullable enable

namespace Baseten.JsonConverters
{
    /// <inheritdoc />
    public sealed class UpsertGridConnectionConfigBedrockV1AuthDiscriminatorMethodJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Baseten.UpsertGridConnectionConfigBedrockV1AuthDiscriminatorMethod>
    {
        /// <inheritdoc />
        public override global::Baseten.UpsertGridConnectionConfigBedrockV1AuthDiscriminatorMethod Read(
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
                        return global::Baseten.UpsertGridConnectionConfigBedrockV1AuthDiscriminatorMethodExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Baseten.UpsertGridConnectionConfigBedrockV1AuthDiscriminatorMethod)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Baseten.UpsertGridConnectionConfigBedrockV1AuthDiscriminatorMethod);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Baseten.UpsertGridConnectionConfigBedrockV1AuthDiscriminatorMethod value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Baseten.UpsertGridConnectionConfigBedrockV1AuthDiscriminatorMethodExtensions.ToValueString(value));
        }
    }
}
