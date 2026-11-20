
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SetTrainingJobCheckpointTtlRequestV1
    {
        /// <summary>
        /// Seconds from now until the checkpoint expires and is deleted, from 3600 (1 hour) to 315360000 (10 years). Null removes the TTL, so the checkpoint never expires.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ttl_seconds")]
        public int? TtlSeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SetTrainingJobCheckpointTtlRequestV1" /> class.
        /// </summary>
        /// <param name="ttlSeconds">
        /// Seconds from now until the checkpoint expires and is deleted, from 3600 (1 hour) to 315360000 (10 years). Null removes the TTL, so the checkpoint never expires.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SetTrainingJobCheckpointTtlRequestV1(
            int? ttlSeconds)
        {
            this.TtlSeconds = ttlSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SetTrainingJobCheckpointTtlRequestV1" /> class.
        /// </summary>
        public SetTrainingJobCheckpointTtlRequestV1()
        {
        }

    }
}