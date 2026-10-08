#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Baseten.CLI.Commands;

internal static partial class ImagesGetImageBuildLogsCommandApiCommand
{
    private static Argument<string> ImageName { get; } = new(
        name: @"image-name")
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

    private static Option<global::System.DateTime?> StartTime { get; } = new(
        name: @"--start-time")
    {
        Description = @"Inclusive RFC 3339 start time. Defaults to 24 hours before end_time.",
    };

    private static Option<global::System.DateTime?> EndTime { get; } = new(
        name: @"--end-time")
    {
        Description = @"RFC 3339 end time. Defaults to the current time.",
    };

    private static Option<int?> Limit { get; } = new(
        name: @"--limit")
    {
        Description = @"Maximum number of log entries to return.",
    };

    private static Option<int?> Offset { get; } = new(
        name: @"--offset")
    {
        Description = @"Number of log entries to skip. Narrow the time range beyond 10000 entries.",
    };

                    private static string FormatResponse(ParseResult parseResult, global::Baseten.SandboxImageBuildLogsResponseV1 value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Baseten.SandboxImageBuildLogsResponseV1 value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    static partial void CustomizeCommand(ref Command command);

    public static Command Create(string? commandName = null)
    {
        var command = new Command(commandName ?? @"get-image-build-logs", @"Get image build logs
Return one page of logs from the latest recorded build of this image, including failed builds, newest first. Logs may take a short time to appear. Defaults to the last 24 hours; the requested time range must not exceed 7 days. Keep start_time and end_time fixed when paging with offset. A new build changes the log source; this endpoint does not retrieve a historical build by ID. While a new upload is waiting to start, logs may still refer to the preceding build. Older builds without a recorded environment use image-level build logs within the requested time range.");
                        command.Arguments.Add(ImageName);
                        command.Options.Add(TeamId);
                        command.Options.Add(XTeamId);
                        command.Options.Add(StartTime);
                        command.Options.Add(EndTime);
                        command.Options.Add(Limit);
                        command.Options.Add(Offset);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var imageName = parseResult.GetRequiredValue(ImageName);
                        var teamId = parseResult.GetValue(TeamId);
                        var xTeamId = parseResult.GetValue(XTeamId);
                        var startTime = parseResult.GetValue(StartTime);
                        var endTime = parseResult.GetValue(EndTime);
                        var limit = parseResult.GetValue(Limit);
                        var offset = parseResult.GetValue(Offset);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Images.GetImageBuildLogsAsync(
                                    imageName: imageName,
                                    teamId: teamId,
                                    xTeamId: xTeamId,
                                    startTime: startTime,
                                    endTime: endTime,
                                    limit: limit,
                                    offset: offset,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                if (!await CliRuntime.TryWriteOutputDirectoryAsync(
                                        parseResult,
                                        response,
                                        global::Baseten.SourceGenerationContext.Default,
                                        @"Logs",
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