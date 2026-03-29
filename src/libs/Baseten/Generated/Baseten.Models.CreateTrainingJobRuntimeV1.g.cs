
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Configuration to specify the runtime environment for a training job.
    /// </summary>
    public sealed partial class CreateTrainingJobRuntimeV1
    {
        /// <summary>
        /// Commands to execute when starting the runtime.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_commands")]
        public global::System.Collections.Generic.IList<string>? StartCommands { get; set; }

        /// <summary>
        /// Environment variables to set in the runtime.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment_variables")]
        public object? EnvironmentVariables { get; set; }

        /// <summary>
        /// Runtime artifacts for the training job.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("artifacts")]
        public global::System.Collections.Generic.IList<global::Baseten.CreateTrainingJobS3Artifact>? Artifacts { get; set; }

        /// <summary>
        /// Deprecated. Use cache_config instead.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_cache")]
        public bool? EnableCache { get; set; }

        /// <summary>
        /// Configuration for the read-write cache.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_config")]
        public global::Baseten.CreateTrainingJobCacheConfig? CacheConfig { get; set; }

        /// <summary>
        /// Configuration for checkpointing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("checkpointing_config")]
        public global::Baseten.CreateTrainingJobCheckpointingConfig? CheckpointingConfig { get; set; }

        /// <summary>
        /// Configuration for loading checkpoints<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("load_checkpoint_config")]
        public global::Baseten.LoadCheckpointConfig? LoadCheckpointConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTrainingJobRuntimeV1" /> class.
        /// </summary>
        /// <param name="startCommands">
        /// Commands to execute when starting the runtime.
        /// </param>
        /// <param name="environmentVariables">
        /// Environment variables to set in the runtime.
        /// </param>
        /// <param name="artifacts">
        /// Runtime artifacts for the training job.
        /// </param>
        /// <param name="enableCache">
        /// Deprecated. Use cache_config instead.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="cacheConfig">
        /// Configuration for the read-write cache.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="checkpointingConfig">
        /// Configuration for checkpointing.
        /// </param>
        /// <param name="loadCheckpointConfig">
        /// Configuration for loading checkpoints<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTrainingJobRuntimeV1(
            global::System.Collections.Generic.IList<string>? startCommands,
            object? environmentVariables,
            global::System.Collections.Generic.IList<global::Baseten.CreateTrainingJobS3Artifact>? artifacts,
            bool? enableCache,
            global::Baseten.CreateTrainingJobCacheConfig? cacheConfig,
            global::Baseten.CreateTrainingJobCheckpointingConfig? checkpointingConfig,
            global::Baseten.LoadCheckpointConfig? loadCheckpointConfig)
        {
            this.StartCommands = startCommands;
            this.EnvironmentVariables = environmentVariables;
            this.Artifacts = artifacts;
            this.EnableCache = enableCache;
            this.CacheConfig = cacheConfig;
            this.CheckpointingConfig = checkpointingConfig;
            this.LoadCheckpointConfig = loadCheckpointConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTrainingJobRuntimeV1" /> class.
        /// </summary>
        public CreateTrainingJobRuntimeV1()
        {
        }
    }
}