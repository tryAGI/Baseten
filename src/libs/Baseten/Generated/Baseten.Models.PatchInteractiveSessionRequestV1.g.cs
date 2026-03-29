
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Request to patch an interactive session.<br/>
    /// Only fields that are provided (non-None) will be applied.
    /// </summary>
    public sealed partial class PatchInteractiveSessionRequestV1
    {
        /// <summary>
        /// For on_startup sessions, minutes to add to the expiration. For on_demand/on_failure sessions, minutes to add to the timeout. Use -1 for infinite timeout (bumps by 10 years).<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeout_minutes")]
        public int? TimeoutMinutes { get; set; }

        /// <summary>
        /// Update when the interactive session is created. Cannot be changed if the session trigger is 'on_startup'.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trigger")]
        public global::Baseten.V1InteractiveSessionTrigger? Trigger { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchInteractiveSessionRequestV1" /> class.
        /// </summary>
        /// <param name="timeoutMinutes">
        /// For on_startup sessions, minutes to add to the expiration. For on_demand/on_failure sessions, minutes to add to the timeout. Use -1 for infinite timeout (bumps by 10 years).<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="trigger">
        /// Update when the interactive session is created. Cannot be changed if the session trigger is 'on_startup'.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchInteractiveSessionRequestV1(
            int? timeoutMinutes,
            global::Baseten.V1InteractiveSessionTrigger? trigger)
        {
            this.TimeoutMinutes = timeoutMinutes;
            this.Trigger = trigger;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchInteractiveSessionRequestV1" /> class.
        /// </summary>
        public PatchInteractiveSessionRequestV1()
        {
        }
    }
}