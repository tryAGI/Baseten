
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Request to update a library listing version.
    /// </summary>
    public sealed partial class UpdateLibraryListingVersionRequestV1
    {
        /// <summary>
        /// Whether this version should be the live version. Setting to true demotes the current live version.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_live")]
        public bool? IsLive { get; set; }

        /// <summary>
        /// Whether users deploying this model can download the Truss<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_truss_download")]
        public bool? AllowTrussDownload { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateLibraryListingVersionRequestV1" /> class.
        /// </summary>
        /// <param name="isLive">
        /// Whether this version should be the live version. Setting to true demotes the current live version.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="allowTrussDownload">
        /// Whether users deploying this model can download the Truss<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateLibraryListingVersionRequestV1(
            bool? isLive,
            bool? allowTrussDownload)
        {
            this.IsLive = isLive;
            this.AllowTrussDownload = allowTrussDownload;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateLibraryListingVersionRequestV1" /> class.
        /// </summary>
        public UpdateLibraryListingVersionRequestV1()
        {
        }
    }
}