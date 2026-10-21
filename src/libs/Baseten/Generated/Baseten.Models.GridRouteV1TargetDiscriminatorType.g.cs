
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public enum GridRouteV1TargetDiscriminatorType
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
    public static class GridRouteV1TargetDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GridRouteV1TargetDiscriminatorType value)
        {
            return value switch
            {
                GridRouteV1TargetDiscriminatorType.BasetenModelApi => "BASETEN_MODEL_API",
                GridRouteV1TargetDiscriminatorType.Classifier => "CLASSIFIER",
                GridRouteV1TargetDiscriminatorType.Connection => "CONNECTION",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GridRouteV1TargetDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "BASETEN_MODEL_API" => GridRouteV1TargetDiscriminatorType.BasetenModelApi,
                "CLASSIFIER" => GridRouteV1TargetDiscriminatorType.Classifier,
                "CONNECTION" => GridRouteV1TargetDiscriminatorType.Connection,
                _ => null,
            };
        }
    }
}