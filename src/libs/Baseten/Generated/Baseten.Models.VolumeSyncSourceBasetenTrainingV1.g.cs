
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Baseten training artifact source.
    /// </summary>
    public sealed partial class VolumeSyncSourceBasetenTrainingV1
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
        /// Baseten training artifact source type.
        /// </summary>
        /// <default>"BASETEN_TRAINING"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "BASETEN_TRAINING";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VolumeSyncSourceBasetenTrainingV1" /> class.
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
        /// <param name="type">
        /// Baseten training artifact source type.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VolumeSyncSourceBasetenTrainingV1(
            string uri,
            global::System.Collections.Generic.IList<string>? include,
            global::System.Collections.Generic.IList<string>? exclude,
            string type = "BASETEN_TRAINING")
        {
            this.Uri = uri ?? throw new global::System.ArgumentNullException(nameof(uri));
            this.Include = include;
            this.Exclude = exclude;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VolumeSyncSourceBasetenTrainingV1" /> class.
        /// </summary>
        public VolumeSyncSourceBasetenTrainingV1()
        {
        }

        /// <summary>
        /// Creates a new <see cref="VolumeSyncSourceBasetenTrainingV1"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static VolumeSyncSourceBasetenTrainingV1 FromUri(string uri)
        {
            return new VolumeSyncSourceBasetenTrainingV1
            {
                Uri = uri,
            };
        }

    }
}