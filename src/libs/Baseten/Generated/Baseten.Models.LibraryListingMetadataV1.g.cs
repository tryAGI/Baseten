
#nullable enable

namespace Baseten
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LibraryListingMetadataV1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameter_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ParameterCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context_length")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ContextLength { get; set; }

        /// <summary>
        /// Default Value: [text]
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_modalities")]
        public global::System.Collections.Generic.IList<global::Baseten.LibraryListingMetadataV1InputModalitie>? InputModalities { get; set; }

        /// <summary>
        /// Default Value: [text]
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_modalities")]
        public global::System.Collections.Generic.IList<global::Baseten.LibraryListingMetadataV1OutputModalitie>? OutputModalities { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("license")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string License { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variant")]
        public string? Variant { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LibraryListingMetadataV1" /> class.
        /// </summary>
        /// <param name="parameterCount"></param>
        /// <param name="contextLength"></param>
        /// <param name="license"></param>
        /// <param name="inputModalities">
        /// Default Value: [text]
        /// </param>
        /// <param name="outputModalities">
        /// Default Value: [text]
        /// </param>
        /// <param name="variant">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LibraryListingMetadataV1(
            int parameterCount,
            int contextLength,
            string license,
            global::System.Collections.Generic.IList<global::Baseten.LibraryListingMetadataV1InputModalitie>? inputModalities,
            global::System.Collections.Generic.IList<global::Baseten.LibraryListingMetadataV1OutputModalitie>? outputModalities,
            string? variant)
        {
            this.ParameterCount = parameterCount;
            this.ContextLength = contextLength;
            this.InputModalities = inputModalities;
            this.OutputModalities = outputModalities;
            this.License = license ?? throw new global::System.ArgumentNullException(nameof(license));
            this.Variant = variant;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LibraryListingMetadataV1" /> class.
        /// </summary>
        public LibraryListingMetadataV1()
        {
        }

    }
}