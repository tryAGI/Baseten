
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Filters for searching trainers visible to the requesting user.
    /// </summary>
    public sealed partial class SearchTrainersRequestV1
    {
        /// <summary>
        /// Filter by trainer ID.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trainer_id")]
        public string? TrainerId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchTrainersRequestV1" /> class.
        /// </summary>
        /// <param name="trainerId">
        /// Filter by trainer ID.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchTrainersRequestV1(
            string? trainerId)
        {
            this.TrainerId = trainerId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchTrainersRequestV1" /> class.
        /// </summary>
        public SearchTrainersRequestV1()
        {
        }
    }
}