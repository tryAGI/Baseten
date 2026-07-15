
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A Frontier Gateway endpoint was deleted.
    /// </summary>
    public sealed partial class AuditLogEventGatewayEndpointDeletedV1
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"GATEWAY_ENDPOINT_DELETED"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_type")]
        public string EventType { get; set; } = "GATEWAY_ENDPOINT_DELETED";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gateway_endpoint_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GatewayEndpointId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Slug { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogEventGatewayEndpointDeletedV1" /> class.
        /// </summary>
        /// <param name="gatewayEndpointId"></param>
        /// <param name="slug"></param>
        /// <param name="eventType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuditLogEventGatewayEndpointDeletedV1(
            string gatewayEndpointId,
            string slug,
            string eventType = "GATEWAY_ENDPOINT_DELETED")
        {
            this.EventType = eventType;
            this.GatewayEndpointId = gatewayEndpointId ?? throw new global::System.ArgumentNullException(nameof(gatewayEndpointId));
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogEventGatewayEndpointDeletedV1" /> class.
        /// </summary>
        public AuditLogEventGatewayEndpointDeletedV1()
        {
        }

    }
}