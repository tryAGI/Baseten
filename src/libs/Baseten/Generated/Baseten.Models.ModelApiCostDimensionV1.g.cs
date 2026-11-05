
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public enum ModelApiCostDimensionV1
    {
        /// <summary>
        ///
        /// </summary>
        ApiKeyPrefix,
        /// <summary>
        ///
        /// </summary>
        Model,
        /// <summary>
        ///
        /// </summary>
        ServiceTier,
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
    public static class ModelApiCostDimensionV1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelApiCostDimensionV1 value)
        {
            return value switch
            {
                ModelApiCostDimensionV1.ApiKeyPrefix => "api_key_prefix",
                ModelApiCostDimensionV1.Model => "model",
                ModelApiCostDimensionV1.ServiceTier => "service_tier",
                ModelApiCostDimensionV1.Team => "team",
                ModelApiCostDimensionV1.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelApiCostDimensionV1? ToEnum(string value)
        {
            return value switch
            {
                "api_key_prefix" => ModelApiCostDimensionV1.ApiKeyPrefix,
                "model" => ModelApiCostDimensionV1.Model,
                "service_tier" => ModelApiCostDimensionV1.ServiceTier,
                "team" => ModelApiCostDimensionV1.Team,
                "user" => ModelApiCostDimensionV1.User,
                _ => null,
            };
        }
    }
}