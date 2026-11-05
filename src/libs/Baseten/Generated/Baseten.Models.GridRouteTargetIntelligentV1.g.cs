
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GridRouteTargetIntelligentV1
    {
        /// <summary>
        /// Target kind for an intelligent route: Baseten picks the model per request.
        /// </summary>
        /// <default>"INTELLIGENT"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "INTELLIGENT";

        /// <summary>
        /// Route classifier that picks the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("route_classifier")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.GridRouteClassifierV1 RouteClassifier { get; set; }

        /// <summary>
        /// How the classifier weighs cost against quality.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tradeoff")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Baseten.JsonConverters.GridRouteTargetIntelligentV1TradeoffJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.GridRouteTargetIntelligentV1Tradeoff Tradeoff { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GridRouteTargetIntelligentV1" /> class.
        /// </summary>
        /// <param name="routeClassifier">
        /// Route classifier that picks the model.
        /// </param>
        /// <param name="tradeoff">
        /// How the classifier weighs cost against quality.
        /// </param>
        /// <param name="type">
        /// Target kind for an intelligent route: Baseten picks the model per request.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GridRouteTargetIntelligentV1(
            global::Baseten.GridRouteClassifierV1 routeClassifier,
            global::Baseten.GridRouteTargetIntelligentV1Tradeoff tradeoff,
            string type = "INTELLIGENT")
        {
            this.Type = type;
            this.RouteClassifier = routeClassifier ?? throw new global::System.ArgumentNullException(nameof(routeClassifier));
            this.Tradeoff = tradeoff;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GridRouteTargetIntelligentV1" /> class.
        /// </summary>
        public GridRouteTargetIntelligentV1()
        {
        }

    }
}