
#nullable enable

namespace Baseten
{
    /// <summary>
    /// The response to a request to cancel a promotion.
    /// </summary>
    public sealed partial class CancelPromotionResponseV1
    {
        /// <summary>
        /// Status of the request to cancel a promotion. Can be CANCELED or RAMPING_DOWN.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Baseten.JsonConverters.CancelPromotionStatusV1JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.CancelPromotionStatusV1 Status { get; set; }

        /// <summary>
        /// A message describing the status of the request to cancel a promotion
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CancelPromotionResponseV1" /> class.
        /// </summary>
        /// <param name="status">
        /// Status of the request to cancel a promotion. Can be CANCELED or RAMPING_DOWN.
        /// </param>
        /// <param name="message">
        /// A message describing the status of the request to cancel a promotion
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CancelPromotionResponseV1(
            global::Baseten.CancelPromotionStatusV1 status,
            string message)
        {
            this.Status = status;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CancelPromotionResponseV1" /> class.
        /// </summary>
        public CancelPromotionResponseV1()
        {
        }
    }
}