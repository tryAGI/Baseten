
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A chain deployment was activated.
    /// </summary>
    public sealed partial class AuditLogEventChainDeploymentActivatedV1
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"CHAIN_DEPLOYMENT_ACTIVATED"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_type")]
        public string EventType { get; set; } = "CHAIN_DEPLOYMENT_ACTIVATED";

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
        [global::System.Text.Json.Serialization.JsonPropertyName("chain_deployment_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ChainDeploymentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chain_deployment_name")]
        public string? ChainDeploymentName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogEventChainDeploymentActivatedV1" /> class.
        /// </summary>
        /// <param name="chainId"></param>
        /// <param name="chainName"></param>
        /// <param name="chainDeploymentId"></param>
        /// <param name="chainDeploymentName"></param>
        /// <param name="eventType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuditLogEventChainDeploymentActivatedV1(
            string chainId,
            string chainName,
            string chainDeploymentId,
            string? chainDeploymentName,
            string eventType = "CHAIN_DEPLOYMENT_ACTIVATED")
        {
            this.EventType = eventType;
            this.ChainId = chainId ?? throw new global::System.ArgumentNullException(nameof(chainId));
            this.ChainName = chainName ?? throw new global::System.ArgumentNullException(nameof(chainName));
            this.ChainDeploymentId = chainDeploymentId ?? throw new global::System.ArgumentNullException(nameof(chainDeploymentId));
            this.ChainDeploymentName = chainDeploymentName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogEventChainDeploymentActivatedV1" /> class.
        /// </summary>
        public AuditLogEventChainDeploymentActivatedV1()
        {
        }

    }
}