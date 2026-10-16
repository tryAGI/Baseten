
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpsertRouteTargetClassifierV1
    {
        /// <summary>
        /// Target kind for a classifier-based route.
        /// </summary>
        /// <default>"CLASSIFIER"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "CLASSIFIER";

        /// <summary>
        /// ID of the classifier that picks a route for each request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("classifier_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ClassifierId { get; set; }

        /// <summary>
        /// IDs of the routes the classifier may pick. All must belong to the route's team and must not be routers themselves.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_route_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> AllowedRouteIds { get; set; }

        /// <summary>
        /// ID of the allowed route used when the classifier picks none.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_route_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DefaultRouteId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpsertRouteTargetClassifierV1" /> class.
        /// </summary>
        /// <param name="classifierId">
        /// ID of the classifier that picks a route for each request.
        /// </param>
        /// <param name="allowedRouteIds">
        /// IDs of the routes the classifier may pick. All must belong to the route's team and must not be routers themselves.
        /// </param>
        /// <param name="defaultRouteId">
        /// ID of the allowed route used when the classifier picks none.
        /// </param>
        /// <param name="type">
        /// Target kind for a classifier-based route.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpsertRouteTargetClassifierV1(
            string classifierId,
            global::System.Collections.Generic.IList<string> allowedRouteIds,
            string defaultRouteId,
            string type = "CLASSIFIER")
        {
            this.Type = type;
            this.ClassifierId = classifierId ?? throw new global::System.ArgumentNullException(nameof(classifierId));
            this.AllowedRouteIds = allowedRouteIds ?? throw new global::System.ArgumentNullException(nameof(allowedRouteIds));
            this.DefaultRouteId = defaultRouteId ?? throw new global::System.ArgumentNullException(nameof(defaultRouteId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpsertRouteTargetClassifierV1" /> class.
        /// </summary>
        public UpsertRouteTargetClassifierV1()
        {
        }

    }
}