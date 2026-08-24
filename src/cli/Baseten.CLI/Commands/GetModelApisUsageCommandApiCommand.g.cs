#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Baseten.CLI.Commands;

internal static partial class GetModelApisUsageCommandApiCommand
{
    private static Option<global::System.DateTime?> StartTime { get; } = new(
        name: @"--start-time")
    {
        Description = @"Start of the query range (ISO 8601, UTC), inclusive. Snapped down to the start of its bucket. Required on the first page, and ignored when you pass a cursor.",
    };

    private static Option<global::System.DateTime?> EndTime { get; } = new(
        name: @"--end-time")
    {
        Description = @"End of the query range (ISO 8601, UTC), exclusive. Defaults to the current time.",
    };

    private static Option<global::Baseten.BucketWidth?> BucketWidth { get; } = new(
        name: @"--bucket-width")
    {
        Description = @"Width of each time bucket: 1m, 1h, or 1d. Defaults to 1d.",
    };

    private static Option<global::System.Collections.Generic.IList<global::Baseten.UsageDimensionV1>?> GroupBy { get; } = new(
        name: @"--group-by")
    {
        Description = @"Dimensions to break usage down by, repeated once per dimension: api_key, user, model. Defaults to model.",
    };

    private static Option<global::System.Collections.Generic.IList<string>?> ApiKeys { get; } = new(
        name: @"--api-keys")
    {
        Description = @"Return only usage for these API key prefixes, repeated once per prefix.",
    };

    private static Option<global::System.Collections.Generic.IList<string>?> UserIds { get; } = new(
        name: @"--user-ids")
    {
        Description = @"Return only usage attributed to these user IDs, repeated once per ID.",
    };

    private static Option<global::System.Collections.Generic.IList<string>?> Models { get; } = new(
        name: @"--models")
    {
        Description = @"Return only usage for these models, repeated once per model.",
    };

    private static Option<int?> Limit { get; } = new(
        name: @"--limit")
    {
        Description = @"Number of time buckets to return. Defaults and maximums depend on bucket_width: 1d defaults to 7 and allows 31, 1h defaults to 24 and allows 168, 1m defaults to 60 and allows 1440.",
    };

    private static Option<string?> Cursor { get; } = new(
        name: @"--cursor")
    {
        Description = @"Opaque cursor from the pagination.cursor field of a previous response",
    };

                    private static string FormatResponse(ParseResult parseResult, global::Baseten.ModelApisUsageResponseV1 value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Baseten.ModelApisUsageResponseV1 value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"get-model-apis-usage", @"Gets Model APIs token usage in time buckets
Returns your organization's Model APIs token usage as a series of contiguous time buckets, broken down by the dimensions you pass in group_by. Buckets with no usage are included, so the series has no gaps. Usage is retained for 92 days, so buckets older than that are returned with no results.");
                        command.Options.Add(StartTime);
                        command.Options.Add(EndTime);
                        command.Options.Add(BucketWidth);
                        command.Options.Add(GroupBy);
                        command.Options.Add(ApiKeys);
                        command.Options.Add(UserIds);
                        command.Options.Add(Models);
                        command.Options.Add(Limit);
                        command.Options.Add(Cursor);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var startTime = parseResult.GetValue(StartTime);
                        var endTime = parseResult.GetValue(EndTime);
                        var bucketWidth = parseResult.GetValue(BucketWidth);
                        var groupBy = parseResult.GetValue(GroupBy);
                        var apiKeys = parseResult.GetValue(ApiKeys);
                        var userIds = parseResult.GetValue(UserIds);
                        var models = parseResult.GetValue(Models);
                        var limit = parseResult.GetValue(Limit);
                        var cursor = parseResult.GetValue(Cursor);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.GetModelApisUsageAsync(
                                    startTime: startTime,
                                    endTime: endTime,
                                    bucketWidth: bucketWidth,
                                    groupBy: groupBy,
                                    apiKeys: apiKeys,
                                    userIds: userIds,
                                    models: models,
                                    limit: limit,
                                    cursor: cursor,
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