
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RouteTargetConnectionV1
    {
        /// <summary>
        /// Target kind for a provider reached through a team connection.
        /// </summary>
        /// <default>"CONNECTION"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "CONNECTION";

        /// <summary>
        /// Model name sent to the provider.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// Identifier of the team connection authenticating with the provider.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connection_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ConnectionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RouteTargetConnectionV1" /> class.
        /// </summary>
        /// <param name="model">
        /// Model name sent to the provider.
        /// </param>
        /// <param name="connectionId">
        /// Identifier of the team connection authenticating with the provider.
        /// </param>
        /// <param name="type">
        /// Target kind for a provider reached through a team connection.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RouteTargetConnectionV1(
            string model,
            string connectionId,
            string type = "CONNECTION")
        {
            this.Type = type;
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.ConnectionId = connectionId ?? throw new global::System.ArgumentNullException(nameof(connectionId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RouteTargetConnectionV1" /> class.
        /// </summary>
        public RouteTargetConnectionV1()
        {
        }

    }
}