
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Response for ``GET /v1/loops/deployments/&lt;deployment_id&gt;``.
    /// </summary>
    public sealed partial class GetLoopDeploymentResponseV1
    {
        /// <summary>
        /// The loop deployment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployment")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.LoopDeploymentV1 Deployment { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetLoopDeploymentResponseV1" /> class.
        /// </summary>
        /// <param name="deployment">
        /// The loop deployment.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetLoopDeploymentResponseV1(
            global::Baseten.LoopDeploymentV1 deployment)
        {
            this.Deployment = deployment ?? throw new global::System.ArgumentNullException(nameof(deployment));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetLoopDeploymentResponseV1" /> class.
        /// </summary>
        public GetLoopDeploymentResponseV1()
        {
        }
    }
}