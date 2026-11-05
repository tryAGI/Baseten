
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Authentication using a Hugging Face trusted publisher and Baseten workload identity.
    /// </summary>
    public sealed partial class VolumeSyncAuthenticationHuggingFaceOIDCV1
    {
        /// <summary>
        /// Hugging Face username for an account CI/CD identity, or namespace/repository for a repository trusted publisher. Configure trust in Hugging Face before starting the sync.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resource")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Resource { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VolumeSyncAuthenticationHuggingFaceOIDCV1" /> class.
        /// </summary>
        /// <param name="resource">
        /// Hugging Face username for an account CI/CD identity, or namespace/repository for a repository trusted publisher. Configure trust in Hugging Face before starting the sync.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VolumeSyncAuthenticationHuggingFaceOIDCV1(
            string resource)
        {
            this.Resource = resource ?? throw new global::System.ArgumentNullException(nameof(resource));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VolumeSyncAuthenticationHuggingFaceOIDCV1" /> class.
        /// </summary>
        public VolumeSyncAuthenticationHuggingFaceOIDCV1()
        {
        }

    }
}