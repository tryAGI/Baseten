
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Upstream provider of a route target, named like the route target types.
    /// </summary>
    public enum GridProviderV1
    {
        /// <summary>
        ///
        /// </summary>
        Anthropic,
        /// <summary>
        ///
        /// </summary>
        Azure,
        /// <summary>
        ///
        /// </summary>
        BasetenModelApi,
        /// <summary>
        ///
        /// </summary>
        Bedrock,
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
    public static class GridProviderV1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GridProviderV1 value)
        {
            return value switch
            {
                GridProviderV1.Anthropic => "ANTHROPIC",
                GridProviderV1.Azure => "AZURE",
                GridProviderV1.BasetenModelApi => "BASETEN_MODEL_API",
                GridProviderV1.Bedrock => "BEDROCK",
                GridProviderV1.Openai => "OPENAI",
                GridProviderV1.OpenaiCompatible => "OPENAI_COMPATIBLE",
                GridProviderV1.Vertex => "VERTEX",
                GridProviderV1.Xai => "XAI",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GridProviderV1? ToEnum(string value)
        {
            return value switch
            {
                "ANTHROPIC" => GridProviderV1.Anthropic,
                "AZURE" => GridProviderV1.Azure,
                "BASETEN_MODEL_API" => GridProviderV1.BasetenModelApi,
                "BEDROCK" => GridProviderV1.Bedrock,
                "OPENAI" => GridProviderV1.Openai,
                "OPENAI_COMPATIBLE" => GridProviderV1.OpenaiCompatible,
                "VERTEX" => GridProviderV1.Vertex,
                "XAI" => GridProviderV1.Xai,
                _ => null,
            };
        }
    }
}