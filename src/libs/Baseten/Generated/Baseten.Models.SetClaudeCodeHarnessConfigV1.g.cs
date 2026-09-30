
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SetClaudeCodeHarnessConfigV1
    {
        /// <summary>
        /// Identifier of the team whose default models to set. Every route must belong to this team.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TeamId { get; set; }

        /// <summary>
        /// Claude Code, which supports the `primary` and `background` roles.
        /// </summary>
        /// <default>"claude-code"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("harness")]
        public string Harness { get; set; } = "claude-code";

        /// <summary>
        /// Route ID for each model role. Roles left out use Baseten's defaults.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("models")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.BackgroundHarnessModelsV1 Models { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SetClaudeCodeHarnessConfigV1" /> class.
        /// </summary>
        /// <param name="teamId">
        /// Identifier of the team whose default models to set. Every route must belong to this team.
        /// </param>
        /// <param name="models">
        /// Route ID for each model role. Roles left out use Baseten's defaults.
        /// </param>
        /// <param name="harness">
        /// Claude Code, which supports the `primary` and `background` roles.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SetClaudeCodeHarnessConfigV1(
            string teamId,
            global::Baseten.BackgroundHarnessModelsV1 models,
            string harness = "claude-code")
        {
            this.TeamId = teamId ?? throw new global::System.ArgumentNullException(nameof(teamId));
            this.Harness = harness;
            this.Models = models ?? throw new global::System.ArgumentNullException(nameof(models));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SetClaudeCodeHarnessConfigV1" /> class.
        /// </summary>
        public SetClaudeCodeHarnessConfigV1()
        {
        }

    }
}