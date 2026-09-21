
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Public failure details for a volume sync.
    /// </summary>
    public sealed partial class VolumeSyncErrorV1
    {
        /// <summary>
        /// Stable machine-readable failure classification.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Code { get; set; }

        /// <summary>
        /// Redacted user-facing failure message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VolumeSyncErrorV1" /> class.
        /// </summary>
        /// <param name="code">
        /// Stable machine-readable failure classification.
        /// </param>
        /// <param name="message">
        /// Redacted user-facing failure message.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VolumeSyncErrorV1(
            string code,
            string message)
        {
            this.Code = code ?? throw new global::System.ArgumentNullException(nameof(code));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VolumeSyncErrorV1" /> class.
        /// </summary>
        public VolumeSyncErrorV1()
        {
        }

    }
}