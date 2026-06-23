
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Replace the config when config.yaml changes.<br/>
    /// Config has no action: it is always a full replacement of the parsed config.<br/>
    /// Derived changes (environment variables, external data, requirements) are<br/>
    /// emitted as their own ops alongside this one.
    /// </summary>
    public sealed partial class DeploymentPatchOpConfigV1
    {
        /// <summary>
        /// Default Value: config
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// The full parsed config as a JSON object.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Config { get; set; }

        /// <summary>
        /// Config file path within the source.<br/>
        /// Default Value: config.yaml
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        public string? Path { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentPatchOpConfigV1" /> class.
        /// </summary>
        /// <param name="config">
        /// The full parsed config as a JSON object.
        /// </param>
        /// <param name="type">
        /// Default Value: config
        /// </param>
        /// <param name="path">
        /// Config file path within the source.<br/>
        /// Default Value: config.yaml
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeploymentPatchOpConfigV1(
            object config,
            string? type,
            string? path)
        {
            this.Type = type;
            this.Config = config ?? throw new global::System.ArgumentNullException(nameof(config));
            this.Path = path;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentPatchOpConfigV1" /> class.
        /// </summary>
        public DeploymentPatchOpConfigV1()
        {
        }

    }
}