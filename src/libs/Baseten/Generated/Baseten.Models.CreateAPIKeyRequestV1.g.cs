
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Request to create an API key.
    /// </summary>
    public sealed partial class CreateAPIKeyRequestV1
    {
        /// <summary>
        /// Optional name for the API key<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Type of the API key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Baseten.JsonConverters.APIKeyCategoryJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.APIKeyCategory Type { get; set; }

        /// <summary>
        /// List of model IDs to scope the API key to, only present if type is 'WORKSPACE_EXPORT_METRICS' or 'WORKSPACE_INVOKE'<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_ids")]
        public global::System.Collections.Generic.IList<string>? ModelIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAPIKeyRequestV1" /> class.
        /// </summary>
        /// <param name="type">
        /// Type of the API key.
        /// </param>
        /// <param name="name">
        /// Optional name for the API key<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="modelIds">
        /// List of model IDs to scope the API key to, only present if type is 'WORKSPACE_EXPORT_METRICS' or 'WORKSPACE_INVOKE'<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAPIKeyRequestV1(
            global::Baseten.APIKeyCategory type,
            string? name,
            global::System.Collections.Generic.IList<string>? modelIds)
        {
            this.Name = name;
            this.Type = type;
            this.ModelIds = modelIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAPIKeyRequestV1" /> class.
        /// </summary>
        public CreateAPIKeyRequestV1()
        {
        }
    }
}