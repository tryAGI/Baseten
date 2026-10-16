
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateRouteRequestV1TargetDiscriminatorType
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
    public static class CreateRouteRequestV1TargetDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateRouteRequestV1TargetDiscriminatorType value)
        {
            return value switch
            {
                CreateRouteRequestV1TargetDiscriminatorType.BasetenModelApi => "BASETEN_MODEL_API",
                CreateRouteRequestV1TargetDiscriminatorType.Classifier => "CLASSIFIER",
                CreateRouteRequestV1TargetDiscriminatorType.Connection => "CONNECTION",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateRouteRequestV1TargetDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "BASETEN_MODEL_API" => CreateRouteRequestV1TargetDiscriminatorType.BasetenModelApi,
                "CLASSIFIER" => CreateRouteRequestV1TargetDiscriminatorType.Classifier,
                "CONNECTION" => CreateRouteRequestV1TargetDiscriminatorType.Connection,
                _ => null,
            };
        }
    }
}