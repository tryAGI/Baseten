
#nullable enable

namespace Baseten
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LoopsRunV1
    {
        /// <summary>
        /// The run ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The session ID this run belongs to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SessionId { get; set; }

        /// <summary>
        /// The ID of the Loops deployment the run executes on.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployment_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DeploymentId { get; set; }

        /// <summary>
        /// The run's display name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The HuggingFace base model the run is fine-tuning.
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
        /// Time the run was created in ISO 8601 format
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// The sampler bound to this run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sampler")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.LoopsSamplerV1 Sampler { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LoopsRunV1" /> class.
        /// </summary>
        /// <param name="id">
        /// The run ID.
        /// </param>
        /// <param name="sessionId">
        /// The session ID this run belongs to.
        /// </param>
        /// <param name="deploymentId">
        /// The ID of the Loops deployment the run executes on.
        /// </param>
        /// <param name="name">
        /// The run's display name.
        /// </param>
        /// <param name="baseModel">
        /// The HuggingFace base model the run is fine-tuning.
        /// </param>
        /// <param name="baseUrl">
        /// The run's base URL.
        /// </param>
        /// <param name="createdAt">
        /// Time the run was created in ISO 8601 format
        /// </param>
        /// <param name="sampler">
        /// The sampler bound to this run.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LoopsRunV1(
            string id,
            string sessionId,
            string deploymentId,
            string name,
            string baseModel,
            string baseUrl,
            global::System.DateTime createdAt,
            global::Baseten.LoopsSamplerV1 sampler)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.SessionId = sessionId ?? throw new global::System.ArgumentNullException(nameof(sessionId));
            this.DeploymentId = deploymentId ?? throw new global::System.ArgumentNullException(nameof(deploymentId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.BaseModel = baseModel ?? throw new global::System.ArgumentNullException(nameof(baseModel));
            this.BaseUrl = baseUrl ?? throw new global::System.ArgumentNullException(nameof(baseUrl));
            this.CreatedAt = createdAt;
            this.Sampler = sampler ?? throw new global::System.ArgumentNullException(nameof(sampler));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LoopsRunV1" /> class.
        /// </summary>
        public LoopsRunV1()
        {
        }

    }
}