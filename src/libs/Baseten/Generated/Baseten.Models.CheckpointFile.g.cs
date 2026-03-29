
#nullable enable

namespace Baseten
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CheckpointFile
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("relative_file_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RelativeFileName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_rank")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int NodeRank { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size_bytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long SizeBytes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_modified")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LastModified { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckpointFile" /> class.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="relativeFileName"></param>
        /// <param name="nodeRank"></param>
        /// <param name="sizeBytes"></param>
        /// <param name="lastModified"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CheckpointFile(
            string url,
            string relativeFileName,
            int nodeRank,
            long sizeBytes,
            string lastModified)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.RelativeFileName = relativeFileName ?? throw new global::System.ArgumentNullException(nameof(relativeFileName));
            this.NodeRank = nodeRank;
            this.SizeBytes = sizeBytes;
            this.LastModified = lastModified ?? throw new global::System.ArgumentNullException(nameof(lastModified));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckpointFile" /> class.
        /// </summary>
        public CheckpointFile()
        {
        }
    }
}