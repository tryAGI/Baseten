
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateVolumeSyncRequestV1SourceDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        Azure,
        /// <summary>
        ///
        /// </summary>
        BasetenTraining,
        /// <summary>
        ///
        /// </summary>
        Coreweave,
        /// <summary>
        ///
        /// </summary>
        Gcs,
        /// <summary>
        ///
        /// </summary>
        HuggingFace,
        /// <summary>
        ///
        /// </summary>
        R2,
        /// <summary>
        ///
        /// </summary>
        S3,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateVolumeSyncRequestV1SourceDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateVolumeSyncRequestV1SourceDiscriminatorType value)
        {
            return value switch
            {
                CreateVolumeSyncRequestV1SourceDiscriminatorType.Azure => "AZURE",
                CreateVolumeSyncRequestV1SourceDiscriminatorType.BasetenTraining => "BASETEN_TRAINING",
                CreateVolumeSyncRequestV1SourceDiscriminatorType.Coreweave => "COREWEAVE",
                CreateVolumeSyncRequestV1SourceDiscriminatorType.Gcs => "GCS",
                CreateVolumeSyncRequestV1SourceDiscriminatorType.HuggingFace => "HUGGING_FACE",
                CreateVolumeSyncRequestV1SourceDiscriminatorType.R2 => "R2",
                CreateVolumeSyncRequestV1SourceDiscriminatorType.S3 => "S3",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateVolumeSyncRequestV1SourceDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "AZURE" => CreateVolumeSyncRequestV1SourceDiscriminatorType.Azure,
                "BASETEN_TRAINING" => CreateVolumeSyncRequestV1SourceDiscriminatorType.BasetenTraining,
                "COREWEAVE" => CreateVolumeSyncRequestV1SourceDiscriminatorType.Coreweave,
                "GCS" => CreateVolumeSyncRequestV1SourceDiscriminatorType.Gcs,
                "HUGGING_FACE" => CreateVolumeSyncRequestV1SourceDiscriminatorType.HuggingFace,
                "R2" => CreateVolumeSyncRequestV1SourceDiscriminatorType.R2,
                "S3" => CreateVolumeSyncRequestV1SourceDiscriminatorType.S3,
                _ => null,
            };
        }
    }
}