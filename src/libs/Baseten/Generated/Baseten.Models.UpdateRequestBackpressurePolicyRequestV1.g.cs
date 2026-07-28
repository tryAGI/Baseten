
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Request body for ``PATCH /v1/models/.../deployments/.../request_backpressure_policy``.
    /// </summary>
    public sealed partial class UpdateRequestBackpressurePolicyRequestV1
    {
        /// <summary>
        /// Controls how the deployment handles requests when at capacity. queue_on_full (default) queues requests while reject_on_full returns HTTP 429.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_backpressure_policy")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Baseten.JsonConverters.RequestBackpressurePolicyV1JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.RequestBackpressurePolicyV1 RequestBackpressurePolicy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateRequestBackpressurePolicyRequestV1" /> class.
        /// </summary>
        /// <param name="requestBackpressurePolicy">
        /// Controls how the deployment handles requests when at capacity. queue_on_full (default) queues requests while reject_on_full returns HTTP 429.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateRequestBackpressurePolicyRequestV1(
            global::Baseten.RequestBackpressurePolicyV1 requestBackpressurePolicy)
        {
            this.RequestBackpressurePolicy = requestBackpressurePolicy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateRequestBackpressurePolicyRequestV1" /> class.
        /// </summary>
        public UpdateRequestBackpressurePolicyRequestV1()
        {
        }

    }
}