
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ClearRouteHarnessConfigRequestV1
    {
        /// <summary>
        /// Identifier of the team whose default models to clear.
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
        /// Initializes a new instance of the <see cref="ClearRouteHarnessConfigRequestV1" /> class.
        /// </summary>
        /// <param name="teamId">
        /// Identifier of the team whose default models to clear.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClearRouteHarnessConfigRequestV1(
            string teamId)
        {
            this.TeamId = teamId ?? throw new global::System.ArgumentNullException(nameof(teamId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClearRouteHarnessConfigRequestV1" /> class.
        /// </summary>
        public ClearRouteHarnessConfigRequestV1()
        {
        }

    }
}