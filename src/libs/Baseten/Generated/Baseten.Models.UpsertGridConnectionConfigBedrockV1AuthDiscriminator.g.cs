
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpsertGridConnectionConfigBedrockV1AuthDiscriminator
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Baseten.JsonConverters.UpsertGridConnectionConfigBedrockV1AuthDiscriminatorMethodJsonConverter))]
        public global::Baseten.UpsertGridConnectionConfigBedrockV1AuthDiscriminatorMethod? Method { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpsertGridConnectionConfigBedrockV1AuthDiscriminator" /> class.
        /// </summary>
        /// <param name="method"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpsertGridConnectionConfigBedrockV1AuthDiscriminator(
            global::Baseten.UpsertGridConnectionConfigBedrockV1AuthDiscriminatorMethod? method)
        {
            this.Method = method;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpsertGridConnectionConfigBedrockV1AuthDiscriminator" /> class.
        /// </summary>
        public UpsertGridConnectionConfigBedrockV1AuthDiscriminator()
        {
        }

    }
}