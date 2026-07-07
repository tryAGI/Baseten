
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A response with presigned URLs for a training job's artifacts.
    /// </summary>
    public sealed partial class DownloadTrainingJobResponseV1
    {
        /// <summary>
        /// Presigned URLs for the job's uploaded artifacts.
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
        /// Presigned URLs for the job's uploaded artifacts.
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