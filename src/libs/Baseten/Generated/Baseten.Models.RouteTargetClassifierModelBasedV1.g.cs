
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RouteTargetClassifierModelBasedV1
    {
        /// <summary>
        /// Target kind for a classifier-model-based route.
        /// </summary>
        /// <default>"CLASSIFIER_MODEL_BASED"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "CLASSIFIER_MODEL_BASED";

        /// <summary>
        /// ID of the Baseten model that picks a route for each request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("classifier_model_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ClassifierModelId { get; set; }

        /// <summary>
        /// Environment of the classifier model. Null for production.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("classifier_environment_name")]
        public string? ClassifierEnvironmentName { get; set; }

        /// <summary>
        /// Route used when the classifier picks none.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_route")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.RouteRefV1 DefaultRoute { get; set; }

        /// <summary>
        /// Routes the classifier may pick, in creation order.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_routes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Baseten.RouteRefV1> AllowedRoutes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RouteTargetClassifierModelBasedV1" /> class.
        /// </summary>
        /// <param name="classifierModelId">
        /// ID of the Baseten model that picks a route for each request.
        /// </param>
        /// <param name="defaultRoute">
        /// Route used when the classifier picks none.
        /// </param>
        /// <param name="allowedRoutes">
        /// Routes the classifier may pick, in creation order.
        /// </param>
        /// <param name="classifierEnvironmentName">
        /// Environment of the classifier model. Null for production.
        /// </param>
        /// <param name="type">
        /// Target kind for a classifier-model-based route.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RouteTargetClassifierModelBasedV1(
            string classifierModelId,
            global::Baseten.RouteRefV1 defaultRoute,
            global::System.Collections.Generic.IList<global::Baseten.RouteRefV1> allowedRoutes,
            string? classifierEnvironmentName,
            string type = "CLASSIFIER_MODEL_BASED")
        {
            this.Type = type;
            this.ClassifierModelId = classifierModelId ?? throw new global::System.ArgumentNullException(nameof(classifierModelId));
            this.ClassifierEnvironmentName = classifierEnvironmentName;
            this.DefaultRoute = defaultRoute ?? throw new global::System.ArgumentNullException(nameof(defaultRoute));
            this.AllowedRoutes = allowedRoutes ?? throw new global::System.ArgumentNullException(nameof(allowedRoutes));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RouteTargetClassifierModelBasedV1" /> class.
        /// </summary>
        public RouteTargetClassifierModelBasedV1()
        {
        }

    }
}