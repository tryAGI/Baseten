
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RouteHarnessModelV1
    {
        /// <summary>
        /// Who chose this role's route: `team` if a team admin set it, or `baseten` if it is Baseten's default, chosen from the team's Model API routes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Baseten.JsonConverters.RouteHarnessModelSourceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.RouteHarnessModelSource Source { get; set; }

        /// <summary>
        /// Route to use for this role.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("route")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.RouteV1 Route { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RouteHarnessModelV1" /> class.
        /// </summary>
        /// <param name="source">
        /// Who chose this role's route: `team` if a team admin set it, or `baseten` if it is Baseten's default, chosen from the team's Model API routes.
        /// </param>
        /// <param name="route">
        /// Route to use for this role.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RouteHarnessModelV1(
            global::Baseten.RouteHarnessModelSource source,
            global::Baseten.RouteV1 route)
        {
            this.Source = source;
            this.Route = route ?? throw new global::System.ArgumentNullException(nameof(route));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RouteHarnessModelV1" /> class.
        /// </summary>
        public RouteHarnessModelV1()
        {
        }

    }
}