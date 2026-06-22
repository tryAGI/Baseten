
#nullable enable

namespace Baseten
{
    /// <summary>
    /// PATCH body. Updates provided mutable fields; targets are replaced as a full list.
    /// </summary>
    public sealed partial class UpdateEndpointRequestV1
    {
        /// <summary>
        /// New globally-unique slug of the form '{org_prefix}/{name}'.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        public string? Slug { get; set; }

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
        /// <param name="slug">
        /// New globally-unique slug of the form '{org_prefix}/{name}'.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="targets">
        /// The endpoint's upstream targets. Exactly one target is supported at this time.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateEndpointRequestV1(
            string? slug,
            global::System.Collections.Generic.IList<global::Baseten.EndpointTargetRequestV1>? targets)
        {
            this.Slug = slug;
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