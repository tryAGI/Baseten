
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Every permission and permission category.
    /// </summary>
    public sealed partial class AccessPermissionsV1
    {
        /// <summary>
        /// Every permission category
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("categories")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Baseten.AccessPermissionCategoryV1> Categories { get; set; }

        /// <summary>
        /// Every permission, including those for features your organization doesn't have. Only `available` differs between organizations.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permissions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Baseten.AccessPermissionV1> Permissions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AccessPermissionsV1" /> class.
        /// </summary>
        /// <param name="categories">
        /// Every permission category
        /// </param>
        /// <param name="permissions">
        /// Every permission, including those for features your organization doesn't have. Only `available` differs between organizations.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AccessPermissionsV1(
            global::System.Collections.Generic.IList<global::Baseten.AccessPermissionCategoryV1> categories,
            global::System.Collections.Generic.IList<global::Baseten.AccessPermissionV1> permissions)
        {
            this.Categories = categories ?? throw new global::System.ArgumentNullException(nameof(categories));
            this.Permissions = permissions ?? throw new global::System.ArgumentNullException(nameof(permissions));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccessPermissionsV1" /> class.
        /// </summary>
        public AccessPermissionsV1()
        {
        }

    }
}