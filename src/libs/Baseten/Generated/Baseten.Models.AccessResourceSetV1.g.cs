
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A set of resources a role assignment applies to: what all of them match.
    /// </summary>
    public sealed partial class AccessResourceSetV1
    {
        /// <summary>
        /// Resources the set matches together, every one of them: a resource, an environment of the team's models and chains, or a model or chain in an environment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("all_of")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Baseten.AccessResourceV1> AllOf { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AccessResourceSetV1" /> class.
        /// </summary>
        /// <param name="allOf">
        /// Resources the set matches together, every one of them: a resource, an environment of the team's models and chains, or a model or chain in an environment
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AccessResourceSetV1(
            global::System.Collections.Generic.IList<global::Baseten.AccessResourceV1> allOf)
        {
            this.AllOf = allOf ?? throw new global::System.ArgumentNullException(nameof(allOf));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccessResourceSetV1" /> class.
        /// </summary>
        public AccessResourceSetV1()
        {
        }

    }
}