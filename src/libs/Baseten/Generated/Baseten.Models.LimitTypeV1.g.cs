
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public enum LimitTypeV1
    {
        /// <summary>
        ///
        /// </summary>
        ConcurrentRequest,
        /// <summary>
        ///
        /// </summary>
        OutputToken,
        /// <summary>
        ///
        /// </summary>
        Request,
        /// <summary>
        ///
        /// </summary>
        Token,
        /// <summary>
        ///
        /// </summary>
        UncachedInputToken,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LimitTypeV1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LimitTypeV1 value)
        {
            return value switch
            {
                LimitTypeV1.ConcurrentRequest => "CONCURRENT_REQUEST",
                LimitTypeV1.OutputToken => "OUTPUT_TOKEN",
                LimitTypeV1.Request => "REQUEST",
                LimitTypeV1.Token => "TOKEN",
                LimitTypeV1.UncachedInputToken => "UNCACHED_INPUT_TOKEN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LimitTypeV1? ToEnum(string value)
        {
            return value switch
            {
                "CONCURRENT_REQUEST" => LimitTypeV1.ConcurrentRequest,
                "OUTPUT_TOKEN" => LimitTypeV1.OutputToken,
                "REQUEST" => LimitTypeV1.Request,
                "TOKEN" => LimitTypeV1.Token,
                "UNCACHED_INPUT_TOKEN" => LimitTypeV1.UncachedInputToken,
                _ => null,
            };
        }
    }
}