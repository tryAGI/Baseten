
#nullable enable

namespace Baseten
{
    /// <summary>
    /// 
    /// </summary>
    public enum V1InteractiveSessionTrigger
    {
        /// <summary>
        /// 
        /// </summary>
        OnDemand,
        /// <summary>
        /// 
        /// </summary>
        OnFailure,
        /// <summary>
        /// 
        /// </summary>
        OnStartup,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class V1InteractiveSessionTriggerExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1InteractiveSessionTrigger value)
        {
            return value switch
            {
                V1InteractiveSessionTrigger.OnDemand => "on_demand",
                V1InteractiveSessionTrigger.OnFailure => "on_failure",
                V1InteractiveSessionTrigger.OnStartup => "on_startup",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1InteractiveSessionTrigger? ToEnum(string value)
        {
            return value switch
            {
                "on_demand" => V1InteractiveSessionTrigger.OnDemand,
                "on_failure" => V1InteractiveSessionTrigger.OnFailure,
                "on_startup" => V1InteractiveSessionTrigger.OnStartup,
                _ => null,
            };
        }
    }
}