
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Persistent volume.
    /// </summary>
    public sealed partial class SandboxVolumeV1
    {
        /// <summary>
        /// Volume name, used in volume_name path parameters and sandbox volumes.<br/>
        /// Included only in responses<br/>
        /// Example: datasets
        /// </summary>
        /// <default>default!</default>
        /// <example>datasets</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Capacity, as a size (e.g. "10Gi", "512Mi") or a number of Mi (e.g. 1024).<br/>
        /// Example: 10Gi
        /// </summary>
        /// <example>10Gi</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Baseten.JsonConverters.OneOfJsonConverter<string, int?>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.OneOf<string, int?> Size { get; set; }

        /// <summary>
        /// Region of the volume.<br/>
        /// Example: us-pdx-1
        /// </summary>
        /// <example>us-pdx-1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Region { get; set; }

        /// <summary>
        /// Volume status, always uppercase.<br/>
        /// Example: DEPLOYED
        /// </summary>
        /// <example>DEPLOYED</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Baseten.JsonConverters.SandboxVolumeStatusV1JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.SandboxVolumeStatusV1 Status { get; set; }

        /// <summary>
        /// Name of the sandbox the volume is mounted in. Absent when not mounted.<br/>
        /// Included only in responses<br/>
        /// Example: baseten-api-review-0916
        /// </summary>
        /// <example>baseten-api-review-0916</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("attached_to")]
        public string? AttachedTo { get; set; }

        /// <summary>
        /// Labels. Omitted from list responses.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labels")]
        public global::System.Collections.Generic.Dictionary<string, string>? Labels { get; set; }

        /// <summary>
        /// Included only in responses<br/>
        /// Example: 2026-10-12T12:00:00Z
        /// </summary>
        /// <example>2026-10-12T12:00:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Included only in responses<br/>
        /// Example: 2026-10-12T12:00:00Z
        /// </summary>
        /// <example>2026-10-12T12:00:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// User or service account that created the volume.<br/>
        /// Included only in responses<br/>
        /// Example: sandbox-automation
        /// </summary>
        /// <example>sandbox-automation</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_by")]
        public string? CreatedBy { get; set; }

        /// <summary>
        /// User or service account that last updated the volume.<br/>
        /// Included only in responses<br/>
        /// Example: sandbox-automation
        /// </summary>
        /// <example>sandbox-automation</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_by")]
        public string? UpdatedBy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxVolumeV1" /> class.
        /// </summary>
        /// <param name="size">
        /// Capacity, as a size (e.g. "10Gi", "512Mi") or a number of Mi (e.g. 1024).<br/>
        /// Example: 10Gi
        /// </param>
        /// <param name="region">
        /// Region of the volume.<br/>
        /// Example: us-pdx-1
        /// </param>
        /// <param name="status">
        /// Volume status, always uppercase.<br/>
        /// Example: DEPLOYED
        /// </param>
        /// <param name="attachedTo">
        /// Name of the sandbox the volume is mounted in. Absent when not mounted.<br/>
        /// Included only in responses<br/>
        /// Example: baseten-api-review-0916
        /// </param>
        /// <param name="labels">
        /// Labels. Omitted from list responses.
        /// </param>
        /// <param name="createdAt">
        /// Included only in responses<br/>
        /// Example: 2026-10-12T12:00:00Z
        /// </param>
        /// <param name="updatedAt">
        /// Included only in responses<br/>
        /// Example: 2026-10-12T12:00:00Z
        /// </param>
        /// <param name="createdBy">
        /// User or service account that created the volume.<br/>
        /// Included only in responses<br/>
        /// Example: sandbox-automation
        /// </param>
        /// <param name="updatedBy">
        /// User or service account that last updated the volume.<br/>
        /// Included only in responses<br/>
        /// Example: sandbox-automation
        /// </param>
        /// <param name="name">
        /// Volume name, used in volume_name path parameters and sandbox volumes.<br/>
        /// Included only in responses<br/>
        /// Example: datasets
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxVolumeV1(
            global::Baseten.OneOf<string, int?> size,
            string region,
            global::Baseten.SandboxVolumeStatusV1 status,
            string? attachedTo,
            global::System.Collections.Generic.Dictionary<string, string>? labels,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt,
            string? createdBy,
            string? updatedBy,
            string name = default!)
        {
            this.Name = name;
            this.Size = size;
            this.Region = region ?? throw new global::System.ArgumentNullException(nameof(region));
            this.Status = status;
            this.AttachedTo = attachedTo;
            this.Labels = labels;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.CreatedBy = createdBy;
            this.UpdatedBy = updatedBy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxVolumeV1" /> class.
        /// </summary>
        public SandboxVolumeV1()
        {
        }

    }
}