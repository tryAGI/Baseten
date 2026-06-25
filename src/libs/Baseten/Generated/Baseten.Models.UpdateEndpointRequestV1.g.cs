
#nullable enable

namespace Baseten
{
    /// <summary>
    /// PATCH body. Replaces the endpoint's full target list. The slug is immutable<br/>
    /// after creation; to change it, create a new endpoint and delete this one.
    /// </summary>
    public sealed partial class UpdateEndpointRequestV1
    {
        /// <summary>
        /// The endpoint's upstream targets. Exactly one target is supported at this time.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("targets")]
        public global::System.Collections.Generic.IList<global::Baseten.EndpointTargetRequestV1>? Targets { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateEndpointRequestV1" /> class.
        /// </summary>
        /// <param name="targets">
        /// The endpoint's upstream targets. Exactly one target is supported at this time.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateEndpointRequestV1(
            global::System.Collections.Generic.IList<global::Baseten.EndpointTargetRequestV1>? targets)
        {
            this.Targets = targets;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateEndpointRequestV1" /> class.
        /// </summary>
        public UpdateEndpointRequestV1()
        {
        }

    }
}