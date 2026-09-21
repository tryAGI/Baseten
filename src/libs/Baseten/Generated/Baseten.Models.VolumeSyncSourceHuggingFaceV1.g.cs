
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Hugging Face source.
    /// </summary>
    public sealed partial class VolumeSyncSourceHuggingFaceV1
    {
        /// <summary>
        /// Remote source URI to materialize into the destination volume.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uri")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Uri { get; set; }

        /// <summary>
        /// Glob patterns selecting files to include.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include")]
        public global::System.Collections.Generic.IList<string>? Include { get; set; }

        /// <summary>
        /// Glob patterns selecting files to exclude.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exclude")]
        public global::System.Collections.Generic.IList<string>? Exclude { get; set; }

        /// <summary>
        /// Optional workspace secret containing credentials for this source.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_secret_name")]
        public string? AuthSecretName { get; set; }

        /// <summary>
        /// Hugging Face source type.
        /// </summary>
        /// <default>"HUGGING_FACE"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "HUGGING_FACE";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VolumeSyncSourceHuggingFaceV1" /> class.
        /// </summary>
        /// <param name="uri">
        /// Remote source URI to materialize into the destination volume.
        /// </param>
        /// <param name="include">
        /// Glob patterns selecting files to include.
        /// </param>
        /// <param name="exclude">
        /// Glob patterns selecting files to exclude.
        /// </param>
        /// <param name="authSecretName">
        /// Optional workspace secret containing credentials for this source.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="type">
        /// Hugging Face source type.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VolumeSyncSourceHuggingFaceV1(
            string uri,
            global::System.Collections.Generic.IList<string>? include,
            global::System.Collections.Generic.IList<string>? exclude,
            string? authSecretName,
            string type = "HUGGING_FACE")
        {
            this.Uri = uri ?? throw new global::System.ArgumentNullException(nameof(uri));
            this.Include = include;
            this.Exclude = exclude;
            this.AuthSecretName = authSecretName;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VolumeSyncSourceHuggingFaceV1" /> class.
        /// </summary>
        public VolumeSyncSourceHuggingFaceV1()
        {
        }

        /// <summary>
        /// Creates a new <see cref="VolumeSyncSourceHuggingFaceV1"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static VolumeSyncSourceHuggingFaceV1 FromUri(string uri)
        {
            return new VolumeSyncSourceHuggingFaceV1
            {
                Uri = uri,
            };
        }

    }
}