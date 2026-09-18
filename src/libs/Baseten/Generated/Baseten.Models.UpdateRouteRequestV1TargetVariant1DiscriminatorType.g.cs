
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
    public static class UpdateRouteRequestV1TargetVariant1DiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateRouteRequestV1TargetVariant1DiscriminatorType value)
        {
            return value switch
            {
                UpdateRouteRequestV1TargetVariant1DiscriminatorType.Anthropic => "ANTHROPIC",
                UpdateRouteRequestV1TargetVariant1DiscriminatorType.BasetenModelApi => "BASETEN_MODEL_API",
                UpdateRouteRequestV1TargetVariant1DiscriminatorType.Openai => "OPENAI",
                UpdateRouteRequestV1TargetVariant1DiscriminatorType.OpenaiCompatible => "OPENAI_COMPATIBLE",
                UpdateRouteRequestV1TargetVariant1DiscriminatorType.Vertex => "VERTEX",
                UpdateRouteRequestV1TargetVariant1DiscriminatorType.Xai => "XAI",
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
                "ANTHROPIC" => UpdateRouteRequestV1TargetVariant1DiscriminatorType.Anthropic,
                "BASETEN_MODEL_API" => UpdateRouteRequestV1TargetVariant1DiscriminatorType.BasetenModelApi,
                "OPENAI" => UpdateRouteRequestV1TargetVariant1DiscriminatorType.Openai,
                "OPENAI_COMPATIBLE" => UpdateRouteRequestV1TargetVariant1DiscriminatorType.OpenaiCompatible,
                "VERTEX" => UpdateRouteRequestV1TargetVariant1DiscriminatorType.Vertex,
                "XAI" => UpdateRouteRequestV1TargetVariant1DiscriminatorType.Xai,
                _ => null,
            };
        }
    }
}