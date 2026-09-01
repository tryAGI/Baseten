
#nullable enable

namespace Baseten
{
    /// <summary>
    /// New capacity guarantee for a PENDING training job. 'dedicated' runs on on-demand capacity that is not preempted. 'spot' runs on interruptible capacity that may be preempted; the user is responsible for checkpointing their own progress. Only jobs in the PENDING state can have their availability model changed.<br/>
    /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
    /// </summary>
    public sealed partial class UpdateTrainingJobRequestV1AvailabilityModel
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}