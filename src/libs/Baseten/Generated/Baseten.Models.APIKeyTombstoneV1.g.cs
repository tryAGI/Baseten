
#nullable enable

namespace Baseten
{
    /// <summary>
    /// An API key tombstone.
    /// </summary>
    public sealed partial class APIKeyTombstoneV1
    {
        /// <summary>
        /// Unique prefix of the API key
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prefix")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prefix { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="APIKeyTombstoneV1" /> class.
        /// </summary>
        /// <param name="prefix">
        /// Unique prefix of the API key
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public APIKeyTombstoneV1(
            string prefix)
        {
            this.Prefix = prefix ?? throw new global::System.ArgumentNullException(nameof(prefix));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="APIKeyTombstoneV1" /> class.
        /// </summary>
        public APIKeyTombstoneV1()
        {
        }
    }
}