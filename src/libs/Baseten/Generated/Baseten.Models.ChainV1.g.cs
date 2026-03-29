
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A chain.
    /// </summary>
    public sealed partial class ChainV1
    {
        /// <summary>
        /// Unique identifier of the chain
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Time the chain was created in ISO 8601 format
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Name of the chain
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Number of deployments of the chain
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployments_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int DeploymentsCount { get; set; }

        /// <summary>
        /// Name of the team associated with the chain
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TeamName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChainV1" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier of the chain
        /// </param>
        /// <param name="createdAt">
        /// Time the chain was created in ISO 8601 format
        /// </param>
        /// <param name="name">
        /// Name of the chain
        /// </param>
        /// <param name="deploymentsCount">
        /// Number of deployments of the chain
        /// </param>
        /// <param name="teamName">
        /// Name of the team associated with the chain
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChainV1(
            string id,
            global::System.DateTime createdAt,
            string name,
            int deploymentsCount,
            string teamName)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.CreatedAt = createdAt;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.DeploymentsCount = deploymentsCount;
            this.TeamName = teamName ?? throw new global::System.ArgumentNullException(nameof(teamName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChainV1" /> class.
        /// </summary>
        public ChainV1()
        {
        }
    }
}