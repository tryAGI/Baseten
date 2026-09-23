
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Why a supported model is not enabled for this workspace.
    /// </summary>
    public sealed partial class EnablementDetailsV1
    {
        /// <summary>
        /// Machine-readable reason the model is not enabled. Currently one of 'needs_approval', 'sequence_length_unsupported' or 'loops_not_enabled'. Deliberately not a closed enum: values are added as the check learns to distinguish cases that call for a different action, so treat an unrecognized value as 'not enabled, reason unknown' rather than an error.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Reason { get; set; }

        /// <summary>
        /// Human-readable explanation of the reason.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason_detail")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ReasonDetail { get; set; }

        /// <summary>
        /// Human-readable next step to enable the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("remediation")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Remediation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EnablementDetailsV1" /> class.
        /// </summary>
        /// <param name="reason">
        /// Machine-readable reason the model is not enabled. Currently one of 'needs_approval', 'sequence_length_unsupported' or 'loops_not_enabled'. Deliberately not a closed enum: values are added as the check learns to distinguish cases that call for a different action, so treat an unrecognized value as 'not enabled, reason unknown' rather than an error.
        /// </param>
        /// <param name="reasonDetail">
        /// Human-readable explanation of the reason.
        /// </param>
        /// <param name="remediation">
        /// Human-readable next step to enable the model.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EnablementDetailsV1(
            string reason,
            string reasonDetail,
            string remediation)
        {
            this.Reason = reason ?? throw new global::System.ArgumentNullException(nameof(reason));
            this.ReasonDetail = reasonDetail ?? throw new global::System.ArgumentNullException(nameof(reasonDetail));
            this.Remediation = remediation ?? throw new global::System.ArgumentNullException(nameof(remediation));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnablementDetailsV1" /> class.
        /// </summary>
        public EnablementDetailsV1()
        {
        }

    }
}