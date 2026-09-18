
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public enum LoopsCheckpointSourceResponseV1SourceDiscriminatorKind
    {
        /// <summary>
        ///
        /// </summary>
        S3,
        /// <summary>
        ///
        /// </summary>
        Volume,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LoopsCheckpointSourceResponseV1SourceDiscriminatorKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LoopsCheckpointSourceResponseV1SourceDiscriminatorKind value)
        {
            return value switch
            {
                LoopsCheckpointSourceResponseV1SourceDiscriminatorKind.S3 => "s3",
                LoopsCheckpointSourceResponseV1SourceDiscriminatorKind.Volume => "volume",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LoopsCheckpointSourceResponseV1SourceDiscriminatorKind? ToEnum(string value)
        {
            return value switch
            {
                "s3" => LoopsCheckpointSourceResponseV1SourceDiscriminatorKind.S3,
                "volume" => LoopsCheckpointSourceResponseV1SourceDiscriminatorKind.Volume,
                _ => null,
            };
        }
    }
}