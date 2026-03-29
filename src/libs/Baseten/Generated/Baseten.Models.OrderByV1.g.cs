
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A request to order training jobs.
    /// </summary>
    public sealed partial class OrderByV1
    {
        /// <summary>
        /// The field to order by.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("field")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Field { get; set; }

        /// <summary>
        /// The direction to order by.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("order")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Order { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrderByV1" /> class.
        /// </summary>
        /// <param name="field">
        /// The field to order by.
        /// </param>
        /// <param name="order">
        /// The direction to order by.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrderByV1(
            string field,
            string order)
        {
            this.Field = field ?? throw new global::System.ArgumentNullException(nameof(field));
            this.Order = order ?? throw new global::System.ArgumentNullException(nameof(order));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrderByV1" /> class.
        /// </summary>
        public OrderByV1()
        {
        }
    }
}