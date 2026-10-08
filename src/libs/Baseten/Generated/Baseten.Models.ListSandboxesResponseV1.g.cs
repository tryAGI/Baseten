
#nullable enable

namespace Baseten
{
    /// <summary>
    /// One page of sandboxes.<br/>
    /// Example: {"items":[{"lifecycle":{"expiration_policies":[{"action":"DELETE","type":"TTL_IDLE","value":"24h"},{"action":"DELETE","type":"TTL_MAX_AGE","value":"7d"},{"action":"DELETE","type":"DATE","value":"2026-09-23T21:26:58Z"}],"terminated_retention":"24h"},"network":{"proxy":{"allowed_domains":["api.openai.com","pypi.org","files.pythonhosted.org","registry.npmjs.org"],"bypass":["registry.npmjs.org"],"forbidden_domains":["facebook.com","*.facebook.com"],"routing":[{"destinations":["api.openai.com"],"headers":{"Authorization":"Bearer {{SECRET:openai-key}}"},"body":{"user":"baseten-api-review-0916"}}]},"subnet":"default"},"region":"us-pdx-1","envs":[{"name":"NODE_ENV","secret":false,"value":"production"},{"name":"PORT","secret":false,"value":"3000"}],"image":"baseten/base-image:latest","memory":4096,"ports":[{"name":"http","protocol":"HTTP","target":3000}],"external_id":"api-review-20260916-001","labels":{"env":"development","project":"api-review","team":"engineering"},"name":"baseten-api-review-0916","url":"https://sbx-baseten-api-review-0916-esb1qo.us-pdx-1.b10.run","status":"DEPLOYED","created_at":"2026-09-16T21:26:58.545765901Z","updated_at":"2026-09-16T21:31:13Z","created_by":"sandbox-automation","updated_by":"sandbox-automation","last_used_at":"2026-09-16T21:31:13Z","expires_in":86400}],"pagination":{"has_more":true,"cursor":"eyJ2IjoxLCJsYXN0X2tleSI6ImJhc2V0ZW4tYXBpLXJldmlldy0wOTE2Iiwic29ydCI6ImRlc2MifQ"}}
    /// </summary>
    public sealed partial class ListSandboxesResponseV1
    {
        /// <summary>
        /// Resources on this page.<br/>
        /// Example: [{"lifecycle":{"expiration_policies":[{"action":"DELETE","type":"TTL_IDLE","value":"24h"},{"action":"DELETE","type":"TTL_MAX_AGE","value":"7d"},{"action":"DELETE","type":"DATE","value":"2026-09-23T21:26:58Z"}],"terminated_retention":"24h"},"network":{"proxy":{"allowed_domains":["api.openai.com","pypi.org","files.pythonhosted.org","registry.npmjs.org"],"bypass":["registry.npmjs.org"],"forbidden_domains":["facebook.com","*.facebook.com"],"routing":[{"destinations":["api.openai.com"],"headers":{"Authorization":"Bearer {{SECRET:openai-key}}"},"body":{"user":"baseten-api-review-0916"}}]},"subnet":"default"},"region":"us-pdx-1","envs":[{"name":"NODE_ENV","secret":false,"value":"production"},{"name":"PORT","secret":false,"value":"3000"}],"image":"baseten/base-image:latest","memory":4096,"ports":[{"name":"http","protocol":"HTTP","target":3000}],"external_id":"api-review-20260916-001","labels":{"env":"development","project":"api-review","team":"engineering"},"name":"baseten-api-review-0916","url":"https://sbx-baseten-api-review-0916-esb1qo.us-pdx-1.b10.run","status":"DEPLOYED","created_at":"2026-09-16T21:26:58.545765901Z","updated_at":"2026-09-16T21:31:13Z","created_by":"sandbox-automation","updated_by":"sandbox-automation","last_used_at":"2026-09-16T21:31:13Z","expires_in":86400}]
        /// </summary>
        /// <example>[{"lifecycle":{"expiration_policies":[{"action":"DELETE","type":"TTL_IDLE","value":"24h"},{"action":"DELETE","type":"TTL_MAX_AGE","value":"7d"},{"action":"DELETE","type":"DATE","value":"2026-09-23T21:26:58Z"}],"terminated_retention":"24h"},"network":{"proxy":{"allowed_domains":["api.openai.com","pypi.org","files.pythonhosted.org","registry.npmjs.org"],"bypass":["registry.npmjs.org"],"forbidden_domains":["facebook.com","*.facebook.com"],"routing":[{"destinations":["api.openai.com"],"headers":{"Authorization":"Bearer {{SECRET:openai-key}}"},"body":{"user":"baseten-api-review-0916"}}]},"subnet":"default"},"region":"us-pdx-1","envs":[{"name":"NODE_ENV","secret":false,"value":"production"},{"name":"PORT","secret":false,"value":"3000"}],"image":"baseten/base-image:latest","memory":4096,"ports":[{"name":"http","protocol":"HTTP","target":3000}],"external_id":"api-review-20260916-001","labels":{"env":"development","project":"api-review","team":"engineering"},"name":"baseten-api-review-0916","url":"https://sbx-baseten-api-review-0916-esb1qo.us-pdx-1.b10.run","status":"DEPLOYED","created_at":"2026-09-16T21:26:58.545765901Z","updated_at":"2026-09-16T21:31:13Z","created_by":"sandbox-automation","updated_by":"sandbox-automation","last_used_at":"2026-09-16T21:31:13Z","expires_in":86400}]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Baseten.SandboxV1> Items { get; set; }

        /// <summary>
        /// Cursor pagination information. The cursor is present only when another page is available.<br/>
        /// Example: {"has_more":true,"cursor":"eyJ2IjoxLCJsYXN0X2tleSI6ImJhc2V0ZW4tYXBpLXJldmlldy0wOTE2Iiwic29ydCI6ImRlc2MifQ"}
        /// </summary>
        /// <example>{"has_more":true,"cursor":"eyJ2IjoxLCJsYXN0X2tleSI6ImJhc2V0ZW4tYXBpLXJldmlldy0wOTE2Iiwic29ydCI6ImRlc2MifQ"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("pagination")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.SandboxApiPaginationV1 Pagination { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListSandboxesResponseV1" /> class.
        /// </summary>
        /// <param name="items">
        /// Resources on this page.<br/>
        /// Example: [{"lifecycle":{"expiration_policies":[{"action":"DELETE","type":"TTL_IDLE","value":"24h"},{"action":"DELETE","type":"TTL_MAX_AGE","value":"7d"},{"action":"DELETE","type":"DATE","value":"2026-09-23T21:26:58Z"}],"terminated_retention":"24h"},"network":{"proxy":{"allowed_domains":["api.openai.com","pypi.org","files.pythonhosted.org","registry.npmjs.org"],"bypass":["registry.npmjs.org"],"forbidden_domains":["facebook.com","*.facebook.com"],"routing":[{"destinations":["api.openai.com"],"headers":{"Authorization":"Bearer {{SECRET:openai-key}}"},"body":{"user":"baseten-api-review-0916"}}]},"subnet":"default"},"region":"us-pdx-1","envs":[{"name":"NODE_ENV","secret":false,"value":"production"},{"name":"PORT","secret":false,"value":"3000"}],"image":"baseten/base-image:latest","memory":4096,"ports":[{"name":"http","protocol":"HTTP","target":3000}],"external_id":"api-review-20260916-001","labels":{"env":"development","project":"api-review","team":"engineering"},"name":"baseten-api-review-0916","url":"https://sbx-baseten-api-review-0916-esb1qo.us-pdx-1.b10.run","status":"DEPLOYED","created_at":"2026-09-16T21:26:58.545765901Z","updated_at":"2026-09-16T21:31:13Z","created_by":"sandbox-automation","updated_by":"sandbox-automation","last_used_at":"2026-09-16T21:31:13Z","expires_in":86400}]
        /// </param>
        /// <param name="pagination">
        /// Cursor pagination information. The cursor is present only when another page is available.<br/>
        /// Example: {"has_more":true,"cursor":"eyJ2IjoxLCJsYXN0X2tleSI6ImJhc2V0ZW4tYXBpLXJldmlldy0wOTE2Iiwic29ydCI6ImRlc2MifQ"}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListSandboxesResponseV1(
            global::System.Collections.Generic.IList<global::Baseten.SandboxV1> items,
            global::Baseten.SandboxApiPaginationV1 pagination)
        {
            this.Items = items ?? throw new global::System.ArgumentNullException(nameof(items));
            this.Pagination = pagination ?? throw new global::System.ArgumentNullException(nameof(pagination));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListSandboxesResponseV1" /> class.
        /// </summary>
        public ListSandboxesResponseV1()
        {
        }

    }
}