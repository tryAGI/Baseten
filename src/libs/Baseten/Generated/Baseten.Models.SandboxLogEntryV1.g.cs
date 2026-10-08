
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SandboxLogEntryV1
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Timestamp { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Numeric log severity.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("severity")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Severity { get; set; }

        /// <summary>
        /// Associated trace identifier, or an empty string when unavailable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trace_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TraceId { get; set; }

        /// <summary>
        /// Action or command when present on the log entry.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        public string? Action { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxLogEntryV1" /> class.
        /// </summary>
        /// <param name="timestamp"></param>
        /// <param name="message"></param>
        /// <param name="severity">
        /// Numeric log severity.
        /// </param>
        /// <param name="traceId">
        /// Associated trace identifier, or an empty string when unavailable.
        /// </param>
        /// <param name="action">
        /// Action or command when present on the log entry.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxLogEntryV1(
            global::System.DateTime timestamp,
            string message,
            int severity,
            string traceId,
            string? action)
        {
            this.Timestamp = timestamp;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Severity = severity;
            this.TraceId = traceId ?? throw new global::System.ArgumentNullException(nameof(traceId));
            this.Action = action;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxLogEntryV1" /> class.
        /// </summary>
        public SandboxLogEntryV1()
        {
        }

    }
}