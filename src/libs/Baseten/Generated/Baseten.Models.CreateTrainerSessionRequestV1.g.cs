
#nullable enable

namespace Baseten
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateTrainerSessionRequestV1
    {
        /// <summary>
        /// ID of the training project to associate with.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("training_project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TrainingProjectId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTrainerSessionRequestV1" /> class.
        /// </summary>
        /// <param name="trainingProjectId">
        /// ID of the training project to associate with.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTrainerSessionRequestV1(
            string trainingProjectId)
        {
            this.TrainingProjectId = trainingProjectId ?? throw new global::System.ArgumentNullException(nameof(trainingProjectId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTrainerSessionRequestV1" /> class.
        /// </summary>
        public CreateTrainerSessionRequestV1()
        {
        }
    }
}