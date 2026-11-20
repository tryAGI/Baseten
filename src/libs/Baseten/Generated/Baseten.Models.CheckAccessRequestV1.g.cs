
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Permissions to check.
    /// </summary>
    public sealed partial class CheckAccessRequestV1
    {
        /// <summary>
        /// Permissions to check, at most 100
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("checks")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Baseten.AccessCheckV1> Checks { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckAccessRequestV1" /> class.
        /// </summary>
        /// <param name="checks">
        /// Permissions to check, at most 100
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CheckAccessRequestV1(
            global::System.Collections.Generic.IList<global::Baseten.AccessCheckV1> checks)
        {
            this.Checks = checks ?? throw new global::System.ArgumentNullException(nameof(checks));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckAccessRequestV1" /> class.
        /// </summary>
        public CheckAccessRequestV1()
        {
        }

    }
}