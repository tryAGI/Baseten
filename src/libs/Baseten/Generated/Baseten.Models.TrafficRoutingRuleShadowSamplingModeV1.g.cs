
#nullable enable

namespace Baseten
{
    /// <summary>
    /// How a shadow rule picks which requests to shadow. RANDOM picks each request<br/>
    /// independently. USER_SESSION keeps a whole session together, so every request in a sampled<br/>
    /// session is shadowed.
    /// </summary>
    public enum TrafficRoutingRuleShadowSamplingModeV1
    {
        /// <summary>
        ///
        /// </summary>
        Random,
        /// <summary>
        ///
        /// </summary>
        UserSession,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TrafficRoutingRuleShadowSamplingModeV1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TrafficRoutingRuleShadowSamplingModeV1 value)
        {
            return value switch
            {
                TrafficRoutingRuleShadowSamplingModeV1.Random => "RANDOM",
                TrafficRoutingRuleShadowSamplingModeV1.UserSession => "USER_SESSION",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TrafficRoutingRuleShadowSamplingModeV1? ToEnum(string value)
        {
            return value switch
            {
                "RANDOM" => TrafficRoutingRuleShadowSamplingModeV1.Random,
                "USER_SESSION" => TrafficRoutingRuleShadowSamplingModeV1.UserSession,
                _ => null,
            };
        }
    }
}