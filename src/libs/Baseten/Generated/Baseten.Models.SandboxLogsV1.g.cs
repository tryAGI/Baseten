
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SandboxLogsV1
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sandbox_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SandboxName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime StartTime { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime EndTime { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Baseten.SandboxLogEntryV1> Logs { get; set; }

        /// <summary>
        /// Opaque cursor for the next page; null when there are no more entries.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxLogsV1" /> class.
        /// </summary>
        /// <param name="sandboxName"></param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="logs"></param>
        /// <param name="nextCursor">
        /// Opaque cursor for the next page; null when there are no more entries.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxLogsV1(
            string sandboxName,
            global::System.DateTime startTime,
            global::System.DateTime endTime,
            global::System.Collections.Generic.IList<global::Baseten.SandboxLogEntryV1> logs,
            string? nextCursor)
        {
            this.SandboxName = sandboxName ?? throw new global::System.ArgumentNullException(nameof(sandboxName));
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.Logs = logs ?? throw new global::System.ArgumentNullException(nameof(logs));
            this.NextCursor = nextCursor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxLogsV1" /> class.
        /// </summary>
        public SandboxLogsV1()
        {
        }

    }
}