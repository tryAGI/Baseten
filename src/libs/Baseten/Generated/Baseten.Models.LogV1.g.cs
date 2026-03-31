
#nullable enable

namespace Baseten
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LogV1
    {
        /// <summary>
        /// Epoch nanosecond timestamp of the log message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Timestamp { get; set; }

        /// <summary>
        /// The contents of the log message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// The replica the log line was emitted from.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("replica")]
        public string? Replica { get; set; }

        /// <summary>
        /// The request ID associated with an inference request.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        public string? RequestId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LogV1" /> class.
        /// </summary>
        /// <param name="timestamp">
        /// Epoch nanosecond timestamp of the log message.
        /// </param>
        /// <param name="message">
        /// The contents of the log message.
        /// </param>
        /// <param name="replica">
        /// The replica the log line was emitted from.
        /// </param>
        /// <param name="requestId">
        /// The request ID associated with an inference request.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LogV1(
            string timestamp,
            string message,
            string? replica,
            string? requestId)
        {
            this.Timestamp = timestamp ?? throw new global::System.ArgumentNullException(nameof(timestamp));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Replica = replica;
            this.RequestId = requestId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LogV1" /> class.
        /// </summary>
        public LogV1()
        {
        }
    }
}