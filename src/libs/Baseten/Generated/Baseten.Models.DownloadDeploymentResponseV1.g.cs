
#nullable enable

namespace Baseten
{
    /// <summary>
    /// The response to a request to download a deployment's truss.
    /// </summary>
    public sealed partial class DownloadDeploymentResponseV1
    {
        /// <summary>
        /// Presigned URL to download the truss tar file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("download_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DownloadUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DownloadDeploymentResponseV1" /> class.
        /// </summary>
        /// <param name="downloadUrl">
        /// Presigned URL to download the truss tar file
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DownloadDeploymentResponseV1(
            string downloadUrl)
        {
            this.DownloadUrl = downloadUrl ?? throw new global::System.ArgumentNullException(nameof(downloadUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DownloadDeploymentResponseV1" /> class.
        /// </summary>
        public DownloadDeploymentResponseV1()
        {
        }
    }
}