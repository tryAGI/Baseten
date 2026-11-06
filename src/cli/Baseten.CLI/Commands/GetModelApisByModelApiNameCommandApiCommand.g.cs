#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Baseten.CLI.Commands;

internal static partial class GetModelApisByModelApiNameCommandApiCommand
{
    private static Argument<string> ModelApiName { get; } = new(
        name: @"model-api-name")
    {
        Description = @"This is a missing parameter that was added automatically. Please check the OpenAPI spec.",
    };

    private static Option<global::System.Collections.Generic.IList<string>?> TeamIds { get; } = new(
        name: @"--team-ids")
    {
        Description = @"Select teams for added-model details, repeated once per team. Defaults to all teams where you can invoke Model APIs. Any unauthorized team causes a 403.",
    };

                    private static string FormatResponse(ParseResult parseResult, global::Baseten.ModelAPIV1 value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Baseten.ModelAPIV1 value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    static partial void CustomizeCommand(ref Command command);

    public static Command Create(string? commandName = null)
    {
        var command = new Command(commandName ?? @"get-model-apis-by-model-api-name", @"Gets a Model API
Returns model metadata with added-model details for teams where you can invoke Model APIs. Legacy Default Team fields remain deprecated but unchanged. Pass team_ids to narrow team details; unauthorized teams cause a 403.");
                        command.Arguments.Add(ModelApiName);
                        command.Options.Add(TeamIds);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var modelApiName = parseResult.GetRequiredValue(ModelApiName);
                        var teamIds = parseResult.GetValue(TeamIds);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.GetModelApisByModelApiNameAsync(
                                    modelApiName: modelApiName,
                                    teamIds: teamIds,
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