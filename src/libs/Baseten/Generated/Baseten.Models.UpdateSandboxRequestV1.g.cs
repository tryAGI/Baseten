
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Partial sandbox update. Omitted fields remain unchanged. Supplied arrays and maps (including labels) replace their previous values; supplied structured objects update only their supplied fields. Null is not accepted. The name, memory, network, region, image, and ports are immutable after creation. Supplying any of these fields returns 400, including unchanged, empty, or null values.<br/>
    /// Example: {"lifecycle":{"expiration_policies":[{"action":"DELETE","type":"TTL_IDLE","value":"24h"},{"action":"DELETE","type":"TTL_MAX_AGE","value":"7d"},{"action":"DELETE","type":"DATE","value":"2026-09-23T21:26:58Z"}],"terminated_retention":"24h"},"envs":[{"name":"NODE_ENV","secret":false,"value":"production"},{"name":"PORT","secret":false,"value":"3000"}],"external_id":"api-review-20260916-001","labels":{"env":"development","project":"api-review","team":"engineering","revision":"2"}}
    /// </summary>
    public sealed partial class UpdateSandboxRequestV1
    {
        /// <summary>
        /// Lifecycle configuration controlling automatic sandbox deletion based on idle time, max age, or specific dates<br/>
        /// Example: {"expiration_policies":[{"action":"DELETE","type":"TTL_IDLE","value":"24h"},{"action":"DELETE","type":"TTL_MAX_AGE","value":"7d"},{"action":"DELETE","type":"DATE","value":"2026-09-23T21:26:58Z"}],"terminated_retention":"24h"}
        /// </summary>
        /// <example>{"expiration_policies":[{"action":"DELETE","type":"TTL_IDLE","value":"24h"},{"action":"DELETE","type":"TTL_MAX_AGE","value":"7d"},{"action":"DELETE","type":"DATE","value":"2026-09-23T21:26:58Z"}],"terminated_retention":"24h"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("lifecycle")]
        public global::Baseten.SandboxLifecycleV1? Lifecycle { get; set; }

        /// <summary>
        /// Environment variables injected into the sandbox.<br/>
        /// Example: [{"name":"NODE_ENV","secret":false,"value":"production"}, {"name":"PORT","secret":false,"value":"3000"}]
        /// </summary>
        /// <example>[{"name":"NODE_ENV","secret":false,"value":"production"}, {"name":"PORT","secret":false,"value":"3000"}]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("envs")]
        public global::System.Collections.Generic.IList<global::Baseten.SandboxEnvV1>? Envs { get; set; }

        /// <summary>
        /// Caller-owned identifier for external lookups. Max 64 chars, alphanumeric + dash.<br/>
        /// Example: api-review-20260916-001
        /// </summary>
        /// <example>api-review-20260916-001</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_id")]
        public string? ExternalId { get; set; }

        /// <summary>
        /// Key-value pairs for organizing and filtering resources. Labels can be used to categorize resources by environment, project, team, or any custom taxonomy.<br/>
        /// Example: {"env":"development","project":"api-review","team":"engineering","revision":"2"}
        /// </summary>
        /// <example>{"env":"development","project":"api-review","team":"engineering","revision":"2"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("labels")]
        public global::System.Collections.Generic.Dictionary<string, string>? Labels { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSandboxRequestV1" /> class.
        /// </summary>
        /// <param name="lifecycle">
        /// Lifecycle configuration controlling automatic sandbox deletion based on idle time, max age, or specific dates<br/>
        /// Example: {"expiration_policies":[{"action":"DELETE","type":"TTL_IDLE","value":"24h"},{"action":"DELETE","type":"TTL_MAX_AGE","value":"7d"},{"action":"DELETE","type":"DATE","value":"2026-09-23T21:26:58Z"}],"terminated_retention":"24h"}
        /// </param>
        /// <param name="envs">
        /// Environment variables injected into the sandbox.<br/>
        /// Example: [{"name":"NODE_ENV","secret":false,"value":"production"}, {"name":"PORT","secret":false,"value":"3000"}]
        /// </param>
        /// <param name="externalId">
        /// Caller-owned identifier for external lookups. Max 64 chars, alphanumeric + dash.<br/>
        /// Example: api-review-20260916-001
        /// </param>
        /// <param name="labels">
        /// Key-value pairs for organizing and filtering resources. Labels can be used to categorize resources by environment, project, team, or any custom taxonomy.<br/>
        /// Example: {"env":"development","project":"api-review","team":"engineering","revision":"2"}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateSandboxRequestV1(
            global::Baseten.SandboxLifecycleV1? lifecycle,
            global::System.Collections.Generic.IList<global::Baseten.SandboxEnvV1>? envs,
            string? externalId,
            global::System.Collections.Generic.Dictionary<string, string>? labels)
        {
            this.Lifecycle = lifecycle;
            this.Envs = envs;
            this.ExternalId = externalId;
            this.Labels = labels;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSandboxRequestV1" /> class.
        /// </summary>
        public UpdateSandboxRequestV1()
        {
        }

    }
}