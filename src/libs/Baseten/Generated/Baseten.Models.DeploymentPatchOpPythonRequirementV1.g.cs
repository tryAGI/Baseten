
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Add, update, or remove a single Python requirement.
    /// </summary>
    public sealed partial class DeploymentPatchOpPythonRequirementV1
    {
        /// <summary>
        /// Default Value: python_requirement
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// How this op changes the requirement.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Baseten.JsonConverters.DeploymentPatchActionV1JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.DeploymentPatchActionV1 Action { get; set; }

        /// <summary>
        /// The requirement to apply. For removals this is the package name; otherwise the full requirements.txt-style line.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requirement")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Requirement { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentPatchOpPythonRequirementV1" /> class.
        /// </summary>
        /// <param name="action">
        /// How this op changes the requirement.
        /// </param>
        /// <param name="requirement">
        /// The requirement to apply. For removals this is the package name; otherwise the full requirements.txt-style line.
        /// </param>
        /// <param name="type">
        /// Default Value: python_requirement
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeploymentPatchOpPythonRequirementV1(
            global::Baseten.DeploymentPatchActionV1 action,
            string requirement,
            string? type)
        {
            this.Type = type;
            this.Action = action;
            this.Requirement = requirement ?? throw new global::System.ArgumentNullException(nameof(requirement));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentPatchOpPythonRequirementV1" /> class.
        /// </summary>
        public DeploymentPatchOpPythonRequirementV1()
        {
        }

    }
}