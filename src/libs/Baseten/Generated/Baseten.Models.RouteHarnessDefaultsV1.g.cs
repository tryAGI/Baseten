
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RouteHarnessDefaultsV1
    {
        /// <summary>
        /// Default models for Claude Code.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("claude_code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.BackgroundHarnessDefaultsV1 ClaudeCode { get; set; }

        /// <summary>
        /// Default models for OpenCode.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("opencode")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.BackgroundHarnessDefaultsV1 Opencode { get; set; }

        /// <summary>
        /// Default models for Codex.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("codex")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.PrimaryHarnessDefaultsV1 Codex { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RouteHarnessDefaultsV1" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RouteHarnessDefaultsV1(
            global::Baseten.BackgroundHarnessDefaultsV1 claudeCode,
            global::Baseten.BackgroundHarnessDefaultsV1 opencode,
            global::Baseten.PrimaryHarnessDefaultsV1 codex)
        {
            this.ClaudeCode = claudeCode ?? throw new global::System.ArgumentNullException(nameof(claudeCode));
            this.Opencode = opencode ?? throw new global::System.ArgumentNullException(nameof(opencode));
            this.Codex = codex ?? throw new global::System.ArgumentNullException(nameof(codex));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RouteHarnessDefaultsV1" /> class.
        /// </summary>
        public RouteHarnessDefaultsV1()
        {
        }

    }
}