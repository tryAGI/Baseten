
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpdateCodexHarnessConfigV1
    {
        /// <summary>
        /// Identifier of the team whose default models to set. Every route must belong to this team.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TeamId { get; set; }

        /// <summary>
        /// Codex, which supports only the `primary` role.
        /// </summary>
        /// <default>"codex"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("harness")]
        public string Harness { get; set; } = "codex";

        /// <summary>
        /// Route IDs for the model roles to change. Roles left out are unchanged.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("models")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.UpdatePrimaryHarnessModelsV1 Models { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCodexHarnessConfigV1" /> class.
        /// </summary>
        /// <param name="teamId">
        /// Identifier of the team whose default models to set. Every route must belong to this team.
        /// </param>
        /// <param name="models">
        /// Route IDs for the model roles to change. Roles left out are unchanged.
        /// </param>
        /// <param name="harness">
        /// Codex, which supports only the `primary` role.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateCodexHarnessConfigV1(
            string teamId,
            global::Baseten.UpdatePrimaryHarnessModelsV1 models,
            string harness = "codex")
        {
            this.TeamId = teamId ?? throw new global::System.ArgumentNullException(nameof(teamId));
            this.Harness = harness;
            this.Models = models ?? throw new global::System.ArgumentNullException(nameof(models));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCodexHarnessConfigV1" /> class.
        /// </summary>
        public UpdateCodexHarnessConfigV1()
        {
        }

    }
}