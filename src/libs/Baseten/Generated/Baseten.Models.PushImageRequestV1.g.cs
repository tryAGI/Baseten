
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Push a sandbox image from a source archive or an existing registry image.<br/>
    /// Example: {"name":"base-image","image":"docker.io/b10/base-image:latest","docker_config":"{\u0022auths\u0022:{\u0022https://index.docker.io/v1/\u0022:{\u0022auth\u0022:\u0022YjEwLXJldmlldzpkZW1vLW5vdC1hLXZhbGlkLXJlZ2lzdHJ5LXRva2Vu\u0022}}}"}
    /// </summary>
    public sealed partial class PushImageRequestV1
    {
        /// <summary>
        /// Target image repository name. Reusing a name pushes a new version to the existing repository.<br/>
        /// Example: base-image
        /// </summary>
        /// <example>base-image</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Optional source registry image reference including a registry hostname. When omitted, the response provides an archive upload URL.<br/>
        /// Example: docker.io/b10/base-image:latest
        /// </summary>
        /// <example>docker.io/b10/base-image:latest</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        public string? Image { get; set; }

        /// <summary>
        /// Optional serialized registry authentication configuration for importing a private image. Used only when image is supplied; never returned.<br/>
        /// Included only in requests<br/>
        /// Example: {"auths":{"https://index.docker.io/v1/":{"auth":"YjEwLXJldmlldzpkZW1vLW5vdC1hLXZhbGlkLXJlZ2lzdHJ5LXRva2Vu"}}}
        /// </summary>
        /// <example>{"auths":{"https://index.docker.io/v1/":{"auth":"YjEwLXJldmlldzpkZW1vLW5vdC1hLXZhbGlkLXJlZ2lzdHJ5LXRva2Vu"}}}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("docker_config")]
        public string? DockerConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PushImageRequestV1" /> class.
        /// </summary>
        /// <param name="name">
        /// Target image repository name. Reusing a name pushes a new version to the existing repository.<br/>
        /// Example: base-image
        /// </param>
        /// <param name="image">
        /// Optional source registry image reference including a registry hostname. When omitted, the response provides an archive upload URL.<br/>
        /// Example: docker.io/b10/base-image:latest
        /// </param>
        /// <param name="dockerConfig">
        /// Optional serialized registry authentication configuration for importing a private image. Used only when image is supplied; never returned.<br/>
        /// Included only in requests<br/>
        /// Example: {"auths":{"https://index.docker.io/v1/":{"auth":"YjEwLXJldmlldzpkZW1vLW5vdC1hLXZhbGlkLXJlZ2lzdHJ5LXRva2Vu"}}}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PushImageRequestV1(
            string name,
            string? image,
            string? dockerConfig)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Image = image;
            this.DockerConfig = dockerConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PushImageRequestV1" /> class.
        /// </summary>
        public PushImageRequestV1()
        {
        }

    }
}