
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A group of related permissions, such as the permissions on model deployments.
    /// </summary>
    public sealed partial class AccessPermissionCategoryV1
    {
        /// <summary>
        /// Name of the category, such as `model.deployment`. The names of its permissions start with it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Short human-readable name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DisplayName { get; set; }

        /// <summary>
        /// What the category covers
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// Types of resource a role assignment can select for these permissions, such as `MODEL`. Empty when assignments can't select resources for them.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resource_types")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Baseten.AccessResourceTypeV1> ResourceTypes { get; set; }

        /// <summary>
        /// Whether a role assignment can limit these permissions to environments
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supports_environments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool SupportsEnvironments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AccessPermissionCategoryV1" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the category, such as `model.deployment`. The names of its permissions start with it.
        /// </param>
        /// <param name="displayName">
        /// Short human-readable name
        /// </param>
        /// <param name="description">
        /// What the category covers
        /// </param>
        /// <param name="resourceTypes">
        /// Types of resource a role assignment can select for these permissions, such as `MODEL`. Empty when assignments can't select resources for them.
        /// </param>
        /// <param name="supportsEnvironments">
        /// Whether a role assignment can limit these permissions to environments
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AccessPermissionCategoryV1(
            string name,
            string displayName,
            string description,
            global::System.Collections.Generic.IList<global::Baseten.AccessResourceTypeV1> resourceTypes,
            bool supportsEnvironments)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.DisplayName = displayName ?? throw new global::System.ArgumentNullException(nameof(displayName));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.ResourceTypes = resourceTypes ?? throw new global::System.ArgumentNullException(nameof(resourceTypes));
            this.SupportsEnvironments = supportsEnvironments;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccessPermissionCategoryV1" /> class.
        /// </summary>
        public AccessPermissionCategoryV1()
        {
        }

    }
}