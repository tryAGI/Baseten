
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RouteV1
    {
        /// <summary>
        /// Stable route identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Immutable name to send in the inference request's model field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Identifier of the owning team.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TeamId { get; set; }

        /// <summary>
        /// Name of the owning team.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TeamName { get; set; }

        /// <summary>
        /// Display label, defaulting to the route name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DisplayName { get; set; }

        /// <summary>
        /// Short description of the route, empty when unset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// Configured upstream target.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Baseten.JsonConverters.TargetJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.Target Target { get; set; }

        /// <summary>
        /// Base URL for inference requests using this route.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invoke_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string InvokeUrl { get; set; }

        /// <summary>
        /// Creation time, ISO 8601.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RouteV1" /> class.
        /// </summary>
        /// <param name="id">
        /// Stable route identifier.
        /// </param>
        /// <param name="name">
        /// Immutable name to send in the inference request's model field.
        /// </param>
        /// <param name="teamId">
        /// Identifier of the owning team.
        /// </param>
        /// <param name="teamName">
        /// Name of the owning team.
        /// </param>
        /// <param name="displayName">
        /// Display label, defaulting to the route name.
        /// </param>
        /// <param name="description">
        /// Short description of the route, empty when unset.
        /// </param>
        /// <param name="target">
        /// Configured upstream target.
        /// </param>
        /// <param name="invokeUrl">
        /// Base URL for inference requests using this route.
        /// </param>
        /// <param name="createdAt">
        /// Creation time, ISO 8601.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RouteV1(
            string id,
            string name,
            string teamId,
            string teamName,
            string displayName,
            string description,
            global::Baseten.Target target,
            string invokeUrl,
            global::System.DateTime createdAt)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.TeamId = teamId ?? throw new global::System.ArgumentNullException(nameof(teamId));
            this.TeamName = teamName ?? throw new global::System.ArgumentNullException(nameof(teamName));
            this.DisplayName = displayName ?? throw new global::System.ArgumentNullException(nameof(displayName));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Target = target;
            this.InvokeUrl = invokeUrl ?? throw new global::System.ArgumentNullException(nameof(invokeUrl));
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RouteV1" /> class.
        /// </summary>
        public RouteV1()
        {
        }

    }
}