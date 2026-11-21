
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Baseten
{
    /// <summary>
    /// A checkpoint for a training job.
    /// </summary>
    public sealed partial class TrainingJobCheckpointV1
    {
        /// <summary>
        /// Deprecated: use `checkpoint_name`, which has the same value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("checkpoint_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CheckpointId { get; set; }

        /// <summary>
        /// The checkpoint's name, for example `checkpoint-500`. To refer to the checkpoint in a URL, use its `id`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("checkpoint_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CheckpointName { get; set; }

        /// <summary>
        /// The timestamp of the checkpoint in ISO 8601 format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// The type of checkpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("checkpoint_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CheckpointType { get; set; }

        /// <summary>
        /// The base model of the checkpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_model")]
        public string? BaseModel { get; set; }

        /// <summary>
        /// The adapter config of the checkpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lora_adapter_config")]
        public object? LoraAdapterConfig { get; set; }

        /// <summary>
        /// The size of the checkpoint in bytes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size_bytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long SizeBytes { get; set; }

        /// <summary>
        /// Sync state of the checkpoint: SYNCING or COMPLETE.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sync_status")]
        public string? SyncStatus { get; set; }

        /// <summary>
        /// The checkpoint's unique ID, used in checkpoint URLs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The ID of the training job.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("training_job_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TrainingJobId { get; set; }

        /// <summary>
        /// When the checkpoint expires and is deleted. Null means it never expires.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        public global::System.DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TrainingJobCheckpointV1" /> class.
        /// </summary>
        /// <param name="checkpointId">
        /// Deprecated: use `checkpoint_name`, which has the same value.
        /// </param>
        /// <param name="checkpointName">
        /// The checkpoint's name, for example `checkpoint-500`. To refer to the checkpoint in a URL, use its `id`.
        /// </param>
        /// <param name="createdAt">
        /// The timestamp of the checkpoint in ISO 8601 format.
        /// </param>
        /// <param name="checkpointType">
        /// The type of checkpoint.
        /// </param>
        /// <param name="sizeBytes">
        /// The size of the checkpoint in bytes.
        /// </param>
        /// <param name="id">
        /// The checkpoint's unique ID, used in checkpoint URLs.
        /// </param>
        /// <param name="trainingJobId">
        /// The ID of the training job.
        /// </param>
        /// <param name="baseModel">
        /// The base model of the checkpoint.
        /// </param>
        /// <param name="loraAdapterConfig">
        /// The adapter config of the checkpoint.
        /// </param>
        /// <param name="syncStatus">
        /// Sync state of the checkpoint: SYNCING or COMPLETE.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="expiresAt">
        /// When the checkpoint expires and is deleted. Null means it never expires.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TrainingJobCheckpointV1(
            string checkpointId,
            string checkpointName,
            global::System.DateTime createdAt,
            string checkpointType,
            long sizeBytes,
            string id,
            string trainingJobId,
            string? baseModel,
            object? loraAdapterConfig,
            string? syncStatus,
            global::System.DateTime? expiresAt)
        {
            this.CheckpointId = checkpointId ?? throw new global::System.ArgumentNullException(nameof(checkpointId));
            this.CheckpointName = checkpointName ?? throw new global::System.ArgumentNullException(nameof(checkpointName));
            this.CreatedAt = createdAt;
            this.CheckpointType = checkpointType ?? throw new global::System.ArgumentNullException(nameof(checkpointType));
            this.BaseModel = baseModel;
            this.LoraAdapterConfig = loraAdapterConfig;
            this.SizeBytes = sizeBytes;
            this.SyncStatus = syncStatus;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.TrainingJobId = trainingJobId ?? throw new global::System.ArgumentNullException(nameof(trainingJobId));
            this.ExpiresAt = expiresAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrainingJobCheckpointV1" /> class.
        /// </summary>
        public TrainingJobCheckpointV1()
        {
        }

    }
}