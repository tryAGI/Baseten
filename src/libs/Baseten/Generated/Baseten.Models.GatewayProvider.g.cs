
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Customer-facing provider for an endpoint target.<br/>
    /// External providers resolve to a fixed upstream host + protocol adapter via<br/>
    /// ``_EXTERNAL_PROVIDER_CONFIGS``; ``BASETEN`` derives its host from the referenced oracle.
    /// </summary>
    public enum GatewayProvider
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
        Openai,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GatewayProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GatewayProvider value)
        {
            return value switch
            {
                GatewayProvider.Anthropic => "ANTHROPIC",
                GatewayProvider.Baseten => "BASETEN",
                GatewayProvider.Openai => "OPENAI",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GatewayProvider? ToEnum(string value)
        {
            return value switch
            {
                "ANTHROPIC" => GatewayProvider.Anthropic,
                "BASETEN" => GatewayProvider.Baseten,
                "OPENAI" => GatewayProvider.Openai,
                _ => null,
            };
        }
    }
}