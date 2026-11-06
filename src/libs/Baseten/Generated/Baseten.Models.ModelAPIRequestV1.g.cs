
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Query-string filters for ``GET /v1/model_apis/{model_api_name}``.
    /// </summary>
    public sealed partial class ModelAPIRequestV1
    {
        /// <summary>
        /// Select teams for added-model details, repeated once per team. Defaults to all teams where you can invoke Model APIs. Any unauthorized team causes a 403.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_ids")]
        public global::System.Collections.Generic.IList<string>? TeamIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelAPIRequestV1" /> class.
        /// </summary>
        /// <param name="teamIds">
        /// Select teams for added-model details, repeated once per team. Defaults to all teams where you can invoke Model APIs. Any unauthorized team causes a 403.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelAPIRequestV1(
            global::System.Collections.Generic.IList<string>? teamIds)
        {
            this.TeamIds = teamIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelAPIRequestV1" /> class.
        /// </summary>
        public ModelAPIRequestV1()
        {
        }

    }
}