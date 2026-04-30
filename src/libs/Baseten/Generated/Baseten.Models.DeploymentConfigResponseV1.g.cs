
#nullable enable

namespace Baseten
{
    /// <summary>
    /// The config of a deployment.
    /// </summary>
    public sealed partial class DeploymentConfigResponseV1
    {
        /// <summary>
        /// The parsed config of the deployment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Config { get; set; }

        /// <summary>
        /// The original config.yaml text submitted by the client, preserving comments, ordering, and formatting. Null if not available.
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
        /// The parsed config of the deployment
        /// </param>
        /// <param name="rawConfig">
        /// The original config.yaml text submitted by the client, preserving comments, ordering, and formatting. Null if not available.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeploymentConfigResponseV1(
            object config,
            string? rawConfig)
        {
            this.Config = config ?? throw new global::System.ArgumentNullException(nameof(config));
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