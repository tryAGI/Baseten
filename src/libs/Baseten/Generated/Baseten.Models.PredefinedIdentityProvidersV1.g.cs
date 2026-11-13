
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PredefinedIdentityProvidersV1
    {
        /// <summary>
        /// Identity providers Baseten supports
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Baseten.PredefinedIdentityProviderV1> Items { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PredefinedIdentityProvidersV1" /> class.
        /// </summary>
        /// <param name="items">
        /// Identity providers Baseten supports
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PredefinedIdentityProvidersV1(
            global::System.Collections.Generic.IList<global::Baseten.PredefinedIdentityProviderV1> items)
        {
            this.Items = items ?? throw new global::System.ArgumentNullException(nameof(items));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PredefinedIdentityProvidersV1" /> class.
        /// </summary>
        public PredefinedIdentityProvidersV1()
        {
        }

    }
}