
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public enum LoopsLoRAConfigV1ExpertLayout
    {
        /// <summary>
        ///
        /// </summary>
        PerExpert,
        /// <summary>
        ///
        /// </summary>
        SharedAdapter,
        /// <summary>
        ///
        /// </summary>
        SharedOuter,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LoopsLoRAConfigV1ExpertLayoutExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LoopsLoRAConfigV1ExpertLayout value)
        {
            return value switch
            {
                LoopsLoRAConfigV1ExpertLayout.PerExpert => "per_expert",
                LoopsLoRAConfigV1ExpertLayout.SharedAdapter => "shared_adapter",
                LoopsLoRAConfigV1ExpertLayout.SharedOuter => "shared_outer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LoopsLoRAConfigV1ExpertLayout? ToEnum(string value)
        {
            return value switch
            {
                "per_expert" => LoopsLoRAConfigV1ExpertLayout.PerExpert,
                "shared_adapter" => LoopsLoRAConfigV1ExpertLayout.SharedAdapter,
                "shared_outer" => LoopsLoRAConfigV1ExpertLayout.SharedOuter,
                _ => null,
            };
        }
    }
}