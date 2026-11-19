
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GridRouteClassifierV1
    {
        /// <summary>
        /// Stable route classifier identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Display name of the route classifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DisplayName { get; set; }

        /// <summary>
        /// Tradeoffs the route classifier supports. Empty when it supports all of them.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supported_tradeoffs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Baseten.GridRouteClassifierV1SupportedTradeoff> SupportedTradeoffs { get; set; }

        /// <summary>
        /// Canonical model ids the route classifier picks from.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("decidable_canonical_model_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> DecidableCanonicalModelIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GridRouteClassifierV1" /> class.
        /// </summary>
        /// <param name="id">
        /// Stable route classifier identifier.
        /// </param>
        /// <param name="displayName">
        /// Display name of the route classifier.
        /// </param>
        /// <param name="supportedTradeoffs">
        /// Tradeoffs the route classifier supports. Empty when it supports all of them.
        /// </param>
        /// <param name="decidableCanonicalModelIds">
        /// Canonical model ids the route classifier picks from.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GridRouteClassifierV1(
            string id,
            string displayName,
            global::System.Collections.Generic.IList<global::Baseten.GridRouteClassifierV1SupportedTradeoff> supportedTradeoffs,
            global::System.Collections.Generic.IList<string> decidableCanonicalModelIds)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.DisplayName = displayName ?? throw new global::System.ArgumentNullException(nameof(displayName));
            this.SupportedTradeoffs = supportedTradeoffs ?? throw new global::System.ArgumentNullException(nameof(supportedTradeoffs));
            this.DecidableCanonicalModelIds = decidableCanonicalModelIds ?? throw new global::System.ArgumentNullException(nameof(decidableCanonicalModelIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GridRouteClassifierV1" /> class.
        /// </summary>
        public GridRouteClassifierV1()
        {
        }

    }
}