
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateRouteRequestV1TargetVariant1DiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        BasetenModelApi,
        /// <summary>
        ///
        /// </summary>
        ClassifierModelBased,
        /// <summary>
        ///
        /// </summary>
        Connection,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateRouteRequestV1TargetVariant1DiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateRouteRequestV1TargetVariant1DiscriminatorType value)
        {
            return value switch
            {
                UpdateRouteRequestV1TargetVariant1DiscriminatorType.BasetenModelApi => "BASETEN_MODEL_API",
                UpdateRouteRequestV1TargetVariant1DiscriminatorType.ClassifierModelBased => "CLASSIFIER_MODEL_BASED",
                UpdateRouteRequestV1TargetVariant1DiscriminatorType.Connection => "CONNECTION",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateRouteRequestV1TargetVariant1DiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "BASETEN_MODEL_API" => UpdateRouteRequestV1TargetVariant1DiscriminatorType.BasetenModelApi,
                "CLASSIFIER_MODEL_BASED" => UpdateRouteRequestV1TargetVariant1DiscriminatorType.ClassifierModelBased,
                "CONNECTION" => UpdateRouteRequestV1TargetVariant1DiscriminatorType.Connection,
                _ => null,
            };
        }
    }
}