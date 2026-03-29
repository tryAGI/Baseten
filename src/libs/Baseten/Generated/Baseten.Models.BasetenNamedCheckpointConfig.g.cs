
#nullable enable

namespace Baseten
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BasetenNamedCheckpointConfig
    {
        /// <summary>
        /// Name of the checkpoint to load from
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("checkpoint_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CheckpointName { get; set; }

        /// <summary>
        /// Name of the project to load the checkpoint from<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_name")]
        public string? ProjectName { get; set; }

        /// <summary>
        /// ID of the job to load the checkpoint from<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("job_id")]
        public string? JobId { get; set; }

        /// <summary>
        /// Default Value: baseten_named_checkpoint
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("typ")]
        public string? Typ { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BasetenNamedCheckpointConfig" /> class.
        /// </summary>
        /// <param name="checkpointName">
        /// Name of the checkpoint to load from
        /// </param>
        /// <param name="projectName">
        /// Name of the project to load the checkpoint from<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="jobId">
        /// ID of the job to load the checkpoint from<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="typ">
        /// Default Value: baseten_named_checkpoint
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BasetenNamedCheckpointConfig(
            string checkpointName,
            string? projectName,
            string? jobId,
            string? typ)
        {
            this.CheckpointName = checkpointName ?? throw new global::System.ArgumentNullException(nameof(checkpointName));
            this.ProjectName = projectName;
            this.JobId = jobId;
            this.Typ = typ;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BasetenNamedCheckpointConfig" /> class.
        /// </summary>
        public BasetenNamedCheckpointConfig()
        {
        }
    }
}