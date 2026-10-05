
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
        Anthropic,
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
        Openai,
        /// <summary>
        ///
        /// </summary>
        Xai,
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
                CreateRouteRequestV1TargetDiscriminatorType.Anthropic => "ANTHROPIC",
                CreateRouteRequestV1TargetDiscriminatorType.BasetenModelApi => "BASETEN_MODEL_API",
                CreateRouteRequestV1TargetDiscriminatorType.ClassifierModelBased => "CLASSIFIER_MODEL_BASED",
                CreateRouteRequestV1TargetDiscriminatorType.Openai => "OPENAI",
                CreateRouteRequestV1TargetDiscriminatorType.Xai => "XAI",
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
                "ANTHROPIC" => CreateRouteRequestV1TargetDiscriminatorType.Anthropic,
                "BASETEN_MODEL_API" => CreateRouteRequestV1TargetDiscriminatorType.BasetenModelApi,
                "CLASSIFIER_MODEL_BASED" => CreateRouteRequestV1TargetDiscriminatorType.ClassifierModelBased,
                "OPENAI" => CreateRouteRequestV1TargetDiscriminatorType.Openai,
                "XAI" => CreateRouteRequestV1TargetDiscriminatorType.Xai,
                _ => null,
            };
        }
    }
}