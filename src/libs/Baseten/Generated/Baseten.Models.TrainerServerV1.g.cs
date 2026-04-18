
#nullable enable

namespace Baseten
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TrainerServerV1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BaseUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sampling_server")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.SamplingServerV1 SamplingServer { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TrainerServerV1" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="baseUrl"></param>
        /// <param name="samplingServer"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TrainerServerV1(
            string id,
            string baseUrl,
            global::Baseten.SamplingServerV1 samplingServer)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.BaseUrl = baseUrl ?? throw new global::System.ArgumentNullException(nameof(baseUrl));
            this.SamplingServer = samplingServer ?? throw new global::System.ArgumentNullException(nameof(samplingServer));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrainerServerV1" /> class.
        /// </summary>
        public TrainerServerV1()
        {
        }
    }
}