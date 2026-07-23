
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Response for ``POST /v1/loops/runs/&lt;run_id&gt;/deactivate``.
    /// </summary>
    public sealed partial class DeactivateLoopsRunResponseV1
    {
        /// <summary>
        /// The deactivated Loops run ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The base model whose Loops run was deactivated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BaseModel { get; set; }

        /// <summary>
        /// The user who owns the Loops run.
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
        /// Initializes a new instance of the <see cref="DeactivateLoopsRunResponseV1" /> class.
        /// </summary>
        /// <param name="id">
        /// The deactivated Loops run ID.
        /// </param>
        /// <param name="baseModel">
        /// The base model whose Loops run was deactivated.
        /// </param>
        /// <param name="user">
        /// The user who owns the Loops run.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeactivateLoopsRunResponseV1(
            string id,
            string baseModel,
            global::Baseten.UserV1 user)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.BaseModel = baseModel ?? throw new global::System.ArgumentNullException(nameof(baseModel));
            this.User = user ?? throw new global::System.ArgumentNullException(nameof(user));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeactivateLoopsRunResponseV1" /> class.
        /// </summary>
        public DeactivateLoopsRunResponseV1()
        {
        }

    }
}