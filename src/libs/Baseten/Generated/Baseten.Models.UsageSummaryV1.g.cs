
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Billing usage summary for the requested date range.
    /// </summary>
    public sealed partial class UsageSummaryV1
    {
        /// <summary>
        /// Dedicated model serving usage<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dedicated_usage")]
        public global::Baseten.DedicatedUsageV1? DedicatedUsage { get; set; }

        /// <summary>
        /// Training usage<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("training_usage")]
        public global::Baseten.TrainingUsageV1? TrainingUsage { get; set; }

        /// <summary>
        /// Model APIs usage<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_apis_usage")]
        public global::Baseten.ModelApisUsageV1? ModelApisUsage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageSummaryV1" /> class.
        /// </summary>
        /// <param name="dedicatedUsage">
        /// Dedicated model serving usage<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="trainingUsage">
        /// Training usage<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="modelApisUsage">
        /// Model APIs usage<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UsageSummaryV1(
            global::Baseten.DedicatedUsageV1? dedicatedUsage,
            global::Baseten.TrainingUsageV1? trainingUsage,
            global::Baseten.ModelApisUsageV1? modelApisUsage)
        {
            this.DedicatedUsage = dedicatedUsage;
            this.TrainingUsage = trainingUsage;
            this.ModelApisUsage = modelApisUsage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageSummaryV1" /> class.
        /// </summary>
        public UsageSummaryV1()
        {
        }
    }
}