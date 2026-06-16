
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A Loops deployment — the long-lived run + sampler pair owned by a user.<br/>
    /// The deployment's current sampler is included inline. The full list of<br/>
    /// samplers visible to the caller (across all deployments) lives at<br/>
    /// ``GET /v1/loops/samplers``.
    /// </summary>
    public sealed partial class LoopsDeploymentV1
    {
        /// <summary>
        /// The Loops deployment ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The HuggingFace base model the deployment is fine-tuning.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BaseModel { get; set; }

        /// <summary>
        /// The run's base URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BaseUrl { get; set; }

        /// <summary>
        /// Latest deployment status.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.LoopsDeploymentStatusV1 Status { get; set; }

        /// <summary>
        /// The sampler bound to this deployment.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sampler")]
        public global::Baseten.LoopsSamplerV1? Sampler { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LoopsDeploymentV1" /> class.
        /// </summary>
        /// <param name="id">
        /// The Loops deployment ID.
        /// </param>
        /// <param name="baseModel">
        /// The HuggingFace base model the deployment is fine-tuning.
        /// </param>
        /// <param name="baseUrl">
        /// The run's base URL.
        /// </param>
        /// <param name="status">
        /// Latest deployment status.
        /// </param>
        /// <param name="sampler">
        /// The sampler bound to this deployment.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LoopsDeploymentV1(
            string id,
            string baseModel,
            string baseUrl,
            global::Baseten.LoopsDeploymentStatusV1 status,
            global::Baseten.LoopsSamplerV1? sampler)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.BaseModel = baseModel ?? throw new global::System.ArgumentNullException(nameof(baseModel));
            this.BaseUrl = baseUrl ?? throw new global::System.ArgumentNullException(nameof(baseUrl));
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.Sampler = sampler;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LoopsDeploymentV1" /> class.
        /// </summary>
        public LoopsDeploymentV1()
        {
        }

    }
}