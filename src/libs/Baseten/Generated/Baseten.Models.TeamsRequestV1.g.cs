
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Request parameters for listing teams.
    /// </summary>
    public sealed partial class TeamsRequestV1
    {
        /// <summary>
        /// When set, returns only the team with this exact name, if any.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamsRequestV1" /> class.
        /// </summary>
        /// <param name="name">
        /// When set, returns only the team with this exact name, if any.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TeamsRequestV1(
            string? name)
        {
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamsRequestV1" /> class.
        /// </summary>
        public TeamsRequestV1()
        {
        }

    }
}