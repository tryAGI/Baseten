
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Response containing auth codes for all nodes of a training job's interactive sessions.
    /// </summary>
    public sealed partial class GetAuthCodesResponseV1
    {
        /// <summary>
        /// List of auth codes for each node that has an active interactive session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_codes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Baseten.AuthCodeV1> AuthCodes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAuthCodesResponseV1" /> class.
        /// </summary>
        /// <param name="authCodes">
        /// List of auth codes for each node that has an active interactive session.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAuthCodesResponseV1(
            global::System.Collections.Generic.IList<global::Baseten.AuthCodeV1> authCodes)
        {
            this.AuthCodes = authCodes ?? throw new global::System.ArgumentNullException(nameof(authCodes));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAuthCodesResponseV1" /> class.
        /// </summary>
        public GetAuthCodesResponseV1()
        {
        }
    }
}