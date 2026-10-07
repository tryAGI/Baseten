
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Environment variable with name and value<br/>
    /// Example: {"name":"NODE_ENV","secret":false,"value":"production"}
    /// </summary>
    public sealed partial class SandboxEnvV1
    {
        /// <summary>
        /// Name of the environment variable<br/>
        /// Example: NODE_ENV
        /// </summary>
        /// <example>NODE_ENV</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Whether the value is a secret<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret")]
        public bool? Secret { get; set; }

        /// <summary>
        /// Value of the environment variable<br/>
        /// Example: production
        /// </summary>
        /// <example>production</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public string? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxEnvV1" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the environment variable<br/>
        /// Example: NODE_ENV
        /// </param>
        /// <param name="secret">
        /// Whether the value is a secret<br/>
        /// Example: false
        /// </param>
        /// <param name="value">
        /// Value of the environment variable<br/>
        /// Example: production
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxEnvV1(
            string? name,
            bool? secret,
            string? value)
        {
            this.Name = name;
            this.Secret = secret;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxEnvV1" /> class.
        /// </summary>
        public SandboxEnvV1()
        {
        }

    }
}