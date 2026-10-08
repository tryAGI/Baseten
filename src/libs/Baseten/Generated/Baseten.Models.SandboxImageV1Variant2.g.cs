
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SandboxImageV1Variant2
    {
        /// <summary>
        /// Empty for get summary responses. Use GET /sandboxes/images/{image_name}/tags to retrieve paginated image versions.<br/>
        /// Example: []
        /// </summary>
        /// <example>[]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Baseten.SandboxImageTagV1> Tags { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxImageV1Variant2" /> class.
        /// </summary>
        /// <param name="tags">
        /// Empty for get summary responses. Use GET /sandboxes/images/{image_name}/tags to retrieve paginated image versions.<br/>
        /// Example: []
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxImageV1Variant2(
            global::System.Collections.Generic.IList<global::Baseten.SandboxImageTagV1> tags)
        {
            this.Tags = tags ?? throw new global::System.ArgumentNullException(nameof(tags));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxImageV1Variant2" /> class.
        /// </summary>
        public SandboxImageV1Variant2()
        {
        }

    }
}