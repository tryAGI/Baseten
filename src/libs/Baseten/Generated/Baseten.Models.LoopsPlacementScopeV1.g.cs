
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Where a Loops run's trainer or a standalone sampler runs.
    /// </summary>
    public enum LoopsPlacementScopeV1
    {
        /// <summary>
        ///
        /// </summary>
        Dedicated,
        /// <summary>
        ///
        /// </summary>
        Default,
        /// <summary>
        ///
        /// </summary>
        Serverless,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LoopsPlacementScopeV1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LoopsPlacementScopeV1 value)
        {
            return value switch
            {
                LoopsPlacementScopeV1.Dedicated => "dedicated",
                LoopsPlacementScopeV1.Default => "default",
                LoopsPlacementScopeV1.Serverless => "serverless",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LoopsPlacementScopeV1? ToEnum(string value)
        {
            return value switch
            {
                "dedicated" => LoopsPlacementScopeV1.Dedicated,
                "default" => LoopsPlacementScopeV1.Default,
                "serverless" => LoopsPlacementScopeV1.Serverless,
                _ => null,
            };
        }
    }
}