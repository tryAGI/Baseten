
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class LibraryListingMetadataV1
    {
        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameter_count")]
        public int? ParameterCount { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context_length")]
        public int? ContextLength { get; set; }

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
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("publisher")]
        public string? Publisher { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_api_slug")]
        public string? ModelApiSlug { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("release_date")]
        public global::System.DateTime? ReleaseDate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LibraryListingMetadataV1" /> class.
        /// </summary>
        /// <param name="license"></param>
        /// <param name="parameterCount">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="contextLength">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="inputModalities">
        /// Default Value: [text]
        /// </param>
        /// <param name="outputModalities">
        /// Default Value: [text]
        /// </param>
        /// <param name="variant">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="publisher">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="modelApiSlug">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="releaseDate">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LibraryListingMetadataV1(
            string license,
            int? parameterCount,
            int? contextLength,
            global::System.Collections.Generic.IList<global::Baseten.LibraryListingMetadataV1InputModalitie>? inputModalities,
            global::System.Collections.Generic.IList<global::Baseten.LibraryListingMetadataV1OutputModalitie>? outputModalities,
            string? variant,
            string? publisher,
            string? modelApiSlug,
            global::System.DateTime? releaseDate)
        {
            this.ParameterCount = parameterCount;
            this.ContextLength = contextLength;
            this.InputModalities = inputModalities;
            this.OutputModalities = outputModalities;
            this.License = license ?? throw new global::System.ArgumentNullException(nameof(license));
            this.Variant = variant;
            this.Publisher = publisher;
            this.ModelApiSlug = modelApiSlug;
            this.ReleaseDate = releaseDate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LibraryListingMetadataV1" /> class.
        /// </summary>
        public LibraryListingMetadataV1()
        {
        }

    }
}