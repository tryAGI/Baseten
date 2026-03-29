
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A list of chains.
    /// </summary>
    public sealed partial class ChainsV1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chains")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Baseten.ChainV1> Chains { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChainsV1" /> class.
        /// </summary>
        /// <param name="chains"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChainsV1(
            global::System.Collections.Generic.IList<global::Baseten.ChainV1> chains)
        {
            this.Chains = chains ?? throw new global::System.ArgumentNullException(nameof(chains));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChainsV1" /> class.
        /// </summary>
        public ChainsV1()
        {
        }
    }
}