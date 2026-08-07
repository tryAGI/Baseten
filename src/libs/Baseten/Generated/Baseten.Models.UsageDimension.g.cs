
#nullable enable

namespace Baseten
{
    /// <summary>
    /// 
    /// </summary>
    public enum UsageDimension
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
        ServiceTier,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UsageDimensionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UsageDimension value)
        {
            return value switch
            {
                UsageDimension.ApiKey => "api_key",
                UsageDimension.Model => "model",
                UsageDimension.ServiceTier => "service_tier",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UsageDimension? ToEnum(string value)
        {
            return value switch
            {
                "api_key" => UsageDimension.ApiKey,
                "model" => UsageDimension.Model,
                "service_tier" => UsageDimension.ServiceTier,
                _ => null,
            };
        }
    }
}