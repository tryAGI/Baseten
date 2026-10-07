
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Partial sandbox update. Omitted fields remain unchanged. Supplied arrays and maps (including labels) replace their previous values; supplied structured objects update only their supplied fields. Null is not accepted. The name, memory, and network configuration are immutable after creation. Supplying memory or network returns 400, including unchanged, empty, or null values.<br/>
    /// Example: {"enabled":true,"lifecycle":{"expiration_policies":[{"action":"DELETE","type":"TTL_IDLE","value":"24h"},{"action":"DELETE","type":"TTL_MAX_AGE","value":"7d"},{"action":"DELETE","type":"DATE","value":"2026-09-23T21:26:58Z"}],"terminated_retention":"24h"},"region":"us-pdx-1","envs":[{"name":"NODE_ENV","secret":false,"value":"production"},{"name":"PORT","secret":false,"value":"3000"}],"image":"blaxel/base-image:latest","ports":[{"name":"http","protocol":"HTTP","target":3000}],"display_name":"Baseten API review - revised","external_id":"api-review-20260916-001","labels":{"env":"development","project":"api-review","team":"engineering","revision":"2"}}
    /// </summary>
    public sealed partial class UpdateSandboxRequestV1
    {
        /// <summary>
        /// When false, the sandbox is disabled and will not accept connections<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Lifecycle configuration controlling automatic sandbox deletion based on idle time, max age, or specific dates<br/>
        /// Example: {"expiration_policies":[{"action":"DELETE","type":"TTL_IDLE","value":"24h"},{"action":"DELETE","type":"TTL_MAX_AGE","value":"7d"},{"action":"DELETE","type":"DATE","value":"2026-09-23T21:26:58Z"}],"terminated_retention":"24h"}
        /// </summary>
        /// <example>{"expiration_policies":[{"action":"DELETE","type":"TTL_IDLE","value":"24h"},{"action":"DELETE","type":"TTL_MAX_AGE","value":"7d"},{"action":"DELETE","type":"DATE","value":"2026-09-23T21:26:58Z"}],"terminated_retention":"24h"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("lifecycle")]
        public global::Baseten.SandboxLifecycleV1? Lifecycle { get; set; }

        /// <summary>
        /// Region where the sandbox runs (for example us-pdx-1 or eu-lon-1). When omitted at creation, the closest region is selected.<br/>
        /// Example: us-pdx-1
        /// </summary>
        /// <example>us-pdx-1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        public string? Region { get; set; }

        /// <summary>
        /// Environment variables injected into the sandbox.<br/>
        /// Example: [{"name":"NODE_ENV","secret":false,"value":"production"}, {"name":"PORT","secret":false,"value":"3000"}]
        /// </summary>
        /// <example>[{"name":"NODE_ENV","secret":false,"value":"production"}, {"name":"PORT","secret":false,"value":"3000"}]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("envs")]
        public global::System.Collections.Generic.IList<global::Baseten.SandboxEnvV1>? Envs { get; set; }

        /// <summary>
        /// Image reference including its tag. Use blaxel/base-image:latest to get started with the built-in sandbox execution API. This image is available directly without building, pushing, or listing images through GET /v1/sandboxes/images.<br/>
        /// Example: blaxel/base-image:latest
        /// </summary>
        /// <example>blaxel/base-image:latest</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        public string? Image { get; set; }

        /// <summary>
        /// Set of ports for a resource<br/>
        /// Example: [{"name":"http","protocol":"HTTP","target":3000}]
        /// </summary>
        /// <example>[{"name":"http","protocol":"HTTP","target":3000}]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("ports")]
        public global::System.Collections.Generic.IList<global::Baseten.SandboxPortV1>? Ports { get; set; }

        /// <summary>
        /// Human-readable name for display in the UI. Can contain spaces and special characters, max 63 characters.<br/>
        /// Example: Baseten API review - revised
        /// </summary>
        /// <example>Baseten API review - revised</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        public string? DisplayName { get; set; }

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
        /// <param name="enabled">
        /// When false, the sandbox is disabled and will not accept connections<br/>
        /// Example: true
        /// </param>
        /// <param name="lifecycle">
        /// Lifecycle configuration controlling automatic sandbox deletion based on idle time, max age, or specific dates<br/>
        /// Example: {"expiration_policies":[{"action":"DELETE","type":"TTL_IDLE","value":"24h"},{"action":"DELETE","type":"TTL_MAX_AGE","value":"7d"},{"action":"DELETE","type":"DATE","value":"2026-09-23T21:26:58Z"}],"terminated_retention":"24h"}
        /// </param>
        /// <param name="region">
        /// Region where the sandbox runs (for example us-pdx-1 or eu-lon-1). When omitted at creation, the closest region is selected.<br/>
        /// Example: us-pdx-1
        /// </param>
        /// <param name="envs">
        /// Environment variables injected into the sandbox.<br/>
        /// Example: [{"name":"NODE_ENV","secret":false,"value":"production"}, {"name":"PORT","secret":false,"value":"3000"}]
        /// </param>
        /// <param name="image">
        /// Image reference including its tag. Use blaxel/base-image:latest to get started with the built-in sandbox execution API. This image is available directly without building, pushing, or listing images through GET /v1/sandboxes/images.<br/>
        /// Example: blaxel/base-image:latest
        /// </param>
        /// <param name="ports">
        /// Set of ports for a resource<br/>
        /// Example: [{"name":"http","protocol":"HTTP","target":3000}]
        /// </param>
        /// <param name="displayName">
        /// Human-readable name for display in the UI. Can contain spaces and special characters, max 63 characters.<br/>
        /// Example: Baseten API review - revised
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
            bool? enabled,
            global::Baseten.SandboxLifecycleV1? lifecycle,
            string? region,
            global::System.Collections.Generic.IList<global::Baseten.SandboxEnvV1>? envs,
            string? image,
            global::System.Collections.Generic.IList<global::Baseten.SandboxPortV1>? ports,
            string? displayName,
            string? externalId,
            global::System.Collections.Generic.Dictionary<string, string>? labels)
        {
            this.Enabled = enabled;
            this.Lifecycle = lifecycle;
            this.Region = region;
            this.Envs = envs;
            this.Image = image;
            this.Ports = ports;
            this.DisplayName = displayName;
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