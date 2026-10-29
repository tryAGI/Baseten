
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Volume fields to change. name and region cannot be changed.
    /// </summary>
    public sealed partial class UpdateSandboxVolumeRequestV1
    {
        /// <summary>
        /// New capacity, as a size (e.g. "20Gi") or a number of Mi, greater than or equal to the current size.<br/>
        /// Example: 20Gi
        /// </summary>
        /// <example>20Gi</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Baseten.JsonConverters.OneOfJsonConverter<string, int?>))]
        public global::Baseten.OneOf<string, int?>? Size { get; set; }

        /// <summary>
        /// Labels replacing all current labels, not merged with them. Omit to keep them.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labels")]
        public global::System.Collections.Generic.Dictionary<string, string>? Labels { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSandboxVolumeRequestV1" /> class.
        /// </summary>
        /// <param name="size">
        /// New capacity, as a size (e.g. "20Gi") or a number of Mi, greater than or equal to the current size.<br/>
        /// Example: 20Gi
        /// </param>
        /// <param name="labels">
        /// Labels replacing all current labels, not merged with them. Omit to keep them.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateSandboxVolumeRequestV1(
            global::Baseten.OneOf<string, int?>? size,
            global::System.Collections.Generic.Dictionary<string, string>? labels)
        {
            this.Size = size;
            this.Labels = labels;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSandboxVolumeRequestV1" /> class.
        /// </summary>
        public UpdateSandboxVolumeRequestV1()
        {
        }

    }
}