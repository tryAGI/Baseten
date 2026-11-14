
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Whether a create request would pass the checks the server runs on it.
    /// </summary>
    public sealed partial class VerificationV1
    {
        /// <summary>
        /// Whether the input passes every check
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("valid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Valid { get; set; }

        /// <summary>
        /// Why the input fails, as creating it would report. Null when it's valid.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VerificationV1" /> class.
        /// </summary>
        /// <param name="valid">
        /// Whether the input passes every check
        /// </param>
        /// <param name="error">
        /// Why the input fails, as creating it would report. Null when it's valid.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VerificationV1(
            bool valid,
            string? error)
        {
            this.Valid = valid;
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VerificationV1" /> class.
        /// </summary>
        public VerificationV1()
        {
        }

    }
}