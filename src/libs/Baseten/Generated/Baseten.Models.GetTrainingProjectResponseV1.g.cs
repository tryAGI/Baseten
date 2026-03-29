
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A response to getting a training project.
    /// </summary>
    public sealed partial class GetTrainingProjectResponseV1
    {
        /// <summary>
        /// The training project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("training_project")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.TrainingProjectV1 TrainingProject { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTrainingProjectResponseV1" /> class.
        /// </summary>
        /// <param name="trainingProject">
        /// The training project.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetTrainingProjectResponseV1(
            global::Baseten.TrainingProjectV1 trainingProject)
        {
            this.TrainingProject = trainingProject ?? throw new global::System.ArgumentNullException(nameof(trainingProject));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTrainingProjectResponseV1" /> class.
        /// </summary>
        public GetTrainingProjectResponseV1()
        {
        }
    }
}