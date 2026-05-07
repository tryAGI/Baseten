
#nullable enable

namespace Baseten
{
    /// <summary>
    /// The config of a deployment. Fields are populated per `output_format`.
    /// </summary>
    public sealed partial class DeploymentConfigResponseV1
    {
        /// <summary>
        /// The parsed config of the deployment.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        public object? Config { get; set; }

        /// <summary>
        /// The original config.yaml text — preserves comments, ordering, formatting.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("raw_config")]
        public string? RawConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentConfigResponseV1" /> class.
        /// </summary>
        /// <param name="config">
        /// The parsed config of the deployment.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="rawConfig">
        /// The original config.yaml text — preserves comments, ordering, formatting.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeploymentConfigResponseV1(
            object? config,
            string? rawConfig)
        {
            this.Config = config;
            this.RawConfig = rawConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentConfigResponseV1" /> class.
        /// </summary>
        public DeploymentConfigResponseV1()
        {
        }
    }
}