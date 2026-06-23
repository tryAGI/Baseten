#nullable enable

namespace Baseten.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateDeploymentPatchRequestV1PatchOpDiscriminatorTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Baseten.CreateDeploymentPatchRequestV1PatchOpDiscriminatorType?>
    {
        /// <inheritdoc />
        public override global::Baseten.CreateDeploymentPatchRequestV1PatchOpDiscriminatorType? Read(
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
                        return global::Baseten.CreateDeploymentPatchRequestV1PatchOpDiscriminatorTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Baseten.CreateDeploymentPatchRequestV1PatchOpDiscriminatorType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Baseten.CreateDeploymentPatchRequestV1PatchOpDiscriminatorType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Baseten.CreateDeploymentPatchRequestV1PatchOpDiscriminatorType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Baseten.CreateDeploymentPatchRequestV1PatchOpDiscriminatorTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
