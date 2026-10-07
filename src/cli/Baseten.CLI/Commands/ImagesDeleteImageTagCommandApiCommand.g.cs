#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Baseten.CLI.Commands;

internal static partial class ImagesDeleteImageTagCommandApiCommand
{
    private static Argument<string> ImageName { get; } = new(
        name: @"image-name")
    {
        Description = @"This is a missing parameter that was added automatically. Please check the OpenAPI spec.",
    };

    private static Argument<string> TagName { get; } = new(
        name: @"tag-name")
    {
        Description = @"This is a missing parameter that was added automatically. Please check the OpenAPI spec.",
    };

    private static Option<string?> TeamId { get; } = new(
        name: @"--team-id")
    {
        Description = @"Optional team ID. Must match X-Team-Id when both are supplied. If neither selector is supplied, defaults to the caller's only accessible team. Callers with multiple accessible teams must select a team. Requests without access to any team are forbidden.",
    };

    private static Option<string?> XTeamId { get; } = new(
        name: @"--x-team-id")
    {
        Description = @"Optional team ID. Must match the team_id query parameter when both are supplied. If neither selector is supplied, defaults to the caller's only accessible team. Callers with multiple accessible teams must select a team. Requests without access to any team are forbidden.",
    };

                    private static string FormatResponse(ParseResult parseResult, global::Baseten.ImageV1 value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Baseten.ImageV1 value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    static partial void CustomizeCommand(ref Command command);

    public static Command Create(string? commandName = null)
    {
        var command = new Command(commandName ?? @"delete-image-tag", @"Delete an image tag
Delete a specific image version. Reject deletion if the version is referenced by an active deployment. Return the updated image with its remaining tags, possibly empty.");
                        command.Arguments.Add(ImageName);
                        command.Arguments.Add(TagName);
                        command.Options.Add(TeamId);
                        command.Options.Add(XTeamId);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var imageName = parseResult.GetRequiredValue(ImageName);
                        var tagName = parseResult.GetRequiredValue(TagName);
                        var teamId = parseResult.GetValue(TeamId);
                        var xTeamId = parseResult.GetValue(XTeamId);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Images.DeleteImageTagAsync(
                                    imageName: imageName,
                                    tagName: tagName,
                                    teamId: teamId,
                                    xTeamId: xTeamId,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                if (!await CliRuntime.TryWriteOutputDirectoryAsync(
                                        parseResult,
                                        response,
                                        global::Baseten.SourceGenerationContext.Default,
                                        @"Tags",
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
        CustomizeCommand(ref command);
        return command;
    }
}