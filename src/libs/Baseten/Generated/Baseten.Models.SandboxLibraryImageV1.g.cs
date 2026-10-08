
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Built-in sandbox image usable directly as a sandbox image.
    /// </summary>
    public sealed partial class SandboxLibraryImageV1
    {
        /// <summary>
        /// Stable identifier of the built-in image.<br/>
        /// Example: base-image
        /// </summary>
        /// <example>base-image</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Human-readable name.<br/>
        /// Example: Base Image
        /// </summary>
        /// <example>Base Image</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// Short description.<br/>
        /// Example: A minimal sandbox environment with the sandbox execution API.
        /// </summary>
        /// <example>A minimal sandbox environment with the sandbox execution API.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Detailed description.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("long_description")]
        public string? LongDescription { get; set; }

        /// <summary>
        /// Image reference including its tag, usable as the image of a sandbox.<br/>
        /// Example: baseten/base-image:latest
        /// </summary>
        /// <example>baseten/base-image:latest</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Image { get; set; }

        /// <summary>
        /// Recommended memory allocation in megabytes.<br/>
        /// Example: 4096
        /// </summary>
        /// <example>4096</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("memory")]
        public long? Memory { get; set; }

        /// <summary>
        /// Set of ports for a resource<br/>
        /// Example: [{"name":"http","protocol":"HTTP","target":3000}]
        /// </summary>
        /// <example>[{"name":"http","protocol":"HTTP","target":3000}]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("ports")]
        public global::System.Collections.Generic.IList<global::Baseten.SandboxPortV1>? Ports { get; set; }

        /// <summary>
        /// Categories of the image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("categories")]
        public global::System.Collections.Generic.IList<string>? Categories { get; set; }

        /// <summary>
        /// Tags of the image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// Documentation URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Icon URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("icon")]
        public string? Icon { get; set; }

        /// <summary>
        /// Light-mode icon URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("icon_light")]
        public string? IconLight { get; set; }

        /// <summary>
        /// Dark-mode icon URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("icon_dark")]
        public string? IconDark { get; set; }

        /// <summary>
        /// Whether the image requires an enterprise plan.<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("enterprise")]
        public bool? Enterprise { get; set; }

        /// <summary>
        /// Whether the image is hidden. Always false in listings.<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("hidden")]
        public bool? Hidden { get; set; }

        /// <summary>
        /// Whether the image is not yet available. Always false in listings.<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("coming_soon")]
        public bool? ComingSoon { get; set; }

        /// <summary>
        /// Optional settings suggested when creating a sandbox from this image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creation_options")]
        public global::Baseten.SandboxLibraryImageCreationOptionsV1? CreationOptions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxLibraryImageV1" /> class.
        /// </summary>
        /// <param name="name">
        /// Stable identifier of the built-in image.<br/>
        /// Example: base-image
        /// </param>
        /// <param name="image">
        /// Image reference including its tag, usable as the image of a sandbox.<br/>
        /// Example: baseten/base-image:latest
        /// </param>
        /// <param name="displayName">
        /// Human-readable name.<br/>
        /// Example: Base Image
        /// </param>
        /// <param name="description">
        /// Short description.<br/>
        /// Example: A minimal sandbox environment with the sandbox execution API.
        /// </param>
        /// <param name="longDescription">
        /// Detailed description.
        /// </param>
        /// <param name="memory">
        /// Recommended memory allocation in megabytes.<br/>
        /// Example: 4096
        /// </param>
        /// <param name="ports">
        /// Set of ports for a resource<br/>
        /// Example: [{"name":"http","protocol":"HTTP","target":3000}]
        /// </param>
        /// <param name="categories">
        /// Categories of the image.
        /// </param>
        /// <param name="tags">
        /// Tags of the image.
        /// </param>
        /// <param name="url">
        /// Documentation URL.
        /// </param>
        /// <param name="icon">
        /// Icon URL.
        /// </param>
        /// <param name="iconLight">
        /// Light-mode icon URL.
        /// </param>
        /// <param name="iconDark">
        /// Dark-mode icon URL.
        /// </param>
        /// <param name="enterprise">
        /// Whether the image requires an enterprise plan.<br/>
        /// Example: false
        /// </param>
        /// <param name="hidden">
        /// Whether the image is hidden. Always false in listings.<br/>
        /// Example: false
        /// </param>
        /// <param name="comingSoon">
        /// Whether the image is not yet available. Always false in listings.<br/>
        /// Example: false
        /// </param>
        /// <param name="creationOptions">
        /// Optional settings suggested when creating a sandbox from this image.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxLibraryImageV1(
            string name,
            string image,
            string? displayName,
            string? description,
            string? longDescription,
            long? memory,
            global::System.Collections.Generic.IList<global::Baseten.SandboxPortV1>? ports,
            global::System.Collections.Generic.IList<string>? categories,
            global::System.Collections.Generic.IList<string>? tags,
            string? url,
            string? icon,
            string? iconLight,
            string? iconDark,
            bool? enterprise,
            bool? hidden,
            bool? comingSoon,
            global::Baseten.SandboxLibraryImageCreationOptionsV1? creationOptions)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.DisplayName = displayName;
            this.Description = description;
            this.LongDescription = longDescription;
            this.Image = image ?? throw new global::System.ArgumentNullException(nameof(image));
            this.Memory = memory;
            this.Ports = ports;
            this.Categories = categories;
            this.Tags = tags;
            this.Url = url;
            this.Icon = icon;
            this.IconLight = iconLight;
            this.IconDark = iconDark;
            this.Enterprise = enterprise;
            this.Hidden = hidden;
            this.ComingSoon = comingSoon;
            this.CreationOptions = creationOptions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxLibraryImageV1" /> class.
        /// </summary>
        public SandboxLibraryImageV1()
        {
        }

    }
}