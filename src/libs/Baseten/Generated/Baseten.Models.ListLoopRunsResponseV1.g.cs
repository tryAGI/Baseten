
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Runs matching the query filters.
    /// </summary>
    public sealed partial class ListLoopRunsResponseV1
    {
        /// <summary>
        /// List of runs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("runs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Baseten.LoopRunListItemV1> Runs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListLoopRunsResponseV1" /> class.
        /// </summary>
        /// <param name="runs">
        /// List of runs.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListLoopRunsResponseV1(
            global::System.Collections.Generic.IList<global::Baseten.LoopRunListItemV1> runs)
        {
            this.Runs = runs ?? throw new global::System.ArgumentNullException(nameof(runs));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListLoopRunsResponseV1" /> class.
        /// </summary>
        public ListLoopRunsResponseV1()
        {
        }
    }
}