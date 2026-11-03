
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateGridMachineUserRequestV1
    {
        /// <summary>
        /// Identifier of the team that owns the machine user. Defaults to your only team, if you belong to exactly one.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_id")]
        public string? TeamId { get; set; }

        /// <summary>
        /// Name of the machine user, unique within the team. At most 255 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// When set, also creates the machine user's first API key.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key")]
        public global::Baseten.CreateGridMachineUserAPIKeyRequestV1? ApiKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGridMachineUserRequestV1" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the machine user, unique within the team. At most 255 characters.
        /// </param>
        /// <param name="teamId">
        /// Identifier of the team that owns the machine user. Defaults to your only team, if you belong to exactly one.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="apiKey">
        /// When set, also creates the machine user's first API key.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateGridMachineUserRequestV1(
            string name,
            string? teamId,
            global::Baseten.CreateGridMachineUserAPIKeyRequestV1? apiKey)
        {
            this.TeamId = teamId;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.ApiKey = apiKey;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGridMachineUserRequestV1" /> class.
        /// </summary>
        public CreateGridMachineUserRequestV1()
        {
        }

    }
}