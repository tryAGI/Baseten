
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A resource to select or check: a resource, or an environment by name.
    /// </summary>
    public sealed partial class AccessResourceRequestV1
    {
        /// <summary>
        /// Type of the resource
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Baseten.JsonConverters.AccessResourceTypeV1JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.AccessResourceTypeV1 Type { get; set; }

        /// <summary>
        /// Unique identifier of the resource, such as a model's ID, or the name of an environment, such as `production`, which needs no environment group
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("identifier")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Identifier { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AccessResourceRequestV1" /> class.
        /// </summary>
        /// <param name="type">
        /// Type of the resource
        /// </param>
        /// <param name="identifier">
        /// Unique identifier of the resource, such as a model's ID, or the name of an environment, such as `production`, which needs no environment group
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AccessResourceRequestV1(
            global::Baseten.AccessResourceTypeV1 type,
            string identifier)
        {
            this.Type = type;
            this.Identifier = identifier ?? throw new global::System.ArgumentNullException(nameof(identifier));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccessResourceRequestV1" /> class.
        /// </summary>
        public AccessResourceRequestV1()
        {
        }

    }
}