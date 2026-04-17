
#nullable enable

namespace Baseten
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SamplingServerV1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_url")]
        public string? BaseUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SamplingServerV1" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="baseUrl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SamplingServerV1(
            string? id,
            string? baseUrl)
        {
            this.Id = id;
            this.BaseUrl = baseUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SamplingServerV1" /> class.
        /// </summary>
        public SamplingServerV1()
        {
        }
    }
}