
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Details of an in-progress promotion.
    /// </summary>
    public sealed partial class InProgressPromotionV1
    {
        /// <summary>
        /// Status of the promotion
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Baseten.JsonConverters.InProgressPromotionStatusV1JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.InProgressPromotionStatusV1 Status { get; set; }

        /// <summary>
        /// Percentage of traffic routed to the candidate deployment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("percent_traffic_to_new_version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PercentTrafficToNewVersion { get; set; }

        /// <summary>
        /// Error message if promotion failed<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_message")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// Whether this is a rolling deploy<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rolling_deploy")]
        public bool? RollingDeploy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InProgressPromotionV1" /> class.
        /// </summary>
        /// <param name="status">
        /// Status of the promotion
        /// </param>
        /// <param name="percentTrafficToNewVersion">
        /// Percentage of traffic routed to the candidate deployment
        /// </param>
        /// <param name="errorMessage">
        /// Error message if promotion failed<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="rollingDeploy">
        /// Whether this is a rolling deploy<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InProgressPromotionV1(
            global::Baseten.InProgressPromotionStatusV1 status,
            int percentTrafficToNewVersion,
            string? errorMessage,
            bool? rollingDeploy)
        {
            this.Status = status;
            this.PercentTrafficToNewVersion = percentTrafficToNewVersion;
            this.ErrorMessage = errorMessage;
            this.RollingDeploy = rollingDeploy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InProgressPromotionV1" /> class.
        /// </summary>
        public InProgressPromotionV1()
        {
        }
    }
}