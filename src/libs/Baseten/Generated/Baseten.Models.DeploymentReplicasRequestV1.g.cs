
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DeploymentReplicasRequestV1
    {
        /// <summary>
        /// Opaque cursor returned by a previous page. Omit to fetch the first page.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cursor")]
        public string? Cursor { get; set; }

        /// <summary>
        /// Maximum number of items to return.<br/>
        /// Default Value: 100
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// Replica statuses to include. Repeat the statuses query parameter to filter by multiple statuses. Omit to include all statuses, including terminated replicas.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("statuses")]
        public global::System.Collections.Generic.IList<global::Baseten.DeploymentReplicaStatusV1>? Statuses { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentReplicasRequestV1" /> class.
        /// </summary>
        /// <param name="cursor">
        /// Opaque cursor returned by a previous page. Omit to fetch the first page.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="limit">
        /// Maximum number of items to return.<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="statuses">
        /// Replica statuses to include. Repeat the statuses query parameter to filter by multiple statuses. Omit to include all statuses, including terminated replicas.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeploymentReplicasRequestV1(
            string? cursor,
            int? limit,
            global::System.Collections.Generic.IList<global::Baseten.DeploymentReplicaStatusV1>? statuses)
        {
            this.Cursor = cursor;
            this.Limit = limit;
            this.Statuses = statuses;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentReplicasRequestV1" /> class.
        /// </summary>
        public DeploymentReplicasRequestV1()
        {
        }

    }
}