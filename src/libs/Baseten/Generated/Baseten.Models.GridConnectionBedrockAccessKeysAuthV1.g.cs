
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GridConnectionBedrockAccessKeysAuthV1
    {
        /// <summary>
        /// The secret holds the access keys of an IAM user, as the base64-encoded JSON object `{"AccessKeyId": "...", "SecretAccessKey": "..."}`
        /// </summary>
        /// <default>"access_keys"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        public string Method { get; set; } = "access_keys";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GridConnectionBedrockAccessKeysAuthV1" /> class.
        /// </summary>
        /// <param name="method">
        /// The secret holds the access keys of an IAM user, as the base64-encoded JSON object `{"AccessKeyId": "...", "SecretAccessKey": "..."}`
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GridConnectionBedrockAccessKeysAuthV1(
            string method = "access_keys")
        {
            this.Method = method;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GridConnectionBedrockAccessKeysAuthV1" /> class.
        /// </summary>
        public GridConnectionBedrockAccessKeysAuthV1()
        {
        }

    }
}