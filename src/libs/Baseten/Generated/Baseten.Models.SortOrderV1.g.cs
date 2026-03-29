
#nullable enable

namespace Baseten
{
    /// <summary>
    /// 
    /// </summary>
    public enum SortOrderV1
    {
        /// <summary>
        /// 
        /// </summary>
        Asc,
        /// <summary>
        /// 
        /// </summary>
        Desc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SortOrderV1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SortOrderV1 value)
        {
            return value switch
            {
                SortOrderV1.Asc => "asc",
                SortOrderV1.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SortOrderV1? ToEnum(string value)
        {
            return value switch
            {
                "asc" => SortOrderV1.Asc,
                "desc" => SortOrderV1.Desc,
                _ => null,
            };
        }
    }
}