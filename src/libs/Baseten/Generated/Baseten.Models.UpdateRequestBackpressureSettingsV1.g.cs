
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A request to update request backpressure settings.
    /// </summary>
    public sealed partial class UpdateRequestBackpressureSettingsV1
    {
        /// <summary>
        /// Backpressure policy to apply. Null indicates no policy (on update, clears an existing one).<br/>
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
        /// Initializes a new instance of the <see cref="UpdateRequestBackpressureSettingsV1" /> class.
        /// </summary>
        /// <param name="policy">
        /// Backpressure policy to apply. Null indicates no policy (on update, clears an existing one).<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateRequestBackpressureSettingsV1(
            global::Baseten.RequestBackpressurePolicyV1? policy)
        {
            this.Policy = policy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateRequestBackpressureSettingsV1" /> class.
        /// </summary>
        public UpdateRequestBackpressureSettingsV1()
        {
        }

    }
}