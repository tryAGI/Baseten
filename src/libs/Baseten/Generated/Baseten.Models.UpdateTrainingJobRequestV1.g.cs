
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A request to update mutable fields on a training job.<br/>
    /// Every field is optional so a caller can patch one without the other, but at least<br/>
    /// one must be provided: an empty body has nothing to apply.
    /// </summary>
    public sealed partial class UpdateTrainingJobRequestV1
    {
        /// <summary>
        /// New queue priority for a PENDING training job. Higher values are dequeued first. Only jobs in the PENDING state can have their priority changed.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("priority")]
        public int? Priority { get; set; }

        /// <summary>
        /// New capacity guarantee for a PENDING training job. 'standard' runs on capacity that is not preempted. 'spot' runs on interruptible capacity that may be preempted; you are responsible for checkpointing your own progress. Only jobs in the PENDING state can have their availability model changed.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("availability_model")]
        public global::Baseten.AvailabilityModelV1? AvailabilityModel { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateTrainingJobRequestV1" /> class.
        /// </summary>
        /// <param name="priority">
        /// New queue priority for a PENDING training job. Higher values are dequeued first. Only jobs in the PENDING state can have their priority changed.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="availabilityModel">
        /// New capacity guarantee for a PENDING training job. 'standard' runs on capacity that is not preempted. 'spot' runs on interruptible capacity that may be preempted; you are responsible for checkpointing your own progress. Only jobs in the PENDING state can have their availability model changed.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateTrainingJobRequestV1(
            int? priority,
            global::Baseten.AvailabilityModelV1? availabilityModel)
        {
            this.Priority = priority;
            this.AvailabilityModel = availabilityModel;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateTrainingJobRequestV1" /> class.
        /// </summary>
        public UpdateTrainingJobRequestV1()
        {
        }

    }
}