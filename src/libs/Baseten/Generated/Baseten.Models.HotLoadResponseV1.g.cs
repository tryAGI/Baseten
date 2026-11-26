
#nullable enable

namespace Baseten
{
    /// <summary>
    /// The stored hot-load target.
    /// </summary>
    public sealed partial class HotLoadResponseV1
    {
        /// <summary>
        /// Revision of the stored target; grows with every request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("revision")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Revision { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HotLoadResponseV1" /> class.
        /// </summary>
        /// <param name="revision">
        /// Revision of the stored target; grows with every request.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HotLoadResponseV1(
            int revision)
        {
            this.Revision = revision;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HotLoadResponseV1" /> class.
        /// </summary>
        public HotLoadResponseV1()
        {
        }

    }
}