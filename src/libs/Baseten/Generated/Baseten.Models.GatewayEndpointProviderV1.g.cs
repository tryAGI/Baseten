
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public enum GatewayEndpointProviderV1
    {
        /// <summary>
        ///
        /// </summary>
        Anthropic,
        /// <summary>
        ///
        /// </summary>
        Baseten,
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
    public static class GatewayEndpointProviderV1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GatewayEndpointProviderV1 value)
        {
            return value switch
            {
                GatewayEndpointProviderV1.Anthropic => "ANTHROPIC",
                GatewayEndpointProviderV1.Baseten => "BASETEN",
                GatewayEndpointProviderV1.BasetenModelApi => "BASETEN_MODEL_API",
                GatewayEndpointProviderV1.Openai => "OPENAI",
                GatewayEndpointProviderV1.OpenaiCompatible => "OPENAI_COMPATIBLE",
                GatewayEndpointProviderV1.Vertex => "VERTEX",
                GatewayEndpointProviderV1.Xai => "XAI",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GatewayEndpointProviderV1? ToEnum(string value)
        {
            return value switch
            {
                "ANTHROPIC" => GatewayEndpointProviderV1.Anthropic,
                "BASETEN" => GatewayEndpointProviderV1.Baseten,
                "BASETEN_MODEL_API" => GatewayEndpointProviderV1.BasetenModelApi,
                "OPENAI" => GatewayEndpointProviderV1.Openai,
                "OPENAI_COMPATIBLE" => GatewayEndpointProviderV1.OpenaiCompatible,
                "VERTEX" => GatewayEndpointProviderV1.Vertex,
                "XAI" => GatewayEndpointProviderV1.Xai,
                _ => null,
            };
        }
    }
}