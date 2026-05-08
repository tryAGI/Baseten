
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Response for ``GET /v1/loops/runs/&lt;run_id&gt;``.
    /// </summary>
    public sealed partial class GetLoopRunResponseV1
    {
        /// <summary>
        /// The Loops run with its associated sampler.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.LoopRunV1 Run { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetLoopRunResponseV1" /> class.
        /// </summary>
        /// <param name="run">
        /// The Loops run with its associated sampler.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetLoopRunResponseV1(
            global::Baseten.LoopRunV1 run)
        {
            this.Run = run ?? throw new global::System.ArgumentNullException(nameof(run));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetLoopRunResponseV1" /> class.
        /// </summary>
        public GetLoopRunResponseV1()
        {
        }
    }
}