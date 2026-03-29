
#nullable enable

namespace Baseten
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InstanceTypeWithPriceV1
    {
        /// <summary>
        /// Instance type properties.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instance_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.InstanceTypeV1 InstanceType { get; set; }

        /// <summary>
        /// Usage price in USD / minute.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("price")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Price { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InstanceTypeWithPriceV1" /> class.
        /// </summary>
        /// <param name="instanceType">
        /// Instance type properties.
        /// </param>
        /// <param name="price">
        /// Usage price in USD / minute.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InstanceTypeWithPriceV1(
            global::Baseten.InstanceTypeV1 instanceType,
            double price)
        {
            this.InstanceType = instanceType ?? throw new global::System.ArgumentNullException(nameof(instanceType));
            this.Price = price;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InstanceTypeWithPriceV1" /> class.
        /// </summary>
        public InstanceTypeWithPriceV1()
        {
        }
    }
}