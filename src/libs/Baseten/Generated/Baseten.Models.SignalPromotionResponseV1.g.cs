
#nullable enable

namespace Baseten
{
    /// <summary>
    /// The response to a request to signal a rolling promotion.
    /// </summary>
    public sealed partial class SignalPromotionResponseV1
    {
        /// <summary>
        /// Whether the signal was successfully sent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Success { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SignalPromotionResponseV1" /> class.
        /// </summary>
        /// <param name="success">
        /// Whether the signal was successfully sent
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SignalPromotionResponseV1(
            bool success)
        {
            this.Success = success;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SignalPromotionResponseV1" /> class.
        /// </summary>
        public SignalPromotionResponseV1()
        {
        }
    }
}