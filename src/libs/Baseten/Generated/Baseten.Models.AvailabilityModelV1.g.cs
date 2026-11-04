
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Capacity a training job or Loops trainer runs on.
    /// </summary>
    public enum AvailabilityModelV1
    {
        /// <summary>
        ///
        /// </summary>
        Spot,
        /// <summary>
        ///
        /// </summary>
        Standard,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AvailabilityModelV1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AvailabilityModelV1 value)
        {
            return value switch
            {
                AvailabilityModelV1.Spot => "spot",
                AvailabilityModelV1.Standard => "standard",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AvailabilityModelV1? ToEnum(string value)
        {
            return value switch
            {
                "spot" => AvailabilityModelV1.Spot,
                "standard" => AvailabilityModelV1.Standard,
                _ => null,
            };
        }
    }
}