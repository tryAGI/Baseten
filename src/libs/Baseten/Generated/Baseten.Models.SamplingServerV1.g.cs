
#nullable enable

namespace Baseten
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SamplingServerV1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BaseUrl { get; set; }

        /// <summary>
        /// Hashid of the underlying Baseten model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelId { get; set; }

        /// <summary>
        /// Hashid of the specific model deployment (version).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployment_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DeploymentId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SamplingServerV1" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="baseUrl"></param>
        /// <param name="modelId">
        /// Hashid of the underlying Baseten model.
        /// </param>
        /// <param name="deploymentId">
        /// Hashid of the specific model deployment (version).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SamplingServerV1(
            string id,
            string baseUrl,
            string modelId,
            string deploymentId)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.BaseUrl = baseUrl ?? throw new global::System.ArgumentNullException(nameof(baseUrl));
            this.ModelId = modelId ?? throw new global::System.ArgumentNullException(nameof(modelId));
            this.DeploymentId = deploymentId ?? throw new global::System.ArgumentNullException(nameof(deploymentId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SamplingServerV1" /> class.
        /// </summary>
        public SamplingServerV1()
        {
        }

    }
}