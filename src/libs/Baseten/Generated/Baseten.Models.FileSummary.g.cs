
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Information about a file in the cache.
    /// </summary>
    public sealed partial class FileSummary
    {
        /// <summary>
        /// Relative path of the file in the cache
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Path { get; set; }

        /// <summary>
        /// Size of the file in bytes
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size_bytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long SizeBytes { get; set; }

        /// <summary>
        /// Last modification time of the file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modified")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Modified { get; set; }

        /// <summary>
        /// Type of the file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FileType { get; set; }

        /// <summary>
        /// Permissions of the file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permissions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Permissions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FileSummary" /> class.
        /// </summary>
        /// <param name="path">
        /// Relative path of the file in the cache
        /// </param>
        /// <param name="sizeBytes">
        /// Size of the file in bytes
        /// </param>
        /// <param name="modified">
        /// Last modification time of the file
        /// </param>
        /// <param name="fileType">
        /// Type of the file
        /// </param>
        /// <param name="permissions">
        /// Permissions of the file
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FileSummary(
            string path,
            long sizeBytes,
            string modified,
            string fileType,
            string permissions)
        {
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.SizeBytes = sizeBytes;
            this.Modified = modified ?? throw new global::System.ArgumentNullException(nameof(modified));
            this.FileType = fileType ?? throw new global::System.ArgumentNullException(nameof(fileType));
            this.Permissions = permissions ?? throw new global::System.ArgumentNullException(nameof(permissions));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileSummary" /> class.
        /// </summary>
        public FileSummary()
        {
        }
    }
}