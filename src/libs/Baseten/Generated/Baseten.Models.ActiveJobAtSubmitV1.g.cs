
#nullable enable

namespace Baseten
{
    /// <summary>
    /// One other job in the same (org, gpu_type) pool that was holding GPU<br/>
    /// capacity at the moment the target was submitted.
    /// </summary>
    public sealed partial class ActiveJobAtSubmitV1
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
        [global::System.Text.Json.Serialization.JsonPropertyName("total_gpus")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalGpus { get; set; }

        /// <summary>
        /// Workload plane the other job was on
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workload_plane_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WorkloadPlaneName { get; set; }

        /// <summary>
        /// Other job's status as of submitted_at (one of ACTIVE_STATES)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status_at_submit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string StatusAtSubmit { get; set; }

        /// <summary>
        /// When that status was set
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status_set_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime StatusSetAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActiveJobAtSubmitV1" /> class.
        /// </summary>
        /// <param name="trainingJobId">
        /// Hashid of the other training job
        /// </param>
        /// <param name="instanceTypeName">
        /// Instance type of the other job
        /// </param>
        /// <param name="totalGpus">
        /// gpu_count * effective_node_count
        /// </param>
        /// <param name="workloadPlaneName">
        /// Workload plane the other job was on
        /// </param>
        /// <param name="statusAtSubmit">
        /// Other job's status as of submitted_at (one of ACTIVE_STATES)
        /// </param>
        /// <param name="statusSetAt">
        /// When that status was set
        /// </param>
        /// <param name="trainingJobName">
        /// Other job's name<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ActiveJobAtSubmitV1(
            string trainingJobId,
            string instanceTypeName,
            int totalGpus,
            string workloadPlaneName,
            string statusAtSubmit,
            global::System.DateTime statusSetAt,
            string? trainingJobName)
        {
            this.TrainingJobId = trainingJobId ?? throw new global::System.ArgumentNullException(nameof(trainingJobId));
            this.TrainingJobName = trainingJobName;
            this.InstanceTypeName = instanceTypeName ?? throw new global::System.ArgumentNullException(nameof(instanceTypeName));
            this.TotalGpus = totalGpus;
            this.WorkloadPlaneName = workloadPlaneName ?? throw new global::System.ArgumentNullException(nameof(workloadPlaneName));
            this.StatusAtSubmit = statusAtSubmit ?? throw new global::System.ArgumentNullException(nameof(statusAtSubmit));
            this.StatusSetAt = statusSetAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActiveJobAtSubmitV1" /> class.
        /// </summary>
        public ActiveJobAtSubmitV1()
        {
        }

    }
}