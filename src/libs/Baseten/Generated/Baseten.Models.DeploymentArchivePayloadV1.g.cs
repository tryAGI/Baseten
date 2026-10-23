
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
        /// Create the environment named by `environment_name` if it does not exist yet. If false, a push to an environment that does not exist is rejected. Only meaningful when `environment_name` is set to something other than `production`, which always exists. This field currently defaults to true, but that default will change to false in a future release. Set it explicitly to avoid a behavior change.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("create_environment_if_missing")]
        public bool? CreateEnvironmentIfMissing { get; set; }

        /// <summary>
        /// Region in which to deploy the model<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        public string? Region { get; set; }

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
        /// Autoscaling settings for the new deployment. With `environment_name`, the new deployment starts from the environment's settings with these changes applied, and the environment keeps the result when the promotion completes. Without it, they apply to the new deployment only.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("autoscaling_settings")]
        public global::Baseten.UpdateAutoscalingSettingsV1? AutoscalingSettings { get; set; }

        /// <summary>
        /// Request backpressure settings for the new deployment, applied the same way as `autoscaling_settings`.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_backpressure_settings")]
        public global::Baseten.UpdateRequestBackpressureSettingsV1? RequestBackpressureSettings { get; set; }

        /// <summary>
        /// Autoscaling schedule changes for the environment named by `environment_name`, applied when the promotion completes. Requires `environment_name`.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("autoscaling_schedule_settings")]
        public global::Baseten.UpdateAutoscalingScheduleSettingsV1? AutoscalingScheduleSettings { get; set; }

        /// <summary>
        /// Promotion settings for promoting the new deployment into the environment named by `environment_name`, for this promotion only. Omitted fields keep the environment's values, and the environment's promotion settings are unchanged. Requires `environment_name`.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promotion_settings_override")]
        public global::Baseten.UpdatePromotionSettingsV1? PromotionSettingsOverride { get; set; }

        /// <summary>
        /// Instance type for the new deployment, from `GET /v1/instance_types`, in place of the one in `config`. With `environment_name`, the environment takes it when the promotion completes. Without it, it applies to the new deployment only. Cannot be set with `preserve_env_instance_type: true`.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instance_type_id")]
        public string? InstanceTypeId { get; set; }

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
        /// <param name="createEnvironmentIfMissing">
        /// Create the environment named by `environment_name` if it does not exist yet. If false, a push to an environment that does not exist is rejected. Only meaningful when `environment_name` is set to something other than `production`, which always exists. This field currently defaults to true, but that default will change to false in a future release. Set it explicitly to avoid a behavior change.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="region">
        /// Region in which to deploy the model<br/>
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
        /// <param name="autoscalingSettings">
        /// Autoscaling settings for the new deployment. With `environment_name`, the new deployment starts from the environment's settings with these changes applied, and the environment keeps the result when the promotion completes. Without it, they apply to the new deployment only.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="requestBackpressureSettings">
        /// Request backpressure settings for the new deployment, applied the same way as `autoscaling_settings`.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="autoscalingScheduleSettings">
        /// Autoscaling schedule changes for the environment named by `environment_name`, applied when the promotion completes. Requires `environment_name`.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="promotionSettingsOverride">
        /// Promotion settings for promoting the new deployment into the environment named by `environment_name`, for this promotion only. Omitted fields keep the environment's values, and the environment's promotion settings are unchanged. Requires `environment_name`.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="instanceTypeId">
        /// Instance type for the new deployment, from `GET /v1/instance_types`, in place of the one in `config`. With `environment_name`, the environment takes it when the promotion completes. Without it, it applies to the new deployment only. Cannot be set with `preserve_env_instance_type: true`.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeploymentArchivePayloadV1(
            object config,
            string? rawConfig,
            object? userEnv,
            string? environmentName,
            bool? createEnvironmentIfMissing,
            string? region,
            bool? preserveEnvInstanceType,
            int? deployTimeoutMinutes,
            string? deploymentName,
            object? labels,
            bool? isDevelopment,
            global::Baseten.UpdateAutoscalingSettingsV1? autoscalingSettings,
            global::Baseten.UpdateRequestBackpressureSettingsV1? requestBackpressureSettings,
            global::Baseten.UpdateAutoscalingScheduleSettingsV1? autoscalingScheduleSettings,
            global::Baseten.UpdatePromotionSettingsV1? promotionSettingsOverride,
            string? instanceTypeId)
        {
            this.Config = config ?? throw new global::System.ArgumentNullException(nameof(config));
            this.RawConfig = rawConfig;
            this.UserEnv = userEnv;
            this.EnvironmentName = environmentName;
            this.CreateEnvironmentIfMissing = createEnvironmentIfMissing;
            this.Region = region;
            this.PreserveEnvInstanceType = preserveEnvInstanceType;
            this.DeployTimeoutMinutes = deployTimeoutMinutes;
            this.DeploymentName = deploymentName;
            this.Labels = labels;
            this.IsDevelopment = isDevelopment;
            this.AutoscalingSettings = autoscalingSettings;
            this.RequestBackpressureSettings = requestBackpressureSettings;
            this.AutoscalingScheduleSettings = autoscalingScheduleSettings;
            this.PromotionSettingsOverride = promotionSettingsOverride;
            this.InstanceTypeId = instanceTypeId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentArchivePayloadV1" /> class.
        /// </summary>
        public DeploymentArchivePayloadV1()
        {
        }

    }
}