
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A response that includes the artifacts for a training job
    /// </summary>
    public sealed partial class DownloadTrainingJobResponseV1
    {
        /// <summary>
        /// Presigned URL's for the artifacts
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("artifact_presigned_urls")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> ArtifactPresignedUrls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DownloadTrainingJobResponseV1" /> class.
        /// </summary>
        /// <param name="artifactPresignedUrls">
        /// Presigned URL's for the artifacts
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DownloadTrainingJobResponseV1(
            global::System.Collections.Generic.IList<string> artifactPresignedUrls)
        {
            this.ArtifactPresignedUrls = artifactPresignedUrls ?? throw new global::System.ArgumentNullException(nameof(artifactPresignedUrls));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DownloadTrainingJobResponseV1" /> class.
        /// </summary>
        public DownloadTrainingJobResponseV1()
        {
        }
    }
}