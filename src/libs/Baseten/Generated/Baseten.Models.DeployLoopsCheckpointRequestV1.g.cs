
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DeployLoopsCheckpointRequestV1
    {
        /// <summary>
        /// Sampler checkpoint IDs to deploy together.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("checkpoint_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> CheckpointIds { get; set; }

        /// <summary>
        /// Name for the created model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelName { get; set; }

        /// <summary>
        /// Instance type ID for the deployment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instance_type_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string InstanceTypeId { get; set; }

        /// <summary>
        /// Name of the team-scoped secret that supplies HF_TOKEN.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hf_secret_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HfSecretName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeployLoopsCheckpointRequestV1" /> class.
        /// </summary>
        /// <param name="checkpointIds">
        /// Sampler checkpoint IDs to deploy together.
        /// </param>
        /// <param name="modelName">
        /// Name for the created model.
        /// </param>
        /// <param name="instanceTypeId">
        /// Instance type ID for the deployment.
        /// </param>
        /// <param name="hfSecretName">
        /// Name of the team-scoped secret that supplies HF_TOKEN.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeployLoopsCheckpointRequestV1(
            global::System.Collections.Generic.IList<string> checkpointIds,
            string modelName,
            string instanceTypeId,
            string hfSecretName)
        {
            this.CheckpointIds = checkpointIds ?? throw new global::System.ArgumentNullException(nameof(checkpointIds));
            this.ModelName = modelName ?? throw new global::System.ArgumentNullException(nameof(modelName));
            this.InstanceTypeId = instanceTypeId ?? throw new global::System.ArgumentNullException(nameof(instanceTypeId));
            this.HfSecretName = hfSecretName ?? throw new global::System.ArgumentNullException(nameof(hfSecretName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeployLoopsCheckpointRequestV1" /> class.
        /// </summary>
        public DeployLoopsCheckpointRequestV1()
        {
        }

    }
}