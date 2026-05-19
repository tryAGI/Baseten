
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A newly created deployment and its model.
    /// </summary>
    public sealed partial class CreatedModelDeploymentV1
    {
        /// <summary>
        /// The model the deployment belongs to. May have been created by this call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.ModelV1 Model { get; set; }

        /// <summary>
        /// The newly created deployment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployment")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.DeploymentV1 Deployment { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatedModelDeploymentV1" /> class.
        /// </summary>
        /// <param name="model">
        /// The model the deployment belongs to. May have been created by this call.
        /// </param>
        /// <param name="deployment">
        /// The newly created deployment.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreatedModelDeploymentV1(
            global::Baseten.ModelV1 model,
            global::Baseten.DeploymentV1 deployment)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Deployment = deployment ?? throw new global::System.ArgumentNullException(nameof(deployment));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatedModelDeploymentV1" /> class.
        /// </summary>
        public CreatedModelDeploymentV1()
        {
        }

    }
}