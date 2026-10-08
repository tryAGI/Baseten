
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A tag identifying a version of a sandbox image.<br/>
    /// Example: {"name":"latest","created_at":"2026-09-16T21:20:00Z","updated_at":"2026-09-16T21:25:00Z","size":134217728}
    /// </summary>
    public sealed partial class SandboxImageTagV1
    {
        /// <summary>
        /// Image tag name.<br/>
        /// Example: latest
        /// </summary>
        /// <example>latest</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Time the tag was created.<br/>
        /// Included only in responses<br/>
        /// Example: 2026-09-16T21:20:00Z
        /// </summary>
        /// <example>2026-09-16T21:20:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Time the tag was last updated.<br/>
        /// Included only in responses<br/>
        /// Example: 2026-09-16T21:25:00Z
        /// </summary>
        /// <example>2026-09-16T21:25:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Image size in bytes.<br/>
        /// Included only in responses<br/>
        /// Example: 134217728
        /// </summary>
        /// <example>134217728</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        public long? Size { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxImageTagV1" /> class.
        /// </summary>
        /// <param name="name">
        /// Image tag name.<br/>
        /// Example: latest
        /// </param>
        /// <param name="createdAt">
        /// Time the tag was created.<br/>
        /// Included only in responses<br/>
        /// Example: 2026-09-16T21:20:00Z
        /// </param>
        /// <param name="updatedAt">
        /// Time the tag was last updated.<br/>
        /// Included only in responses<br/>
        /// Example: 2026-09-16T21:25:00Z
        /// </param>
        /// <param name="size">
        /// Image size in bytes.<br/>
        /// Included only in responses<br/>
        /// Example: 134217728
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxImageTagV1(
            string name,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt,
            long? size)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Size = size;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxImageTagV1" /> class.
        /// </summary>
        public SandboxImageTagV1()
        {
        }

    }
}