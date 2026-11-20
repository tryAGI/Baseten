
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Answers to permission checks.
    /// </summary>
    public sealed partial class CheckAccessResponseV1
    {
        /// <summary>
        /// One result per check, in the order you sent them
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Baseten.AccessCheckResultV1> Results { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckAccessResponseV1" /> class.
        /// </summary>
        /// <param name="results">
        /// One result per check, in the order you sent them
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CheckAccessResponseV1(
            global::System.Collections.Generic.IList<global::Baseten.AccessCheckResultV1> results)
        {
            this.Results = results ?? throw new global::System.ArgumentNullException(nameof(results));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckAccessResponseV1" /> class.
        /// </summary>
        public CheckAccessResponseV1()
        {
        }

    }
}