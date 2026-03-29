
#nullable enable

namespace Baseten
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateTrainingJobCacheConfig
    {
        /// <summary>
        /// Whether to enable the legacy Hugging Face cache.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_legacy_hf_mount")]
        public bool? EnableLegacyHfMount { get; set; }

        /// <summary>
        /// Whether to enable the read-write cache.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Whether to require region affinity for the read-write cache. If False, the resulting job is not guaranteed to be deployed alongside the previous cache.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("require_cache_affinity")]
        public bool? RequireCacheAffinity { get; set; }

        /// <summary>
        /// Mount base path for the cache directory. The project cache and team cache will be mounted under this path.<br/>
        /// Default Value: /root/.cache
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mount_base_path")]
        public string? MountBasePath { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTrainingJobCacheConfig" /> class.
        /// </summary>
        /// <param name="enableLegacyHfMount">
        /// Whether to enable the legacy Hugging Face cache.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="enabled">
        /// Whether to enable the read-write cache.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requireCacheAffinity">
        /// Whether to require region affinity for the read-write cache. If False, the resulting job is not guaranteed to be deployed alongside the previous cache.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="mountBasePath">
        /// Mount base path for the cache directory. The project cache and team cache will be mounted under this path.<br/>
        /// Default Value: /root/.cache
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTrainingJobCacheConfig(
            bool? enableLegacyHfMount,
            bool? enabled,
            bool? requireCacheAffinity,
            string? mountBasePath)
        {
            this.EnableLegacyHfMount = enableLegacyHfMount;
            this.Enabled = enabled;
            this.RequireCacheAffinity = requireCacheAffinity;
            this.MountBasePath = mountBasePath;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTrainingJobCacheConfig" /> class.
        /// </summary>
        public CreateTrainingJobCacheConfig()
        {
        }
    }
}