
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Run entry returned by ``GET /v1/loops/runs``.
    /// </summary>
    public sealed partial class LoopRunListItemV1
    {
        /// <summary>
        /// The run ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RunId { get; set; }

        /// <summary>
        /// The session ID this run belongs to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SessionId { get; set; }

        /// <summary>
        /// The HuggingFace base model the run is fine-tuning.
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
        /// Initializes a new instance of the <see cref="LoopRunListItemV1" /> class.
        /// </summary>
        /// <param name="runId">
        /// The run ID.
        /// </param>
        /// <param name="sessionId">
        /// The session ID this run belongs to.
        /// </param>
        /// <param name="baseModel">
        /// The HuggingFace base model the run is fine-tuning.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LoopRunListItemV1(
            string runId,
            string sessionId,
            string baseModel)
        {
            this.RunId = runId ?? throw new global::System.ArgumentNullException(nameof(runId));
            this.SessionId = sessionId ?? throw new global::System.ArgumentNullException(nameof(sessionId));
            this.BaseModel = baseModel ?? throw new global::System.ArgumentNullException(nameof(baseModel));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LoopRunListItemV1" /> class.
        /// </summary>
        public LoopRunListItemV1()
        {
        }
    }
}