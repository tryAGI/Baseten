
#nullable enable

namespace Baseten
{
    /// <summary>
    /// 
    /// </summary>
    public enum Name
    {
        /// <summary>
        /// 
        /// </summary>
        Created,
        /// <summary>
        /// 
        /// </summary>
        Deploying,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Running,
        /// <summary>
        /// 
        /// </summary>
        ScaledToZero,
        /// <summary>
        /// 
        /// </summary>
        Stopped,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Name value)
        {
            return value switch
            {
                Name.Created => "CREATED",
                Name.Deploying => "DEPLOYING",
                Name.Failed => "FAILED",
                Name.Running => "RUNNING",
                Name.ScaledToZero => "SCALED_TO_ZERO",
                Name.Stopped => "STOPPED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Name? ToEnum(string value)
        {
            return value switch
            {
                "CREATED" => Name.Created,
                "DEPLOYING" => Name.Deploying,
                "FAILED" => Name.Failed,
                "RUNNING" => Name.Running,
                "SCALED_TO_ZERO" => Name.ScaledToZero,
                "STOPPED" => Name.Stopped,
                _ => null,
            };
        }
    }
}