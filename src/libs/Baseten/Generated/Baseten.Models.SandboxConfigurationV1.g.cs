
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Writable sandbox configuration. Fields are serialized at the root of the request or resource.<br/>
    /// Example: {"lifecycle":{"expiration_policies":[{"action":"DELETE","type":"TTL_IDLE","value":"24h"},{"action":"DELETE","type":"TTL_MAX_AGE","value":"7d"},{"action":"DELETE","type":"DATE","value":"2026-09-23T21:26:58Z"}],"terminated_retention":"24h"},"network":{"proxy":{"allowed_domains":["api.openai.com","pypi.org","files.pythonhosted.org","registry.npmjs.org"],"bypass":["registry.npmjs.org"],"forbidden_domains":["facebook.com","*.facebook.com"],"routing":[{"destinations":["api.openai.com"],"headers":{"Authorization":"Bearer {{SECRET:openai-key}}"},"body":{"user":"baseten-api-review-0916"},"secrets":{"openai-key":"sk-proj-demo-not-a-valid-api-key"}}]},"subnet":"default"},"region":"us-pdx-1","envs":[{"name":"NODE_ENV","secret":false,"value":"production"},{"name":"PORT","secret":false,"value":"3000"}],"image":"baseten/base-image:latest","memory":4096,"ports":[{"name":"http","protocol":"HTTP","target":3000}],"external_id":"api-review-20260916-001","labels":{"env":"development","project":"api-review","team":"engineering"}}
    /// </summary>
    public sealed partial class SandboxConfigurationV1
    {
        /// <summary>
        /// Lifecycle configuration controlling automatic sandbox deletion based on idle time, max age, or specific dates<br/>
        /// Example: {"expiration_policies":[{"action":"DELETE","type":"TTL_IDLE","value":"24h"},{"action":"DELETE","type":"TTL_MAX_AGE","value":"7d"},{"action":"DELETE","type":"DATE","value":"2026-09-23T21:26:58Z"}],"terminated_retention":"24h"}
        /// </summary>
        /// <example>{"expiration_policies":[{"action":"DELETE","type":"TTL_IDLE","value":"24h"},{"action":"DELETE","type":"TTL_MAX_AGE","value":"7d"},{"action":"DELETE","type":"DATE","value":"2026-09-23T21:26:58Z"}],"terminated_retention":"24h"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("lifecycle")]
        public global::Baseten.SandboxLifecycleV1? Lifecycle { get; set; }

        /// <summary>
        /// Network configuration for a sandbox including subnet, domain filtering, and proxy settings<br/>
        /// Example: {"proxy":{"allowed_domains":["api.openai.com","pypi.org","files.pythonhosted.org","registry.npmjs.org"],"bypass":["registry.npmjs.org"],"forbidden_domains":["facebook.com","*.facebook.com"],"routing":[{"destinations":["api.openai.com"],"headers":{"Authorization":"Bearer {{SECRET:openai-key}}"},"body":{"user":"baseten-api-review-0916"},"secrets":{"openai-key":"sk-proj-demo-not-a-valid-api-key"}}]},"subnet":"default"}
        /// </summary>
        /// <example>{"proxy":{"allowed_domains":["api.openai.com","pypi.org","files.pythonhosted.org","registry.npmjs.org"],"bypass":["registry.npmjs.org"],"forbidden_domains":["facebook.com","*.facebook.com"],"routing":[{"destinations":["api.openai.com"],"headers":{"Authorization":"Bearer {{SECRET:openai-key}}"},"body":{"user":"baseten-api-review-0916"},"secrets":{"openai-key":"sk-proj-demo-not-a-valid-api-key"}}]},"subnet":"default"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("network")]
        public global::Baseten.SandboxNetworkV1? Network { get; set; }

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
        /// Image reference including its tag. Built-in image references are returned in the canonical baseten/ namespace. Use baseten/base-image:latest to get started with the built-in sandbox execution API. This image is available directly without building, pushing, or listing images through GET /v1/sandboxes/images.<br/>
        /// Example: baseten/base-image:latest
        /// </summary>
        /// <example>baseten/base-image:latest</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        public string? Image { get; set; }

        /// <summary>
        /// Memory allocation in megabytes. Also determines CPU allocation (CPU cores = memory in MB / 2048, e.g., 4096MB = 2 CPUs).<br/>
        /// Example: 4096
        /// </summary>
        /// <example>4096</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("memory")]
        public long? Memory { get; set; }

        /// <summary>
        /// Set of ports for a resource<br/>
        /// Example: [{"name":"http","protocol":"HTTP","target":3000}]
        /// </summary>
        /// <example>[{"name":"http","protocol":"HTTP","target":3000}]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("ports")]
        public global::System.Collections.Generic.IList<global::Baseten.SandboxPortV1>? Ports { get; set; }

        /// <summary>
        /// Caller-owned identifier for external lookups. Max 64 chars, alphanumeric + dash.<br/>
        /// Example: api-review-20260916-001
        /// </summary>
        /// <example>api-review-20260916-001</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_id")]
        public string? ExternalId { get; set; }

        /// <summary>
        /// Key-value pairs for organizing and filtering resources. Labels can be used to categorize resources by environment, project, team, or any custom taxonomy.<br/>
        /// Example: {"env":"development","project":"api-review","team":"engineering"}
        /// </summary>
        /// <example>{"env":"development","project":"api-review","team":"engineering"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("labels")]
        public global::System.Collections.Generic.Dictionary<string, string>? Labels { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxConfigurationV1" /> class.
        /// </summary>
        /// <param name="lifecycle">
        /// Lifecycle configuration controlling automatic sandbox deletion based on idle time, max age, or specific dates<br/>
        /// Example: {"expiration_policies":[{"action":"DELETE","type":"TTL_IDLE","value":"24h"},{"action":"DELETE","type":"TTL_MAX_AGE","value":"7d"},{"action":"DELETE","type":"DATE","value":"2026-09-23T21:26:58Z"}],"terminated_retention":"24h"}
        /// </param>
        /// <param name="network">
        /// Network configuration for a sandbox including subnet, domain filtering, and proxy settings<br/>
        /// Example: {"proxy":{"allowed_domains":["api.openai.com","pypi.org","files.pythonhosted.org","registry.npmjs.org"],"bypass":["registry.npmjs.org"],"forbidden_domains":["facebook.com","*.facebook.com"],"routing":[{"destinations":["api.openai.com"],"headers":{"Authorization":"Bearer {{SECRET:openai-key}}"},"body":{"user":"baseten-api-review-0916"},"secrets":{"openai-key":"sk-proj-demo-not-a-valid-api-key"}}]},"subnet":"default"}
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
        /// Image reference including its tag. Built-in image references are returned in the canonical baseten/ namespace. Use baseten/base-image:latest to get started with the built-in sandbox execution API. This image is available directly without building, pushing, or listing images through GET /v1/sandboxes/images.<br/>
        /// Example: baseten/base-image:latest
        /// </param>
        /// <param name="memory">
        /// Memory allocation in megabytes. Also determines CPU allocation (CPU cores = memory in MB / 2048, e.g., 4096MB = 2 CPUs).<br/>
        /// Example: 4096
        /// </param>
        /// <param name="ports">
        /// Set of ports for a resource<br/>
        /// Example: [{"name":"http","protocol":"HTTP","target":3000}]
        /// </param>
        /// <param name="externalId">
        /// Caller-owned identifier for external lookups. Max 64 chars, alphanumeric + dash.<br/>
        /// Example: api-review-20260916-001
        /// </param>
        /// <param name="labels">
        /// Key-value pairs for organizing and filtering resources. Labels can be used to categorize resources by environment, project, team, or any custom taxonomy.<br/>
        /// Example: {"env":"development","project":"api-review","team":"engineering"}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxConfigurationV1(
            global::Baseten.SandboxLifecycleV1? lifecycle,
            global::Baseten.SandboxNetworkV1? network,
            string? region,
            global::System.Collections.Generic.IList<global::Baseten.SandboxEnvV1>? envs,
            string? image,
            long? memory,
            global::System.Collections.Generic.IList<global::Baseten.SandboxPortV1>? ports,
            string? externalId,
            global::System.Collections.Generic.Dictionary<string, string>? labels)
        {
            this.Lifecycle = lifecycle;
            this.Network = network;
            this.Region = region;
            this.Envs = envs;
            this.Image = image;
            this.Memory = memory;
            this.Ports = ports;
            this.ExternalId = externalId;
            this.Labels = labels;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxConfigurationV1" /> class.
        /// </summary>
        public SandboxConfigurationV1()
        {
        }

    }
}