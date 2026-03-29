
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A BIS LLM model version
    /// </summary>
    public sealed partial class LLMModelVersionV1
    {
        /// <summary>
        /// Unique identifier of the model version
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Time the model was created in ISO 8601 format
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Name of the model version
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
        /// Initializes a new instance of the <see cref="LLMModelVersionV1" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier of the model version
        /// </param>
        /// <param name="createdAt">
        /// Time the model was created in ISO 8601 format
        /// </param>
        /// <param name="name">
        /// Name of the model version
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LLMModelVersionV1(
            string id,
            global::System.DateTime createdAt,
            string name)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.CreatedAt = createdAt;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LLMModelVersionV1" /> class.
        /// </summary>
        public LLMModelVersionV1()
        {
        }
    }
}