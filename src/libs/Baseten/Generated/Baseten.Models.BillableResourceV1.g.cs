
#nullable enable

namespace Baseten
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BillableResourceV1
    {
        /// <summary>
        /// Unique identifier of the resource
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Resource kind (MODEL_DEPLOYMENT, TRAINING_JOB, or CHAINLET)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Baseten.JsonConverters.ResourceKindJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.ResourceKind Kind { get; set; }

        /// <summary>
        /// Name of the resource<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Indicates if the resource has been deleted
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_deleted")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsDeleted { get; set; }

        /// <summary>
        /// Instance type used<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instance_type")]
        public string? InstanceType { get; set; }

        /// <summary>
        /// Environment name (e.g., 'production', 'staging')<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment_name")]
        public string? EnvironmentName { get; set; }

        /// <summary>
        /// Chain metadata if this is a chainlet deployment<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chain_metadata")]
        public global::Baseten.ChainMetadataV1? ChainMetadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BillableResourceV1" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier of the resource
        /// </param>
        /// <param name="kind">
        /// Resource kind (MODEL_DEPLOYMENT, TRAINING_JOB, or CHAINLET)
        /// </param>
        /// <param name="isDeleted">
        /// Indicates if the resource has been deleted
        /// </param>
        /// <param name="name">
        /// Name of the resource<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="instanceType">
        /// Instance type used<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="environmentName">
        /// Environment name (e.g., 'production', 'staging')<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="chainMetadata">
        /// Chain metadata if this is a chainlet deployment<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BillableResourceV1(
            string id,
            global::Baseten.ResourceKind kind,
            bool isDeleted,
            string? name,
            string? instanceType,
            string? environmentName,
            global::Baseten.ChainMetadataV1? chainMetadata)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Kind = kind;
            this.Name = name;
            this.IsDeleted = isDeleted;
            this.InstanceType = instanceType;
            this.EnvironmentName = environmentName;
            this.ChainMetadata = chainMetadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BillableResourceV1" /> class.
        /// </summary>
        public BillableResourceV1()
        {
        }
    }
}