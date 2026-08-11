
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Request body for ``PATCH /v1/models/.../deployments/.../request_backpressure_settings``.
    /// </summary>
    public sealed partial class UpdateRequestBackpressureSettingsRequestV1
    {
        /// <summary>
        /// Controls how the deployment handles requests when at capacity. queue_on_full (default) queues requests while reject_on_full returns HTTP 429.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("policy")]
        public global::Baseten.RequestBackpressurePolicyV1? Policy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateRequestBackpressureSettingsRequestV1" /> class.
        /// </summary>
        /// <param name="policy">
        /// Controls how the deployment handles requests when at capacity. queue_on_full (default) queues requests while reject_on_full returns HTTP 429.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateRequestBackpressureSettingsRequestV1(
            global::Baseten.RequestBackpressurePolicyV1? policy)
        {
            this.Policy = policy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateRequestBackpressureSettingsRequestV1" /> class.
        /// </summary>
        public UpdateRequestBackpressureSettingsRequestV1()
        {
        }

    }
}