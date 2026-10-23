
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateSandboxPreviewRequestV1Variant2
    {
        /// <summary>
        /// Lifetime counted from the request, using seconds, minutes, hours or composite durations such as 1h30m. Whole days are also supported, for example 7d; days cannot be combined with other units. The preview is deleted when it elapses.<br/>
        /// Example: 24h
        /// </summary>
        /// <example>24h</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("ttl")]
        public string? Ttl { get; set; }

        /// <summary>
        /// When true, return the existing preview with this name instead of failing with a conflict. Without name, the name is public-&lt;port&gt; or private-&lt;port&gt;, so the same port and visibility return the same preview. Existing configuration is preserved. Defaults to false when omitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("create_if_not_exists")]
        public bool? CreateIfNotExists { get; set; }

        /// <summary>
        /// Preview name, unique within the sandbox. When omitted, generated from the sandbox name and port, or public-&lt;port&gt; or private-&lt;port&gt; when create_if_not_exists is true.<br/>
        /// Example: web
        /// </summary>
        /// <example>web</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Sandbox port to expose.<br/>
        /// Example: 3000
        /// </summary>
        /// <example>3000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("port")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Port { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSandboxPreviewRequestV1Variant2" /> class.
        /// </summary>
        /// <param name="port">
        /// Sandbox port to expose.<br/>
        /// Example: 3000
        /// </param>
        /// <param name="ttl">
        /// Lifetime counted from the request, using seconds, minutes, hours or composite durations such as 1h30m. Whole days are also supported, for example 7d; days cannot be combined with other units. The preview is deleted when it elapses.<br/>
        /// Example: 24h
        /// </param>
        /// <param name="createIfNotExists">
        /// When true, return the existing preview with this name instead of failing with a conflict. Without name, the name is public-&lt;port&gt; or private-&lt;port&gt;, so the same port and visibility return the same preview. Existing configuration is preserved. Defaults to false when omitted.
        /// </param>
        /// <param name="name">
        /// Preview name, unique within the sandbox. When omitted, generated from the sandbox name and port, or public-&lt;port&gt; or private-&lt;port&gt; when create_if_not_exists is true.<br/>
        /// Example: web
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateSandboxPreviewRequestV1Variant2(
            int port,
            string? ttl,
            bool? createIfNotExists,
            string? name)
        {
            this.Ttl = ttl;
            this.CreateIfNotExists = createIfNotExists;
            this.Name = name;
            this.Port = port;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSandboxPreviewRequestV1Variant2" /> class.
        /// </summary>
        public CreateSandboxPreviewRequestV1Variant2()
        {
        }

    }
}