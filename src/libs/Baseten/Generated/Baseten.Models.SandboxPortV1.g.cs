
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A port for a resource<br/>
    /// Example: {"name":"http","protocol":"HTTP","target":3000}
    /// </summary>
    public sealed partial class SandboxPortV1
    {
        /// <summary>
        /// The name of the port<br/>
        /// Example: http
        /// </summary>
        /// <example>http</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The protocol of the port<br/>
        /// Example: HTTP
        /// </summary>
        /// <example>HTTP</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("protocol")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Baseten.JsonConverters.SandboxPortV1ProtocolJsonConverter))]
        public global::Baseten.SandboxPortV1Protocol? Protocol { get; set; }

        /// <summary>
        /// The target port of the port<br/>
        /// Example: 3000
        /// </summary>
        /// <example>3000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("target")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Target { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxPortV1" /> class.
        /// </summary>
        /// <param name="target">
        /// The target port of the port<br/>
        /// Example: 3000
        /// </param>
        /// <param name="name">
        /// The name of the port<br/>
        /// Example: http
        /// </param>
        /// <param name="protocol">
        /// The protocol of the port<br/>
        /// Example: HTTP
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxPortV1(
            int target,
            string? name,
            global::Baseten.SandboxPortV1Protocol? protocol)
        {
            this.Name = name;
            this.Protocol = protocol;
            this.Target = target;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxPortV1" /> class.
        /// </summary>
        public SandboxPortV1()
        {
        }

    }
}