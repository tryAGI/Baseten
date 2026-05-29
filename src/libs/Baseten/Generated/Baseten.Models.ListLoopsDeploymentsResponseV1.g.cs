
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Response for ``GET /v1/loops/deployments``.<br/>
    /// Returns every Loops deployment owned by the caller, regardless of status<br/>
    /// (CREATED, DEPLOYING, RUNNING, STOPPED, or FAILED). Clients filter<br/>
    /// terminal-state deployments themselves.
    /// </summary>
    public sealed partial class ListLoopsDeploymentsResponseV1
    {
        /// <summary>
        /// Active Loops deployments.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Baseten.LoopsDeploymentV1> Deployments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListLoopsDeploymentsResponseV1" /> class.
        /// </summary>
        /// <param name="deployments">
        /// Active Loops deployments.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListLoopsDeploymentsResponseV1(
            global::System.Collections.Generic.IList<global::Baseten.LoopsDeploymentV1> deployments)
        {
            this.Deployments = deployments ?? throw new global::System.ArgumentNullException(nameof(deployments));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListLoopsDeploymentsResponseV1" /> class.
        /// </summary>
        public ListLoopsDeploymentsResponseV1()
        {
        }

    }
}