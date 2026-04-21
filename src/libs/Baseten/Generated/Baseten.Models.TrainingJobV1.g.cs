
#nullable enable

namespace Baseten
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TrainingJobV1
    {
        /// <summary>
        /// Unique identifier of the training job.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Time the job was created in ISO 8601 format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Current status of the training job.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("current_status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CurrentStatus { get; set; }

        /// <summary>
        /// Error message if the training job failed.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_message")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// Instance type of the training job.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instance_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.InstanceTypeV1 InstanceType { get; set; }

        /// <summary>
        /// Time the job was updated in ISO 8601 format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// ID of the training project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("training_project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TrainingProjectId { get; set; }

        /// <summary>
        /// Summary of the training project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("training_project")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.TrainingProjectSummaryV1 TrainingProject { get; set; }

        /// <summary>
        /// Name of the training job.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Checkpoint sync status of the training job.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("checkpoint_sync_status")]
        public global::Baseten.CheckpointSyncStatus? CheckpointSyncStatus { get; set; }

        /// <summary>
        /// Queue priority. Higher values are dequeued first. NULL is treated as 0.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("priority")]
        public int? Priority { get; set; }

        /// <summary>
        /// The user who created the training job.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public global::Baseten.UserV1? User { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TrainingJobV1" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier of the training job.
        /// </param>
        /// <param name="createdAt">
        /// Time the job was created in ISO 8601 format.
        /// </param>
        /// <param name="currentStatus">
        /// Current status of the training job.
        /// </param>
        /// <param name="instanceType">
        /// Instance type of the training job.
        /// </param>
        /// <param name="updatedAt">
        /// Time the job was updated in ISO 8601 format.
        /// </param>
        /// <param name="trainingProjectId">
        /// ID of the training project.
        /// </param>
        /// <param name="trainingProject">
        /// Summary of the training project.
        /// </param>
        /// <param name="errorMessage">
        /// Error message if the training job failed.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="name">
        /// Name of the training job.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="checkpointSyncStatus">
        /// Checkpoint sync status of the training job.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="priority">
        /// Queue priority. Higher values are dequeued first. NULL is treated as 0.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="user">
        /// The user who created the training job.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TrainingJobV1(
            string id,
            global::System.DateTime createdAt,
            string currentStatus,
            global::Baseten.InstanceTypeV1 instanceType,
            global::System.DateTime updatedAt,
            string trainingProjectId,
            global::Baseten.TrainingProjectSummaryV1 trainingProject,
            string? errorMessage,
            string? name,
            global::Baseten.CheckpointSyncStatus? checkpointSyncStatus,
            int? priority,
            global::Baseten.UserV1? user)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.CreatedAt = createdAt;
            this.CurrentStatus = currentStatus ?? throw new global::System.ArgumentNullException(nameof(currentStatus));
            this.ErrorMessage = errorMessage;
            this.InstanceType = instanceType ?? throw new global::System.ArgumentNullException(nameof(instanceType));
            this.UpdatedAt = updatedAt;
            this.TrainingProjectId = trainingProjectId ?? throw new global::System.ArgumentNullException(nameof(trainingProjectId));
            this.TrainingProject = trainingProject ?? throw new global::System.ArgumentNullException(nameof(trainingProject));
            this.Name = name;
            this.CheckpointSyncStatus = checkpointSyncStatus;
            this.Priority = priority;
            this.User = user;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrainingJobV1" /> class.
        /// </summary>
        public TrainingJobV1()
        {
        }
    }
}