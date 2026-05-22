
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Response for ``POST /v1/loops/deployments/&lt;id&gt;/metrics``.
    /// </summary>
    public sealed partial class GetLoopsDeploymentMetricsResponseV1
    {
        /// <summary>
        /// The trainer deployment ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployment_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DeploymentId { get; set; }

        /// <summary>
        /// Metrics for the deployment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metrics")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.LoopsDeploymentMetricsV1 Metrics { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetLoopsDeploymentMetricsResponseV1" /> class.
        /// </summary>
        /// <param name="deploymentId">
        /// The trainer deployment ID.
        /// </param>
        /// <param name="metrics">
        /// Metrics for the deployment.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetLoopsDeploymentMetricsResponseV1(
            string deploymentId,
            global::Baseten.LoopsDeploymentMetricsV1 metrics)
        {
            this.DeploymentId = deploymentId ?? throw new global::System.ArgumentNullException(nameof(deploymentId));
            this.Metrics = metrics ?? throw new global::System.ArgumentNullException(nameof(metrics));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetLoopsDeploymentMetricsResponseV1" /> class.
        /// </summary>
        public GetLoopsDeploymentMetricsResponseV1()
        {
        }

    }
}