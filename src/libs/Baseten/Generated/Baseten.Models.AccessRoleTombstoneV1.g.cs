
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A deleted custom role.
    /// </summary>
    public sealed partial class AccessRoleTombstoneV1
    {
        /// <summary>
        /// Unique identifier of the deleted role
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AccessRoleTombstoneV1" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier of the deleted role
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AccessRoleTombstoneV1(
            string id)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccessRoleTombstoneV1" /> class.
        /// </summary>
        public AccessRoleTombstoneV1()
        {
        }

    }
}