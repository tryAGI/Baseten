
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Request body for ``POST /v1/loops/deployments/deactivate``.
    /// </summary>
    public sealed partial class DeactivateLoopDeploymentRequestV1
    {
        /// <summary>
        /// The base model ID whose active loop deployment should be deactivated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BaseModel { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeactivateLoopDeploymentRequestV1" /> class.
        /// </summary>
        /// <param name="baseModel">
        /// The base model ID whose active loop deployment should be deactivated.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeactivateLoopDeploymentRequestV1(
            string baseModel)
        {
            this.BaseModel = baseModel ?? throw new global::System.ArgumentNullException(nameof(baseModel));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeactivateLoopDeploymentRequestV1" /> class.
        /// </summary>
        public DeactivateLoopDeploymentRequestV1()
        {
        }
    }
}