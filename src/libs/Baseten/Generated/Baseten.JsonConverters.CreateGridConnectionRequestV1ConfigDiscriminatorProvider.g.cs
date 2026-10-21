#nullable enable

namespace Baseten.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateGridConnectionRequestV1ConfigDiscriminatorProviderJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Baseten.CreateGridConnectionRequestV1ConfigDiscriminatorProvider>
    {
        /// <inheritdoc />
        public override global::Baseten.CreateGridConnectionRequestV1ConfigDiscriminatorProvider Read(
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
                        return global::Baseten.CreateGridConnectionRequestV1ConfigDiscriminatorProviderExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Baseten.CreateGridConnectionRequestV1ConfigDiscriminatorProvider)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Baseten.CreateGridConnectionRequestV1ConfigDiscriminatorProvider);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Baseten.CreateGridConnectionRequestV1ConfigDiscriminatorProvider value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Baseten.CreateGridConnectionRequestV1ConfigDiscriminatorProviderExtensions.ToValueString(value));
        }
    }
}
