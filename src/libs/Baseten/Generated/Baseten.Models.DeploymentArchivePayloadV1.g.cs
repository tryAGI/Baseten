
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Deployment-level fields for a model-archive push.<br/>
    /// Shared by every endpoint that creates a deployment from an uploaded archive:<br/>
    /// `POST /v1/prepare_model_upload`, the `model_archive` source on `POST<br/>
    /// /v1/models`, and `POST /v1/models/{model_id}/deployments`.
    /// </summary>
    public sealed partial class DeploymentArchivePayloadV1
    {
        /// <summary>
        /// Parsed model config as a JSON object.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Config { get; set; }

        /// <summary>
        /// Original config.yaml text, persisted as-is on the deployment. Best-effort: invalid raw configs are logged and dropped without failing the request.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("raw_config")]
        public string? RawConfig { get; set; }

        /// <summary>
        /// Client environment metadata (e.g. client version, Python version). Validated server-side.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_env")]
        public object? UserEnv { get; set; }

        /// <summary>
        /// Stable environment to push to (e.g. `production`). If unset, the deployment is created without environment selection. Caller must have push permission for the named environment.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment_name")]
        public string? EnvironmentName { get; set; }

        /// <summary>
        /// Retain the target environment's current instance type rather than the one in `config`. Only meaningful when `environment_name` is set and that environment already exists.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preserve_env_instance_type")]
        public bool? PreserveEnvInstanceType { get; set; }

        /// <summary>
        /// Deploy timeout in minutes; allowed range 10 to 1440. Server default applies if unset.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deploy_timeout_minutes")]
        public int? DeployTimeoutMinutes { get; set; }

        /// <summary>
        /// Optional human-readable name for the deployment.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployment_name")]
        public string? DeploymentName { get; set; }

        /// <summary>
        /// User-provided key-value labels for the deployment.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labels")]
        public object? Labels { get; set; }

        /// <summary>
        /// If true, push as a development deployment: the model's single mutable dev slot, created if absent and overwritten in place otherwise. The following fields must be left at their defaults: `environment_name`, `preserve_env_instance_type`, `deployment_name`.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_development")]
        public bool? IsDevelopment { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentArchivePayloadV1" /> class.
        /// </summary>
        /// <param name="config">
        /// Parsed model config as a JSON object.
        /// </param>
        /// <param name="rawConfig">
        /// Original config.yaml text, persisted as-is on the deployment. Best-effort: invalid raw configs are logged and dropped without failing the request.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="userEnv">
        /// Client environment metadata (e.g. client version, Python version). Validated server-side.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="environmentName">
        /// Stable environment to push to (e.g. `production`). If unset, the deployment is created without environment selection. Caller must have push permission for the named environment.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="preserveEnvInstanceType">
        /// Retain the target environment's current instance type rather than the one in `config`. Only meaningful when `environment_name` is set and that environment already exists.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="deployTimeoutMinutes">
        /// Deploy timeout in minutes; allowed range 10 to 1440. Server default applies if unset.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="deploymentName">
        /// Optional human-readable name for the deployment.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="labels">
        /// User-provided key-value labels for the deployment.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="isDevelopment">
        /// If true, push as a development deployment: the model's single mutable dev slot, created if absent and overwritten in place otherwise. The following fields must be left at their defaults: `environment_name`, `preserve_env_instance_type`, `deployment_name`.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeploymentArchivePayloadV1(
            object config,
            string? rawConfig,
            object? userEnv,
            string? environmentName,
            bool? preserveEnvInstanceType,
            int? deployTimeoutMinutes,
            string? deploymentName,
            object? labels,
            bool? isDevelopment)
        {
            this.Config = config ?? throw new global::System.ArgumentNullException(nameof(config));
            this.RawConfig = rawConfig;
            this.UserEnv = userEnv;
            this.EnvironmentName = environmentName;
            this.PreserveEnvInstanceType = preserveEnvInstanceType;
            this.DeployTimeoutMinutes = deployTimeoutMinutes;
            this.DeploymentName = deploymentName;
            this.Labels = labels;
            this.IsDevelopment = isDevelopment;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentArchivePayloadV1" /> class.
        /// </summary>
        public DeploymentArchivePayloadV1()
        {
        }

    }
}