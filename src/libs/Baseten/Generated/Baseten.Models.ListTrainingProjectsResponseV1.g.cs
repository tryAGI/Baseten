
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A response to list training projects.
    /// </summary>
    public sealed partial class ListTrainingProjectsResponseV1
    {
        /// <summary>
        /// List of training projects.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("training_projects")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Baseten.TrainingProjectV1> TrainingProjects { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListTrainingProjectsResponseV1" /> class.
        /// </summary>
        /// <param name="trainingProjects">
        /// List of training projects.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListTrainingProjectsResponseV1(
            global::System.Collections.Generic.IList<global::Baseten.TrainingProjectV1> trainingProjects)
        {
            this.TrainingProjects = trainingProjects ?? throw new global::System.ArgumentNullException(nameof(trainingProjects));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListTrainingProjectsResponseV1" /> class.
        /// </summary>
        public ListTrainingProjectsResponseV1()
        {
        }
    }
}