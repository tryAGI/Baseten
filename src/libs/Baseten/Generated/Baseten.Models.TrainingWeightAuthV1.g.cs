
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Authentication configuration for a training weight source.
    /// </summary>
    public sealed partial class TrainingWeightAuthV1
    {
        /// <summary>
        /// Method used to authenticate the weight source.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_method")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Baseten.JsonConverters.AuthMethodJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.AuthMethod AuthMethod { get; set; }

        /// <summary>
        /// Name of the workspace secret used for custom-secret authentication.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_secret_name")]
        public string? AuthSecretName { get; set; }

        /// <summary>
        /// AWS IAM role ARN used for OIDC authentication.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aws_oidc_role_arn")]
        public string? AwsOidcRoleArn { get; set; }

        /// <summary>
        /// AWS region used for OIDC authentication.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aws_oidc_region")]
        public string? AwsOidcRegion { get; set; }

        /// <summary>
        /// GCP service account used for OIDC authentication.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gcp_oidc_service_account")]
        public string? GcpOidcServiceAccount { get; set; }

        /// <summary>
        /// GCP workload identity provider used for OIDC authentication.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gcp_oidc_workload_id_provider")]
        public string? GcpOidcWorkloadIdProvider { get; set; }

        /// <summary>
        /// AWS IAM role ARN that Baseten assumes to access the weight source.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aws_assume_role_arn")]
        public string? AwsAssumeRoleArn { get; set; }

        /// <summary>
        /// AWS region used for assume-role authentication.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aws_assume_role_region")]
        public string? AwsAssumeRoleRegion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TrainingWeightAuthV1" /> class.
        /// </summary>
        /// <param name="authMethod">
        /// Method used to authenticate the weight source.
        /// </param>
        /// <param name="authSecretName">
        /// Name of the workspace secret used for custom-secret authentication.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="awsOidcRoleArn">
        /// AWS IAM role ARN used for OIDC authentication.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="awsOidcRegion">
        /// AWS region used for OIDC authentication.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="gcpOidcServiceAccount">
        /// GCP service account used for OIDC authentication.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="gcpOidcWorkloadIdProvider">
        /// GCP workload identity provider used for OIDC authentication.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="awsAssumeRoleArn">
        /// AWS IAM role ARN that Baseten assumes to access the weight source.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="awsAssumeRoleRegion">
        /// AWS region used for assume-role authentication.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TrainingWeightAuthV1(
            global::Baseten.AuthMethod authMethod,
            string? authSecretName,
            string? awsOidcRoleArn,
            string? awsOidcRegion,
            string? gcpOidcServiceAccount,
            string? gcpOidcWorkloadIdProvider,
            string? awsAssumeRoleArn,
            string? awsAssumeRoleRegion)
        {
            this.AuthMethod = authMethod;
            this.AuthSecretName = authSecretName;
            this.AwsOidcRoleArn = awsOidcRoleArn;
            this.AwsOidcRegion = awsOidcRegion;
            this.GcpOidcServiceAccount = gcpOidcServiceAccount;
            this.GcpOidcWorkloadIdProvider = gcpOidcWorkloadIdProvider;
            this.AwsAssumeRoleArn = awsAssumeRoleArn;
            this.AwsAssumeRoleRegion = awsAssumeRoleRegion;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrainingWeightAuthV1" /> class.
        /// </summary>
        public TrainingWeightAuthV1()
        {
        }

    }
}