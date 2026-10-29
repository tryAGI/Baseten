
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A persistent volume mounted in the sandbox. The volume must exist, be in the sandbox's region and not be mounted elsewhere. A sandbox mounts at most one persistent volume.<br/>
    /// Example: {"name":"datasets","mount_path":"/data","read_only":false}
    /// </summary>
    public sealed partial class SandboxVolumeAttachmentV1
    {
        /// <summary>
        /// Name of the volume to mount.<br/>
        /// Example: datasets
        /// </summary>
        /// <example>datasets</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Absolute path where the volume is mounted in the sandbox.<br/>
        /// Example: /data
        /// </summary>
        /// <example>/data</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("mount_path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MountPath { get; set; }

        /// <summary>
        /// Mount the volume read-only. Defaults to false.<br/>
        /// Default Value: false<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("read_only")]
        public bool? ReadOnly { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxVolumeAttachmentV1" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the volume to mount.<br/>
        /// Example: datasets
        /// </param>
        /// <param name="mountPath">
        /// Absolute path where the volume is mounted in the sandbox.<br/>
        /// Example: /data
        /// </param>
        /// <param name="readOnly">
        /// Mount the volume read-only. Defaults to false.<br/>
        /// Default Value: false<br/>
        /// Example: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxVolumeAttachmentV1(
            string name,
            string mountPath,
            bool? readOnly)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.MountPath = mountPath ?? throw new global::System.ArgumentNullException(nameof(mountPath));
            this.ReadOnly = readOnly;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxVolumeAttachmentV1" /> class.
        /// </summary>
        public SandboxVolumeAttachmentV1()
        {
        }

    }
}