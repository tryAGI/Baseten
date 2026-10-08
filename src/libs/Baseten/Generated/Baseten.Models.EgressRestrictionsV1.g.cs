
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class EgressRestrictionsV1
    {
        /// <summary>
        /// Allowed outbound FQDNs; '*' wildcards are supported.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fqdn_allow_list")]
        public global::System.Collections.Generic.IList<string>? FqdnAllowList { get; set; }

        /// <summary>
        /// Allowed outbound IPv4 addresses or CIDR ranges.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ip_allow_list")]
        public global::System.Collections.Generic.IList<string>? IpAllowList { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EgressRestrictionsV1" /> class.
        /// </summary>
        /// <param name="fqdnAllowList">
        /// Allowed outbound FQDNs; '*' wildcards are supported.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="ipAllowList">
        /// Allowed outbound IPv4 addresses or CIDR ranges.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EgressRestrictionsV1(
            global::System.Collections.Generic.IList<string>? fqdnAllowList,
            global::System.Collections.Generic.IList<string>? ipAllowList)
        {
            this.FqdnAllowList = fqdnAllowList;
            this.IpAllowList = ipAllowList;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EgressRestrictionsV1" /> class.
        /// </summary>
        public EgressRestrictionsV1()
        {
        }

    }
}