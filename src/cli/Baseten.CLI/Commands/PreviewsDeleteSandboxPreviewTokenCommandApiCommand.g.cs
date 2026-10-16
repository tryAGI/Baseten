#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Baseten.CLI.Commands;

internal static partial class PreviewsDeleteSandboxPreviewTokenCommandApiCommand
{
    private static Argument<string> SandboxName { get; } = new(
        name: @"sandbox-name")
    {
        Description = @"This is a missing parameter that was added automatically. Please check the OpenAPI spec.",
    };

    private static Argument<string> PreviewName { get; } = new(
        name: @"preview-name")
    {
        Description = @"This is a missing parameter that was added automatically. Please check the OpenAPI spec.",
    };

    private static Argument<string> TokenName { get; } = new(
        name: @"token-name")
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

    static partial void CustomizeCommand(ref Command command);

    public static Command Create(string? commandName = null)
    {
        var command = new Command(commandName ?? @"delete-sandbox-preview-token", @"Delete a preview token
Revoke the token. Requests using it are rejected immediately.");
                        command.Arguments.Add(SandboxName);
                        command.Arguments.Add(PreviewName);
                        command.Arguments.Add(TokenName);
                        command.Options.Add(TeamId);
                        command.Options.Add(XTeamId);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var sandboxName = parseResult.GetRequiredValue(SandboxName);
                        var previewName = parseResult.GetRequiredValue(PreviewName);
                        var tokenName = parseResult.GetRequiredValue(TokenName);
                        var teamId = parseResult.GetValue(TeamId);
                        var xTeamId = parseResult.GetValue(XTeamId);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                await client.Previews.DeleteSandboxPreviewTokenAsync(
                                    sandboxName: sandboxName,
                                    previewName: previewName,
                                    tokenName: tokenName,
                                    teamId: teamId,
                                    xTeamId: xTeamId,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);

                                await CliRuntime.WriteSuccessAsync(parseResult, cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        CustomizeCommand(ref command);
        return command;
    }
}