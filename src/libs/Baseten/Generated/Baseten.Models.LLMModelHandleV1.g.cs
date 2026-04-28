
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Handle for a BIS LLM model deployment.
    /// </summary>
    public sealed partial class LLMModelHandleV1
    {
        /// <summary>
        /// Unique identifier of the model
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelId { get; set; }

        /// <summary>
        /// Unique identifier of the model version
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VersionId { get; set; }

        /// <summary>
        /// Hostname used to invoke the model
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hostname")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Hostname { get; set; }

        /// <summary>
        /// Name of the instance type the model deployment is running on<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instance_type_name")]
        public string? InstanceTypeName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LLMModelHandleV1" /> class.
        /// </summary>
        /// <param name="modelId">
        /// Unique identifier of the model
        /// </param>
        /// <param name="versionId">
        /// Unique identifier of the model version
        /// </param>
        /// <param name="hostname">
        /// Hostname used to invoke the model
        /// </param>
        /// <param name="instanceTypeName">
        /// Name of the instance type the model deployment is running on<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LLMModelHandleV1(
            string modelId,
            string versionId,
            string hostname,
            string? instanceTypeName)
        {
            this.ModelId = modelId ?? throw new global::System.ArgumentNullException(nameof(modelId));
            this.VersionId = versionId ?? throw new global::System.ArgumentNullException(nameof(versionId));
            this.Hostname = hostname ?? throw new global::System.ArgumentNullException(nameof(hostname));
            this.InstanceTypeName = instanceTypeName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LLMModelHandleV1" /> class.
        /// </summary>
        public LLMModelHandleV1()
        {
        }
    }
}