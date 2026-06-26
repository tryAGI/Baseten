
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A PENDING job in the same (org, gpu_type) pool that was ahead of the<br/>
    /// target in dequeue FIFO order at submitted_at — higher priority, or same<br/>
    /// priority and earlier submission.
    /// </summary>
    public sealed partial class PendingJobAheadAtSubmitV1
    {
        /// <summary>
        /// Hashid of the other training job
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("training_job_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TrainingJobId { get; set; }

        /// <summary>
        /// Other job's name<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("training_job_name")]
        public string? TrainingJobName { get; set; }

        /// <summary>
        /// Instance type of the other job
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instance_type_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string InstanceTypeName { get; set; }

        /// <summary>
        /// gpu_count * effective_node_count
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requested_gpus")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int RequestedGpus { get; set; }

        /// <summary>
        /// Effective priority (NULL coalesced to 0)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("priority")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Priority { get; set; }

        /// <summary>
        /// The other job's submission time
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("submitted_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime SubmittedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PendingJobAheadAtSubmitV1" /> class.
        /// </summary>
        /// <param name="trainingJobId">
        /// Hashid of the other training job
        /// </param>
        /// <param name="instanceTypeName">
        /// Instance type of the other job
        /// </param>
        /// <param name="requestedGpus">
        /// gpu_count * effective_node_count
        /// </param>
        /// <param name="priority">
        /// Effective priority (NULL coalesced to 0)
        /// </param>
        /// <param name="submittedAt">
        /// The other job's submission time
        /// </param>
        /// <param name="trainingJobName">
        /// Other job's name<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PendingJobAheadAtSubmitV1(
            string trainingJobId,
            string instanceTypeName,
            int requestedGpus,
            int priority,
            global::System.DateTime submittedAt,
            string? trainingJobName)
        {
            this.TrainingJobId = trainingJobId ?? throw new global::System.ArgumentNullException(nameof(trainingJobId));
            this.TrainingJobName = trainingJobName;
            this.InstanceTypeName = instanceTypeName ?? throw new global::System.ArgumentNullException(nameof(instanceTypeName));
            this.RequestedGpus = requestedGpus;
            this.Priority = priority;
            this.SubmittedAt = submittedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PendingJobAheadAtSubmitV1" /> class.
        /// </summary>
        public PendingJobAheadAtSubmitV1()
        {
        }

    }
}