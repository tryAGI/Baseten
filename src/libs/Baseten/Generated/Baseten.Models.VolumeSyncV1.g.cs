
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Current state and result of a volume sync.
    /// </summary>
    public sealed partial class VolumeSyncV1
    {
        /// <summary>
        /// Identifier of this sync operation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sync_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SyncId { get; set; }

        /// <summary>
        /// Current lifecycle state of the sync.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Baseten.JsonConverters.VolumeSyncStatusV1JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.VolumeSyncStatusV1 Status { get; set; }

        /// <summary>
        /// Remote source being synced.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Baseten.JsonConverters.SourceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.Source Source { get; set; }

        /// <summary>
        /// BDN volume being populated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("destination")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.VolumeSyncDestinationV1 Destination { get; set; }

        /// <summary>
        /// Produced artifact identifier; null until the sync is ready.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("volume_version_id")]
        public string? VolumeVersionId { get; set; }

        /// <summary>
        /// Immutable BDN reference; null until the sync is ready.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version_ref")]
        public string? VersionRef { get; set; }

        /// <summary>
        /// BLAKE3 digest of the synced content; null until available.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_digest")]
        public string? ContentDigest { get; set; }

        /// <summary>
        /// Total size of the synced content in bytes; null until available.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_size_bytes")]
        public long? TotalSizeBytes { get; set; }

        /// <summary>
        /// Time at which the sync was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Time at which the sync reached a terminal state.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed_at")]
        public global::System.DateTime? CompletedAt { get; set; }

        /// <summary>
        /// Redacted failure details; null unless the sync failed.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public global::Baseten.VolumeSyncErrorV1? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VolumeSyncV1" /> class.
        /// </summary>
        /// <param name="syncId">
        /// Identifier of this sync operation.
        /// </param>
        /// <param name="status">
        /// Current lifecycle state of the sync.
        /// </param>
        /// <param name="source">
        /// Remote source being synced.
        /// </param>
        /// <param name="destination">
        /// BDN volume being populated.
        /// </param>
        /// <param name="createdAt">
        /// Time at which the sync was created.
        /// </param>
        /// <param name="volumeVersionId">
        /// Produced artifact identifier; null until the sync is ready.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="versionRef">
        /// Immutable BDN reference; null until the sync is ready.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="contentDigest">
        /// BLAKE3 digest of the synced content; null until available.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="totalSizeBytes">
        /// Total size of the synced content in bytes; null until available.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="completedAt">
        /// Time at which the sync reached a terminal state.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="error">
        /// Redacted failure details; null unless the sync failed.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VolumeSyncV1(
            string syncId,
            global::Baseten.VolumeSyncStatusV1 status,
            global::Baseten.Source source,
            global::Baseten.VolumeSyncDestinationV1 destination,
            global::System.DateTime createdAt,
            string? volumeVersionId,
            string? versionRef,
            string? contentDigest,
            long? totalSizeBytes,
            global::System.DateTime? completedAt,
            global::Baseten.VolumeSyncErrorV1? error)
        {
            this.SyncId = syncId ?? throw new global::System.ArgumentNullException(nameof(syncId));
            this.Status = status;
            this.Source = source;
            this.Destination = destination ?? throw new global::System.ArgumentNullException(nameof(destination));
            this.VolumeVersionId = volumeVersionId;
            this.VersionRef = versionRef;
            this.ContentDigest = contentDigest;
            this.TotalSizeBytes = totalSizeBytes;
            this.CreatedAt = createdAt;
            this.CompletedAt = completedAt;
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VolumeSyncV1" /> class.
        /// </summary>
        public VolumeSyncV1()
        {
        }

    }
}