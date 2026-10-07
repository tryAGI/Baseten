
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Lifecycle configuration controlling automatic sandbox deletion based on idle time, max age, or specific dates<br/>
    /// Example: {"expiration_policies":[{"action":"DELETE","type":"TTL_IDLE","value":"24h"},{"action":"DELETE","type":"TTL_MAX_AGE","value":"7d"},{"action":"DELETE","type":"DATE","value":"2026-09-23T21:26:58Z"}],"terminated_retention":"24h"}
    /// </summary>
    public sealed partial class SandboxLifecycleV1
    {
        /// <summary>
        /// List of expiration policies. Multiple policies can be combined; whichever condition is met first triggers the action.<br/>
        /// Example: [{"action":"DELETE","type":"TTL_IDLE","value":"24h"}, {"action":"DELETE","type":"TTL_MAX_AGE","value":"7d"}, {"action":"DELETE","type":"DATE","value":"2026-09-23T21:26:58Z"}]
        /// </summary>
        /// <example>[{"action":"DELETE","type":"TTL_IDLE","value":"24h"}, {"action":"DELETE","type":"TTL_MAX_AGE","value":"7d"}, {"action":"DELETE","type":"DATE","value":"2026-09-23T21:26:58Z"}]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("expiration_policies")]
        public global::System.Collections.Generic.IList<global::Baseten.SandboxExpirationPolicyV1>? ExpirationPolicies { get; set; }

        /// <summary>
        /// Duration to keep the sandbox record after termination for log access (e.g., '1h', '24h', '7d'). Defaults to 5m. Subject to maximum quota limits.<br/>
        /// Example: 24h
        /// </summary>
        /// <example>24h</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("terminated_retention")]
        public string? TerminatedRetention { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxLifecycleV1" /> class.
        /// </summary>
        /// <param name="expirationPolicies">
        /// List of expiration policies. Multiple policies can be combined; whichever condition is met first triggers the action.<br/>
        /// Example: [{"action":"DELETE","type":"TTL_IDLE","value":"24h"}, {"action":"DELETE","type":"TTL_MAX_AGE","value":"7d"}, {"action":"DELETE","type":"DATE","value":"2026-09-23T21:26:58Z"}]
        /// </param>
        /// <param name="terminatedRetention">
        /// Duration to keep the sandbox record after termination for log access (e.g., '1h', '24h', '7d'). Defaults to 5m. Subject to maximum quota limits.<br/>
        /// Example: 24h
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxLifecycleV1(
            global::System.Collections.Generic.IList<global::Baseten.SandboxExpirationPolicyV1>? expirationPolicies,
            string? terminatedRetention)
        {
            this.ExpirationPolicies = expirationPolicies;
            this.TerminatedRetention = terminatedRetention;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxLifecycleV1" /> class.
        /// </summary>
        public SandboxLifecycleV1()
        {
        }

    }
}