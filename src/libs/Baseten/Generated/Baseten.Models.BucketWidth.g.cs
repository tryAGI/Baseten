
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public enum BucketWidth
    {
        /// <summary>
        ///
        /// </summary>
        x1d,
        /// <summary>
        ///
        /// </summary>
        x1h,
        /// <summary>
        ///
        /// </summary>
        x1m,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BucketWidthExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BucketWidth value)
        {
            return value switch
            {
                BucketWidth.x1d => "1d",
                BucketWidth.x1h => "1h",
                BucketWidth.x1m => "1m",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BucketWidth? ToEnum(string value)
        {
            return value switch
            {
                "1d" => BucketWidth.x1d,
                "1h" => BucketWidth.x1h,
                "1m" => BucketWidth.x1m,
                _ => null,
            };
        }
    }
}