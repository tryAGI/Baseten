
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A request backpressure policy a request set; a null policy clears it. Not itself a<br/>
    /// payload in the discriminated union.
    /// </summary>
    public sealed partial class AuditLogEventRequestBackpressureSettingsUpdateV1
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("policy")]
        public string? Policy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogEventRequestBackpressureSettingsUpdateV1" /> class.
        /// </summary>
        /// <param name="policy"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuditLogEventRequestBackpressureSettingsUpdateV1(
            string? policy)
        {
            this.Policy = policy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogEventRequestBackpressureSettingsUpdateV1" /> class.
        /// </summary>
        public AuditLogEventRequestBackpressureSettingsUpdateV1()
        {
        }

    }
}