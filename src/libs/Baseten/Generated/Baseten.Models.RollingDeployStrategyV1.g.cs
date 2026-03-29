
#nullable enable

namespace Baseten
{
    /// <summary>
    /// The rolling deploy strategy.
    /// </summary>
    public enum RollingDeployStrategyV1
    {
        /// <summary>
        /// 
        /// </summary>
        Replica,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RollingDeployStrategyV1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RollingDeployStrategyV1 value)
        {
            return value switch
            {
                RollingDeployStrategyV1.Replica => "REPLICA",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RollingDeployStrategyV1? ToEnum(string value)
        {
            return value switch
            {
                "REPLICA" => RollingDeployStrategyV1.Replica,
                _ => null,
            };
        }
    }
}