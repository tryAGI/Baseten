
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Optional settings suggested when creating a sandbox from this image.
    /// </summary>
    public sealed partial class SandboxLibraryImageCreationOptionsV1
    {
        /// <summary>
        /// Kernel selection arguments.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extra_args")]
        public global::System.Collections.Generic.Dictionary<string, string>? ExtraArgs { get; set; }

        /// <summary>
        /// Volume attachments.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("volumes")]
        public global::System.Collections.Generic.IList<global::Baseten.SandboxLibraryImageVolumeV1>? Volumes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxLibraryImageCreationOptionsV1" /> class.
        /// </summary>
        /// <param name="extraArgs">
        /// Kernel selection arguments.
        /// </param>
        /// <param name="volumes">
        /// Volume attachments.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxLibraryImageCreationOptionsV1(
            global::System.Collections.Generic.Dictionary<string, string>? extraArgs,
            global::System.Collections.Generic.IList<global::Baseten.SandboxLibraryImageVolumeV1>? volumes)
        {
            this.ExtraArgs = extraArgs;
            this.Volumes = volumes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxLibraryImageCreationOptionsV1" /> class.
        /// </summary>
        public SandboxLibraryImageCreationOptionsV1()
        {
        }

    }
}