
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A list of chain deployments.
    /// </summary>
    public sealed partial class ChainDeploymentsV1
    {
        /// <summary>
        /// A list of chain deployments
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Baseten.ChainDeploymentV1> Deployments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChainDeploymentsV1" /> class.
        /// </summary>
        /// <param name="deployments">
        /// A list of chain deployments
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChainDeploymentsV1(
            global::System.Collections.Generic.IList<global::Baseten.ChainDeploymentV1> deployments)
        {
            this.Deployments = deployments ?? throw new global::System.ArgumentNullException(nameof(deployments));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChainDeploymentsV1" /> class.
        /// </summary>
        public ChainDeploymentsV1()
        {
        }
    }
}