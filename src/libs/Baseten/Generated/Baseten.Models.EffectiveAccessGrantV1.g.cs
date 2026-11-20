
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A place a permission is held: the organization, a team, a resource, or an environment.
    /// </summary>
    public sealed partial class EffectiveAccessGrantV1
    {
        /// <summary>
        /// ID of the team. Null for the organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_id")]
        public string? TeamId { get; set; }

        /// <summary>
        /// Name of the team. Null for the organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_name")]
        public string? TeamName { get; set; }

        /// <summary>
        /// The resource. Null when the grant isn't limited to one resource.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resource")]
        public global::Baseten.AccessResourceV1? Resource { get; set; }

        /// <summary>
        /// Name of the environment, such as `production`. Null for every environment. Permission checks don't take an environment yet, so these grants aren't confirmed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment")]
        public string? Environment { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EffectiveAccessGrantV1" /> class.
        /// </summary>
        /// <param name="teamId">
        /// ID of the team. Null for the organization.
        /// </param>
        /// <param name="teamName">
        /// Name of the team. Null for the organization.
        /// </param>
        /// <param name="resource">
        /// The resource. Null when the grant isn't limited to one resource.
        /// </param>
        /// <param name="environment">
        /// Name of the environment, such as `production`. Null for every environment. Permission checks don't take an environment yet, so these grants aren't confirmed.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EffectiveAccessGrantV1(
            string? teamId,
            string? teamName,
            global::Baseten.AccessResourceV1? resource,
            string? environment)
        {
            this.TeamId = teamId;
            this.TeamName = teamName;
            this.Resource = resource;
            this.Environment = environment;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EffectiveAccessGrantV1" /> class.
        /// </summary>
        public EffectiveAccessGrantV1()
        {
        }

    }
}