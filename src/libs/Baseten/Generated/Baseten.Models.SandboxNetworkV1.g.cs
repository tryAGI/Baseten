
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Network configuration for a sandbox including subnet, domain filtering, and proxy settings<br/>
    /// Example: {"proxy":{"allowed_domains":["api.openai.com","pypi.org","files.pythonhosted.org","registry.npmjs.org"],"bypass":["registry.npmjs.org"],"forbidden_domains":["facebook.com","*.facebook.com"],"routing":[{"destinations":["api.openai.com"],"headers":{"Authorization":"Bearer {{SECRET:openai-key}}"},"body":{"user":"baseten-api-review-0916"},"secrets":{"openai-key":"sk-proj-demo-not-a-valid-api-key"}}]},"subnet":"default"}
    /// </summary>
    public sealed partial class SandboxNetworkV1
    {
        /// <summary>
        /// Proxy configuration for routing sandbox HTTP traffic through the platform proxy with MITM inspection and per-destination header/body injection<br/>
        /// Example: {"allowed_domains":["api.openai.com","pypi.org","files.pythonhosted.org","registry.npmjs.org"],"bypass":["registry.npmjs.org"],"forbidden_domains":["facebook.com","*.facebook.com"],"routing":[{"destinations":["api.openai.com"],"headers":{"Authorization":"Bearer {{SECRET:openai-key}}"},"body":{"user":"baseten-api-review-0916"},"secrets":{"openai-key":"sk-proj-demo-not-a-valid-api-key"}}]}
        /// </summary>
        /// <example>{"allowed_domains":["api.openai.com","pypi.org","files.pythonhosted.org","registry.npmjs.org"],"bypass":["registry.npmjs.org"],"forbidden_domains":["facebook.com","*.facebook.com"],"routing":[{"destinations":["api.openai.com"],"headers":{"Authorization":"Bearer {{SECRET:openai-key}}"},"body":{"user":"baseten-api-review-0916"},"secrets":{"openai-key":"sk-proj-demo-not-a-valid-api-key"}}]}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("proxy")]
        public global::Baseten.SandboxProxyConfigV1? Proxy { get; set; }

        /// <summary>
        /// Subnet name for the sandbox. Defaults to "default" at creation.<br/>
        /// Example: default
        /// </summary>
        /// <example>default</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("subnet")]
        public string? Subnet { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxNetworkV1" /> class.
        /// </summary>
        /// <param name="proxy">
        /// Proxy configuration for routing sandbox HTTP traffic through the platform proxy with MITM inspection and per-destination header/body injection<br/>
        /// Example: {"allowed_domains":["api.openai.com","pypi.org","files.pythonhosted.org","registry.npmjs.org"],"bypass":["registry.npmjs.org"],"forbidden_domains":["facebook.com","*.facebook.com"],"routing":[{"destinations":["api.openai.com"],"headers":{"Authorization":"Bearer {{SECRET:openai-key}}"},"body":{"user":"baseten-api-review-0916"},"secrets":{"openai-key":"sk-proj-demo-not-a-valid-api-key"}}]}
        /// </param>
        /// <param name="subnet">
        /// Subnet name for the sandbox. Defaults to "default" at creation.<br/>
        /// Example: default
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxNetworkV1(
            global::Baseten.SandboxProxyConfigV1? proxy,
            string? subnet)
        {
            this.Proxy = proxy;
            this.Subnet = subnet;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxNetworkV1" /> class.
        /// </summary>
        public SandboxNetworkV1()
        {
        }

    }
}