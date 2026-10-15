#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Baseten.CLI.Commands;

internal static partial class SandboxesGetSandboxMetricsCommandApiCommand
{
    private static Argument<string> SandboxName { get; } = new(
        name: @"sandbox-name")
    {
        Description = @"Immutable sandbox name returned by creation.",
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

    private static Option<global::Baseten.SandboxMetricModeV1?> Mode { get; } = new(
        name: @"--mode")
    {
        Description = @"Defaults to CURRENT, which rejects start_epoch_millis and end_epoch_millis. SERIES uses a server-selected step of 30 seconds up to 2 hours, 60 seconds up to 1 day, 600 seconds up to 3 days, and 3600 seconds beyond 3 days.",
    };

    private static Option<long?> StartEpochMillis { get; } = new(
        name: @"--start-epoch-millis")
    {
        Description = @"Unix milliseconds. Defaults to one hour before end; SERIES snaps outward.",
    };

    private static Option<long?> EndEpochMillis { get; } = new(
        name: @"--end-epoch-millis")
    {
        Description = @"Exclusive end in Unix milliseconds, default now. Maximum aligned window is 7 days.",
    };

    private static Option<global::System.Collections.Generic.IList<global::Baseten.SandboxMetricNameV1>?> Metrics { get; } = new(
        name: @"--metrics")
    {
        Description = @"Metric names in response order. Omit to request all three signals.",
    };

                    private static string FormatResponse(ParseResult parseResult, global::Baseten.SandboxMetricsV1 value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Baseten.SandboxMetricsV1 value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    static partial void CustomizeCommand(ref Command command);

    public static Command Create(string? commandName = null)
    {
        var command = new Command(commandName ?? @"get-sandbox-metrics", @"Get sandbox metrics
Returns every interval with labeled request counts, CPU cores, and RSS memory bytes. CURRENT returns one snapshot at now, with
request counts over the preceding minute and latest gauges.
SUMMARY returns one value set over the window. SERIES snaps the window outward
to UTC step boundaries and echoes those boundaries; each value covers
[start_epoch_millis, start_epoch_millis + step_seconds).
Missing gauge samples remain null. Request counts are zero after
creation without traffic, and null before creation. CPU averages are averages
of valid sampled CPU rates; memory averages are averages of sampled RSS.
Windows default to one hour, are limited to 7 days after alignment, and at most
10000 intervals. Telemetry failures return an error.
");
                        command.Arguments.Add(SandboxName);
                        command.Options.Add(TeamId);
                        command.Options.Add(XTeamId);
                        command.Options.Add(Mode);
                        command.Options.Add(StartEpochMillis);
                        command.Options.Add(EndEpochMillis);
                        command.Options.Add(Metrics);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var sandboxName = parseResult.GetRequiredValue(SandboxName);
                        var teamId = parseResult.GetValue(TeamId);
                        var xTeamId = parseResult.GetValue(XTeamId);
                        var mode = parseResult.GetValue(Mode);
                        var startEpochMillis = parseResult.GetValue(StartEpochMillis);
                        var endEpochMillis = parseResult.GetValue(EndEpochMillis);
                        var metrics = parseResult.GetValue(Metrics);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Sandboxes.GetSandboxMetricsAsync(
                                    sandboxName: sandboxName,
                                    teamId: teamId,
                                    xTeamId: xTeamId,
                                    mode: mode,
                                    startEpochMillis: startEpochMillis,
                                    endEpochMillis: endEpochMillis,
                                    metrics: metrics,
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