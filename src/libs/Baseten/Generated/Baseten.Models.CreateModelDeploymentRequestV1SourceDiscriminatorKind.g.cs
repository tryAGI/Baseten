
#nullable enable

namespace Baseten
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateModelDeploymentRequestV1SourceDiscriminatorKind
    {
        /// <summary>
        /// 
        /// </summary>
        ModelArchive,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateModelDeploymentRequestV1SourceDiscriminatorKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateModelDeploymentRequestV1SourceDiscriminatorKind value)
        {
            return value switch
            {
                CreateModelDeploymentRequestV1SourceDiscriminatorKind.ModelArchive => "model_archive",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateModelDeploymentRequestV1SourceDiscriminatorKind? ToEnum(string value)
        {
            return value switch
            {
                "model_archive" => CreateModelDeploymentRequestV1SourceDiscriminatorKind.ModelArchive,
                _ => null,
            };
        }
    }
}