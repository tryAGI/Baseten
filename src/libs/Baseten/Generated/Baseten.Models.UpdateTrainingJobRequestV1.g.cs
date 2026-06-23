
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A request to update mutable fields on a training job.
    /// </summary>
    public sealed partial class UpdateTrainingJobRequestV1
    {
        /// <summary>
        /// New queue priority for a PENDING training job. Higher values are dequeued first. Only jobs in the PENDING state can have their priority changed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("priority")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Priority { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateTrainingJobRequestV1" /> class.
        /// </summary>
        /// <param name="priority">
        /// New queue priority for a PENDING training job. Higher values are dequeued first. Only jobs in the PENDING state can have their priority changed.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateTrainingJobRequestV1(
            int priority)
        {
            this.Priority = priority;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateTrainingJobRequestV1" /> class.
        /// </summary>
        public UpdateTrainingJobRequestV1()
        {
        }

    }
}