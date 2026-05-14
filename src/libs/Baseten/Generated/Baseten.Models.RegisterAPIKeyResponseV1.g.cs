
#nullable enable

namespace Baseten
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RegisterAPIKeyResponseV1
    {
        /// <summary>
        /// Whether the registration was successful
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ok")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Ok { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RegisterAPIKeyResponseV1" /> class.
        /// </summary>
        /// <param name="ok">
        /// Whether the registration was successful
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RegisterAPIKeyResponseV1(
            bool ok)
        {
            this.Ok = ok;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RegisterAPIKeyResponseV1" /> class.
        /// </summary>
        public RegisterAPIKeyResponseV1()
        {
        }

    }
}