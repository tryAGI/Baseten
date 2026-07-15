
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Query params for listing audit-log entries.
    /// </summary>
    public sealed partial class ListAuditLogsRequestV1
    {
        /// <summary>
        /// Opaque cursor returned by a previous page. Omit to fetch the first page.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cursor")]
        public string? Cursor { get; set; }

        /// <summary>
        /// Maximum number of entries to return per page. Defaults to 20, and must be between 1 and 200.<br/>
        /// Default Value: 20
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// Sort order by the time the action occurred. Defaults to DESC (newest first). Ignored when paginating with a cursor.<br/>
        /// Default Value: DESC
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("direction")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Baseten.JsonConverters.AuditLogSortDirectionV1JsonConverter))]
        public global::Baseten.AuditLogSortDirectionV1? Direction { get; set; }

        /// <summary>
        /// Case-insensitive substring matched against resource names and IDs in the entry.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("search")]
        public string? Search { get; set; }

        /// <summary>
        /// When set, returns only entries whose event type falls in one of these groups.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_type_groups")]
        public global::System.Collections.Generic.IList<global::Baseten.AuditLogEventTypeGroupV1>? EventTypeGroups { get; set; }

        /// <summary>
        /// When set, returns only entries whose acting user is one of these IDs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_ids")]
        public global::System.Collections.Generic.IList<string>? UserIds { get; set; }

        /// <summary>
        /// When set, returns only entries referencing one of these model deployment IDs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployment_ids")]
        public global::System.Collections.Generic.IList<string>? DeploymentIds { get; set; }

        /// <summary>
        /// When set, returns only entries referencing one of these chain deployment IDs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chain_deployment_ids")]
        public global::System.Collections.Generic.IList<string>? ChainDeploymentIds { get; set; }

        /// <summary>
        /// When set, returns only entries for one of these environments.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment_names")]
        public global::System.Collections.Generic.IList<string>? EnvironmentNames { get; set; }

        /// <summary>
        /// When set, returns only entries issued from one of these surfaces.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sources")]
        public global::System.Collections.Generic.IList<global::Baseten.AuditLogSourceV1>? Sources { get; set; }

        /// <summary>
        /// Epoch milliseconds for the start of the window. Defaults to the beginning of the audit-log history.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_epoch_millis")]
        public long? StartEpochMillis { get; set; }

        /// <summary>
        /// Epoch milliseconds for the end of the window. Defaults to the current time.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_epoch_millis")]
        public long? EndEpochMillis { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListAuditLogsRequestV1" /> class.
        /// </summary>
        /// <param name="cursor">
        /// Opaque cursor returned by a previous page. Omit to fetch the first page.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="limit">
        /// Maximum number of entries to return per page. Defaults to 20, and must be between 1 and 200.<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="direction">
        /// Sort order by the time the action occurred. Defaults to DESC (newest first). Ignored when paginating with a cursor.<br/>
        /// Default Value: DESC
        /// </param>
        /// <param name="search">
        /// Case-insensitive substring matched against resource names and IDs in the entry.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="eventTypeGroups">
        /// When set, returns only entries whose event type falls in one of these groups.
        /// </param>
        /// <param name="userIds">
        /// When set, returns only entries whose acting user is one of these IDs.
        /// </param>
        /// <param name="deploymentIds">
        /// When set, returns only entries referencing one of these model deployment IDs.
        /// </param>
        /// <param name="chainDeploymentIds">
        /// When set, returns only entries referencing one of these chain deployment IDs.
        /// </param>
        /// <param name="environmentNames">
        /// When set, returns only entries for one of these environments.
        /// </param>
        /// <param name="sources">
        /// When set, returns only entries issued from one of these surfaces.
        /// </param>
        /// <param name="startEpochMillis">
        /// Epoch milliseconds for the start of the window. Defaults to the beginning of the audit-log history.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="endEpochMillis">
        /// Epoch milliseconds for the end of the window. Defaults to the current time.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListAuditLogsRequestV1(
            string? cursor,
            int? limit,
            global::Baseten.AuditLogSortDirectionV1? direction,
            string? search,
            global::System.Collections.Generic.IList<global::Baseten.AuditLogEventTypeGroupV1>? eventTypeGroups,
            global::System.Collections.Generic.IList<string>? userIds,
            global::System.Collections.Generic.IList<string>? deploymentIds,
            global::System.Collections.Generic.IList<string>? chainDeploymentIds,
            global::System.Collections.Generic.IList<string>? environmentNames,
            global::System.Collections.Generic.IList<global::Baseten.AuditLogSourceV1>? sources,
            long? startEpochMillis,
            long? endEpochMillis)
        {
            this.Cursor = cursor;
            this.Limit = limit;
            this.Direction = direction;
            this.Search = search;
            this.EventTypeGroups = eventTypeGroups;
            this.UserIds = userIds;
            this.DeploymentIds = deploymentIds;
            this.ChainDeploymentIds = chainDeploymentIds;
            this.EnvironmentNames = environmentNames;
            this.Sources = sources;
            this.StartEpochMillis = startEpochMillis;
            this.EndEpochMillis = endEpochMillis;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListAuditLogsRequestV1" /> class.
        /// </summary>
        public ListAuditLogsRequestV1()
        {
        }

    }
}