
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A request to update the environment settings for a chainlet.
    /// </summary>
    public sealed partial class ChainletEnvironmentInstanceTypeUpdateV1
    {
        /// <summary>
        /// Name of the chainlet
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chainlet_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ChainletName { get; set; }

        /// <summary>
        /// Key of the instance type to use for the chainlet
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instance_type_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string InstanceTypeId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChainletEnvironmentInstanceTypeUpdateV1" /> class.
        /// </summary>
        /// <param name="chainletName">
        /// Name of the chainlet
        /// </param>
        /// <param name="instanceTypeId">
        /// Key of the instance type to use for the chainlet
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChainletEnvironmentInstanceTypeUpdateV1(
            string chainletName,
            string instanceTypeId)
        {
            this.ChainletName = chainletName ?? throw new global::System.ArgumentNullException(nameof(chainletName));
            this.InstanceTypeId = instanceTypeId ?? throw new global::System.ArgumentNullException(nameof(instanceTypeId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChainletEnvironmentInstanceTypeUpdateV1" /> class.
        /// </summary>
        public ChainletEnvironmentInstanceTypeUpdateV1()
        {
        }
    }
}