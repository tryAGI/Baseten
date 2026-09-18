
#nullable enable

namespace Baseten
{
    /// <summary>
    /// The checkpoint's files are fetched as presigned URLs, page by page.
    /// </summary>
    public sealed partial class LoopsCheckpointS3SourceV1
    {
        /// <summary>
        /// Default Value: s3
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        public string? Kind { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LoopsCheckpointS3SourceV1" /> class.
        /// </summary>
        /// <param name="kind">
        /// Default Value: s3
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LoopsCheckpointS3SourceV1(
            string? kind)
        {
            this.Kind = kind;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LoopsCheckpointS3SourceV1" /> class.
        /// </summary>
        public LoopsCheckpointS3SourceV1()
        {
        }

    }
}