#nullable enable

using System.CommandLine;

namespace Baseten.CLI.Commands;

internal sealed record TrainingWeightAuthV1OptionSet(
    Option<global::Baseten.AuthMethod> AuthMethod,
                     Option<string?> AuthSecretName,
                     Option<string?> AwsOidcRoleArn,
                     Option<string?> AwsOidcRegion,
                     Option<string?> GcpOidcServiceAccount,
                     Option<string?> GcpOidcWorkloadIdProvider,
                     Option<string?> AwsAssumeRoleArn,
                     Option<string?> AwsAssumeRoleRegion)
{
    public static TrainingWeightAuthV1OptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new TrainingWeightAuthV1OptionSet(
                        AuthMethod: new Option<global::Baseten.AuthMethod>($"--{normalizedPrefix}auth-method")
                {
                    Description = @"Method used to authenticate the weight source.",
                    Required = true,
                },
                AuthSecretName: new Option<string?>($"--{normalizedPrefix}auth-secret-name")
                {
                    Description = @"Name of the workspace secret used for custom-secret authentication.",
                },
                AwsOidcRoleArn: new Option<string?>($"--{normalizedPrefix}aws-oidc-role-arn")
                {
                    Description = @"AWS IAM role ARN used for OIDC authentication.",
                },
                AwsOidcRegion: new Option<string?>($"--{normalizedPrefix}aws-oidc-region")
                {
                    Description = @"AWS region used for OIDC authentication.",
                },
                GcpOidcServiceAccount: new Option<string?>($"--{normalizedPrefix}gcp-oidc-service-account")
                {
                    Description = @"GCP service account used for OIDC authentication.",
                },
                GcpOidcWorkloadIdProvider: new Option<string?>($"--{normalizedPrefix}gcp-oidc-workload-id-provider")
                {
                    Description = @"GCP workload identity provider used for OIDC authentication.",
                },
                AwsAssumeRoleArn: new Option<string?>($"--{normalizedPrefix}aws-assume-role-arn")
                {
                    Description = @"AWS IAM role ARN that Baseten assumes to access the weight source.",
                },
                AwsAssumeRoleRegion: new Option<string?>($"--{normalizedPrefix}aws-assume-role-region")
                {
                    Description = @"AWS region used for assume-role authentication.",
                }
        );
    }
}