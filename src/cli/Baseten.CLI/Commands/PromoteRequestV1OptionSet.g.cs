#nullable enable

using System.CommandLine;

namespace Baseten.CLI.Commands;

internal sealed record PromoteRequestV1OptionSet(
    Option<bool?> ScaleDownPreviousProduction,
                     Option<bool?> PreserveEnvInstanceType)
{
    public static PromoteRequestV1OptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new PromoteRequestV1OptionSet(
                        ScaleDownPreviousProduction: CliRuntime.CreateNullableBoolOption(name: $"--{normalizedPrefix}scale-down-previous-production", description: @"Whether to scale down the previous production deployment after promoting"),
                PreserveEnvInstanceType: CliRuntime.CreateNullableBoolOption(name: $"--{normalizedPrefix}preserve-env-instance-type", description: @"Whether to use the promoting deployment's instance type or preserve target environment's instance type")
        );
    }
}