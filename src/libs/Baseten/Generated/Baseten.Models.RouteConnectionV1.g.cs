
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RouteConnectionV1
    {
        /// <summary>
        /// Stable connection identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Identifier of the team that owns the connection.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TeamId { get; set; }

        /// <summary>
        /// Provider the connection authenticates with, and the team secret holding its API key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Baseten.JsonConverters.ConfigJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.Config Config { get; set; }

        /// <summary>
        /// Creation time, ISO 8601.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Last update time, ISO 8601.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RouteConnectionV1" /> class.
        /// </summary>
        /// <param name="id">
        /// Stable connection identifier.
        /// </param>
        /// <param name="teamId">
        /// Identifier of the team that owns the connection.
        /// </param>
        /// <param name="config">
        /// Provider the connection authenticates with, and the team secret holding its API key.
        /// </param>
        /// <param name="createdAt">
        /// Creation time, ISO 8601.
        /// </param>
        /// <param name="updatedAt">
        /// Last update time, ISO 8601.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RouteConnectionV1(
            string id,
            string teamId,
            global::Baseten.Config config,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.TeamId = teamId ?? throw new global::System.ArgumentNullException(nameof(teamId));
            this.Config = config;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RouteConnectionV1" /> class.
        /// </summary>
        public RouteConnectionV1()
        {
        }

    }
}