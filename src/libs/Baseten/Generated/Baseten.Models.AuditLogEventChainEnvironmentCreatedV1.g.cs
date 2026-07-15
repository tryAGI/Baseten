
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A chain environment was created.
    /// </summary>
    public sealed partial class AuditLogEventChainEnvironmentCreatedV1
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"CHAIN_ENVIRONMENT_CREATED"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_type")]
        public string EventType { get; set; } = "CHAIN_ENVIRONMENT_CREATED";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chain_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ChainId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chain_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ChainName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EnvironmentName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redeploy_on_promotion")]
        public bool? RedeployOnPromotion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ramp_up_while_promoting")]
        public bool? RampUpWhilePromoting { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ramp_up_duration_seconds")]
        public int? RampUpDurationSeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogEventChainEnvironmentCreatedV1" /> class.
        /// </summary>
        /// <param name="chainId"></param>
        /// <param name="chainName"></param>
        /// <param name="environmentName"></param>
        /// <param name="redeployOnPromotion"></param>
        /// <param name="rampUpWhilePromoting"></param>
        /// <param name="rampUpDurationSeconds"></param>
        /// <param name="eventType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuditLogEventChainEnvironmentCreatedV1(
            string chainId,
            string chainName,
            string environmentName,
            bool? redeployOnPromotion,
            bool? rampUpWhilePromoting,
            int? rampUpDurationSeconds,
            string eventType = "CHAIN_ENVIRONMENT_CREATED")
        {
            this.EventType = eventType;
            this.ChainId = chainId ?? throw new global::System.ArgumentNullException(nameof(chainId));
            this.ChainName = chainName ?? throw new global::System.ArgumentNullException(nameof(chainName));
            this.EnvironmentName = environmentName ?? throw new global::System.ArgumentNullException(nameof(environmentName));
            this.RedeployOnPromotion = redeployOnPromotion;
            this.RampUpWhilePromoting = rampUpWhilePromoting;
            this.RampUpDurationSeconds = rampUpDurationSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogEventChainEnvironmentCreatedV1" /> class.
        /// </summary>
        public AuditLogEventChainEnvironmentCreatedV1()
        {
        }

    }
}