
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GridHarnessModelV1
    {
        /// <summary>
        /// Where this role's route comes from. `team` covers both a route a team admin set and the default chosen from the team's Model API routes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Baseten.JsonConverters.GridSettingSourceV1JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.GridSettingSourceV1 Source { get; set; }

        /// <summary>
        /// Route to use for this role.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("route")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.GridRouteV1 Route { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GridHarnessModelV1" /> class.
        /// </summary>
        /// <param name="source">
        /// Where this role's route comes from. `team` covers both a route a team admin set and the default chosen from the team's Model API routes.
        /// </param>
        /// <param name="route">
        /// Route to use for this role.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GridHarnessModelV1(
            global::Baseten.GridSettingSourceV1 source,
            global::Baseten.GridRouteV1 route)
        {
            this.Source = source;
            this.Route = route ?? throw new global::System.ArgumentNullException(nameof(route));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GridHarnessModelV1" /> class.
        /// </summary>
        public GridHarnessModelV1()
        {
        }

    }
}