
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SandboxPreviewV1Variant2
    {
        /// <summary>
        /// Preview name, used in preview_name path parameters.<br/>
        /// Included only in responses<br/>
        /// Example: web
        /// </summary>
        /// <default>default!</default>
        /// <example>web</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Exposed sandbox port.<br/>
        /// Included only in responses<br/>
        /// Example: 3000
        /// </summary>
        /// <default>default!</default>
        /// <example>3000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("port")]
        public int Port { get; set; } = default!;

        /// <summary>
        /// HTTPS URL serving the port, including the region label. Use this exact URL. Requests to a private preview need a token.<br/>
        /// Included only in responses<br/>
        /// Example: https://a1b2c3d4e5f6g7h8.us-pdx-1.preview.b10.co
        /// </summary>
        /// <default>default!</default>
        /// <example>https://a1b2c3d4e5f6g7h8.us-pdx-1.preview.b10.co</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Preview status, always uppercase.<br/>
        /// Included only in responses<br/>
        /// Example: DEPLOYED
        /// </summary>
        /// <default>default!</default>
        /// <example>DEPLOYED</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Baseten.JsonConverters.SandboxPreviewStatusV1JsonConverter))]
        public global::Baseten.SandboxPreviewStatusV1 Status { get; set; } = default!;

        /// <summary>
        /// Region serving the preview, the sandbox's region.<br/>
        /// Included only in responses<br/>
        /// Example: us-pdx-1
        /// </summary>
        /// <example>us-pdx-1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        public string? Region { get; set; }

        /// <summary>
        /// Included only in responses<br/>
        /// Example: 2026-10-12T12:00:00Z
        /// </summary>
        /// <example>2026-10-12T12:00:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Included only in responses<br/>
        /// Example: 2026-10-12T12:00:00Z
        /// </summary>
        /// <example>2026-10-12T12:00:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Included only in responses<br/>
        /// Example: sandbox-automation
        /// </summary>
        /// <example>sandbox-automation</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_by")]
        public string? CreatedBy { get; set; }

        /// <summary>
        /// Included only in responses<br/>
        /// Example: sandbox-automation
        /// </summary>
        /// <example>sandbox-automation</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_by")]
        public string? UpdatedBy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxPreviewV1Variant2" /> class.
        /// </summary>
        /// <param name="region">
        /// Region serving the preview, the sandbox's region.<br/>
        /// Included only in responses<br/>
        /// Example: us-pdx-1
        /// </param>
        /// <param name="createdAt">
        /// Included only in responses<br/>
        /// Example: 2026-10-12T12:00:00Z
        /// </param>
        /// <param name="updatedAt">
        /// Included only in responses<br/>
        /// Example: 2026-10-12T12:00:00Z
        /// </param>
        /// <param name="createdBy">
        /// Included only in responses<br/>
        /// Example: sandbox-automation
        /// </param>
        /// <param name="updatedBy">
        /// Included only in responses<br/>
        /// Example: sandbox-automation
        /// </param>
        /// <param name="name">
        /// Preview name, used in preview_name path parameters.<br/>
        /// Included only in responses<br/>
        /// Example: web
        /// </param>
        /// <param name="port">
        /// Exposed sandbox port.<br/>
        /// Included only in responses<br/>
        /// Example: 3000
        /// </param>
        /// <param name="url">
        /// HTTPS URL serving the port, including the region label. Use this exact URL. Requests to a private preview need a token.<br/>
        /// Included only in responses<br/>
        /// Example: https://a1b2c3d4e5f6g7h8.us-pdx-1.preview.b10.co
        /// </param>
        /// <param name="status">
        /// Preview status, always uppercase.<br/>
        /// Included only in responses<br/>
        /// Example: DEPLOYED
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxPreviewV1Variant2(
            string? region,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt,
            string? createdBy,
            string? updatedBy,
            string name = default!,
            int port = default!,
            string url = default!,
            global::Baseten.SandboxPreviewStatusV1 status = default!)
        {
            this.Name = name;
            this.Port = port;
            this.Url = url;
            this.Status = status;
            this.Region = region;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.CreatedBy = createdBy;
            this.UpdatedBy = updatedBy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxPreviewV1Variant2" /> class.
        /// </summary>
        public SandboxPreviewV1Variant2()
        {
        }

    }
}