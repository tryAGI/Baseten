
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Lookup body for ``POST /v1/trainers/checkpoints/search``.
    /// </summary>
    public sealed partial class CheckpointSearchRequestV1
    {
        /// <summary>
        /// bt:// URI of a trainer checkpoint. Form: bt://loops:&lt;trainer_id&gt;/(weights|sampler_weights)/&lt;checkpoint_name&gt;.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("checkpoint_path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CheckpointPath { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckpointSearchRequestV1" /> class.
        /// </summary>
        /// <param name="checkpointPath">
        /// bt:// URI of a trainer checkpoint. Form: bt://loops:&lt;trainer_id&gt;/(weights|sampler_weights)/&lt;checkpoint_name&gt;.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CheckpointSearchRequestV1(
            string checkpointPath)
        {
            this.CheckpointPath = checkpointPath ?? throw new global::System.ArgumentNullException(nameof(checkpointPath));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckpointSearchRequestV1" /> class.
        /// </summary>
        public CheckpointSearchRequestV1()
        {
        }
    }
}