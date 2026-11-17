
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TrainingBDNMountResponseV1
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Source { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Path { get; set; }

        /// <summary>
        /// Relative glob patterns selecting files to mount; empty includes all files.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include")]
        public global::System.Collections.Generic.IList<string>? Include { get; set; }

        /// <summary>
        /// Relative glob patterns excluding files from the mount; exclusions win.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exclude")]
        public global::System.Collections.Generic.IList<string>? Exclude { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TrainingBDNMountResponseV1" /> class.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="path"></param>
        /// <param name="include">
        /// Relative glob patterns selecting files to mount; empty includes all files.
        /// </param>
        /// <param name="exclude">
        /// Relative glob patterns excluding files from the mount; exclusions win.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TrainingBDNMountResponseV1(
            string source,
            string path,
            global::System.Collections.Generic.IList<string>? include,
            global::System.Collections.Generic.IList<string>? exclude)
        {
            this.Source = source ?? throw new global::System.ArgumentNullException(nameof(source));
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.Include = include;
            this.Exclude = exclude;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrainingBDNMountResponseV1" /> class.
        /// </summary>
        public TrainingBDNMountResponseV1()
        {
        }

    }
}