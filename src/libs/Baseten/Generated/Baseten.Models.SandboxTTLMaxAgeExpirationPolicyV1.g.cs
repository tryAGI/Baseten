
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Delete after the specified total lifetime.
    /// </summary>
    public sealed partial class SandboxTTLMaxAgeExpirationPolicyV1
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Baseten.JsonConverters.SandboxTTLMaxAgeExpirationPolicyV1ActionJsonConverter))]
        public global::Baseten.SandboxTTLMaxAgeExpirationPolicyV1Action Action { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Baseten.JsonConverters.SandboxTTLMaxAgeExpirationPolicyV1TypeJsonConverter))]
        public global::Baseten.SandboxTTLMaxAgeExpirationPolicyV1Type Type { get; set; }

        /// <summary>
        /// Duration using seconds, minutes, hours, or composite durations such as 1h30m. Whole days and weeks are also supported, for example 7d or 2w, where d is 24h and w is 7 × 24h. Days and weeks cannot be combined with other units, so 1d12h is rejected; use 36h instead. Values are returned exactly as sent, without normalization.<br/>
        /// Example: 24h
        /// </summary>
        /// <example>24h</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxTTLMaxAgeExpirationPolicyV1" /> class.
        /// </summary>
        /// <param name="value">
        /// Duration using seconds, minutes, hours, or composite durations such as 1h30m. Whole days and weeks are also supported, for example 7d or 2w, where d is 24h and w is 7 × 24h. Days and weeks cannot be combined with other units, so 1d12h is rejected; use 36h instead. Values are returned exactly as sent, without normalization.<br/>
        /// Example: 24h
        /// </param>
        /// <param name="action"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxTTLMaxAgeExpirationPolicyV1(
            string value,
            global::Baseten.SandboxTTLMaxAgeExpirationPolicyV1Action action,
            global::Baseten.SandboxTTLMaxAgeExpirationPolicyV1Type type)
        {
            this.Action = action;
            this.Type = type;
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxTTLMaxAgeExpirationPolicyV1" /> class.
        /// </summary>
        public SandboxTTLMaxAgeExpirationPolicyV1()
        {
        }

    }
}