
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Volume attachment suggested by a built-in image.
    /// </summary>
    public sealed partial class SandboxLibraryImageVolumeV1
    {
        /// <summary>
        /// Volume name, or an internal identifier for ephemeral volumes.<br/>
        /// Example: scratch
        /// </summary>
        /// <example>scratch</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Absolute filesystem path where the volume is mounted.<br/>
        /// Example: /mnt/data
        /// </summary>
        /// <example>/mnt/data</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("mount_path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MountPath { get; set; }

        /// <summary>
        /// Volume type, persistent when empty.<br/>
        /// Example: ephemeral
        /// </summary>
        /// <example>ephemeral</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Storage capacity in megabytes for ephemeral volumes.<br/>
        /// Example: 10240
        /// </summary>
        /// <example>10240</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("size_mb")]
        public long? SizeMb { get; set; }

        /// <summary>
        /// Whether the volume is mounted read-only.<br/>
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
        /// Initializes a new instance of the <see cref="SandboxLibraryImageVolumeV1" /> class.
        /// </summary>
        /// <param name="name">
        /// Volume name, or an internal identifier for ephemeral volumes.<br/>
        /// Example: scratch
        /// </param>
        /// <param name="mountPath">
        /// Absolute filesystem path where the volume is mounted.<br/>
        /// Example: /mnt/data
        /// </param>
        /// <param name="type">
        /// Volume type, persistent when empty.<br/>
        /// Example: ephemeral
        /// </param>
        /// <param name="sizeMb">
        /// Storage capacity in megabytes for ephemeral volumes.<br/>
        /// Example: 10240
        /// </param>
        /// <param name="readOnly">
        /// Whether the volume is mounted read-only.<br/>
        /// Example: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxLibraryImageVolumeV1(
            string name,
            string mountPath,
            string? type,
            long? sizeMb,
            bool? readOnly)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.MountPath = mountPath ?? throw new global::System.ArgumentNullException(nameof(mountPath));
            this.Type = type;
            this.SizeMb = sizeMb;
            this.ReadOnly = readOnly;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxLibraryImageVolumeV1" /> class.
        /// </summary>
        public SandboxLibraryImageVolumeV1()
        {
        }

    }
}