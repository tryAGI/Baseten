
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpsertGridRouteTargetIntelligentV1
    {
        /// <summary>
        /// Target kind for an intelligent route: Baseten picks the model per request.
        /// </summary>
        /// <default>"INTELLIGENT"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "INTELLIGENT";

        /// <summary>
        /// Identifier of the route classifier that picks the model. List them with GET /v1/grid/route_classifiers.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("route_classifier_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RouteClassifierId { get; set; }

        /// <summary>
        /// How the classifier weighs cost against quality. Must be one of the classifier's supported tradeoffs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tradeoff")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Baseten.JsonConverters.UpsertGridRouteTargetIntelligentV1TradeoffJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.UpsertGridRouteTargetIntelligentV1Tradeoff Tradeoff { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpsertGridRouteTargetIntelligentV1" /> class.
        /// </summary>
        /// <param name="routeClassifierId">
        /// Identifier of the route classifier that picks the model. List them with GET /v1/grid/route_classifiers.
        /// </param>
        /// <param name="tradeoff">
        /// How the classifier weighs cost against quality. Must be one of the classifier's supported tradeoffs.
        /// </param>
        /// <param name="type">
        /// Target kind for an intelligent route: Baseten picks the model per request.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpsertGridRouteTargetIntelligentV1(
            string routeClassifierId,
            global::Baseten.UpsertGridRouteTargetIntelligentV1Tradeoff tradeoff,
            string type = "INTELLIGENT")
        {
            this.Type = type;
            this.RouteClassifierId = routeClassifierId ?? throw new global::System.ArgumentNullException(nameof(routeClassifierId));
            this.Tradeoff = tradeoff;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpsertGridRouteTargetIntelligentV1" /> class.
        /// </summary>
        public UpsertGridRouteTargetIntelligentV1()
        {
        }

    }
}