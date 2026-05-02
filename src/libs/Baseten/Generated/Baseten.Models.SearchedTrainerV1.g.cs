
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Trainer entry returned by /v1/trainers/search.
    /// </summary>
    public sealed partial class SearchedTrainerV1
    {
        /// <summary>
        /// The trainer ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trainer_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TrainerId { get; set; }

        /// <summary>
        /// The session ID this trainer belongs to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SessionId { get; set; }

        /// <summary>
        /// The HuggingFace base model the trainer is fine-tuning.
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
        /// Initializes a new instance of the <see cref="SearchedTrainerV1" /> class.
        /// </summary>
        /// <param name="trainerId">
        /// The trainer ID.
        /// </param>
        /// <param name="sessionId">
        /// The session ID this trainer belongs to.
        /// </param>
        /// <param name="baseModel">
        /// The HuggingFace base model the trainer is fine-tuning.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchedTrainerV1(
            string trainerId,
            string sessionId,
            string baseModel)
        {
            this.TrainerId = trainerId ?? throw new global::System.ArgumentNullException(nameof(trainerId));
            this.SessionId = sessionId ?? throw new global::System.ArgumentNullException(nameof(sessionId));
            this.BaseModel = baseModel ?? throw new global::System.ArgumentNullException(nameof(baseModel));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchedTrainerV1" /> class.
        /// </summary>
        public SearchedTrainerV1()
        {
        }
    }
}