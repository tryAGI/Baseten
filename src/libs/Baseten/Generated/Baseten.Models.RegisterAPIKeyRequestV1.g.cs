
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Request to register a caller-supplied API key against an existing FederatedGroup.
    /// </summary>
    public sealed partial class RegisterAPIKeyRequestV1
    {
        /// <summary>
        /// Optional name for the Model API key<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Value of the API key to register
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RegisterAPIKeyRequestV1" /> class.
        /// </summary>
        /// <param name="key">
        /// Value of the API key to register
        /// </param>
        /// <param name="name">
        /// Optional name for the Model API key<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RegisterAPIKeyRequestV1(
            string key,
            string? name)
        {
            this.Name = name;
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RegisterAPIKeyRequestV1" /> class.
        /// </summary>
        public RegisterAPIKeyRequestV1()
        {
        }

    }
}