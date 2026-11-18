
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GridRouteAliasV1
    {
        /// <summary>
        /// Name to send in the inference request's `model` field instead of the route's `name`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Purpose of the alias. CLAUDE_DESKTOP is for Claude Code desktop, which rejects model names without a `claude` substring. ALIAS is any other name the team's clients send for the route.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Baseten.JsonConverters.GridRouteAliasKindV1JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.GridRouteAliasKindV1 Kind { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GridRouteAliasV1" /> class.
        /// </summary>
        /// <param name="name">
        /// Name to send in the inference request's `model` field instead of the route's `name`.
        /// </param>
        /// <param name="kind">
        /// Purpose of the alias. CLAUDE_DESKTOP is for Claude Code desktop, which rejects model names without a `claude` substring. ALIAS is any other name the team's clients send for the route.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GridRouteAliasV1(
            string name,
            global::Baseten.GridRouteAliasKindV1 kind)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Kind = kind;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GridRouteAliasV1" /> class.
        /// </summary>
        public GridRouteAliasV1()
        {
        }

    }
}