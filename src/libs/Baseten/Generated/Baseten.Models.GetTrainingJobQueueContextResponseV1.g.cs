
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Read-only diagnostic for a training job's PENDING window.<br/>
    /// Returns the (org, gpu_type) capacity pool the job was gated by, jobs that<br/>
    /// were holding GPU capacity in that pool when this job was submitted, and<br/>
    /// every status event in [submitted_at, released_at] for those jobs (or up to<br/>
    /// "now" if the target is still PENDING).
    /// </summary>
    public sealed partial class GetTrainingJobQueueContextResponseV1
    {
        /// <summary>
        /// Hashid of the target training job
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_job_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TargetJobId { get; set; }

        /// <summary>
        /// Target job's name<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_job_name")]
        public string? TargetJobName { get; set; }

        /// <summary>
        /// GPU type the target requested
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gpu_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GpuType { get; set; }

        /// <summary>
        /// GPUs the target requested (gpu_count * effective_node_count)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requested_gpus")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int RequestedGpus { get; set; }

        /// <summary>
        /// When the job row was inserted (= API POST time)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("submitted_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime SubmittedAt { get; set; }

        /// <summary>
        /// When the job's TRAINING_JOB_CREATED status was set, i.e. the moment it was released from PENDING. None if still PENDING.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("released_at")]
        public global::System.DateTime? ReleasedAt { get; set; }

        /// <summary>
        /// released_at - submitted_at in seconds. None if still PENDING.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pending_seconds")]
        public int? PendingSeconds { get; set; }

        /// <summary>
        /// Org-level cap for (org, gpu_type). None if no cap is configured.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("org_capacity")]
        public global::Baseten.CapacityAtSubmitV1? OrgCapacity { get; set; }

        /// <summary>
        /// Team-level cap for (team, gpu_type). None if no team cap is configured.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_capacity")]
        public global::Baseten.CapacityAtSubmitV1? TeamCapacity { get; set; }

        /// <summary>
        /// Jobs in the same (org, gpu_type) pool that were holding capacity at submitted_at
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active_at_submit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Baseten.ActiveJobAtSubmitV1> ActiveAtSubmit { get; set; }

        /// <summary>
        /// PENDING jobs in the same (org, gpu_type) pool that were ahead of the target in dequeue FIFO order at submitted_at (priority DESC then created ASC). These also block the target's release.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pending_ahead_at_submit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Baseten.PendingJobAheadAtSubmitV1> PendingAheadAtSubmit { get; set; }

        /// <summary>
        /// Every status event in [submitted_at, events_window_end] for the target job, every job in active_at_submit, and every job in pending_ahead_at_submit, oldest first.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("events")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Baseten.QueueEventV1> Events { get; set; }

        /// <summary>
        /// released_at if set, else 'now' (events ongoing)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("events_window_end")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime EventsWindowEnd { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTrainingJobQueueContextResponseV1" /> class.
        /// </summary>
        /// <param name="targetJobId">
        /// Hashid of the target training job
        /// </param>
        /// <param name="gpuType">
        /// GPU type the target requested
        /// </param>
        /// <param name="requestedGpus">
        /// GPUs the target requested (gpu_count * effective_node_count)
        /// </param>
        /// <param name="submittedAt">
        /// When the job row was inserted (= API POST time)
        /// </param>
        /// <param name="activeAtSubmit">
        /// Jobs in the same (org, gpu_type) pool that were holding capacity at submitted_at
        /// </param>
        /// <param name="pendingAheadAtSubmit">
        /// PENDING jobs in the same (org, gpu_type) pool that were ahead of the target in dequeue FIFO order at submitted_at (priority DESC then created ASC). These also block the target's release.
        /// </param>
        /// <param name="events">
        /// Every status event in [submitted_at, events_window_end] for the target job, every job in active_at_submit, and every job in pending_ahead_at_submit, oldest first.
        /// </param>
        /// <param name="eventsWindowEnd">
        /// released_at if set, else 'now' (events ongoing)
        /// </param>
        /// <param name="targetJobName">
        /// Target job's name<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="releasedAt">
        /// When the job's TRAINING_JOB_CREATED status was set, i.e. the moment it was released from PENDING. None if still PENDING.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="pendingSeconds">
        /// released_at - submitted_at in seconds. None if still PENDING.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="orgCapacity">
        /// Org-level cap for (org, gpu_type). None if no cap is configured.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="teamCapacity">
        /// Team-level cap for (team, gpu_type). None if no team cap is configured.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetTrainingJobQueueContextResponseV1(
            string targetJobId,
            string gpuType,
            int requestedGpus,
            global::System.DateTime submittedAt,
            global::System.Collections.Generic.IList<global::Baseten.ActiveJobAtSubmitV1> activeAtSubmit,
            global::System.Collections.Generic.IList<global::Baseten.PendingJobAheadAtSubmitV1> pendingAheadAtSubmit,
            global::System.Collections.Generic.IList<global::Baseten.QueueEventV1> events,
            global::System.DateTime eventsWindowEnd,
            string? targetJobName,
            global::System.DateTime? releasedAt,
            int? pendingSeconds,
            global::Baseten.CapacityAtSubmitV1? orgCapacity,
            global::Baseten.CapacityAtSubmitV1? teamCapacity)
        {
            this.TargetJobId = targetJobId ?? throw new global::System.ArgumentNullException(nameof(targetJobId));
            this.TargetJobName = targetJobName;
            this.GpuType = gpuType ?? throw new global::System.ArgumentNullException(nameof(gpuType));
            this.RequestedGpus = requestedGpus;
            this.SubmittedAt = submittedAt;
            this.ReleasedAt = releasedAt;
            this.PendingSeconds = pendingSeconds;
            this.OrgCapacity = orgCapacity;
            this.TeamCapacity = teamCapacity;
            this.ActiveAtSubmit = activeAtSubmit ?? throw new global::System.ArgumentNullException(nameof(activeAtSubmit));
            this.PendingAheadAtSubmit = pendingAheadAtSubmit ?? throw new global::System.ArgumentNullException(nameof(pendingAheadAtSubmit));
            this.Events = events ?? throw new global::System.ArgumentNullException(nameof(events));
            this.EventsWindowEnd = eventsWindowEnd;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTrainingJobQueueContextResponseV1" /> class.
        /// </summary>
        public GetTrainingJobQueueContextResponseV1()
        {
        }

    }
}