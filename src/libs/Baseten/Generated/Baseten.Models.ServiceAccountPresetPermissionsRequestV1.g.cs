
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A service account's access, as sent. Omit a list for no restriction; never send it empty.
    /// </summary>
    public sealed partial class ServiceAccountPresetPermissionsRequestV1
    {
        /// <summary>
        /// What the service account may do. WORKSPACE_MANAGE_API_KEYS is for organization-level accounts only; every other type needs a team.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Baseten.JsonConverters.ServiceAccountPresetTypeV1JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.ServiceAccountPresetTypeV1 Type { get; set; }

        /// <summary>
        /// WORKSPACE_INVOKE and WORKSPACE_EXPORT_METRICS only. Models the account covers. Omit for every model in the team, including models added later.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_ids")]
        public global::System.Collections.Generic.IList<string>? ModelIds { get; set; }

        /// <summary>
        /// WORKSPACE_INVOKE: environments the account may call; omit for all. With model_ids, each model must have each environment. WORKSPACE_MANAGE_ALL: restricted environments the account may also manage.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment_names")]
        public global::System.Collections.Generic.IList<string>? EnvironmentNames { get; set; }

        /// <summary>
        /// WORKSPACE_INVOKE_MODEL_APIS only. Model APIs the account may call; omit for all.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_api_slugs")]
        public global::System.Collections.Generic.IList<string>? ModelApiSlugs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceAccountPresetPermissionsRequestV1" /> class.
        /// </summary>
        /// <param name="type">
        /// What the service account may do. WORKSPACE_MANAGE_API_KEYS is for organization-level accounts only; every other type needs a team.
        /// </param>
        /// <param name="modelIds">
        /// WORKSPACE_INVOKE and WORKSPACE_EXPORT_METRICS only. Models the account covers. Omit for every model in the team, including models added later.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="environmentNames">
        /// WORKSPACE_INVOKE: environments the account may call; omit for all. With model_ids, each model must have each environment. WORKSPACE_MANAGE_ALL: restricted environments the account may also manage.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="modelApiSlugs">
        /// WORKSPACE_INVOKE_MODEL_APIS only. Model APIs the account may call; omit for all.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ServiceAccountPresetPermissionsRequestV1(
            global::Baseten.ServiceAccountPresetTypeV1 type,
            global::System.Collections.Generic.IList<string>? modelIds,
            global::System.Collections.Generic.IList<string>? environmentNames,
            global::System.Collections.Generic.IList<string>? modelApiSlugs)
        {
            this.Type = type;
            this.ModelIds = modelIds;
            this.EnvironmentNames = environmentNames;
            this.ModelApiSlugs = modelApiSlugs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceAccountPresetPermissionsRequestV1" /> class.
        /// </summary>
        public ServiceAccountPresetPermissionsRequestV1()
        {
        }

    }
}