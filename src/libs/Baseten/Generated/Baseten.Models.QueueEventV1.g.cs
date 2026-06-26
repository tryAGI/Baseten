
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A single ``TrainingJobStatus`` row inside the queue-context window.
    /// </summary>
    public sealed partial class QueueEventV1
    {
        /// <summary>
        /// Hashid of the training job this event is for
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("training_job_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TrainingJobId { get; set; }

        /// <summary>
        /// Job name<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("training_job_name")]
        public string? TrainingJobName { get; set; }

        /// <summary>
        /// TrainingJobStatus.Name value
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Status { get; set; }

        /// <summary>
        /// When the status row was inserted
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Created { get; set; }

        /// <summary>
        /// Human-readable event message from the status metadata<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_message")]
        public string? EventMessage { get; set; }

        /// <summary>
        /// Exit code from the status metadata, if any<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exit_code")]
        public int? ExitCode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QueueEventV1" /> class.
        /// </summary>
        /// <param name="trainingJobId">
        /// Hashid of the training job this event is for
        /// </param>
        /// <param name="status">
        /// TrainingJobStatus.Name value
        /// </param>
        /// <param name="created">
        /// When the status row was inserted
        /// </param>
        /// <param name="trainingJobName">
        /// Job name<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="eventMessage">
        /// Human-readable event message from the status metadata<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="exitCode">
        /// Exit code from the status metadata, if any<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QueueEventV1(
            string trainingJobId,
            string status,
            global::System.DateTime created,
            string? trainingJobName,
            string? eventMessage,
            int? exitCode)
        {
            this.TrainingJobId = trainingJobId ?? throw new global::System.ArgumentNullException(nameof(trainingJobId));
            this.TrainingJobName = trainingJobName;
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.Created = created;
            this.EventMessage = eventMessage;
            this.ExitCode = exitCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueueEventV1" /> class.
        /// </summary>
        public QueueEventV1()
        {
        }

    }
}