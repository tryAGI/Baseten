
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public enum ToolCallUsageDimensionV1
    {
        /// <summary>
        ///
        /// </summary>
        Team,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolCallUsageDimensionV1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolCallUsageDimensionV1 value)
        {
            return value switch
            {
                ToolCallUsageDimensionV1.Team => "TEAM",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolCallUsageDimensionV1? ToEnum(string value)
        {
            return value switch
            {
                "TEAM" => ToolCallUsageDimensionV1.Team,
                _ => null,
            };
        }
    }
}