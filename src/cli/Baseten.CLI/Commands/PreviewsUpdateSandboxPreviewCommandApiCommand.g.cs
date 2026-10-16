#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Baseten.CLI.Commands;

internal static partial class PreviewsUpdateSandboxPreviewCommandApiCommand
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

    private static Option<bool?> Public { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--public",
        description: @"Whether the URL is reachable without a preview token. Defaults to false.");

    private static Option<global::System.Collections.Generic.Dictionary<string, string>?> ResponseHeaders { get; } = new(
        name: @"--response-headers")
    {
        Description = @"Headers added to every response served by the preview, for example CORS headers.",
    };

    private static Option<global::System.Collections.Generic.Dictionary<string, string>?> RequestHeaders { get; } = new(
        name: @"--request-headers")
    {
        Description = @"Headers added to every request forwarded to the sandbox, for example an Authorization header expected by the application. Responses return each name with the value ""****"", except a GET with show_secrets=true by a workspace administrator. Sending ""****"" back as a value returns 400. A PATCH replaces the whole set.",
    };

    private static Option<string?> Ttl { get; } = new(
        name: @"--ttl")
    {
        Description = @"Lifetime counted from the request, using seconds, minutes, hours or composite durations such as 1h30m. Whole days are also supported, for example 7d; days cannot be combined with other units. The preview is deleted when it elapses.",
    };

    private static Option<global::System.DateTime?> ExpiresAt { get; } = new(
        name: @"--expires-at")
    {
        Description = @"Time at which the preview is deleted. Must be in the future.",
    };

                    private static string FormatResponse(ParseResult parseResult, global::Baseten.SandboxPreviewV1 value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Baseten.SandboxPreviewV1 value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    static partial void CustomizeCommand(ref Command command);

    public static Command Create(string? commandName = null)
    {
        var command = new Command(commandName ?? @"update-sandbox-preview", @"Update a sandbox preview
Partially update the preview. Omitted fields remain unchanged; supplied header maps replace their previous values. The URL does not change. Setting ttl or expires_at replaces any previous expiration and restarts it from now. The name and port are immutable; supplying either returns 400.");
                        command.Arguments.Add(SandboxName);
                        command.Arguments.Add(PreviewName);
                        command.Options.Add(TeamId);
                        command.Options.Add(XTeamId);
                        command.Options.Add(Public);
                        command.Options.Add(ResponseHeaders);
                        command.Options.Add(RequestHeaders);
                        command.Options.Add(Ttl);
                        command.Options.Add(ExpiresAt);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var sandboxName = parseResult.GetRequiredValue(SandboxName);
                        var previewName = parseResult.GetRequiredValue(PreviewName);
                        var teamId = parseResult.GetValue(TeamId);
                        var xTeamId = parseResult.GetValue(XTeamId);
                        var @public = parseResult.GetValue(Public);
                        var responseHeaders = parseResult.GetValue(ResponseHeaders);
                        var requestHeaders = parseResult.GetValue(RequestHeaders);
                        var ttl = parseResult.GetValue(Ttl);
                        var expiresAt = parseResult.GetValue(ExpiresAt);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Previews.UpdateSandboxPreviewAsync(
                                    sandboxName: sandboxName,
                                    previewName: previewName,
                                    teamId: teamId,
                                    xTeamId: xTeamId,
                                    @public: @public,
                                    responseHeaders: responseHeaders,
                                    requestHeaders: requestHeaders,
                                    ttl: ttl,
                                    expiresAt: expiresAt,
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