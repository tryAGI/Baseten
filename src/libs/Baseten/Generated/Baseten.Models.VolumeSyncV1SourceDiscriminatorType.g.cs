
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public enum VolumeSyncV1SourceDiscriminatorType
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
    public static class VolumeSyncV1SourceDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VolumeSyncV1SourceDiscriminatorType value)
        {
            return value switch
            {
                VolumeSyncV1SourceDiscriminatorType.Azure => "AZURE",
                VolumeSyncV1SourceDiscriminatorType.BasetenTraining => "BASETEN_TRAINING",
                VolumeSyncV1SourceDiscriminatorType.Coreweave => "COREWEAVE",
                VolumeSyncV1SourceDiscriminatorType.Gcs => "GCS",
                VolumeSyncV1SourceDiscriminatorType.HuggingFace => "HUGGING_FACE",
                VolumeSyncV1SourceDiscriminatorType.R2 => "R2",
                VolumeSyncV1SourceDiscriminatorType.S3 => "S3",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VolumeSyncV1SourceDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "AZURE" => VolumeSyncV1SourceDiscriminatorType.Azure,
                "BASETEN_TRAINING" => VolumeSyncV1SourceDiscriminatorType.BasetenTraining,
                "COREWEAVE" => VolumeSyncV1SourceDiscriminatorType.Coreweave,
                "GCS" => VolumeSyncV1SourceDiscriminatorType.Gcs,
                "HUGGING_FACE" => VolumeSyncV1SourceDiscriminatorType.HuggingFace,
                "R2" => VolumeSyncV1SourceDiscriminatorType.R2,
                "S3" => VolumeSyncV1SourceDiscriminatorType.S3,
                _ => null,
            };
        }
    }
}