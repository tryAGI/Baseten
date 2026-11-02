
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public enum UpsertGridConnectionConfigBedrockV1AuthDiscriminatorMethod
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
    public static class UpsertGridConnectionConfigBedrockV1AuthDiscriminatorMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpsertGridConnectionConfigBedrockV1AuthDiscriminatorMethod value)
        {
            return value switch
            {
                UpsertGridConnectionConfigBedrockV1AuthDiscriminatorMethod.AccessKeys => "access_keys",
                UpsertGridConnectionConfigBedrockV1AuthDiscriminatorMethod.ApiKey => "api_key",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpsertGridConnectionConfigBedrockV1AuthDiscriminatorMethod? ToEnum(string value)
        {
            return value switch
            {
                "access_keys" => UpsertGridConnectionConfigBedrockV1AuthDiscriminatorMethod.AccessKeys,
                "api_key" => UpsertGridConnectionConfigBedrockV1AuthDiscriminatorMethod.ApiKey,
                _ => null,
            };
        }
    }
}