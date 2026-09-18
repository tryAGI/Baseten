
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
        Openai,
        /// <summary>
        ///
        /// </summary>
        OpenaiCompatible,
        /// <summary>
        ///
        /// </summary>
        Vertex,
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
                RouteV1TargetDiscriminatorType.Openai => "OPENAI",
                RouteV1TargetDiscriminatorType.OpenaiCompatible => "OPENAI_COMPATIBLE",
                RouteV1TargetDiscriminatorType.Vertex => "VERTEX",
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
                "OPENAI" => RouteV1TargetDiscriminatorType.Openai,
                "OPENAI_COMPATIBLE" => RouteV1TargetDiscriminatorType.OpenaiCompatible,
                "VERTEX" => RouteV1TargetDiscriminatorType.Vertex,
                "XAI" => RouteV1TargetDiscriminatorType.Xai,
                _ => null,
            };
        }
    }
}