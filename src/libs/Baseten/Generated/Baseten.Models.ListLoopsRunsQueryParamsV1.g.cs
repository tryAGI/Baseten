
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Query-string filters for ``GET /v1/loops/runs``.<br/>
    /// All filters are optional and can be combined; omit them to list the caller's<br/>
    /// own runs. Pass ``scope=org`` to list every run in the caller's organization<br/>
    /// instead.
    /// </summary>
    public sealed partial class ListLoopsRunsQueryParamsV1
    {
        /// <summary>
        /// Filter by run ID.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_id")]
        public string? RunId { get; set; }

        /// <summary>
        /// Filter runs by base model name.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_model")]
        public string? BaseModel { get; set; }

        /// <summary>
        /// Defaults to the caller's own runs; pass 'org' to list every run in the caller's organization.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        public string? Scope { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListLoopsRunsQueryParamsV1" /> class.
        /// </summary>
        /// <param name="runId">
        /// Filter by run ID.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="baseModel">
        /// Filter runs by base model name.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="scope">
        /// Defaults to the caller's own runs; pass 'org' to list every run in the caller's organization.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListLoopsRunsQueryParamsV1(
            string? runId,
            string? baseModel,
            string? scope)
        {
            this.RunId = runId;
            this.BaseModel = baseModel;
            this.Scope = scope;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListLoopsRunsQueryParamsV1" /> class.
        /// </summary>
        public ListLoopsRunsQueryParamsV1()
        {
        }

    }
}