
#nullable enable

namespace Baseten
{
    /// <summary>
    /// What the caller intends to run.<br/>
    /// Reinforcement learning runs a trainer and a sampler; supervised<br/>
    /// fine-tuning runs a trainer alone. A model can therefore be enabled for one<br/>
    /// and not the other, and the same model can support a longer sequence length<br/>
    /// for SFT than for RL.
    /// </summary>
    public enum LoopsUseCaseV1
    {
        /// <summary>
        ///
        /// </summary>
        Rl,
        /// <summary>
        ///
        /// </summary>
        Sft,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LoopsUseCaseV1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LoopsUseCaseV1 value)
        {
            return value switch
            {
                LoopsUseCaseV1.Rl => "rl",
                LoopsUseCaseV1.Sft => "sft",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LoopsUseCaseV1? ToEnum(string value)
        {
            return value switch
            {
                "rl" => LoopsUseCaseV1.Rl,
                "sft" => LoopsUseCaseV1.Sft,
                _ => null,
            };
        }
    }
}