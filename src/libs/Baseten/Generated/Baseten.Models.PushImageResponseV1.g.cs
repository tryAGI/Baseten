
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Accepted image push. Acceptance does not imply readiness; poll GET /sandboxes/images/{image_name} until status is BUILT or FAILED.<br/>
    /// Example: {"name":"base-image","status":"BUILDING","image":"b10/base-image:latest"}
    /// </summary>
    public sealed partial class PushImageResponseV1
    {
        /// <summary>
        /// Target image repository name.<br/>
        /// Example: base-image
        /// </summary>
        /// <example>base-image</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Image processing status. Only BUILT images are ready to use.<br/>
        /// Example: BUILDING
        /// </summary>
        /// <example>BUILDING</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Baseten.JsonConverters.ImageStatusV1JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.ImageStatusV1 Status { get; set; }

        /// <summary>
        /// Temporary signed URL for uploading the source ZIP archive with HTTP PUT. Present only when no source image was supplied. Uploading starts asynchronous processing. This storage upload is separate from the API endpoints.<br/>
        /// Example: https://uploads.b10.run/images/base-image/20260916212658/source.zip?expires=2026-09-16T22%3A26%3A58Z&amp;signature=demo-not-a-valid-upload-signature
        /// </summary>
        /// <example>https://uploads.b10.run/images/base-image/20260916212658/source.zip?expires=2026-09-16T22%3A26%3A58Z&amp;signature=demo-not-a-valid-upload-signature</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("upload_url")]
        public string? UploadUrl { get; set; }

        /// <summary>
        /// Registered image reference including its tag, when available. Tags are assigned by the service; GET /sandboxes/images/{image_name} returns the available tags once processing completes.<br/>
        /// Example: b10/base-image:latest
        /// </summary>
        /// <example>b10/base-image:latest</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        public string? Image { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PushImageResponseV1" /> class.
        /// </summary>
        /// <param name="name">
        /// Target image repository name.<br/>
        /// Example: base-image
        /// </param>
        /// <param name="status">
        /// Image processing status. Only BUILT images are ready to use.<br/>
        /// Example: BUILDING
        /// </param>
        /// <param name="uploadUrl">
        /// Temporary signed URL for uploading the source ZIP archive with HTTP PUT. Present only when no source image was supplied. Uploading starts asynchronous processing. This storage upload is separate from the API endpoints.<br/>
        /// Example: https://uploads.b10.run/images/base-image/20260916212658/source.zip?expires=2026-09-16T22%3A26%3A58Z&amp;signature=demo-not-a-valid-upload-signature
        /// </param>
        /// <param name="image">
        /// Registered image reference including its tag, when available. Tags are assigned by the service; GET /sandboxes/images/{image_name} returns the available tags once processing completes.<br/>
        /// Example: b10/base-image:latest
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PushImageResponseV1(
            string name,
            global::Baseten.ImageStatusV1 status,
            string? uploadUrl,
            string? image)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Status = status;
            this.UploadUrl = uploadUrl;
            this.Image = image;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PushImageResponseV1" /> class.
        /// </summary>
        public PushImageResponseV1()
        {
        }

    }
}