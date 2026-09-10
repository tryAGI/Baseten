#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Baseten.CLI.Commands;

internal static partial class GetBillingModelApisCommandApiCommand
{
    private static Option<string?> Cursor { get; } = new(
        name: @"--cursor")
    {
        Description = @"Opaque cursor returned by a previous page. Omit to fetch the first page.",
    };

    private static Option<int?> Limit { get; } = new(
        name: @"--limit")
    {
        Description = @"Number of daily cost buckets to return. Defaults to 7; maximum 31.",
    };

    private static Option<global::System.DateTime?> StartDate { get; } = new(
        name: @"--start-date")
    {
        Description = @"Inclusive UTC calendar day at the start of the query range. Defaults to the previous UTC date, cannot be before 2026-08-05, and is ignored when you pass a cursor.",
    };

    private static Option<global::System.DateTime?> EndDate { get; } = new(
        name: @"--end-date")
    {
        Description = @"Exclusive UTC calendar day at the end of the query range. Defaults to the day after the current UTC date so current-day usage is included. The date range cannot exceed 90 days.",
    };

    private static Option<global::System.Collections.Generic.IList<global::Baseten.ModelApiCostDimensionV1>?> GroupBy { get; } = new(
        name: @"--group-by")
    {
        Description = @"Dimensions to break costs down by, repeated once per dimension: api_key_prefix, user, model, or service_tier. Each result represents one observed combination of the requested dimensions within that day. For example, grouping by api_key_prefix and user returns each API-key and user pair that had usage. Combinations without usage are omitted, so result counts can differ between days. Omit for daily organization totals.",
    };

    private static Option<global::System.Collections.Generic.IList<string>?> ApiKeyPrefixes { get; } = new(
        name: @"--api-key-prefixes")
    {
        Description = @"Return only costs for these exact API key prefixes, repeated once per prefix.",
    };

    private static Option<global::System.Collections.Generic.IList<string>?> UserIds { get; } = new(
        name: @"--user-ids")
    {
        Description = @"Return only costs attributed to these exact user IDs, repeated once per ID.",
    };

    private static Option<global::System.Collections.Generic.IList<string>?> Models { get; } = new(
        name: @"--models")
    {
        Description = @"Return only costs for these exact model identifiers, repeated once per model.",
    };

    private static Option<global::System.Collections.Generic.IList<string>?> ServiceTiers { get; } = new(
        name: @"--service-tiers")
    {
        Description = @"Return only costs for these exact service tiers, repeated once per tier.",
    };

                    private static string FormatResponse(ParseResult parseResult, global::Baseten.ModelApisCostsResponseV1 value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Baseten.ModelApisCostsResponseV1 value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"get-billing-model-apis", @"Gets daily Model APIs costs
Returns daily Model API costs in USD for your organization, with optional filtering and grouping by API key, user, model, and service tier. Results may differ from finalized invoice amounts. Cost history is available from August 5, 2026 at 20:45 UTC. August 5 is a partial day; earlier dates are unavailable.");
                        command.Options.Add(Cursor);
                        command.Options.Add(Limit);
                        command.Options.Add(StartDate);
                        command.Options.Add(EndDate);
                        command.Options.Add(GroupBy);
                        command.Options.Add(ApiKeyPrefixes);
                        command.Options.Add(UserIds);
                        command.Options.Add(Models);
                        command.Options.Add(ServiceTiers);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var cursor = parseResult.GetValue(Cursor);
                        var limit = parseResult.GetValue(Limit);
                        var startDate = parseResult.GetValue(StartDate);
                        var endDate = parseResult.GetValue(EndDate);
                        var groupBy = parseResult.GetValue(GroupBy);
                        var apiKeyPrefixes = parseResult.GetValue(ApiKeyPrefixes);
                        var userIds = parseResult.GetValue(UserIds);
                        var models = parseResult.GetValue(Models);
                        var serviceTiers = parseResult.GetValue(ServiceTiers);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.GetBillingModelApisAsync(
                                    cursor: cursor,
                                    limit: limit,
                                    startDate: startDate,
                                    endDate: endDate,
                                    groupBy: groupBy,
                                    apiKeyPrefixes: apiKeyPrefixes,
                                    userIds: userIds,
                                    models: models,
                                    serviceTiers: serviceTiers,
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