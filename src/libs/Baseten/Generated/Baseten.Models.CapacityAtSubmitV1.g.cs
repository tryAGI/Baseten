
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A GPU capacity row as it stands now, with ``last_modified`` so callers<br/>
    /// can judge whether the value matches what the dequeue gate saw at submit<br/>
    /// time. Capacity rows are not historicized: edits overwrite in place. Compare<br/>
    /// ``last_modified`` against the response's ``submitted_at`` — if it's later,<br/>
    /// the value may have changed.
    /// </summary>
    public sealed partial class CapacityAtSubmitV1
    {
        /// <summary>
        /// GPU type identifier (e.g. H100, A100-40GB)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gpu_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GpuType { get; set; }

        /// <summary>
        /// Current max concurrent GPUs of this type
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_gpus")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxGpus { get; set; }

        /// <summary>
        /// Current baseline GPU allocation, if configured<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("min_gpus")]
        public int? MinGpus { get; set; }

        /// <summary>
        /// When the capacity row was last modified
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_modified")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime LastModified { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CapacityAtSubmitV1" /> class.
        /// </summary>
        /// <param name="gpuType">
        /// GPU type identifier (e.g. H100, A100-40GB)
        /// </param>
        /// <param name="maxGpus">
        /// Current max concurrent GPUs of this type
        /// </param>
        /// <param name="lastModified">
        /// When the capacity row was last modified
        /// </param>
        /// <param name="minGpus">
        /// Current baseline GPU allocation, if configured<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CapacityAtSubmitV1(
            string gpuType,
            int maxGpus,
            global::System.DateTime lastModified,
            int? minGpus)
        {
            this.GpuType = gpuType ?? throw new global::System.ArgumentNullException(nameof(gpuType));
            this.MaxGpus = maxGpus;
            this.MinGpus = minGpus;
            this.LastModified = lastModified;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CapacityAtSubmitV1" /> class.
        /// </summary>
        public CapacityAtSubmitV1()
        {
        }

    }
}