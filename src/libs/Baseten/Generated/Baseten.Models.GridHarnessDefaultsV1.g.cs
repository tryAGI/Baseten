
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GridHarnessDefaultsV1
    {
        /// <summary>
        /// Default models for Claude Code.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("claude_code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.GridBackgroundHarnessDefaultsV1 ClaudeCode { get; set; }

        /// <summary>
        /// Default models for OpenCode.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("opencode")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.GridBackgroundHarnessDefaultsV1 Opencode { get; set; }

        /// <summary>
        /// Default models for Codex.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("codex")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.GridPrimaryHarnessDefaultsV1 Codex { get; set; }

        /// <summary>
        /// Default models for Pi.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pi")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.GridPrimaryHarnessDefaultsV1 Pi { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GridHarnessDefaultsV1" /> class.
        /// </summary>
        /// <param name="claudeCode">
        /// Default models for Claude Code.
        /// </param>
        /// <param name="opencode">
        /// Default models for OpenCode.
        /// </param>
        /// <param name="codex">
        /// Default models for Codex.
        /// </param>
        /// <param name="pi">
        /// Default models for Pi.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GridHarnessDefaultsV1(
            global::Baseten.GridBackgroundHarnessDefaultsV1 claudeCode,
            global::Baseten.GridBackgroundHarnessDefaultsV1 opencode,
            global::Baseten.GridPrimaryHarnessDefaultsV1 codex,
            global::Baseten.GridPrimaryHarnessDefaultsV1 pi)
        {
            this.ClaudeCode = claudeCode ?? throw new global::System.ArgumentNullException(nameof(claudeCode));
            this.Opencode = opencode ?? throw new global::System.ArgumentNullException(nameof(opencode));
            this.Codex = codex ?? throw new global::System.ArgumentNullException(nameof(codex));
            this.Pi = pi ?? throw new global::System.ArgumentNullException(nameof(pi));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GridHarnessDefaultsV1" /> class.
        /// </summary>
        public GridHarnessDefaultsV1()
        {
        }

    }
}