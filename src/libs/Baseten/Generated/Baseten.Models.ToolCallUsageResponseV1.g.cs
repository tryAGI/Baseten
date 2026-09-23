
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Daily server-side tool call usage, ordered by day, provider, sku, and model.
    /// </summary>
    public sealed partial class ToolCallUsageResponseV1
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        public global::System.Collections.Generic.IList<global::Baseten.ToolCallUsageBucketV1>? Items { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolCallUsageResponseV1" /> class.
        /// </summary>
        /// <param name="items"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolCallUsageResponseV1(
            global::System.Collections.Generic.IList<global::Baseten.ToolCallUsageBucketV1>? items)
        {
            this.Items = items;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolCallUsageResponseV1" /> class.
        /// </summary>
        public ToolCallUsageResponseV1()
        {
        }

    }
}