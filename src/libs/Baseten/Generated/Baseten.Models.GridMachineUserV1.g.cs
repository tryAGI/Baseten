
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GridMachineUserV1
    {
        /// <summary>
        /// Stable machine user identifier. Grid usage and settings identify the machine user by this ID as its `user_id`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Name of the machine user, unique within its team.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Identifier of the team that owns the machine user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TeamId { get; set; }

        /// <summary>
        /// Name of the team that owns the machine user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TeamName { get; set; }

        /// <summary>
        /// ID of the user who created the machine user. Null when unknown.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_by")]
        public string? CreatedBy { get; set; }

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
        /// Initializes a new instance of the <see cref="GridMachineUserV1" /> class.
        /// </summary>
        /// <param name="id">
        /// Stable machine user identifier. Grid usage and settings identify the machine user by this ID as its `user_id`.
        /// </param>
        /// <param name="name">
        /// Name of the machine user, unique within its team.
        /// </param>
        /// <param name="teamId">
        /// Identifier of the team that owns the machine user.
        /// </param>
        /// <param name="teamName">
        /// Name of the team that owns the machine user.
        /// </param>
        /// <param name="createdAt">
        /// Creation time, ISO 8601.
        /// </param>
        /// <param name="createdBy">
        /// ID of the user who created the machine user. Null when unknown.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GridMachineUserV1(
            string id,
            string name,
            string teamId,
            string teamName,
            global::System.DateTime createdAt,
            string? createdBy)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.TeamId = teamId ?? throw new global::System.ArgumentNullException(nameof(teamId));
            this.TeamName = teamName ?? throw new global::System.ArgumentNullException(nameof(teamName));
            this.CreatedBy = createdBy;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GridMachineUserV1" /> class.
        /// </summary>
        public GridMachineUserV1()
        {
        }

    }
}