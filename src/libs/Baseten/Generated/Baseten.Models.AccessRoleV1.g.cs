
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A set of permissions you assign to users, service accounts, and directory groups. Baseten<br/>
    /// defines the built-in roles, and your organization defines its custom roles.
    /// </summary>
    public sealed partial class AccessRoleV1
    {
        /// <summary>
        /// Unique identifier of the role. Built-in role IDs start with `baseten:`, such as `baseten:reader`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Name of the role
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Description of the role
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// Whether Baseten defines the role. Built-in roles are read-only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("built_in")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool BuiltIn { get; set; }

        /// <summary>
        /// Where the role is assigned: `ORGANIZATION` roles for the whole organization, and `TEAM` roles in a team. `MEMBERSHIP` roles are built-in roles held only through organization membership, such as Admin and Creator, and can't be assigned.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Baseten.JsonConverters.AccessRoleKindV1JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.AccessRoleKindV1 Kind { get; set; }

        /// <summary>
        /// ID of the only team a team role can be assigned in. Null when any team can use it, and for other kinds of role.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_id")]
        public string? TeamId { get; set; }

        /// <summary>
        /// Name of the only team a team role can be assigned in
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_name")]
        public string? TeamName { get; set; }

        /// <summary>
        /// Names of the role's own permissions
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permissions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Permissions { get; set; }

        /// <summary>
        /// IDs of the built-in roles whose permissions this role also grants, including permissions Baseten adds to them later
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_role_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> IncludeRoleIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AccessRoleV1" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier of the role. Built-in role IDs start with `baseten:`, such as `baseten:reader`.
        /// </param>
        /// <param name="name">
        /// Name of the role
        /// </param>
        /// <param name="description">
        /// Description of the role
        /// </param>
        /// <param name="builtIn">
        /// Whether Baseten defines the role. Built-in roles are read-only.
        /// </param>
        /// <param name="kind">
        /// Where the role is assigned: `ORGANIZATION` roles for the whole organization, and `TEAM` roles in a team. `MEMBERSHIP` roles are built-in roles held only through organization membership, such as Admin and Creator, and can't be assigned.
        /// </param>
        /// <param name="permissions">
        /// Names of the role's own permissions
        /// </param>
        /// <param name="includeRoleIds">
        /// IDs of the built-in roles whose permissions this role also grants, including permissions Baseten adds to them later
        /// </param>
        /// <param name="teamId">
        /// ID of the only team a team role can be assigned in. Null when any team can use it, and for other kinds of role.
        /// </param>
        /// <param name="teamName">
        /// Name of the only team a team role can be assigned in
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AccessRoleV1(
            string id,
            string name,
            string description,
            bool builtIn,
            global::Baseten.AccessRoleKindV1 kind,
            global::System.Collections.Generic.IList<string> permissions,
            global::System.Collections.Generic.IList<string> includeRoleIds,
            string? teamId,
            string? teamName)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.BuiltIn = builtIn;
            this.Kind = kind;
            this.TeamId = teamId;
            this.TeamName = teamName;
            this.Permissions = permissions ?? throw new global::System.ArgumentNullException(nameof(permissions));
            this.IncludeRoleIds = includeRoleIds ?? throw new global::System.ArgumentNullException(nameof(includeRoleIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccessRoleV1" /> class.
        /// </summary>
        public AccessRoleV1()
        {
        }

    }
}