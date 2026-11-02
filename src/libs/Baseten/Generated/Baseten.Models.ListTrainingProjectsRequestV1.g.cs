
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A request to list training projects.
    /// </summary>
    public sealed partial class ListTrainingProjectsRequestV1
    {
        /// <summary>
        /// Return only the project with this exact name.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Opaque cursor from the pagination.cursor field of a previous response. Omit both cursor and limit to get every project in one response.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cursor")]
        public string? Cursor { get; set; }

        /// <summary>
        /// Maximum number of projects to return, up to 1000.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListTrainingProjectsRequestV1" /> class.
        /// </summary>
        /// <param name="name">
        /// Return only the project with this exact name.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="cursor">
        /// Opaque cursor from the pagination.cursor field of a previous response. Omit both cursor and limit to get every project in one response.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="limit">
        /// Maximum number of projects to return, up to 1000.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListTrainingProjectsRequestV1(
            string? name,
            string? cursor,
            int? limit)
        {
            this.Name = name;
            this.Cursor = cursor;
            this.Limit = limit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListTrainingProjectsRequestV1" /> class.
        /// </summary>
        public ListTrainingProjectsRequestV1()
        {
        }

    }
}