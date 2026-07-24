
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A Loops run's lifecycle state: ACTIVE or INACTIVE.
    /// </summary>
    public enum LoopsRunStatusNameV1
    {
        /// <summary>
        /// ACTIVE or INACTIVE.
        /// </summary>
        Active,
        /// <summary>
        /// ACTIVE or INACTIVE.
        /// </summary>
        Inactive,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LoopsRunStatusNameV1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LoopsRunStatusNameV1 value)
        {
            return value switch
            {
                LoopsRunStatusNameV1.Active => "ACTIVE",
                LoopsRunStatusNameV1.Inactive => "INACTIVE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LoopsRunStatusNameV1? ToEnum(string value)
        {
            return value switch
            {
                "ACTIVE" => LoopsRunStatusNameV1.Active,
                "INACTIVE" => LoopsRunStatusNameV1.Inactive,
                _ => null,
            };
        }
    }
}