
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A removed role assignment.
    /// </summary>
    public sealed partial class AccessAssignmentTombstoneV1
    {
        /// <summary>
        /// Unique identifier of the removed role assignment
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
        /// Initializes a new instance of the <see cref="AccessAssignmentTombstoneV1" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier of the removed role assignment
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AccessAssignmentTombstoneV1(
            string id)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccessAssignmentTombstoneV1" /> class.
        /// </summary>
        public AccessAssignmentTombstoneV1()
        {
        }

    }
}