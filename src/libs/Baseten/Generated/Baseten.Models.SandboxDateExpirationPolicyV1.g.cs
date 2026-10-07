
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Delete at the specified absolute timestamp.
    /// </summary>
    public sealed partial class SandboxDateExpirationPolicyV1
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Baseten.JsonConverters.SandboxDateExpirationPolicyV1ActionJsonConverter))]
        public global::Baseten.SandboxDateExpirationPolicyV1Action Action { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Baseten.JsonConverters.SandboxDateExpirationPolicyV1TypeJsonConverter))]
        public global::Baseten.SandboxDateExpirationPolicyV1Type Type { get; set; }

        /// <summary>
        /// Example: 2026-09-23T21:26:58Z
        /// </summary>
        /// <example>2026-09-23T21:26:58Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxDateExpirationPolicyV1" /> class.
        /// </summary>
        /// <param name="value">
        /// Example: 2026-09-23T21:26:58Z
        /// </param>
        /// <param name="action"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxDateExpirationPolicyV1(
            global::System.DateTime value,
            global::Baseten.SandboxDateExpirationPolicyV1Action action,
            global::Baseten.SandboxDateExpirationPolicyV1Type type)
        {
            this.Action = action;
            this.Type = type;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxDateExpirationPolicyV1" /> class.
        /// </summary>
        public SandboxDateExpirationPolicyV1()
        {
        }

    }
}