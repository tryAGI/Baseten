
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GridRoutesRequestV1
    {
        /// <summary>
        /// Opaque cursor returned by a previous page. Omit to fetch the first page.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cursor")]
        public string? Cursor { get; set; }

        /// <summary>
        /// Maximum number of items to return.<br/>
        /// Default Value: 100
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// Limit routes to this team. Without it, routes from every team where you can invoke routes.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_id")]
        public string? TeamId { get; set; }

        /// <summary>
        /// Set by harness setup and sync. Returns routes from exactly one team: `team_id`, else the team you belong to; when you belong to several and name none, the request fails with a 400.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("for_harnesses")]
        public bool? ForHarnesses { get; set; }

        /// <summary>
        /// Filter by exact route name. Preserved by the cursor; if repeated, must match the original filter.<br/>
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
        /// Initializes a new instance of the <see cref="GridRoutesRequestV1" /> class.
        /// </summary>
        /// <param name="cursor">
        /// Opaque cursor returned by a previous page. Omit to fetch the first page.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="limit">
        /// Maximum number of items to return.<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="teamId">
        /// Limit routes to this team. Without it, routes from every team where you can invoke routes.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="forHarnesses">
        /// Set by harness setup and sync. Returns routes from exactly one team: `team_id`, else the team you belong to; when you belong to several and name none, the request fails with a 400.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="name">
        /// Filter by exact route name. Preserved by the cursor; if repeated, must match the original filter.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GridRoutesRequestV1(
            string? cursor,
            int? limit,
            string? teamId,
            bool? forHarnesses,
            string? name)
        {
            this.Cursor = cursor;
            this.Limit = limit;
            this.TeamId = teamId;
            this.ForHarnesses = forHarnesses;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GridRoutesRequestV1" /> class.
        /// </summary>
        public GridRoutesRequestV1()
        {
        }

    }
}