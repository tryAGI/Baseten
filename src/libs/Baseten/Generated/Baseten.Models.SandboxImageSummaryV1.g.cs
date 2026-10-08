
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Sandbox image repository summary. Fetch tags through GET /sandboxes/images/{image_name}/tags.<br/>
    /// Example: {"name":"base-image","status":"BUILT","created_at":"2026-09-15T21:20:00Z","updated_at":"2026-09-16T21:25:00Z","last_deployed_at":"2026-09-16T21:26:58.545765901Z","size":260046848,"tag_count":2}
    /// </summary>
    public sealed partial class SandboxImageSummaryV1
    {
        /// <summary>
        /// Stable repository name supplied when pushing the image.<br/>
        /// Example: base-image
        /// </summary>
        /// <example>base-image</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Image processing status. Only BUILT images are ready to use.<br/>
        /// Example: BUILT
        /// </summary>
        /// <example>BUILT</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Baseten.JsonConverters.SandboxImageStatusV1JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.SandboxImageStatusV1 Status { get; set; }

        /// <summary>
        /// Time the image was created.<br/>
        /// Included only in responses<br/>
        /// Example: 2026-09-15T21:20:00Z
        /// </summary>
        /// <example>2026-09-15T21:20:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Time the image was last updated.<br/>
        /// Included only in responses<br/>
        /// Example: 2026-09-16T21:25:00Z
        /// </summary>
        /// <example>2026-09-16T21:25:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Most recent deployment time across all tags, if deployed.<br/>
        /// Included only in responses<br/>
        /// Example: 2026-09-16T21:26:58.545765901Z
        /// </summary>
        /// <example>2026-09-16T21:26:58.545765901Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_deployed_at")]
        public global::System.DateTime? LastDeployedAt { get; set; }

        /// <summary>
        /// Total repository size in bytes.<br/>
        /// Included only in responses<br/>
        /// Example: 260046848
        /// </summary>
        /// <example>260046848</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        public long? Size { get; set; }

        /// <summary>
        /// Number of image versions in the repository.<br/>
        /// Included only in responses<br/>
        /// Example: 2
        /// </summary>
        /// <example>2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tag_count")]
        public long? TagCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxImageSummaryV1" /> class.
        /// </summary>
        /// <param name="name">
        /// Stable repository name supplied when pushing the image.<br/>
        /// Example: base-image
        /// </param>
        /// <param name="status">
        /// Image processing status. Only BUILT images are ready to use.<br/>
        /// Example: BUILT
        /// </param>
        /// <param name="createdAt">
        /// Time the image was created.<br/>
        /// Included only in responses<br/>
        /// Example: 2026-09-15T21:20:00Z
        /// </param>
        /// <param name="updatedAt">
        /// Time the image was last updated.<br/>
        /// Included only in responses<br/>
        /// Example: 2026-09-16T21:25:00Z
        /// </param>
        /// <param name="lastDeployedAt">
        /// Most recent deployment time across all tags, if deployed.<br/>
        /// Included only in responses<br/>
        /// Example: 2026-09-16T21:26:58.545765901Z
        /// </param>
        /// <param name="size">
        /// Total repository size in bytes.<br/>
        /// Included only in responses<br/>
        /// Example: 260046848
        /// </param>
        /// <param name="tagCount">
        /// Number of image versions in the repository.<br/>
        /// Included only in responses<br/>
        /// Example: 2
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxImageSummaryV1(
            string name,
            global::Baseten.SandboxImageStatusV1 status,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt,
            global::System.DateTime? lastDeployedAt,
            long? size,
            long? tagCount)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Status = status;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.LastDeployedAt = lastDeployedAt;
            this.Size = size;
            this.TagCount = tagCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxImageSummaryV1" /> class.
        /// </summary>
        public SandboxImageSummaryV1()
        {
        }

    }
}