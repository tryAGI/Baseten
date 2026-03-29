
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A request to update the instance types for chainlets in an environment. Multiples<br/>
    /// updates can be made in one request. The updates will be processed in batch and a new deployment<br/>
    /// will be created, deployed and promoted into the environment.
    /// </summary>
    public sealed partial class UpdateChainletEnvironmentInstanceTypeRequestV1
    {
        /// <summary>
        /// Mapping of chainlet name to the desired chainlet instance type. If the chainlet name doesn't exist, an error is returned.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updates")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Baseten.ChainletEnvironmentInstanceTypeUpdateV1> Updates { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateChainletEnvironmentInstanceTypeRequestV1" /> class.
        /// </summary>
        /// <param name="updates">
        /// Mapping of chainlet name to the desired chainlet instance type. If the chainlet name doesn't exist, an error is returned.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateChainletEnvironmentInstanceTypeRequestV1(
            global::System.Collections.Generic.IList<global::Baseten.ChainletEnvironmentInstanceTypeUpdateV1> updates)
        {
            this.Updates = updates ?? throw new global::System.ArgumentNullException(nameof(updates));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateChainletEnvironmentInstanceTypeRequestV1" /> class.
        /// </summary>
        public UpdateChainletEnvironmentInstanceTypeRequestV1()
        {
        }
    }
}