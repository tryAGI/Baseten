
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
    public static class RouteV1TargetDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RouteV1TargetDiscriminatorType value)
        {
            return value switch
            {
                RouteV1TargetDiscriminatorType.Anthropic => "ANTHROPIC",
                RouteV1TargetDiscriminatorType.BasetenModelApi => "BASETEN_MODEL_API",
                RouteV1TargetDiscriminatorType.ClassifierModelBased => "CLASSIFIER_MODEL_BASED",
                RouteV1TargetDiscriminatorType.Openai => "OPENAI",
                RouteV1TargetDiscriminatorType.Xai => "XAI",
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
                "ANTHROPIC" => RouteV1TargetDiscriminatorType.Anthropic,
                "BASETEN_MODEL_API" => RouteV1TargetDiscriminatorType.BasetenModelApi,
                "CLASSIFIER_MODEL_BASED" => RouteV1TargetDiscriminatorType.ClassifierModelBased,
                "OPENAI" => RouteV1TargetDiscriminatorType.Openai,
                "XAI" => RouteV1TargetDiscriminatorType.Xai,
                _ => null,
            };
        }
    }
}