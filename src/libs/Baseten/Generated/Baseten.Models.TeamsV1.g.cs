
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A list of teams.
    /// </summary>
    public sealed partial class TeamsV1
    {
        /// <summary>
        /// A list of teams
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("teams")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Baseten.TeamV1> Teams { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamsV1" /> class.
        /// </summary>
        /// <param name="teams">
        /// A list of teams
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TeamsV1(
            global::System.Collections.Generic.IList<global::Baseten.TeamV1> teams)
        {
            this.Teams = teams ?? throw new global::System.ArgumentNullException(nameof(teams));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamsV1" /> class.
        /// </summary>
        public TeamsV1()
        {
        }
    }
}