#nullable enable

namespace Baseten.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateRouteRequestV1TargetDiscriminatorTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Baseten.CreateRouteRequestV1TargetDiscriminatorType>
    {
        /// <inheritdoc />
        public override global::Baseten.CreateRouteRequestV1TargetDiscriminatorType Read(
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
                        return global::Baseten.CreateRouteRequestV1TargetDiscriminatorTypeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Baseten.CreateRouteRequestV1TargetDiscriminatorType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Baseten.CreateRouteRequestV1TargetDiscriminatorType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Baseten.CreateRouteRequestV1TargetDiscriminatorType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Baseten.CreateRouteRequestV1TargetDiscriminatorTypeExtensions.ToValueString(value));
        }
    }
}
