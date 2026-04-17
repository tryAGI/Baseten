
#nullable enable

namespace Baseten
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateSamplingServerResponseV1
    {
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
        /// Initializes a new instance of the <see cref="CreateSamplingServerResponseV1" /> class.
        /// </summary>
        /// <param name="samplingServer"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateSamplingServerResponseV1(
            global::Baseten.SamplingServerV1 samplingServer)
        {
            this.SamplingServer = samplingServer ?? throw new global::System.ArgumentNullException(nameof(samplingServer));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSamplingServerResponseV1" /> class.
        /// </summary>
        public CreateSamplingServerResponseV1()
        {
        }
    }
}