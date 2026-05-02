
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Trainers matching the search filters.
    /// </summary>
    public sealed partial class SearchTrainersResponseV1
    {
        /// <summary>
        /// List of trainers.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trainers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Baseten.SearchedTrainerV1> Trainers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchTrainersResponseV1" /> class.
        /// </summary>
        /// <param name="trainers">
        /// List of trainers.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchTrainersResponseV1(
            global::System.Collections.Generic.IList<global::Baseten.SearchedTrainerV1> trainers)
        {
            this.Trainers = trainers ?? throw new global::System.ArgumentNullException(nameof(trainers));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchTrainersResponseV1" /> class.
        /// </summary>
        public SearchTrainersResponseV1()
        {
        }
    }
}