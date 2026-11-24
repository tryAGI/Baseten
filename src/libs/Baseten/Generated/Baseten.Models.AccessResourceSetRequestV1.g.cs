
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A set of resources to assign a role on: what all of them match.
    /// </summary>
    public sealed partial class AccessResourceSetRequestV1
    {
        /// <summary>
        /// Resources the set matches together, every one of them: at most one resource and at most one environment, such as a model in `staging`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("all_of")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Baseten.AccessResourceRequestV1> AllOf { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AccessResourceSetRequestV1" /> class.
        /// </summary>
        /// <param name="allOf">
        /// Resources the set matches together, every one of them: at most one resource and at most one environment, such as a model in `staging`
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AccessResourceSetRequestV1(
            global::System.Collections.Generic.IList<global::Baseten.AccessResourceRequestV1> allOf)
        {
            this.AllOf = allOf ?? throw new global::System.ArgumentNullException(nameof(allOf));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccessResourceSetRequestV1" /> class.
        /// </summary>
        public AccessResourceSetRequestV1()
        {
        }

    }
}