
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Body for creating a model via `POST /v1/models`.
    /// </summary>
    public sealed partial class CreateModelRequestV1
    {
        /// <summary>
        /// Where the new model is created from.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Baseten.JsonConverters.SourceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.Source Source { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateModelRequestV1" /> class.
        /// </summary>
        /// <param name="source">
        /// Where the new model is created from.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateModelRequestV1(
            global::Baseten.Source source)
        {
            this.Source = source;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateModelRequestV1" /> class.
        /// </summary>
        public CreateModelRequestV1()
        {
        }

    }
}