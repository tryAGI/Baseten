
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpsertRouteTargetClassifierModelBasedV1
    {
        /// <summary>
        /// Target kind for a classifier-model-based route. Not intended for general use: classifiers are deployed by Baseten's post-training team.
        /// </summary>
        /// <default>"CLASSIFIER_MODEL_BASED"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "CLASSIFIER_MODEL_BASED";

        /// <summary>
        /// ID of the Baseten model that picks a route for each request. Only classifiers deployed by Baseten's post-training team are supported.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("classifier_model_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ClassifierModelId { get; set; }

        /// <summary>
        /// Environment of the classifier model. Omit for production, which is returned as null.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("classifier_environment_name")]
        public string? ClassifierEnvironmentName { get; set; }

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
        /// Initializes a new instance of the <see cref="UpsertRouteTargetClassifierModelBasedV1" /> class.
        /// </summary>
        /// <param name="classifierModelId">
        /// ID of the Baseten model that picks a route for each request. Only classifiers deployed by Baseten's post-training team are supported.
        /// </param>
        /// <param name="allowedRouteIds">
        /// IDs of the routes the classifier may pick. All must belong to the route's team and must not be routers themselves.
        /// </param>
        /// <param name="defaultRouteId">
        /// ID of the allowed route used when the classifier picks none.
        /// </param>
        /// <param name="classifierEnvironmentName">
        /// Environment of the classifier model. Omit for production, which is returned as null.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="type">
        /// Target kind for a classifier-model-based route. Not intended for general use: classifiers are deployed by Baseten's post-training team.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpsertRouteTargetClassifierModelBasedV1(
            string classifierModelId,
            global::System.Collections.Generic.IList<string> allowedRouteIds,
            string defaultRouteId,
            string? classifierEnvironmentName,
            string type = "CLASSIFIER_MODEL_BASED")
        {
            this.Type = type;
            this.ClassifierModelId = classifierModelId ?? throw new global::System.ArgumentNullException(nameof(classifierModelId));
            this.ClassifierEnvironmentName = classifierEnvironmentName;
            this.AllowedRouteIds = allowedRouteIds ?? throw new global::System.ArgumentNullException(nameof(allowedRouteIds));
            this.DefaultRouteId = defaultRouteId ?? throw new global::System.ArgumentNullException(nameof(defaultRouteId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpsertRouteTargetClassifierModelBasedV1" /> class.
        /// </summary>
        public UpsertRouteTargetClassifierModelBasedV1()
        {
        }

    }
}