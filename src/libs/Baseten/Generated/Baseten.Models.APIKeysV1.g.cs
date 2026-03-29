
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A list of API keys.
    /// </summary>
    public sealed partial class APIKeysV1
    {
        /// <summary>
        /// A list of API key information
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keys")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Baseten.APIKeyInfoV1> Keys { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="APIKeysV1" /> class.
        /// </summary>
        /// <param name="keys">
        /// A list of API key information
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public APIKeysV1(
            global::System.Collections.Generic.IList<global::Baseten.APIKeyInfoV1> keys)
        {
            this.Keys = keys ?? throw new global::System.ArgumentNullException(nameof(keys));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="APIKeysV1" /> class.
        /// </summary>
        public APIKeysV1()
        {
        }
    }
}