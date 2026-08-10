
#nullable enable

namespace Baseten
{
    /// <summary>
    /// 
    /// </summary>
    public enum SharedEndpointRegionV1
    {
        /// <summary>
        /// 
        /// </summary>
        Eu,
        /// <summary>
        /// 
        /// </summary>
        Unrestricted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SharedEndpointRegionV1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SharedEndpointRegionV1 value)
        {
            return value switch
            {
                SharedEndpointRegionV1.Eu => "EU",
                SharedEndpointRegionV1.Unrestricted => "UNRESTRICTED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SharedEndpointRegionV1? ToEnum(string value)
        {
            return value switch
            {
                "EU" => SharedEndpointRegionV1.Eu,
                "UNRESTRICTED" => SharedEndpointRegionV1.Unrestricted,
                _ => null,
            };
        }
    }
}