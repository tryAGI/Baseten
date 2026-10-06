
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpdateRouteHarnessDefaultsV1
    {
        /// <summary>
        /// Route IDs for the model roles to change; roles left out are unchanged. Every route must belong to the team. Pass null to clear every role, or omit to leave the harness unchanged.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("claude_code")]
        public global::Baseten.UpdateBackgroundHarnessModelsV1? ClaudeCode { get; set; }

        /// <summary>
        /// Route IDs for the model roles to change; roles left out are unchanged. Every route must belong to the team. Pass null to clear every role, or omit to leave the harness unchanged.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("opencode")]
        public global::Baseten.UpdateBackgroundHarnessModelsV1? Opencode { get; set; }

        /// <summary>
        /// Route IDs for the model roles to change; roles left out are unchanged. Every route must belong to the team. Pass null to clear every role, or omit to leave the harness unchanged.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("codex")]
        public global::Baseten.UpdatePrimaryHarnessModelsV1? Codex { get; set; }

        /// <summary>
        /// Route IDs for the model roles to change; roles left out are unchanged. Every route must belong to the team. Pass null to clear every role, or omit to leave the harness unchanged.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pi")]
        public global::Baseten.UpdatePrimaryHarnessModelsV1? Pi { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateRouteHarnessDefaultsV1" /> class.
        /// </summary>
        /// <param name="claudeCode">
        /// Route IDs for the model roles to change; roles left out are unchanged. Every route must belong to the team. Pass null to clear every role, or omit to leave the harness unchanged.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="opencode">
        /// Route IDs for the model roles to change; roles left out are unchanged. Every route must belong to the team. Pass null to clear every role, or omit to leave the harness unchanged.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="codex">
        /// Route IDs for the model roles to change; roles left out are unchanged. Every route must belong to the team. Pass null to clear every role, or omit to leave the harness unchanged.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="pi">
        /// Route IDs for the model roles to change; roles left out are unchanged. Every route must belong to the team. Pass null to clear every role, or omit to leave the harness unchanged.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateRouteHarnessDefaultsV1(
            global::Baseten.UpdateBackgroundHarnessModelsV1? claudeCode,
            global::Baseten.UpdateBackgroundHarnessModelsV1? opencode,
            global::Baseten.UpdatePrimaryHarnessModelsV1? codex,
            global::Baseten.UpdatePrimaryHarnessModelsV1? pi)
        {
            this.ClaudeCode = claudeCode;
            this.Opencode = opencode;
            this.Codex = codex;
            this.Pi = pi;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateRouteHarnessDefaultsV1" /> class.
        /// </summary>
        public UpdateRouteHarnessDefaultsV1()
        {
        }

    }
}