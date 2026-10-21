
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateGridRouteRequestV1TargetDiscriminatorType
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
    public static class CreateGridRouteRequestV1TargetDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateGridRouteRequestV1TargetDiscriminatorType value)
        {
            return value switch
            {
                CreateGridRouteRequestV1TargetDiscriminatorType.BasetenModelApi => "BASETEN_MODEL_API",
                CreateGridRouteRequestV1TargetDiscriminatorType.Classifier => "CLASSIFIER",
                CreateGridRouteRequestV1TargetDiscriminatorType.Connection => "CONNECTION",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateGridRouteRequestV1TargetDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "BASETEN_MODEL_API" => CreateGridRouteRequestV1TargetDiscriminatorType.BasetenModelApi,
                "CLASSIFIER" => CreateGridRouteRequestV1TargetDiscriminatorType.Classifier,
                "CONNECTION" => CreateGridRouteRequestV1TargetDiscriminatorType.Connection,
                _ => null,
            };
        }
    }
}