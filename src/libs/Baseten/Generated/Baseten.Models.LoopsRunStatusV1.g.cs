
#nullable enable

namespace Baseten
{
    /// <summary>
    /// The current status of a Loops run.
    /// </summary>
    public sealed partial class LoopsRunStatusV1
    {
        /// <summary>
        /// ACTIVE while the run is live; INACTIVE once replaced by a newer run or shut down.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Baseten.JsonConverters.LoopsRunStatusNameV1JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.LoopsRunStatusNameV1 Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LoopsRunStatusV1" /> class.
        /// </summary>
        /// <param name="name">
        /// ACTIVE while the run is live; INACTIVE once replaced by a newer run or shut down.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LoopsRunStatusV1(
            global::Baseten.LoopsRunStatusNameV1 name)
        {
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LoopsRunStatusV1" /> class.
        /// </summary>
        public LoopsRunStatusV1()
        {
        }

    }
}