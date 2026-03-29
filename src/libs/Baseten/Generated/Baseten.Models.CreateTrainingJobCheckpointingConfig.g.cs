
#nullable enable

namespace Baseten
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateTrainingJobCheckpointingConfig
    {
        /// <summary>
        /// Whether checkpointing is enabled.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// path where checkpoints will be saved.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("checkpoint_path")]
        public string? CheckpointPath { get; set; }

        /// <summary>
        /// Size of the volume in gibibytes. If not provided, the default size will be used<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("volume_size_gib")]
        public long? VolumeSizeGib { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTrainingJobCheckpointingConfig" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Whether checkpointing is enabled.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="checkpointPath">
        /// path where checkpoints will be saved.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="volumeSizeGib">
        /// Size of the volume in gibibytes. If not provided, the default size will be used<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTrainingJobCheckpointingConfig(
            bool? enabled,
            string? checkpointPath,
            long? volumeSizeGib)
        {
            this.Enabled = enabled;
            this.CheckpointPath = checkpointPath;
            this.VolumeSizeGib = volumeSizeGib;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTrainingJobCheckpointingConfig" /> class.
        /// </summary>
        public CreateTrainingJobCheckpointingConfig()
        {
        }
    }
}