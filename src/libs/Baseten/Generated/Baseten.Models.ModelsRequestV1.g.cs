
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Request parameters for listing models.
    /// </summary>
    public sealed partial class ModelsRequestV1
    {
        /// <summary>
        /// When set, returns only models with this exact name, if any. On a team-scoped route this matches at most one model; on the org-wide route it may match models in multiple teams, since names are unique only within a team.<br/>
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
        /// Initializes a new instance of the <see cref="ModelsRequestV1" /> class.
        /// </summary>
        /// <param name="name">
        /// When set, returns only models with this exact name, if any. On a team-scoped route this matches at most one model; on the org-wide route it may match models in multiple teams, since names are unique only within a team.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelsRequestV1(
            string? name)
        {
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelsRequestV1" /> class.
        /// </summary>
        public ModelsRequestV1()
        {
        }

    }
}