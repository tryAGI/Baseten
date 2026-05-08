
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Response for ``POST /v1/loops/deployments/&lt;deployment_id&gt;/deactivate``.
    /// </summary>
    public sealed partial class DeactivateLoopsDeploymentResponseV1
    {
        /// <summary>
        /// The deactivated Loops deployment ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The base model whose Loops deployment was deactivated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BaseModel { get; set; }

        /// <summary>
        /// The user who owned the Loops deployment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.UserV1 User { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeactivateLoopsDeploymentResponseV1" /> class.
        /// </summary>
        /// <param name="id">
        /// The deactivated Loops deployment ID.
        /// </param>
        /// <param name="baseModel">
        /// The base model whose Loops deployment was deactivated.
        /// </param>
        /// <param name="user">
        /// The user who owned the Loops deployment.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeactivateLoopsDeploymentResponseV1(
            string id,
            string baseModel,
            global::Baseten.UserV1 user)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.BaseModel = baseModel ?? throw new global::System.ArgumentNullException(nameof(baseModel));
            this.User = user ?? throw new global::System.ArgumentNullException(nameof(user));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeactivateLoopsDeploymentResponseV1" /> class.
        /// </summary>
        public DeactivateLoopsDeploymentResponseV1()
        {
        }
    }
}