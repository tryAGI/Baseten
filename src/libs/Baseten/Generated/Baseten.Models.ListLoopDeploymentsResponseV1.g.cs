
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Response for ``GET /v1/loops/deployments``.<br/>
    /// Returns the caller's loop deployments whose latest status is not STOPPED<br/>
    /// (i.e. CREATED, DEPLOYING, RUNNING, or FAILED). Stopped deployments are<br/>
    /// excluded so the list is a fit-for-purpose "what's currently provisioned<br/>
    /// for me" view — the deactivate endpoint is the inverse pair.
    /// </summary>
    public sealed partial class ListLoopDeploymentsResponseV1
    {
        /// <summary>
        /// Active loop deployments.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Baseten.LoopDeploymentV1> Deployments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListLoopDeploymentsResponseV1" /> class.
        /// </summary>
        /// <param name="deployments">
        /// Active loop deployments.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListLoopDeploymentsResponseV1(
            global::System.Collections.Generic.IList<global::Baseten.LoopDeploymentV1> deployments)
        {
            this.Deployments = deployments ?? throw new global::System.ArgumentNullException(nameof(deployments));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListLoopDeploymentsResponseV1" /> class.
        /// </summary>
        public ListLoopDeploymentsResponseV1()
        {
        }
    }
}