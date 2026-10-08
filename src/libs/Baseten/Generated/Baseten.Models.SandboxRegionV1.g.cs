
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SandboxRegionV1
    {
        /// <summary>
        /// Public region identifier to use when creating a sandbox.<br/>
        /// Example: us-was-1
        /// </summary>
        /// <example>us-was-1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Country code.<br/>
        /// Example: us
        /// </summary>
        /// <example>us</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("country")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Country { get; set; }

        /// <summary>
        /// Continent code.<br/>
        /// Example: na
        /// </summary>
        /// <example>na</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("continent")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Continent { get; set; }

        /// <summary>
        /// Region location.<br/>
        /// Example: Washington
        /// </summary>
        /// <example>Washington</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("location")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Location { get; set; }

        /// <summary>
        /// Runtime generation supported by this region, using the public name CARBON. Actual runtime selection depends on the team and sandbox configuration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("info_generation")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Baseten.JsonConverters.SandboxRegionV1InfoGenerationJsonConverter))]
        public global::Baseten.SandboxRegionV1InfoGeneration InfoGeneration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxRegionV1" /> class.
        /// </summary>
        /// <param name="name">
        /// Public region identifier to use when creating a sandbox.<br/>
        /// Example: us-was-1
        /// </param>
        /// <param name="country">
        /// Country code.<br/>
        /// Example: us
        /// </param>
        /// <param name="continent">
        /// Continent code.<br/>
        /// Example: na
        /// </param>
        /// <param name="location">
        /// Region location.<br/>
        /// Example: Washington
        /// </param>
        /// <param name="infoGeneration">
        /// Runtime generation supported by this region, using the public name CARBON. Actual runtime selection depends on the team and sandbox configuration.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxRegionV1(
            string name,
            string country,
            string continent,
            string location,
            global::Baseten.SandboxRegionV1InfoGeneration infoGeneration)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Country = country ?? throw new global::System.ArgumentNullException(nameof(country));
            this.Continent = continent ?? throw new global::System.ArgumentNullException(nameof(continent));
            this.Location = location ?? throw new global::System.ArgumentNullException(nameof(location));
            this.InfoGeneration = infoGeneration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxRegionV1" /> class.
        /// </summary>
        public SandboxRegionV1()
        {
        }

    }
}