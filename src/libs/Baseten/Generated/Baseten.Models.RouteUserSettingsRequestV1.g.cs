
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RouteUserSettingsRequestV1
    {
        /// <summary>
        /// ID of the team to read the user's spend limit in. Defaults to the only team the user has Code spend in this month, else their only team.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_id")]
        public string? TeamId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RouteUserSettingsRequestV1" /> class.
        /// </summary>
        /// <param name="teamId">
        /// ID of the team to read the user's spend limit in. Defaults to the only team the user has Code spend in this month, else their only team.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RouteUserSettingsRequestV1(
            string? teamId)
        {
            this.TeamId = teamId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RouteUserSettingsRequestV1" /> class.
        /// </summary>
        public RouteUserSettingsRequestV1()
        {
        }

    }
}