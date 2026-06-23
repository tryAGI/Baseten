
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Add, update, or remove a single environment variable.
    /// </summary>
    public sealed partial class DeploymentPatchOpEnvVarV1
    {
        /// <summary>
        /// Default Value: environment_variable
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// How this op changes the variable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Baseten.JsonConverters.DeploymentPatchActionV1JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.DeploymentPatchActionV1 Action { get; set; }

        /// <summary>
        /// The environment variable name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The environment variable value. Required for add and update.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public string? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentPatchOpEnvVarV1" /> class.
        /// </summary>
        /// <param name="action">
        /// How this op changes the variable.
        /// </param>
        /// <param name="name">
        /// The environment variable name.
        /// </param>
        /// <param name="type">
        /// Default Value: environment_variable
        /// </param>
        /// <param name="value">
        /// The environment variable value. Required for add and update.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeploymentPatchOpEnvVarV1(
            global::Baseten.DeploymentPatchActionV1 action,
            string name,
            string? type,
            string? value)
        {
            this.Type = type;
            this.Action = action;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentPatchOpEnvVarV1" /> class.
        /// </summary>
        public DeploymentPatchOpEnvVarV1()
        {
        }

    }
}