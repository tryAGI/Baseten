#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Baseten.CLI.Commands;

internal static partial class DeleteRoutesHarnessConfigsByHarnessCommandApiCommand
{
    private static Argument<string> Harness { get; } = new(
        name: @"harness")
    {
        Description = @"This is a missing parameter that was added automatically. Please check the OpenAPI spec.",
    };

    private static Option<string> TeamId { get; } = new(
        name: @"--team-id")
    {
        Description = @"Identifier of the team whose default models to clear.",
        Required = true,
    };

                    private static string FormatResponse(ParseResult parseResult, global::Baseten.RouteHarnessConfigTombstoneV1 value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Baseten.RouteHarnessConfigTombstoneV1 value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    static partial void CustomizeCommand(ref Command command);

    public static Command Create(string? commandName = null)
    {
        var command = new Command(commandName ?? @"delete-routes-harness-configs-by-harness", @"Clears default models for a coding harness
Removes the team's routes for every role of the harness, so each role uses Baseten's default. Requires team admin.");
                        command.Arguments.Add(Harness);
                        command.Options.Add(TeamId);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var harness = parseResult.GetRequiredValue(Harness);
                        var teamId = parseResult.GetRequiredValue(TeamId);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.DeleteRoutesHarnessConfigsByHarnessAsync(
                                    harness: harness,
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