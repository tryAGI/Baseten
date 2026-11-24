
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A place a permission is held: the organization, a team, or in it what one resource set<br/>
    /// selects.
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
        /// The resource, environment, or resource in an environment the grant is limited to. Empty when it isn't limited.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resource_set")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Baseten.AccessResourceV1> ResourceSet { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EffectiveAccessGrantV1" /> class.
        /// </summary>
        /// <param name="resourceSet">
        /// The resource, environment, or resource in an environment the grant is limited to. Empty when it isn't limited.
        /// </param>
        /// <param name="teamId">
        /// ID of the team. Null for the organization.
        /// </param>
        /// <param name="teamName">
        /// Name of the team. Null for the organization.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EffectiveAccessGrantV1(
            global::System.Collections.Generic.IList<global::Baseten.AccessResourceV1> resourceSet,
            string? teamId,
            string? teamName)
        {
            this.TeamId = teamId;
            this.TeamName = teamName;
            this.ResourceSet = resourceSet ?? throw new global::System.ArgumentNullException(nameof(resourceSet));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EffectiveAccessGrantV1" /> class.
        /// </summary>
        public EffectiveAccessGrantV1()
        {
        }

    }
}