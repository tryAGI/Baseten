
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Where a rule sends traffic. Exactly one of deployment_id and environment is set.
    /// </summary>
    public sealed partial class TrafficRoutingTargetV1
    {
        /// <summary>
        /// ID of the target's model
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelId { get; set; }

        /// <summary>
        /// ID of the target deployment<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployment_id")]
        public string? DeploymentId { get; set; }

        /// <summary>
        /// Name of the target environment. Traffic goes to whichever deployment the environment is serving.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment")]
        public string? Environment { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TrafficRoutingTargetV1" /> class.
        /// </summary>
        /// <param name="modelId">
        /// ID of the target's model
        /// </param>
        /// <param name="deploymentId">
        /// ID of the target deployment<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="environment">
        /// Name of the target environment. Traffic goes to whichever deployment the environment is serving.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TrafficRoutingTargetV1(
            string modelId,
            string? deploymentId,
            string? environment)
        {
            this.ModelId = modelId ?? throw new global::System.ArgumentNullException(nameof(modelId));
            this.DeploymentId = deploymentId;
            this.Environment = environment;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrafficRoutingTargetV1" /> class.
        /// </summary>
        public TrafficRoutingTargetV1()
        {
        }

    }
}