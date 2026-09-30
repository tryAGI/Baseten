#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Baseten.CLI.Commands;

internal static partial class GetRoutesHarnessConfigsCommandApiCommand
{
    private static Option<string> TeamId { get; } = new(
        name: @"--team-id")
    {
        Description = @"Identifier of the team whose default models to list.",
        Required = true,
    };

                    private static string FormatResponse(ParseResult parseResult, global::Baseten.RouteHarnessConfigsResponseV1 value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Baseten.RouteHarnessConfigsResponseV1 value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    static partial void CustomizeCommand(ref Command command);

    public static Command Create(string? commandName = null)
    {
        var command = new Command(commandName ?? @"get-routes-harness-configs", @"Lists default models for coding harnesses
Each role uses the route a team admin set for it (`source` is `team`). A role with no route set uses Baseten's default (`source` is `baseten`), chosen from the team's Model API routes: the recommended model for `primary` and the lowest-priced model for `background`. Baseten's defaults never use external-provider routes.");
                        command.Options.Add(TeamId);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var teamId = parseResult.GetRequiredValue(TeamId);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.GetRoutesHarnessConfigsAsync(
                                    teamId: teamId,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::Baseten.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        CustomizeCommand(ref command);
        return command;
    }
}