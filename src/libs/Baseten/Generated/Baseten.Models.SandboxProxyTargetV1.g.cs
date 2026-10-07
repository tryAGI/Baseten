
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Routing rule that injects headers and body fields into requests matching the given destinations. Use destinations ["*"] for a global rule that applies to all proxied traffic.<br/>
    /// Example: {"destinations":["api.openai.com"],"headers":{"Authorization":"Bearer {{SECRET:openai-key}}"},"body":{"user":"baseten-api-review-0916"},"secrets":{"openai-key":"sk-proj-demo-not-a-valid-api-key"}}
    /// </summary>
    public sealed partial class SandboxProxyTargetV1
    {
        /// <summary>
        /// Body fields to inject into matching requests. Values may contain {{SECRET:name}} references resolved from this rule's secrets.<br/>
        /// Example: {"user":"baseten-api-review-0916"}
        /// </summary>
        /// <example>{"user":"baseten-api-review-0916"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("body")]
        public global::System.Collections.Generic.Dictionary<string, string>? Body { get; set; }

        /// <summary>
        /// Destination domains this rule applies to. Use ["*"] for a global rule that matches all destinations.<br/>
        /// Example: [api.openai.com]
        /// </summary>
        /// <example>[api.openai.com]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("destinations")]
        public global::System.Collections.Generic.IList<string>? Destinations { get; set; }

        /// <summary>
        /// Headers to inject into matching requests. Values may contain {{SECRET:name}} references resolved from this rule's secrets.<br/>
        /// Example: {"Authorization":"Bearer {{SECRET:openai-key}}"}
        /// </summary>
        /// <example>{"Authorization":"Bearer {{SECRET:openai-key}}"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        public global::System.Collections.Generic.Dictionary<string, string>? Headers { get; set; }

        /// <summary>
        /// Named secret values for this routing rule, referenced in headers/body via {{SECRET:name}}. Stored encrypted at rest. Write-only: never returned in API responses.<br/>
        /// Included only in requests<br/>
        /// Example: {"openai-key":"sk-proj-demo-not-a-valid-api-key"}
        /// </summary>
        /// <example>{"openai-key":"sk-proj-demo-not-a-valid-api-key"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("secrets")]
        public global::System.Collections.Generic.Dictionary<string, string>? Secrets { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxProxyTargetV1" /> class.
        /// </summary>
        /// <param name="body">
        /// Body fields to inject into matching requests. Values may contain {{SECRET:name}} references resolved from this rule's secrets.<br/>
        /// Example: {"user":"baseten-api-review-0916"}
        /// </param>
        /// <param name="destinations">
        /// Destination domains this rule applies to. Use ["*"] for a global rule that matches all destinations.<br/>
        /// Example: [api.openai.com]
        /// </param>
        /// <param name="headers">
        /// Headers to inject into matching requests. Values may contain {{SECRET:name}} references resolved from this rule's secrets.<br/>
        /// Example: {"Authorization":"Bearer {{SECRET:openai-key}}"}
        /// </param>
        /// <param name="secrets">
        /// Named secret values for this routing rule, referenced in headers/body via {{SECRET:name}}. Stored encrypted at rest. Write-only: never returned in API responses.<br/>
        /// Included only in requests<br/>
        /// Example: {"openai-key":"sk-proj-demo-not-a-valid-api-key"}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxProxyTargetV1(
            global::System.Collections.Generic.Dictionary<string, string>? body,
            global::System.Collections.Generic.IList<string>? destinations,
            global::System.Collections.Generic.Dictionary<string, string>? headers,
            global::System.Collections.Generic.Dictionary<string, string>? secrets)
        {
            this.Body = body;
            this.Destinations = destinations;
            this.Headers = headers;
            this.Secrets = secrets;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxProxyTargetV1" /> class.
        /// </summary>
        public SandboxProxyTargetV1()
        {
        }

    }
}