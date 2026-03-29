
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A user.
    /// </summary>
    public sealed partial class UserV1
    {
        /// <summary>
        /// Email of the user.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserV1" /> class.
        /// </summary>
        /// <param name="email">
        /// Email of the user.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserV1(
            string? email)
        {
            this.Email = email;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserV1" /> class.
        /// </summary>
        public UserV1()
        {
        }
    }
}