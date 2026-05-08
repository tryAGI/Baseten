
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A loop deployment — the long-lived inference + trainer pair owned by a user.<br/>
    /// The associated samplers are not enumerated on this response. SamplingServers<br/>
    /// don't FK to TrainerDeployment directly — they're owned by the parent<br/>
    /// TrainerSession (paired sampler per TrainerServer + standalone samplers).<br/>
    /// The list-of-samplers view lives at ``GET /v1/loops/samplers`` (caller-scoped)<br/>
    /// rather than as a nested field here.
    /// </summary>
    public sealed partial class LoopDeploymentV1
    {
        /// <summary>
        /// The loop deployment ID.
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
        /// The base URL clients use to reach the trainer half of the deployment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BaseUrl { get; set; }

        /// <summary>
        /// Latest deployment status.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.LoopDeploymentStatusV1 Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LoopDeploymentV1" /> class.
        /// </summary>
        /// <param name="id">
        /// The loop deployment ID.
        /// </param>
        /// <param name="baseModel">
        /// The HuggingFace base model the deployment is fine-tuning.
        /// </param>
        /// <param name="baseUrl">
        /// The base URL clients use to reach the trainer half of the deployment.
        /// </param>
        /// <param name="status">
        /// Latest deployment status.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LoopDeploymentV1(
            string id,
            string baseModel,
            string baseUrl,
            global::Baseten.LoopDeploymentStatusV1 status)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.BaseModel = baseModel ?? throw new global::System.ArgumentNullException(nameof(baseModel));
            this.BaseUrl = baseUrl ?? throw new global::System.ArgumentNullException(nameof(baseUrl));
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LoopDeploymentV1" /> class.
        /// </summary>
        public LoopDeploymentV1()
        {
        }
    }
}