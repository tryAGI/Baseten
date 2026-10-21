
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateGridRouteRequestV1TargetVariant1DiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        BasetenModelApi,
        /// <summary>
        ///
        /// </summary>
        Classifier,
        /// <summary>
        ///
        /// </summary>
        Connection,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateGridRouteRequestV1TargetVariant1DiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateGridRouteRequestV1TargetVariant1DiscriminatorType value)
        {
            return value switch
            {
                UpdateGridRouteRequestV1TargetVariant1DiscriminatorType.BasetenModelApi => "BASETEN_MODEL_API",
                UpdateGridRouteRequestV1TargetVariant1DiscriminatorType.Classifier => "CLASSIFIER",
                UpdateGridRouteRequestV1TargetVariant1DiscriminatorType.Connection => "CONNECTION",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateGridRouteRequestV1TargetVariant1DiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "BASETEN_MODEL_API" => UpdateGridRouteRequestV1TargetVariant1DiscriminatorType.BasetenModelApi,
                "CLASSIFIER" => UpdateGridRouteRequestV1TargetVariant1DiscriminatorType.Classifier,
                "CONNECTION" => UpdateGridRouteRequestV1TargetVariant1DiscriminatorType.Connection,
                _ => null,
            };
        }
    }
}