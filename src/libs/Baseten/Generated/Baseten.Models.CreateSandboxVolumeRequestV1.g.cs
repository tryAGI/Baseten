
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Volume to create. Only size is required.
    /// </summary>
    public sealed partial class CreateSandboxVolumeRequestV1
    {
        /// <summary>
        /// Volume name, unique in the team. Generated when omitted.<br/>
        /// Example: datasets
        /// </summary>
        /// <example>datasets</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Capacity, as a size (e.g. "10Gi", "512Mi") or a number of Mi (e.g. 1024). Can grow later, never shrink.<br/>
        /// Example: 10Gi
        /// </summary>
        /// <example>10Gi</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Baseten.JsonConverters.OneOfJsonConverter<string, int?>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.OneOf<string, int?> Size { get; set; }

        /// <summary>
        /// Region of the volume. Defaults to the default sandbox region. Sandboxes mounting it must be in the same region.<br/>
        /// Example: us-pdx-1
        /// </summary>
        /// <example>us-pdx-1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        public string? Region { get; set; }

        /// <summary>
        /// Key-value pairs for organizing and filtering resources. Labels can be used to categorize resources by environment, project, team, or any custom taxonomy.<br/>
        /// Example: {"env":"development","project":"api-review","team":"engineering"}
        /// </summary>
        /// <example>{"env":"development","project":"api-review","team":"engineering"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("labels")]
        public global::System.Collections.Generic.Dictionary<string, string>? Labels { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSandboxVolumeRequestV1" /> class.
        /// </summary>
        /// <param name="size">
        /// Capacity, as a size (e.g. "10Gi", "512Mi") or a number of Mi (e.g. 1024). Can grow later, never shrink.<br/>
        /// Example: 10Gi
        /// </param>
        /// <param name="name">
        /// Volume name, unique in the team. Generated when omitted.<br/>
        /// Example: datasets
        /// </param>
        /// <param name="region">
        /// Region of the volume. Defaults to the default sandbox region. Sandboxes mounting it must be in the same region.<br/>
        /// Example: us-pdx-1
        /// </param>
        /// <param name="labels">
        /// Key-value pairs for organizing and filtering resources. Labels can be used to categorize resources by environment, project, team, or any custom taxonomy.<br/>
        /// Example: {"env":"development","project":"api-review","team":"engineering"}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateSandboxVolumeRequestV1(
            global::Baseten.OneOf<string, int?> size,
            string? name,
            string? region,
            global::System.Collections.Generic.Dictionary<string, string>? labels)
        {
            this.Name = name;
            this.Size = size;
            this.Region = region;
            this.Labels = labels;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSandboxVolumeRequestV1" /> class.
        /// </summary>
        public CreateSandboxVolumeRequestV1()
        {
        }

    }
}