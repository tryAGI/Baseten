
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Which checkpoint target to load: 'trainer' (full training state) or 'sampler' (inference weights)<br/>
    /// Default Value: trainer
    /// </summary>
    public enum LoopsCheckpointConfigTarget
    {
        /// <summary>
        /// 'trainer' (full training state) or 'sampler' (inference weights)
        /// </summary>
        Sampler,
        /// <summary>
        /// 'trainer' (full training state) or 'sampler' (inference weights)
        /// </summary>
        Trainer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LoopsCheckpointConfigTargetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LoopsCheckpointConfigTarget value)
        {
            return value switch
            {
                LoopsCheckpointConfigTarget.Sampler => "sampler",
                LoopsCheckpointConfigTarget.Trainer => "trainer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LoopsCheckpointConfigTarget? ToEnum(string value)
        {
            return value switch
            {
                "sampler" => LoopsCheckpointConfigTarget.Sampler,
                "trainer" => LoopsCheckpointConfigTarget.Trainer,
                _ => null,
            };
        }
    }
}