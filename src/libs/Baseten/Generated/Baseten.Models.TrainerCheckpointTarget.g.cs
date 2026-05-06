
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Whether a TrainerServerCheckpoint is loadable by the sampler or the trainer.<br/>
    /// SAMPLER checkpoints are consumed by the sampling server for inference;<br/>
    /// TRAINER checkpoints capture full trainer state for resuming training.<br/>
    /// Mirrored in the bt:// URI as<br/>
    /// ``bt://trainers:&lt;trainer_id&gt;/(sampler_weights|weights)/&lt;name&gt;``.
    /// </summary>
    public enum TrainerCheckpointTarget
    {
        /// <summary>
        /// //trainers:&lt;trainer_id&gt;/(sampler_weights|weights)/&lt;name&gt;``.
        /// </summary>
        Sampler,
        /// <summary>
        /// //trainers:&lt;trainer_id&gt;/(sampler_weights|weights)/&lt;name&gt;``.
        /// </summary>
        Trainer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TrainerCheckpointTargetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TrainerCheckpointTarget value)
        {
            return value switch
            {
                TrainerCheckpointTarget.Sampler => "sampler",
                TrainerCheckpointTarget.Trainer => "trainer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TrainerCheckpointTarget? ToEnum(string value)
        {
            return value switch
            {
                "sampler" => TrainerCheckpointTarget.Sampler,
                "trainer" => TrainerCheckpointTarget.Trainer,
                _ => null,
            };
        }
    }
}