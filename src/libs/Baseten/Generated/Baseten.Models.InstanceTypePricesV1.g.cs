
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A list of instance types.
    /// </summary>
    public sealed partial class InstanceTypePricesV1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instance_types")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Baseten.InstanceTypeWithPriceV1> InstanceTypes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InstanceTypePricesV1" /> class.
        /// </summary>
        /// <param name="instanceTypes"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InstanceTypePricesV1(
            global::System.Collections.Generic.IList<global::Baseten.InstanceTypeWithPriceV1> instanceTypes)
        {
            this.InstanceTypes = instanceTypes ?? throw new global::System.ArgumentNullException(nameof(instanceTypes));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InstanceTypePricesV1" /> class.
        /// </summary>
        public InstanceTypePricesV1()
        {
        }
    }
}