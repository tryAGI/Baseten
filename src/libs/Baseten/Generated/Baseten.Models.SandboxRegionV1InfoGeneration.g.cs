
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Runtime generation supported by this region, using the public name CARBON. Actual runtime selection depends on the team and sandbox configuration.
    /// </summary>
    public enum SandboxRegionV1InfoGeneration
    {
        /// <summary>
        ///
        /// </summary>
        Carbon,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SandboxRegionV1InfoGenerationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SandboxRegionV1InfoGeneration value)
        {
            return value switch
            {
                SandboxRegionV1InfoGeneration.Carbon => "CARBON",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SandboxRegionV1InfoGeneration? ToEnum(string value)
        {
            return value switch
            {
                "CARBON" => SandboxRegionV1InfoGeneration.Carbon,
                _ => null,
            };
        }
    }
}