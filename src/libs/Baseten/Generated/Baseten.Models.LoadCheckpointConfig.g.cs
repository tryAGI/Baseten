
#nullable enable

namespace Baseten
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LoadCheckpointConfig
    {
        /// <summary>
        /// Whether checkpoint loading is enabled<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Folder where checkpoints will be downloaded<br/>
        /// Default Value: /tmp/loaded_checkpoints
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("download_folder")]
        public string? DownloadFolder { get; set; }

        /// <summary>
        /// List of checkpoint configurations
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("checkpoints")]
        public global::System.Collections.Generic.IList<global::Baseten.CheckpointsItem>? Checkpoints { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LoadCheckpointConfig" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Whether checkpoint loading is enabled<br/>
        /// Default Value: false
        /// </param>
        /// <param name="downloadFolder">
        /// Folder where checkpoints will be downloaded<br/>
        /// Default Value: /tmp/loaded_checkpoints
        /// </param>
        /// <param name="checkpoints">
        /// List of checkpoint configurations
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LoadCheckpointConfig(
            bool? enabled,
            string? downloadFolder,
            global::System.Collections.Generic.IList<global::Baseten.CheckpointsItem>? checkpoints)
        {
            this.Enabled = enabled;
            this.DownloadFolder = downloadFolder;
            this.Checkpoints = checkpoints;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LoadCheckpointConfig" /> class.
        /// </summary>
        public LoadCheckpointConfig()
        {
        }
    }
}