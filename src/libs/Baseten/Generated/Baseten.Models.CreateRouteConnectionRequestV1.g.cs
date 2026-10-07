
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateRouteConnectionRequestV1
    {
        /// <summary>
        /// Identifier of the team that owns the connection.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_id")]
        public string? TeamId { get; set; }

        /// <summary>
        /// Provider the connection authenticates with, and the team secret holding its API key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Baseten.JsonConverters.Config2JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.Config2 Config { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRouteConnectionRequestV1" /> class.
        /// </summary>
        /// <param name="config">
        /// Provider the connection authenticates with, and the team secret holding its API key.
        /// </param>
        /// <param name="teamId">
        /// Identifier of the team that owns the connection.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateRouteConnectionRequestV1(
            global::Baseten.Config2 config,
            string? teamId)
        {
            this.TeamId = teamId;
            this.Config = config;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRouteConnectionRequestV1" /> class.
        /// </summary>
        public CreateRouteConnectionRequestV1()
        {
        }

    }
}