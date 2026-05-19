
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A secret tombstone.
    /// </summary>
    public sealed partial class SecretTombstoneV1
    {
        /// <summary>
        /// Name of the deleted secret
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SecretTombstoneV1" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the deleted secret
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SecretTombstoneV1(
            string name)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SecretTombstoneV1" /> class.
        /// </summary>
        public SecretTombstoneV1()
        {
        }

    }
}