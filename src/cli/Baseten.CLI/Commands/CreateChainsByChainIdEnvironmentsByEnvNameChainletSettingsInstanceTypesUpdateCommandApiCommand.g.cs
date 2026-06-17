#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Baseten.CLI.Commands;

internal static partial class CreateChainsByChainIdEnvironmentsByEnvNameChainletSettingsInstanceTypesUpdateCommandApiCommand
{
    private static Argument<string> ChainId { get; } = new(
        name: @"chain-id")
    {
        Description = @"This is a missing parameter that was added automatically. Please check the OpenAPI spec.",
    };

    private static Argument<string> EnvName { get; } = new(
        name: @"env-name")
    {
        Description = @"This is a missing parameter that was added automatically. Please check the OpenAPI spec.",
    };

    private static Option<global::System.Collections.Generic.IList<global::Baseten.ChainletEnvironmentInstanceTypeUpdateV1>> Updates { get; } = new(
        name: @"--updates")
    {
        Description = @"Mapping of chainlet name to the desired chainlet instance type. If the chainlet name doesn't exist, an error is returned.",
        Required = true,
    };

                    private static string FormatResponse(ParseResult parseResult, global::Baseten.UpdateChainletEnvironmentInstanceTypeResponseV1 value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
                    {
                        string? text = null;
                        CustomizeResponseText(parseResult, value, ref text);
                        if (!string.IsNullOrWhiteSpace(text))
                        {
                            return text;
                        }

                        var hints = new Dictionary<string, CliFormatHint>(StringComparer.OrdinalIgnoreCase)
                        {
                        };
                        CustomizeResponseFormatHints(hints);
                        return CliRuntime.FormatHumanReadable(value, context, truncateLongStrings, hints);
                    }

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Baseten.UpdateChainletEnvironmentInstanceTypeResponseV1 value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"create-chains-by-chain-id-environments-by-env-name-chainlet-settings-instance-types-update", @"Update a chainlet environment's instance type settings.
Updates a chainlet environment's instance type settings. The chainlet environment setting must exist. When updated, a new chain deployment is created and deployed. It is promoted to the chain environment according to promotion settings on the environment.");
                        command.Arguments.Add(ChainId);
                        command.Arguments.Add(EnvName);
                        command.Options.Add(Updates);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var chainId = parseResult.GetRequiredValue(ChainId);
                        var envName = parseResult.GetRequiredValue(EnvName);
                        var updates = parseResult.GetRequiredValue(Updates);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.CreateChainsByChainIdEnvironmentsByEnvNameChainletSettingsInstanceTypesUpdateAsync(
                                    chainId: chainId,
                                    envName: envName,
                                    updates: updates,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                if (!await CliRuntime.TryWriteOutputDirectoryAsync(
                                        parseResult,
                                        response,
                                        global::Baseten.SourceGenerationContext.Default,
                                        @"ChainletEnvironmentSettings",
                                        cancellationToken).ConfigureAwait(false))
                                {
                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::Baseten.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
                                }
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}