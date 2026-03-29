
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A metric for a training job.
    /// </summary>
    public sealed partial class StorageMetricsV1
    {
        /// <summary>
        /// The number of bytes used on the storage entity.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage_bytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Baseten.TrainingJobMetricV1> UsageBytes { get; set; }

        /// <summary>
        /// The utilization of the storage entity as a decimal percentage.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("utilization")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Baseten.TrainingJobMetricV1> Utilization { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StorageMetricsV1" /> class.
        /// </summary>
        /// <param name="usageBytes">
        /// The number of bytes used on the storage entity.
        /// </param>
        /// <param name="utilization">
        /// The utilization of the storage entity as a decimal percentage.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StorageMetricsV1(
            global::System.Collections.Generic.IList<global::Baseten.TrainingJobMetricV1> usageBytes,
            global::System.Collections.Generic.IList<global::Baseten.TrainingJobMetricV1> utilization)
        {
            this.UsageBytes = usageBytes ?? throw new global::System.ArgumentNullException(nameof(usageBytes));
            this.Utilization = utilization ?? throw new global::System.ArgumentNullException(nameof(utilization));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StorageMetricsV1" /> class.
        /// </summary>
        public StorageMetricsV1()
        {
        }
    }
}