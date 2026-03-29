
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A request to create a BIS LLM model
    /// </summary>
    public sealed partial class CreateLLMModelRequestV1
    {
        /// <summary>
        /// Resources allocated to the model
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resources")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Resources { get; set; }

        /// <summary>
        /// Version of the helm chart to use<br/>
        /// Default Value: 1.0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llm_version")]
        public string? LlmVersion { get; set; }

        /// <summary>
        /// Configuration specific to the LLM model
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llm_config")]
        public object? LlmConfig { get; set; }

        /// <summary>
        /// Environment variables for the model
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment_variables")]
        public object? EnvironmentVariables { get; set; }

        /// <summary>
        /// Autoscaling settings for the model<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("autoscaling_settings")]
        public global::Baseten.UpdateAutoscalingSettingsV1? AutoscalingSettings { get; set; }

        /// <summary>
        /// Additional autoscaling configuration (e.g. target in-flight tokens)<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("additional_autoscaling_config")]
        public object? AdditionalAutoscalingConfig { get; set; }

        /// <summary>
        /// User-defined metadata for the deployment<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Name of the model
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateLLMModelRequestV1" /> class.
        /// </summary>
        /// <param name="resources">
        /// Resources allocated to the model
        /// </param>
        /// <param name="name">
        /// Name of the model
        /// </param>
        /// <param name="llmVersion">
        /// Version of the helm chart to use<br/>
        /// Default Value: 1.0
        /// </param>
        /// <param name="llmConfig">
        /// Configuration specific to the LLM model
        /// </param>
        /// <param name="environmentVariables">
        /// Environment variables for the model
        /// </param>
        /// <param name="autoscalingSettings">
        /// Autoscaling settings for the model<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="additionalAutoscalingConfig">
        /// Additional autoscaling configuration (e.g. target in-flight tokens)<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="metadata">
        /// User-defined metadata for the deployment<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateLLMModelRequestV1(
            object resources,
            string name,
            string? llmVersion,
            object? llmConfig,
            object? environmentVariables,
            global::Baseten.UpdateAutoscalingSettingsV1? autoscalingSettings,
            object? additionalAutoscalingConfig,
            object? metadata)
        {
            this.Resources = resources ?? throw new global::System.ArgumentNullException(nameof(resources));
            this.LlmVersion = llmVersion;
            this.LlmConfig = llmConfig;
            this.EnvironmentVariables = environmentVariables;
            this.AutoscalingSettings = autoscalingSettings;
            this.AdditionalAutoscalingConfig = additionalAutoscalingConfig;
            this.Metadata = metadata;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateLLMModelRequestV1" /> class.
        /// </summary>
        public CreateLLMModelRequestV1()
        {
        }
    }
}