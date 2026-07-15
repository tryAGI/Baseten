#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Baseten.CLI.Commands;

internal static partial class GetChainsByChainIdAuditLogsCommandApiCommand
{
    private static Argument<string> ChainId { get; } = new(
        name: @"chain-id")
    {
        Description = @"This is a missing parameter that was added automatically. Please check the OpenAPI spec.",
    };

    private static Option<string?> Cursor { get; } = new(
        name: @"--cursor")
    {
        Description = @"Opaque cursor returned by a previous page. Omit to fetch the first page.",
    };

    private static Option<int?> Limit { get; } = new(
        name: @"--limit")
    {
        Description = @"Maximum number of entries to return per page. Defaults to 20, and must be between 1 and 200.",
    };

    private static Option<global::Baseten.AuditLogSortDirectionV1?> Direction { get; } = new(
        name: @"--direction")
    {
        Description = @"Sort order by the time the action occurred. Defaults to DESC (newest first). Ignored when paginating with a cursor.",
    };

    private static Option<string?> Search { get; } = new(
        name: @"--search")
    {
        Description = @"Case-insensitive substring matched against resource names and IDs in the entry.",
    };

    private static Option<global::System.Collections.Generic.IList<global::Baseten.AuditLogEventTypeGroupV1>?> EventTypeGroups { get; } = new(
        name: @"--event-type-groups")
    {
        Description = @"When set, returns only entries whose event type falls in one of these groups.",
    };

    private static Option<global::System.Collections.Generic.IList<string>?> UserIds { get; } = new(
        name: @"--user-ids")
    {
        Description = @"When set, returns only entries whose acting user is one of these IDs.",
    };

    private static Option<global::System.Collections.Generic.IList<string>?> DeploymentIds { get; } = new(
        name: @"--deployment-ids")
    {
        Description = @"When set, returns only entries referencing one of these model deployment IDs.",
    };

    private static Option<global::System.Collections.Generic.IList<string>?> ChainDeploymentIds { get; } = new(
        name: @"--chain-deployment-ids")
    {
        Description = @"When set, returns only entries referencing one of these chain deployment IDs.",
    };

    private static Option<global::System.Collections.Generic.IList<string>?> EnvironmentNames { get; } = new(
        name: @"--environment-names")
    {
        Description = @"When set, returns only entries for one of these environments.",
    };

    private static Option<global::System.Collections.Generic.IList<global::Baseten.AuditLogSourceV1>?> Sources { get; } = new(
        name: @"--sources")
    {
        Description = @"When set, returns only entries issued from one of these surfaces.",
    };

    private static Option<int?> StartEpochMillis { get; } = new(
        name: @"--start-epoch-millis")
    {
        Description = @"Epoch milliseconds for the start of the window. Defaults to the beginning of the audit-log history.",
    };

    private static Option<int?> EndEpochMillis { get; } = new(
        name: @"--end-epoch-millis")
    {
        Description = @"Epoch milliseconds for the end of the window. Defaults to the current time.",
    };

                    private static string FormatResponse(ParseResult parseResult, global::Baseten.ListAuditLogsResponseV1 value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Baseten.ListAuditLogsResponseV1 value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"get-chains-by-chain-id-audit-logs", @"Gets the audit log for a chain
Returns audit-log entries for a single chain, newest first. Use the filters to narrow by event type, actor, chain deployment, environment, source, or time window, and the cursor to page.");
                        command.Arguments.Add(ChainId);
                        command.Options.Add(Cursor);
                        command.Options.Add(Limit);
                        command.Options.Add(Direction);
                        command.Options.Add(Search);
                        command.Options.Add(EventTypeGroups);
                        command.Options.Add(UserIds);
                        command.Options.Add(DeploymentIds);
                        command.Options.Add(ChainDeploymentIds);
                        command.Options.Add(EnvironmentNames);
                        command.Options.Add(Sources);
                        command.Options.Add(StartEpochMillis);
                        command.Options.Add(EndEpochMillis);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var chainId = parseResult.GetRequiredValue(ChainId);
                        var cursor = parseResult.GetValue(Cursor);
                        var limit = parseResult.GetValue(Limit);
                        var direction = parseResult.GetValue(Direction);
                        var search = parseResult.GetValue(Search);
                        var eventTypeGroups = parseResult.GetValue(EventTypeGroups);
                        var userIds = parseResult.GetValue(UserIds);
                        var deploymentIds = parseResult.GetValue(DeploymentIds);
                        var chainDeploymentIds = parseResult.GetValue(ChainDeploymentIds);
                        var environmentNames = parseResult.GetValue(EnvironmentNames);
                        var sources = parseResult.GetValue(Sources);
                        var startEpochMillis = parseResult.GetValue(StartEpochMillis);
                        var endEpochMillis = parseResult.GetValue(EndEpochMillis);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.GetChainsByChainIdAuditLogsAsync(
                                    chainId: chainId,
                                    cursor: cursor,
                                    limit: limit,
                                    direction: direction,
                                    search: search,
                                    eventTypeGroups: eventTypeGroups,
                                    userIds: userIds,
                                    deploymentIds: deploymentIds,
                                    chainDeploymentIds: chainDeploymentIds,
                                    environmentNames: environmentNames,
                                    sources: sources,
                                    startEpochMillis: startEpochMillis,
                                    endEpochMillis: endEpochMillis,
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
        return command;
    }
}