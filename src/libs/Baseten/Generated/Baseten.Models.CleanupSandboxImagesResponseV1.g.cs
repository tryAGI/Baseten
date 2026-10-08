
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Result of cleaning up unused sandbox images.<br/>
    /// Example: {"deleted":3,"message":"Removed 3 unused image versions. Image versions used by active sandboxes were retained."}
    /// </summary>
    public sealed partial class CleanupSandboxImagesResponseV1
    {
        /// <summary>
        /// Number of image versions removed.<br/>
        /// Example: 3
        /// </summary>
        /// <example>3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleted")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Deleted { get; set; }

        /// <summary>
        /// Human-readable cleanup result.<br/>
        /// Example: Removed 3 unused image versions. Image versions used by active sandboxes were retained.
        /// </summary>
        /// <example>Removed 3 unused image versions. Image versions used by active sandboxes were retained.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CleanupSandboxImagesResponseV1" /> class.
        /// </summary>
        /// <param name="deleted">
        /// Number of image versions removed.<br/>
        /// Example: 3
        /// </param>
        /// <param name="message">
        /// Human-readable cleanup result.<br/>
        /// Example: Removed 3 unused image versions. Image versions used by active sandboxes were retained.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CleanupSandboxImagesResponseV1(
            int deleted,
            string message)
        {
            this.Deleted = deleted;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CleanupSandboxImagesResponseV1" /> class.
        /// </summary>
        public CleanupSandboxImagesResponseV1()
        {
        }

    }
}