
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Response for ``GET /v1/loops/deployments/&lt;deployment_id&gt;``.
    /// </summary>
    public sealed partial class GetLoopsDeploymentResponseV1
    {
        /// <summary>
        /// The Loops deployment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployment")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.LoopsDeploymentV1 Deployment { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetLoopsDeploymentResponseV1" /> class.
        /// </summary>
        /// <param name="deployment">
        /// The Loops deployment.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetLoopsDeploymentResponseV1(
            global::Baseten.LoopsDeploymentV1 deployment)
        {
            this.Deployment = deployment ?? throw new global::System.ArgumentNullException(nameof(deployment));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetLoopsDeploymentResponseV1" /> class.
        /// </summary>
        public GetLoopsDeploymentResponseV1()
        {
        }
    }
}