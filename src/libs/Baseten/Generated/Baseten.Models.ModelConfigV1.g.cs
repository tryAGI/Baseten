
#nullable enable

namespace Baseten
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModelConfigV1
    {
        /// <summary>
        /// Shared endpoint slug.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Slug { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rate_limits")]
        public global::System.Collections.Generic.IList<global::Baseten.RateLimitV1>? RateLimits { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage_limits")]
        public global::System.Collections.Generic.IList<global::Baseten.UsageLimitV1>? UsageLimits { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelConfigV1" /> class.
        /// </summary>
        /// <param name="slug">
        /// Shared endpoint slug.
        /// </param>
        /// <param name="rateLimits"></param>
        /// <param name="usageLimits"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelConfigV1(
            string slug,
            global::System.Collections.Generic.IList<global::Baseten.RateLimitV1>? rateLimits,
            global::System.Collections.Generic.IList<global::Baseten.UsageLimitV1>? usageLimits)
        {
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
            this.RateLimits = rateLimits;
            this.UsageLimits = usageLimits;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelConfigV1" /> class.
        /// </summary>
        public ModelConfigV1()
        {
        }

    }
}