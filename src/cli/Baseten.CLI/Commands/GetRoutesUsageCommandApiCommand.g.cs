#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Baseten.CLI.Commands;

internal static partial class GetRoutesUsageCommandApiCommand
{
    private static Option<string?> Cursor { get; } = new(
        name: @"--cursor")
    {
        Description = @"Opaque cursor returned by a previous page. Omit to fetch the first page.",
    };

    private static Option<int?> Limit { get; } = new(
        name: @"--limit")
    {
        Description = @"Number of daily buckets to return. Defaults to 7; maximum 31.",
    };

    private static Option<global::System.DateTime?> StartDate { get; } = new(
        name: @"--start-date")
    {
        Description = @"Inclusive UTC calendar day at the start of the query range. Defaults to the previous UTC date, and is ignored when you pass a cursor.",
    };

    private static Option<global::System.DateTime?> EndDate { get; } = new(
        name: @"--end-date")
    {
        Description = @"Exclusive UTC calendar day at the end of the query range. Defaults to the day after the current UTC date so current-day usage is included.",
    };

    private static Option<global::System.Collections.Generic.IList<global::Baseten.RouteUsageDimensionV1>?> GroupBy { get; } = new(
        name: @"--group-by")
    {
        Description = @"Dimensions to break usage down by, repeated once per dimension: API_KEY_PREFIX, USER, ROUTE, MODEL, or PROVIDER. Each result represents one observed combination of the requested dimensions within that day, and results are sorted by those values. Combinations without usage are omitted, so result counts can differ between days. Defaults to MODEL.",
    };

    private static Option<global::System.Collections.Generic.IList<string>?> ApiKeyPrefixes { get; } = new(
        name: @"--api-key-prefixes")
    {
        Description = @"Return only usage for these exact Routes key prefixes, repeated once per prefix.",
    };

    private static Option<global::System.Collections.Generic.IList<string>?> UserIds { get; } = new(
        name: @"--user-ids")
    {
        Description = @"Return only usage from Routes keys created by these user IDs, repeated once per ID.",
    };

    private static Option<global::System.Collections.Generic.IList<string>?> RouteIds { get; } = new(
        name: @"--route-ids")
    {
        Description = @"Return only usage for these route IDs, repeated once per ID.",
    };

    private static Option<global::System.Collections.Generic.IList<string>?> Models { get; } = new(
        name: @"--models")
    {
        Description = @"Return only usage for these exact model names, repeated once per model.",
    };

    private static Option<global::System.Collections.Generic.IList<global::Baseten.RouteProviderV1>?> Providers { get; } = new(
        name: @"--providers")
    {
        Description = @"Return only usage for these providers, repeated once per provider.",
    };

                    private static string FormatResponse(ParseResult parseResult, global::Baseten.RoutesUsageResponseV1 value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Baseten.RoutesUsageResponseV1 value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"get-routes-usage", @"Gets daily route usage and estimated costs
Buckets are UTC days, and days with no usage are included. Organization admins see all route usage in the organization. Other members, including viewers, see only usage from Routes keys they created, including keys that have since expired, been revoked, or been deleted. Model API costs use your prices at the time of each request. xAI costs are the charges xAI reports. OpenAI and Anthropic costs are estimated from Baseten's reference prices and may differ from your provider's bill. Vertex and OpenAI-compatible usage has no cost estimate. Costs for OpenAI, Anthropic, and xAI estimate what you pay those providers; they are not Baseten charges. A null cost means some usage in that result could not be priced. Usage is retained for 92 days.");
                        command.Options.Add(Cursor);
                        command.Options.Add(Limit);
                        command.Options.Add(StartDate);
                        command.Options.Add(EndDate);
                        command.Options.Add(GroupBy);
                        command.Options.Add(ApiKeyPrefixes);
                        command.Options.Add(UserIds);
                        command.Options.Add(RouteIds);
                        command.Options.Add(Models);
                        command.Options.Add(Providers);


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
                        var routeIds = parseResult.GetValue(RouteIds);
                        var models = parseResult.GetValue(Models);
                        var providers = parseResult.GetValue(Providers);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.GetRoutesUsageAsync(
                                    cursor: cursor,
                                    limit: limit,
                                    startDate: startDate,
                                    endDate: endDate,
                                    groupBy: groupBy,
                                    apiKeyPrefixes: apiKeyPrefixes,
                                    userIds: userIds,
                                    routeIds: routeIds,
                                    models: models,
                                    providers: providers,
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