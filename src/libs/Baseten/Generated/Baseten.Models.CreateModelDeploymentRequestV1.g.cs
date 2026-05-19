
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Body for adding a deployment to an existing model via<br/>
    /// `POST /v1/models/{model_id}/deployments`.
    /// </summary>
    public sealed partial class CreateModelDeploymentRequestV1
    {
        /// <summary>
        /// Where the new deployment is created from.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.DeploymentArchiveSourceV1 Source { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateModelDeploymentRequestV1" /> class.
        /// </summary>
        /// <param name="source">
        /// Where the new deployment is created from.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateModelDeploymentRequestV1(
            global::Baseten.DeploymentArchiveSourceV1 source)
        {
            this.Source = source ?? throw new global::System.ArgumentNullException(nameof(source));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateModelDeploymentRequestV1" /> class.
        /// </summary>
        public CreateModelDeploymentRequestV1()
        {
        }

    }
}