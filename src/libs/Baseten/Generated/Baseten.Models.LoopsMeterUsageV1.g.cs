
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class LoopsMeterUsageV1
    {
        /// <summary>
        /// Tokens billed on this meter
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Tokens { get; set; }

        /// <summary>
        /// Cost of those tokens in dollars
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subtotal")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Baseten.JsonConverters.AnyOfJsonConverter<double?, string>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.AnyOf<double?, string> Subtotal { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LoopsMeterUsageV1" /> class.
        /// </summary>
        /// <param name="tokens">
        /// Tokens billed on this meter
        /// </param>
        /// <param name="subtotal">
        /// Cost of those tokens in dollars
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LoopsMeterUsageV1(
            int tokens,
            global::Baseten.AnyOf<double?, string> subtotal)
        {
            this.Tokens = tokens;
            this.Subtotal = subtotal;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LoopsMeterUsageV1" /> class.
        /// </summary>
        public LoopsMeterUsageV1()
        {
        }

    }
}