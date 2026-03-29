
#nullable enable

namespace Baseten
{
    /// <summary>
    /// 
    /// </summary>
    public enum DockerAuthType
    {
        /// <summary>
        /// 
        /// </summary>
        AwsIam,
        /// <summary>
        /// 
        /// </summary>
        AwsOidc,
        /// <summary>
        /// 
        /// </summary>
        GcpOidc,
        /// <summary>
        /// 
        /// </summary>
        GcpServiceAccountJson,
        /// <summary>
        /// 
        /// </summary>
        RegistrySecret,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DockerAuthTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DockerAuthType value)
        {
            return value switch
            {
                DockerAuthType.AwsIam => "AWS_IAM",
                DockerAuthType.AwsOidc => "AWS_OIDC",
                DockerAuthType.GcpOidc => "GCP_OIDC",
                DockerAuthType.GcpServiceAccountJson => "GCP_SERVICE_ACCOUNT_JSON",
                DockerAuthType.RegistrySecret => "REGISTRY_SECRET",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DockerAuthType? ToEnum(string value)
        {
            return value switch
            {
                "AWS_IAM" => DockerAuthType.AwsIam,
                "AWS_OIDC" => DockerAuthType.AwsOidc,
                "GCP_OIDC" => DockerAuthType.GcpOidc,
                "GCP_SERVICE_ACCOUNT_JSON" => DockerAuthType.GcpServiceAccountJson,
                "REGISTRY_SECRET" => DockerAuthType.RegistrySecret,
                _ => null,
            };
        }
    }
}