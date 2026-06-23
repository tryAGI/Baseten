
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Add, update, or remove a file under the bundled packages directory.
    /// </summary>
    public sealed partial class DeploymentPatchOpPackageV1
    {
        /// <summary>
        /// Default Value: package
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// How this op changes the file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Baseten.JsonConverters.DeploymentPatchActionV1JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.DeploymentPatchActionV1 Action { get; set; }

        /// <summary>
        /// File path relative to the bundled packages directory.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Path { get; set; }

        /// <summary>
        /// UTF-8 file content. Null for removals and binary files.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        /// Base64-encoded content for binary files.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_bytes")]
        public string? ContentBytes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentPatchOpPackageV1" /> class.
        /// </summary>
        /// <param name="action">
        /// How this op changes the file.
        /// </param>
        /// <param name="path">
        /// File path relative to the bundled packages directory.
        /// </param>
        /// <param name="type">
        /// Default Value: package
        /// </param>
        /// <param name="content">
        /// UTF-8 file content. Null for removals and binary files.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="contentBytes">
        /// Base64-encoded content for binary files.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeploymentPatchOpPackageV1(
            global::Baseten.DeploymentPatchActionV1 action,
            string path,
            string? type,
            string? content,
            string? contentBytes)
        {
            this.Type = type;
            this.Action = action;
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.Content = content;
            this.ContentBytes = contentBytes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentPatchOpPackageV1" /> class.
        /// </summary>
        public DeploymentPatchOpPackageV1()
        {
        }

    }
}