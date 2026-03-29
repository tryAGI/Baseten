
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Weight source configuration for MDN (Model Distribution Network).<br/>
    /// Enables training jobs to mount external model weights from HuggingFace, S3, GCS, or R2<br/>
    /// via MDN's caching and CSI mounting infrastructure. Weights are mirrored once and<br/>
    /// deduplicated across training jobs.
    /// </summary>
    public sealed partial class CreateJobWeightConfigV1
    {
        /// <summary>
        /// Weight source URI. Supported formats: hf://, s3://, gs://, r2://
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Source { get; set; }

        /// <summary>
        /// Path where weights will be mounted in the container
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mount_location")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MountLocation { get; set; }

        /// <summary>
        /// File patterns to include (Unix-style shell patterns)<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_patterns")]
        public global::System.Collections.Generic.IList<string>? AllowPatterns { get; set; }

        /// <summary>
        /// File patterns to exclude (Unix-style shell patterns)<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ignore_patterns")]
        public global::System.Collections.Generic.IList<string>? IgnorePatterns { get; set; }

        /// <summary>
        /// Name of the workspace secret for authentication (e.g., HuggingFace token)<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_secret_name")]
        public string? AuthSecretName { get; set; }

        /// <summary>
        /// Authentication configuration for the weight source.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth")]
        public object? Auth { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateJobWeightConfigV1" /> class.
        /// </summary>
        /// <param name="source">
        /// Weight source URI. Supported formats: hf://, s3://, gs://, r2://
        /// </param>
        /// <param name="mountLocation">
        /// Path where weights will be mounted in the container
        /// </param>
        /// <param name="allowPatterns">
        /// File patterns to include (Unix-style shell patterns)<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="ignorePatterns">
        /// File patterns to exclude (Unix-style shell patterns)<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="authSecretName">
        /// Name of the workspace secret for authentication (e.g., HuggingFace token)<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="auth">
        /// Authentication configuration for the weight source.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateJobWeightConfigV1(
            string source,
            string mountLocation,
            global::System.Collections.Generic.IList<string>? allowPatterns,
            global::System.Collections.Generic.IList<string>? ignorePatterns,
            string? authSecretName,
            object? auth)
        {
            this.Source = source ?? throw new global::System.ArgumentNullException(nameof(source));
            this.MountLocation = mountLocation ?? throw new global::System.ArgumentNullException(nameof(mountLocation));
            this.AllowPatterns = allowPatterns;
            this.IgnorePatterns = ignorePatterns;
            this.AuthSecretName = authSecretName;
            this.Auth = auth;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateJobWeightConfigV1" /> class.
        /// </summary>
        public CreateJobWeightConfigV1()
        {
        }
    }
}