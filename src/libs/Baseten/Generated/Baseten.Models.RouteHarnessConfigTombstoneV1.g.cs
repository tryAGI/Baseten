
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RouteHarnessConfigTombstoneV1
    {
        /// <summary>
        /// Harness whose default models were cleared.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("harness")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Baseten.JsonConverters.RouteHarnessJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.RouteHarness Harness { get; set; }

        /// <summary>
        /// Identifier of the team whose default models were cleared.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TeamId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RouteHarnessConfigTombstoneV1" /> class.
        /// </summary>
        /// <param name="harness">
        /// Harness whose default models were cleared.
        /// </param>
        /// <param name="teamId">
        /// Identifier of the team whose default models were cleared.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RouteHarnessConfigTombstoneV1(
            global::Baseten.RouteHarness harness,
            string teamId)
        {
            this.Harness = harness;
            this.TeamId = teamId ?? throw new global::System.ArgumentNullException(nameof(teamId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RouteHarnessConfigTombstoneV1" /> class.
        /// </summary>
        public RouteHarnessConfigTombstoneV1()
        {
        }

    }
}