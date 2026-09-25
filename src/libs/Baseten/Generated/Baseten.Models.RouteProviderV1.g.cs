
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Upstream provider of a route target, named like the route target types.
    /// </summary>
    public enum RouteProviderV1
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
    public static class RouteProviderV1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RouteProviderV1 value)
        {
            return value switch
            {
                RouteProviderV1.Anthropic => "ANTHROPIC",
                RouteProviderV1.BasetenModelApi => "BASETEN_MODEL_API",
                RouteProviderV1.Openai => "OPENAI",
                RouteProviderV1.OpenaiCompatible => "OPENAI_COMPATIBLE",
                RouteProviderV1.Vertex => "VERTEX",
                RouteProviderV1.Xai => "XAI",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RouteProviderV1? ToEnum(string value)
        {
            return value switch
            {
                "ANTHROPIC" => RouteProviderV1.Anthropic,
                "BASETEN_MODEL_API" => RouteProviderV1.BasetenModelApi,
                "OPENAI" => RouteProviderV1.Openai,
                "OPENAI_COMPATIBLE" => RouteProviderV1.OpenaiCompatible,
                "VERTEX" => RouteProviderV1.Vertex,
                "XAI" => RouteProviderV1.Xai,
                _ => null,
            };
        }
    }
}