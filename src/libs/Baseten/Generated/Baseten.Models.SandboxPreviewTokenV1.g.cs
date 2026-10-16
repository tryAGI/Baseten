
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Access token for a private preview.
    /// </summary>
    public sealed partial class SandboxPreviewTokenV1
    {
        /// <summary>
        /// Token name, used in token_name path parameters.<br/>
        /// Example: 7f3k2m9q1x8c4v6b0n5z
        /// </summary>
        /// <example>7f3k2m9q1x8c4v6b0n5z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Value to send as the bl_preview_token query parameter.<br/>
        /// Example: 7f3k2m9q1x8c4v6b0n5z
        /// </summary>
        /// <example>7f3k2m9q1x8c4v6b0n5z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Token { get; set; }

        /// <summary>
        /// Example: 2026-10-13T12:00:00Z
        /// </summary>
        /// <example>2026-10-13T12:00:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime ExpiresAt { get; set; }

        /// <summary>
        /// Whether expires_at has passed.<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("expired")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Expired { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxPreviewTokenV1" /> class.
        /// </summary>
        /// <param name="name">
        /// Token name, used in token_name path parameters.<br/>
        /// Example: 7f3k2m9q1x8c4v6b0n5z
        /// </param>
        /// <param name="token">
        /// Value to send as the bl_preview_token query parameter.<br/>
        /// Example: 7f3k2m9q1x8c4v6b0n5z
        /// </param>
        /// <param name="expiresAt">
        /// Example: 2026-10-13T12:00:00Z
        /// </param>
        /// <param name="expired">
        /// Whether expires_at has passed.<br/>
        /// Example: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxPreviewTokenV1(
            string name,
            string token,
            global::System.DateTime expiresAt,
            bool expired)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Token = token ?? throw new global::System.ArgumentNullException(nameof(token));
            this.ExpiresAt = expiresAt;
            this.Expired = expired;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxPreviewTokenV1" /> class.
        /// </summary>
        public SandboxPreviewTokenV1()
        {
        }

    }
}