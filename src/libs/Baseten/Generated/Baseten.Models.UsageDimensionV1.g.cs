
#nullable enable

namespace Baseten
{
    /// <summary>
    /// 
    /// </summary>
    public enum UsageDimensionV1
    {
        /// <summary>
        /// 
        /// </summary>
        ApiKey,
        /// <summary>
        /// 
        /// </summary>
        Model,
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UsageDimensionV1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UsageDimensionV1 value)
        {
            return value switch
            {
                UsageDimensionV1.ApiKey => "api_key",
                UsageDimensionV1.Model => "model",
                UsageDimensionV1.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UsageDimensionV1? ToEnum(string value)
        {
            return value switch
            {
                "api_key" => UsageDimensionV1.ApiKey,
                "model" => UsageDimensionV1.Model,
                "user" => UsageDimensionV1.User,
                _ => null,
            };
        }
    }
}