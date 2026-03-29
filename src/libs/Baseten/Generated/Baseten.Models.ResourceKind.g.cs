
#nullable enable

namespace Baseten
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResourceKind
    {
        /// <summary>
        /// 
        /// </summary>
        Chainlet,
        /// <summary>
        /// 
        /// </summary>
        ModelDeployment,
        /// <summary>
        /// 
        /// </summary>
        TrainingJob,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResourceKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResourceKind value)
        {
            return value switch
            {
                ResourceKind.Chainlet => "CHAINLET",
                ResourceKind.ModelDeployment => "MODEL_DEPLOYMENT",
                ResourceKind.TrainingJob => "TRAINING_JOB",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResourceKind? ToEnum(string value)
        {
            return value switch
            {
                "CHAINLET" => ResourceKind.Chainlet,
                "MODEL_DEPLOYMENT" => ResourceKind.ModelDeployment,
                "TRAINING_JOB" => ResourceKind.TrainingJob,
                _ => null,
            };
        }
    }
}