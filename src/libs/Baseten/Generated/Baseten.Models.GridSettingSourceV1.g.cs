
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public enum GridSettingSourceV1
    {
        /// <summary>
        ///
        /// </summary>
        Team,
        /// <summary>
        ///
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GridSettingSourceV1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GridSettingSourceV1 value)
        {
            return value switch
            {
                GridSettingSourceV1.Team => "team",
                GridSettingSourceV1.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GridSettingSourceV1? ToEnum(string value)
        {
            return value switch
            {
                "team" => GridSettingSourceV1.Team,
                "user" => GridSettingSourceV1.User,
                _ => null,
            };
        }
    }
}