
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public enum RouteV1TargetDiscriminatorType
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
    public static class RouteV1TargetDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RouteV1TargetDiscriminatorType value)
        {
            return value switch
            {
                RouteV1TargetDiscriminatorType.BasetenModelApi => "BASETEN_MODEL_API",
                RouteV1TargetDiscriminatorType.ClassifierModelBased => "CLASSIFIER_MODEL_BASED",
                RouteV1TargetDiscriminatorType.Connection => "CONNECTION",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RouteV1TargetDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "BASETEN_MODEL_API" => RouteV1TargetDiscriminatorType.BasetenModelApi,
                "CLASSIFIER_MODEL_BASED" => RouteV1TargetDiscriminatorType.ClassifierModelBased,
                "CONNECTION" => RouteV1TargetDiscriminatorType.Connection,
                _ => null,
            };
        }
    }
}