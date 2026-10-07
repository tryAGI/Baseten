
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Delete after the specified period of inactivity.
    /// </summary>
    public sealed partial class SandboxTTLIdleExpirationPolicyV1
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Baseten.JsonConverters.SandboxTTLIdleExpirationPolicyV1ActionJsonConverter))]
        public global::Baseten.SandboxTTLIdleExpirationPolicyV1Action Action { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Baseten.JsonConverters.SandboxTTLIdleExpirationPolicyV1TypeJsonConverter))]
        public global::Baseten.SandboxTTLIdleExpirationPolicyV1Type Type { get; set; }

        /// <summary>
        /// Duration using seconds, minutes, hours, or composite durations such as 1h30m. Whole days and weeks are also supported, for example 7d or 2w.<br/>
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
        /// Initializes a new instance of the <see cref="SandboxTTLIdleExpirationPolicyV1" /> class.
        /// </summary>
        /// <param name="value">
        /// Duration using seconds, minutes, hours, or composite durations such as 1h30m. Whole days and weeks are also supported, for example 7d or 2w.<br/>
        /// Example: 24h
        /// </param>
        /// <param name="action"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxTTLIdleExpirationPolicyV1(
            string value,
            global::Baseten.SandboxTTLIdleExpirationPolicyV1Action action,
            global::Baseten.SandboxTTLIdleExpirationPolicyV1Type type)
        {
            this.Action = action;
            this.Type = type;
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxTTLIdleExpirationPolicyV1" /> class.
        /// </summary>
        public SandboxTTLIdleExpirationPolicyV1()
        {
        }

    }
}