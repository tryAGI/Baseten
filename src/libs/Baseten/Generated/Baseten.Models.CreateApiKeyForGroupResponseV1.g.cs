
#nullable enable

namespace Baseten
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateApiKeyForGroupResponseV1
    {
        /// <summary>
        /// Plaintext key string, returned exactly once.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ApiKey { get; set; }

        /// <summary>
        /// Key prefix (the part before the dot).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prefix")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prefix { get; set; }

        /// <summary>
        /// Display name of the key.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateApiKeyForGroupResponseV1" /> class.
        /// </summary>
        /// <param name="apiKey">
        /// Plaintext key string, returned exactly once.
        /// </param>
        /// <param name="prefix">
        /// Key prefix (the part before the dot).
        /// </param>
        /// <param name="name">
        /// Display name of the key.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateApiKeyForGroupResponseV1(
            string apiKey,
            string prefix,
            string? name)
        {
            this.ApiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));
            this.Prefix = prefix ?? throw new global::System.ArgumentNullException(nameof(prefix));
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateApiKeyForGroupResponseV1" /> class.
        /// </summary>
        public CreateApiKeyForGroupResponseV1()
        {
        }

    }
}