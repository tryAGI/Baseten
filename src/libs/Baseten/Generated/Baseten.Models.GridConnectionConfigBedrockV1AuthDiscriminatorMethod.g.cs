
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public enum GridConnectionConfigBedrockV1AuthDiscriminatorMethod
    {
        /// <summary>
        ///
        /// </summary>
        AccessKeys,
        /// <summary>
        ///
        /// </summary>
        ApiKey,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GridConnectionConfigBedrockV1AuthDiscriminatorMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GridConnectionConfigBedrockV1AuthDiscriminatorMethod value)
        {
            return value switch
            {
                GridConnectionConfigBedrockV1AuthDiscriminatorMethod.AccessKeys => "access_keys",
                GridConnectionConfigBedrockV1AuthDiscriminatorMethod.ApiKey => "api_key",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GridConnectionConfigBedrockV1AuthDiscriminatorMethod? ToEnum(string value)
        {
            return value switch
            {
                "access_keys" => GridConnectionConfigBedrockV1AuthDiscriminatorMethod.AccessKeys,
                "api_key" => GridConnectionConfigBedrockV1AuthDiscriminatorMethod.ApiKey,
                _ => null,
            };
        }
    }
}