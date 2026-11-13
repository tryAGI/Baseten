
#nullable enable

namespace Baseten
{
    /// <summary>
    /// An identity provider Baseten supports.
    /// </summary>
    public enum PredefinedIdentityProviderKindV1
    {
        /// <summary>
        ///
        /// </summary>
        AwsEks,
        /// <summary>
        ///
        /// </summary>
        AwsIam,
        /// <summary>
        ///
        /// </summary>
        AzureAks,
        /// <summary>
        ///
        /// </summary>
        AzureManagedIdentityV1,
        /// <summary>
        ///
        /// </summary>
        AzureManagedIdentityV2,
        /// <summary>
        ///
        /// </summary>
        Baseten,
        /// <summary>
        ///
        /// </summary>
        Gcp,
        /// <summary>
        ///
        /// </summary>
        GithubActions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PredefinedIdentityProviderKindV1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PredefinedIdentityProviderKindV1 value)
        {
            return value switch
            {
                PredefinedIdentityProviderKindV1.AwsEks => "AWS_EKS",
                PredefinedIdentityProviderKindV1.AwsIam => "AWS_IAM",
                PredefinedIdentityProviderKindV1.AzureAks => "AZURE_AKS",
                PredefinedIdentityProviderKindV1.AzureManagedIdentityV1 => "AZURE_MANAGED_IDENTITY_V1",
                PredefinedIdentityProviderKindV1.AzureManagedIdentityV2 => "AZURE_MANAGED_IDENTITY_V2",
                PredefinedIdentityProviderKindV1.Baseten => "BASETEN",
                PredefinedIdentityProviderKindV1.Gcp => "GCP",
                PredefinedIdentityProviderKindV1.GithubActions => "GITHUB_ACTIONS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PredefinedIdentityProviderKindV1? ToEnum(string value)
        {
            return value switch
            {
                "AWS_EKS" => PredefinedIdentityProviderKindV1.AwsEks,
                "AWS_IAM" => PredefinedIdentityProviderKindV1.AwsIam,
                "AZURE_AKS" => PredefinedIdentityProviderKindV1.AzureAks,
                "AZURE_MANAGED_IDENTITY_V1" => PredefinedIdentityProviderKindV1.AzureManagedIdentityV1,
                "AZURE_MANAGED_IDENTITY_V2" => PredefinedIdentityProviderKindV1.AzureManagedIdentityV2,
                "BASETEN" => PredefinedIdentityProviderKindV1.Baseten,
                "GCP" => PredefinedIdentityProviderKindV1.Gcp,
                "GITHUB_ACTIONS" => PredefinedIdentityProviderKindV1.GithubActions,
                _ => null,
            };
        }
    }
}