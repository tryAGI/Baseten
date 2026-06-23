
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Add, update, or remove a file under the model code directory.
    /// </summary>
    public sealed partial class DeploymentPatchOpModelCodeV1
    {
        /// <summary>
        /// Default Value: model_code
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
        /// File path relative to the model code directory.
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
        /// Whether the running server can pick up this change without a restart.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hot_reload")]
        public bool? HotReload { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentPatchOpModelCodeV1" /> class.
        /// </summary>
        /// <param name="action">
        /// How this op changes the file.
        /// </param>
        /// <param name="path">
        /// File path relative to the model code directory.
        /// </param>
        /// <param name="type">
        /// Default Value: model_code
        /// </param>
        /// <param name="content">
        /// UTF-8 file content. Null for removals and binary files.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="contentBytes">
        /// Base64-encoded content for binary files.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="hotReload">
        /// Whether the running server can pick up this change without a restart.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeploymentPatchOpModelCodeV1(
            global::Baseten.DeploymentPatchActionV1 action,
            string path,
            string? type,
            string? content,
            string? contentBytes,
            bool? hotReload)
        {
            this.Type = type;
            this.Action = action;
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.Content = content;
            this.ContentBytes = contentBytes;
            this.HotReload = hotReload;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentPatchOpModelCodeV1" /> class.
        /// </summary>
        public DeploymentPatchOpModelCodeV1()
        {
        }

    }
}