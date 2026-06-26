
#nullable enable

namespace Baseten
{
    /// <summary>
    /// When the job's TRAINING_JOB_CREATED status was set, i.e. the moment it was released from PENDING. None if still PENDING.<br/>
    /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
    /// </summary>
    public sealed partial class GetTrainingJobQueueContextResponseV1ReleasedAt
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}