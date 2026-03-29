
#nullable enable

namespace Baseten
{
    /// <summary>
    /// An instance type.
    /// </summary>
    public sealed partial class InstanceTypeV1
    {
        /// <summary>
        /// Identifier string for the instance type
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Display name of the instance type
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Memory limit of the instance type in Mebibytes
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memory_limit_mib")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long MemoryLimitMib { get; set; }

        /// <summary>
        /// CPU limit of the instance type in millicpu
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("millicpu_limit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MillicpuLimit { get; set; }

        /// <summary>
        /// Number of GPUs on the instance type
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gpu_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int GpuCount { get; set; }

        /// <summary>
        /// Type of GPU on the instance type
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gpu_type")]
        public string? GpuType { get; set; }

        /// <summary>
        /// Memory limit of the GPU on the instance type in Mebibytes
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gpu_memory_limit_mib")]
        public long? GpuMemoryLimitMib { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InstanceTypeV1" /> class.
        /// </summary>
        /// <param name="id">
        /// Identifier string for the instance type
        /// </param>
        /// <param name="name">
        /// Display name of the instance type
        /// </param>
        /// <param name="memoryLimitMib">
        /// Memory limit of the instance type in Mebibytes
        /// </param>
        /// <param name="millicpuLimit">
        /// CPU limit of the instance type in millicpu
        /// </param>
        /// <param name="gpuCount">
        /// Number of GPUs on the instance type
        /// </param>
        /// <param name="gpuType">
        /// Type of GPU on the instance type
        /// </param>
        /// <param name="gpuMemoryLimitMib">
        /// Memory limit of the GPU on the instance type in Mebibytes
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InstanceTypeV1(
            string id,
            string name,
            long memoryLimitMib,
            int millicpuLimit,
            int gpuCount,
            string? gpuType,
            long? gpuMemoryLimitMib)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.MemoryLimitMib = memoryLimitMib;
            this.MillicpuLimit = millicpuLimit;
            this.GpuCount = gpuCount;
            this.GpuType = gpuType;
            this.GpuMemoryLimitMib = gpuMemoryLimitMib;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InstanceTypeV1" /> class.
        /// </summary>
        public InstanceTypeV1()
        {
        }
    }
}