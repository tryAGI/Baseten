
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
        /// Optional default GPU type for cache-enabled CPU job placement, such as H100. GPU jobs use their requested GPU type; uncached CPU jobs use normal CPU routing. Omitting this field preserves the stored default; providing a value updates it. Existing cache-affinity requirements still apply.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_accelerator")]
        public string? ProjectAccelerator { get; set; }

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
        /// <param name="projectAccelerator">
        /// Optional default GPU type for cache-enabled CPU job placement, such as H100. GPU jobs use their requested GPU type; uncached CPU jobs use normal CPU routing. Omitting this field preserves the stored default; providing a value updates it. Existing cache-affinity requirements still apply.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpsertTrainingProjectV1(
            string name,
            string? projectAccelerator)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.ProjectAccelerator = projectAccelerator;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpsertTrainingProjectV1" /> class.
        /// </summary>
        public UpsertTrainingProjectV1()
        {
        }

    }
}