#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Baseten.CLI.Commands;

internal static partial class GetBillingToolCallUsageCommandApiCommand
{
    private static Option<global::System.DateTime> StartDate { get; } = new(
        name: @"--start-date")
    {
        Description = @"Inclusive UTC calendar day at the start of the query range.",
        Required = true,
    };

    private static Option<global::System.DateTime?> EndDate { get; } = new(
        name: @"--end-date")
    {
        Description = @"Exclusive UTC calendar day at the end of the query range. Defaults to the day after the current UTC date so current-day usage is included. The date range cannot exceed 90 days.",
    };

    private static Option<global::System.Collections.Generic.IList<string>?> TeamIds { get; } = new(
        name: @"--team-ids")
    {
        Description = @"Return only usage for these teams, repeated once per team. Defaults to all teams you can manage. An unauthorized team ID causes a 403 response.",
    };

    private static Option<global::System.Collections.Generic.IList<global::Baseten.ToolCallUsageDimensionV1>?> GroupBy { get; } = new(
        name: @"--group-by")
    {
        Description = @"Pass TEAM to split daily rows by team. Defaults to aggregating across teams.",
    };

                    private static string FormatResponse(ParseResult parseResult, global::Baseten.ToolCallUsageResponseV1 value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Baseten.ToolCallUsageResponseV1 value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    static partial void CustomizeCommand(ref Command command);

    public static Command Create(string? commandName = null)
    {
        var command = new Command(commandName ?? @"get-billing-tool-call-usage", @"Gets server-side tool call usage
Returns your organization's server-side tool call usage (web search and fetch tools Baseten executes on your behalf) as daily rows grouped by provider, charge unit (sku), and model. Defaults to teams you can manage; org admins include all organization history. Use team_ids to narrow the scope and group_by=TEAM for per-team rows. An unauthorized team filter causes a 403 response.");
                        command.Options.Add(StartDate);
                        command.Options.Add(EndDate);
                        command.Options.Add(TeamIds);
                        command.Options.Add(GroupBy);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var startDate = parseResult.GetRequiredValue(StartDate);
                        var endDate = parseResult.GetValue(EndDate);
                        var teamIds = parseResult.GetValue(TeamIds);
                        var groupBy = parseResult.GetValue(GroupBy);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.GetBillingToolCallUsageAsync(
                                    startDate: startDate,
                                    endDate: endDate,
                                    teamIds: teamIds,
                                    groupBy: groupBy,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                if (!await CliRuntime.TryWriteOutputDirectoryAsync(
                                        parseResult,
                                        response,
                                        global::Baseten.SourceGenerationContext.Default,
                                        @"Items",
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