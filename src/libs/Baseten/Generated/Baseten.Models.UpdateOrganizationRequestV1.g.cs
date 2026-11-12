
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Partial update of the caller's organization settings. Omitted fields are unchanged.
    /// </summary>
    public sealed partial class UpdateOrganizationRequestV1
    {
        /// <summary>
        /// Whether members can create new personal API keys. Null is not accepted.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_personal_api_keys")]
        public bool? AllowPersonalApiKeys { get; set; }

        /// <summary>
        /// Whether new team and organization API keys can be created. Null is not accepted.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_service_account_api_keys")]
        public bool? AllowServiceAccountApiKeys { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateOrganizationRequestV1" /> class.
        /// </summary>
        /// <param name="allowPersonalApiKeys">
        /// Whether members can create new personal API keys. Null is not accepted.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="allowServiceAccountApiKeys">
        /// Whether new team and organization API keys can be created. Null is not accepted.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateOrganizationRequestV1(
            bool? allowPersonalApiKeys,
            bool? allowServiceAccountApiKeys)
        {
            this.AllowPersonalApiKeys = allowPersonalApiKeys;
            this.AllowServiceAccountApiKeys = allowServiceAccountApiKeys;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateOrganizationRequestV1" /> class.
        /// </summary>
        public UpdateOrganizationRequestV1()
        {
        }

    }
}