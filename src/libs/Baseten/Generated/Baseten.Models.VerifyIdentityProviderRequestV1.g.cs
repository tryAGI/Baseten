
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Request to check an identity provider before adding it.
    /// </summary>
    public sealed partial class VerifyIdentityProviderRequestV1
    {
        /// <summary>
        /// The predefined provider to check, as you'd pass it when adding it
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("predefined")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.VerifyPredefinedIdentityProviderConfigV1 Predefined { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VerifyIdentityProviderRequestV1" /> class.
        /// </summary>
        /// <param name="predefined">
        /// The predefined provider to check, as you'd pass it when adding it
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VerifyIdentityProviderRequestV1(
            global::Baseten.VerifyPredefinedIdentityProviderConfigV1 predefined)
        {
            this.Predefined = predefined ?? throw new global::System.ArgumentNullException(nameof(predefined));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VerifyIdentityProviderRequestV1" /> class.
        /// </summary>
        public VerifyIdentityProviderRequestV1()
        {
        }

    }
}