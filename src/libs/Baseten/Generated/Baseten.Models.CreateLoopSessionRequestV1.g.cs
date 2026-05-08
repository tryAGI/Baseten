
#nullable enable

namespace Baseten
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateLoopSessionRequestV1
    {
        /// <summary>
        /// ID of the training project to associate with. If omitted, a default project is created for the org.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("training_project_id")]
        public string? TrainingProjectId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateLoopSessionRequestV1" /> class.
        /// </summary>
        /// <param name="trainingProjectId">
        /// ID of the training project to associate with. If omitted, a default project is created for the org.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateLoopSessionRequestV1(
            string? trainingProjectId)
        {
            this.TrainingProjectId = trainingProjectId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateLoopSessionRequestV1" /> class.
        /// </summary>
        public CreateLoopSessionRequestV1()
        {
        }
    }
}