
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GridRouteTargetClassifierV1
    {
        /// <summary>
        /// Target kind for a classifier-based route.
        /// </summary>
        /// <default>"CLASSIFIER"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "CLASSIFIER";

        /// <summary>
        /// Classifier that picks a route for each request. Null for routers created before classifiers could be selected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("classifier")]
        public global::Baseten.GridClassifierV1? Classifier { get; set; }

        /// <summary>
        /// Route used when the classifier picks none.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_route")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.GridRouteRefV1 DefaultRoute { get; set; }

        /// <summary>
        /// Routes the classifier may pick, in creation order.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_routes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Baseten.GridRouteRefV1> AllowedRoutes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GridRouteTargetClassifierV1" /> class.
        /// </summary>
        /// <param name="defaultRoute">
        /// Route used when the classifier picks none.
        /// </param>
        /// <param name="allowedRoutes">
        /// Routes the classifier may pick, in creation order.
        /// </param>
        /// <param name="classifier">
        /// Classifier that picks a route for each request. Null for routers created before classifiers could be selected.
        /// </param>
        /// <param name="type">
        /// Target kind for a classifier-based route.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GridRouteTargetClassifierV1(
            global::Baseten.GridRouteRefV1 defaultRoute,
            global::System.Collections.Generic.IList<global::Baseten.GridRouteRefV1> allowedRoutes,
            global::Baseten.GridClassifierV1? classifier,
            string type = "CLASSIFIER")
        {
            this.Type = type;
            this.Classifier = classifier;
            this.DefaultRoute = defaultRoute ?? throw new global::System.ArgumentNullException(nameof(defaultRoute));
            this.AllowedRoutes = allowedRoutes ?? throw new global::System.ArgumentNullException(nameof(allowedRoutes));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GridRouteTargetClassifierV1" /> class.
        /// </summary>
        public GridRouteTargetClassifierV1()
        {
        }

    }
}