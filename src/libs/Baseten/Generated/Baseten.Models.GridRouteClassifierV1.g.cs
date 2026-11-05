
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
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Tradeoffs the route classifier supports. Empty when it supports all of them.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supported_tradeoffs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Baseten.GridRouteClassifierV1SupportedTradeoff> SupportedTradeoffs { get; set; }

        /// <summary>
        /// Model identities the route classifier picks from.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("decidable_models")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> DecidableModels { get; set; }

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
        /// <param name="name">
        /// Display name of the route classifier.
        /// </param>
        /// <param name="supportedTradeoffs">
        /// Tradeoffs the route classifier supports. Empty when it supports all of them.
        /// </param>
        /// <param name="decidableModels">
        /// Model identities the route classifier picks from.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GridRouteClassifierV1(
            string id,
            string name,
            global::System.Collections.Generic.IList<global::Baseten.GridRouteClassifierV1SupportedTradeoff> supportedTradeoffs,
            global::System.Collections.Generic.IList<string> decidableModels)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.SupportedTradeoffs = supportedTradeoffs ?? throw new global::System.ArgumentNullException(nameof(supportedTradeoffs));
            this.DecidableModels = decidableModels ?? throw new global::System.ArgumentNullException(nameof(decidableModels));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GridRouteClassifierV1" /> class.
        /// </summary>
        public GridRouteClassifierV1()
        {
        }

    }
}