
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A permission roles can grant.
    /// </summary>
    public sealed partial class AccessPermissionV1
    {
        /// <summary>
        /// Name of the permission, such as `model.deployment.write`. It starts with its category's name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Name of the permission's category, such as `model.deployment`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("category")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Category { get; set; }

        /// <summary>
        /// Short human-readable name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DisplayName { get; set; }

        /// <summary>
        /// What the permission allows
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// Kinds of custom role that can hold it: `ORGANIZATION`, `TEAM`, or both
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role_kinds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Baseten.AccessRoleKindV1> RoleKinds { get; set; }

        /// <summary>
        /// Whether the permission is reserved for built-in admin roles. Custom roles can't hold it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reserved")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Reserved { get; set; }

        /// <summary>
        /// Whether your organization has the features the permission needs. Custom roles can hold a permission only when it's available and not reserved.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("available")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Available { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AccessPermissionV1" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the permission, such as `model.deployment.write`. It starts with its category's name.
        /// </param>
        /// <param name="category">
        /// Name of the permission's category, such as `model.deployment`
        /// </param>
        /// <param name="displayName">
        /// Short human-readable name
        /// </param>
        /// <param name="description">
        /// What the permission allows
        /// </param>
        /// <param name="roleKinds">
        /// Kinds of custom role that can hold it: `ORGANIZATION`, `TEAM`, or both
        /// </param>
        /// <param name="reserved">
        /// Whether the permission is reserved for built-in admin roles. Custom roles can't hold it.
        /// </param>
        /// <param name="available">
        /// Whether your organization has the features the permission needs. Custom roles can hold a permission only when it's available and not reserved.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AccessPermissionV1(
            string name,
            string category,
            string displayName,
            string description,
            global::System.Collections.Generic.IList<global::Baseten.AccessRoleKindV1> roleKinds,
            bool reserved,
            bool available)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Category = category ?? throw new global::System.ArgumentNullException(nameof(category));
            this.DisplayName = displayName ?? throw new global::System.ArgumentNullException(nameof(displayName));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.RoleKinds = roleKinds ?? throw new global::System.ArgumentNullException(nameof(roleKinds));
            this.Reserved = reserved;
            this.Available = available;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccessPermissionV1" /> class.
        /// </summary>
        public AccessPermissionV1()
        {
        }

    }
}