
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateSandboxPreviewTokenRequestV1
    {
        /// <summary>
        /// When true, return an existing unexpired token of this preview that stays valid at least until expires_at instead of creating a new one. Defaults to false when omitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("create_if_not_exists")]
        public bool? CreateIfNotExists { get; set; }

        /// <summary>
        /// Time at which the token stops working. Must be in the future.<br/>
        /// Example: 2026-10-13T12:00:00Z
        /// </summary>
        /// <example>2026-10-13T12:00:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime ExpiresAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSandboxPreviewTokenRequestV1" /> class.
        /// </summary>
        /// <param name="expiresAt">
        /// Time at which the token stops working. Must be in the future.<br/>
        /// Example: 2026-10-13T12:00:00Z
        /// </param>
        /// <param name="createIfNotExists">
        /// When true, return an existing unexpired token of this preview that stays valid at least until expires_at instead of creating a new one. Defaults to false when omitted.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateSandboxPreviewTokenRequestV1(
            global::System.DateTime expiresAt,
            bool? createIfNotExists)
        {
            this.CreateIfNotExists = createIfNotExists;
            this.ExpiresAt = expiresAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSandboxPreviewTokenRequestV1" /> class.
        /// </summary>
        public CreateSandboxPreviewTokenRequestV1()
        {
        }

    }
}