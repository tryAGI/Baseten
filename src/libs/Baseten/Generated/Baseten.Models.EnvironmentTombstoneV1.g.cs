
#nullable enable

namespace Baseten
{
    /// <summary>
    /// An environment tombstone.
    /// </summary>
    public sealed partial class EnvironmentTombstoneV1
    {
        /// <summary>
        /// Name of the environment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Unique identifier of the model
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelId { get; set; }

        /// <summary>
        /// Whether the environment was deleted
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleted")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Deleted { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentTombstoneV1" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the environment
        /// </param>
        /// <param name="modelId">
        /// Unique identifier of the model
        /// </param>
        /// <param name="deleted">
        /// Whether the environment was deleted
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EnvironmentTombstoneV1(
            string name,
            string modelId,
            bool deleted)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.ModelId = modelId ?? throw new global::System.ArgumentNullException(nameof(modelId));
            this.Deleted = deleted;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentTombstoneV1" /> class.
        /// </summary>
        public EnvironmentTombstoneV1()
        {
        }

    }
}