
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Request rate split by HTTP response code class.
    /// </summary>
    public sealed partial class InferenceVolumeByStatusDatapointV1
    {
        /// <summary>
        /// ISO 8601 timestamp.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Timestamp { get; set; }

        /// <summary>
        /// 2xx requests per second.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status_2xx")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Status2xx { get; set; }

        /// <summary>
        /// 4xx requests per second.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status_4xx")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Status4xx { get; set; }

        /// <summary>
        /// 5xx requests per second.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status_5xx")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Status5xx { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InferenceVolumeByStatusDatapointV1" /> class.
        /// </summary>
        /// <param name="timestamp">
        /// ISO 8601 timestamp.
        /// </param>
        /// <param name="status2xx">
        /// 2xx requests per second.
        /// </param>
        /// <param name="status4xx">
        /// 4xx requests per second.
        /// </param>
        /// <param name="status5xx">
        /// 5xx requests per second.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InferenceVolumeByStatusDatapointV1(
            global::System.DateTime timestamp,
            double status2xx,
            double status4xx,
            double status5xx)
        {
            this.Timestamp = timestamp;
            this.Status2xx = status2xx;
            this.Status4xx = status4xx;
            this.Status5xx = status5xx;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InferenceVolumeByStatusDatapointV1" /> class.
        /// </summary>
        public InferenceVolumeByStatusDatapointV1()
        {
        }

    }
}