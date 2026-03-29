
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Fields that can be upserted on a training project.
    /// </summary>
    public sealed partial class UpsertTrainingProjectV1
    {
        /// <summary>
        /// Name of the training project.
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
        /// Initializes a new instance of the <see cref="UpsertTrainingProjectV1" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the training project.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpsertTrainingProjectV1(
            string name)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpsertTrainingProjectV1" /> class.
        /// </summary>
        public UpsertTrainingProjectV1()
        {
        }
    }
}