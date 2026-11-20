
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A permission a user or service account holds, and where.
    /// </summary>
    public sealed partial class EffectiveAccessPermissionV1
    {
        /// <summary>
        /// Name of the permission, such as `model.deployment.write`
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
        /// Name of the permission's category, such as `model.deployment`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("category")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Category { get; set; }

        /// <summary>
        /// Where it's held, one entry for each place a role grants it
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("grants")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Baseten.EffectiveAccessGrantV1> Grants { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EffectiveAccessPermissionV1" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the permission, such as `model.deployment.write`
        /// </param>
        /// <param name="displayName">
        /// Short human-readable name
        /// </param>
        /// <param name="category">
        /// Name of the permission's category, such as `model.deployment`
        /// </param>
        /// <param name="grants">
        /// Where it's held, one entry for each place a role grants it
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EffectiveAccessPermissionV1(
            string name,
            string displayName,
            string category,
            global::System.Collections.Generic.IList<global::Baseten.EffectiveAccessGrantV1> grants)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.DisplayName = displayName ?? throw new global::System.ArgumentNullException(nameof(displayName));
            this.Category = category ?? throw new global::System.ArgumentNullException(nameof(category));
            this.Grants = grants ?? throw new global::System.ArgumentNullException(nameof(grants));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EffectiveAccessPermissionV1" /> class.
        /// </summary>
        public EffectiveAccessPermissionV1()
        {
        }

    }
}