
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Proxy configuration for routing sandbox HTTP traffic through the platform proxy with MITM inspection and per-destination header/body injection<br/>
    /// Example: {"allowed_domains":["api.openai.com","pypi.org","files.pythonhosted.org","registry.npmjs.org"],"bypass":["registry.npmjs.org"],"forbidden_domains":["facebook.com","*.facebook.com"],"routing":[{"destinations":["api.openai.com"],"headers":{"Authorization":"Bearer {{SECRET:openai-key}}"},"body":{"user":"baseten-api-review-0916"},"secrets":{"openai-key":"sk-proj-demo-not-a-valid-api-key"}}]}
    /// </summary>
    public sealed partial class SandboxProxyConfigV1
    {
        /// <summary>
        /// List of allowed external domains (allowlist). When set, only these domains are reachable. Supports wildcards (e.g. *.storage.example.com).<br/>
        /// Example: [api.openai.com, pypi.org, files.pythonhosted.org, registry.npmjs.org]
        /// </summary>
        /// <example>[api.openai.com, pypi.org, files.pythonhosted.org, registry.npmjs.org]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_domains")]
        public global::System.Collections.Generic.IList<string>? AllowedDomains { get; set; }

        /// <summary>
        /// Domains that bypass the proxy entirely via the NO_PROXY directive. Traffic to these destinations goes direct, not through the CONNECT tunnel. Supports wildcards. Note that localhost, private ranges (10.0.0.0/8, 172.16.0.0/12, 192.168.0.0/16), 169.254.169.254, .local and .internal are always bypassed by default.<br/>
        /// Example: [registry.npmjs.org]
        /// </summary>
        /// <example>[registry.npmjs.org]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("bypass")]
        public global::System.Collections.Generic.IList<string>? Bypass { get; set; }

        /// <summary>
        /// List of forbidden external domains (denylist). When set, all domains except these are reachable. Supports wildcards (e.g. *.malware.com). If both allowed_domains and forbidden_domains are set, allowed_domains takes precedence.<br/>
        /// Example: [facebook.com, *.facebook.com]
        /// </summary>
        /// <example>[facebook.com, *.facebook.com]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("forbidden_domains")]
        public global::System.Collections.Generic.IList<string>? ForbiddenDomains { get; set; }

        /// <summary>
        /// Per-destination routing rules with header/body injection and secrets. Use destinations ["*"] for global rules that apply to all destinations.<br/>
        /// Example: [{"destinations":["api.openai.com"],"headers":{"Authorization":"Bearer {{SECRET:openai-key}}"},"body":{"user":"baseten-api-review-0916"},"secrets":{"openai-key":"sk-proj-demo-not-a-valid-api-key"}}]
        /// </summary>
        /// <example>[{"destinations":["api.openai.com"],"headers":{"Authorization":"Bearer {{SECRET:openai-key}}"},"body":{"user":"baseten-api-review-0916"},"secrets":{"openai-key":"sk-proj-demo-not-a-valid-api-key"}}]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("routing")]
        public global::System.Collections.Generic.IList<global::Baseten.SandboxProxyTargetV1>? Routing { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxProxyConfigV1" /> class.
        /// </summary>
        /// <param name="allowedDomains">
        /// List of allowed external domains (allowlist). When set, only these domains are reachable. Supports wildcards (e.g. *.storage.example.com).<br/>
        /// Example: [api.openai.com, pypi.org, files.pythonhosted.org, registry.npmjs.org]
        /// </param>
        /// <param name="bypass">
        /// Domains that bypass the proxy entirely via the NO_PROXY directive. Traffic to these destinations goes direct, not through the CONNECT tunnel. Supports wildcards. Note that localhost, private ranges (10.0.0.0/8, 172.16.0.0/12, 192.168.0.0/16), 169.254.169.254, .local and .internal are always bypassed by default.<br/>
        /// Example: [registry.npmjs.org]
        /// </param>
        /// <param name="forbiddenDomains">
        /// List of forbidden external domains (denylist). When set, all domains except these are reachable. Supports wildcards (e.g. *.malware.com). If both allowed_domains and forbidden_domains are set, allowed_domains takes precedence.<br/>
        /// Example: [facebook.com, *.facebook.com]
        /// </param>
        /// <param name="routing">
        /// Per-destination routing rules with header/body injection and secrets. Use destinations ["*"] for global rules that apply to all destinations.<br/>
        /// Example: [{"destinations":["api.openai.com"],"headers":{"Authorization":"Bearer {{SECRET:openai-key}}"},"body":{"user":"baseten-api-review-0916"},"secrets":{"openai-key":"sk-proj-demo-not-a-valid-api-key"}}]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxProxyConfigV1(
            global::System.Collections.Generic.IList<string>? allowedDomains,
            global::System.Collections.Generic.IList<string>? bypass,
            global::System.Collections.Generic.IList<string>? forbiddenDomains,
            global::System.Collections.Generic.IList<global::Baseten.SandboxProxyTargetV1>? routing)
        {
            this.AllowedDomains = allowedDomains;
            this.Bypass = bypass;
            this.ForbiddenDomains = forbiddenDomains;
            this.Routing = routing;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxProxyConfigV1" /> class.
        /// </summary>
        public SandboxProxyConfigV1()
        {
        }

    }
}