
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A request to update a deployment.
    /// </summary>
    public sealed partial class UpdateDeploymentRequestV1
    {
        /// <summary>
        /// New name for the deployment, unique among the model's deployments. Only alphanumeric characters, hyphens, underscores, and periods are allowed.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateDeploymentRequestV1" /> class.
        /// </summary>
        /// <param name="name">
        /// New name for the deployment, unique among the model's deployments. Only alphanumeric characters, hyphens, underscores, and periods are allowed.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateDeploymentRequestV1(
            string? name)
        {
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateDeploymentRequestV1" /> class.
        /// </summary>
        public UpdateDeploymentRequestV1()
        {
        }

    }
}