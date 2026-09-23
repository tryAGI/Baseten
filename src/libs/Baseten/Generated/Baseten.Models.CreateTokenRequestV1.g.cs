
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateTokenRequestV1
    {
        /// <summary>
        /// What the token should grant access to. Only `sandboxes` is supported today; the token then authenticates against the sandbox API.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scopes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Baseten.TokenScopeV1> Scopes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTokenRequestV1" /> class.
        /// </summary>
        /// <param name="scopes">
        /// What the token should grant access to. Only `sandboxes` is supported today; the token then authenticates against the sandbox API.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTokenRequestV1(
            global::System.Collections.Generic.IList<global::Baseten.TokenScopeV1> scopes)
        {
            this.Scopes = scopes ?? throw new global::System.ArgumentNullException(nameof(scopes));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTokenRequestV1" /> class.
        /// </summary>
        public CreateTokenRequestV1()
        {
        }

    }
}