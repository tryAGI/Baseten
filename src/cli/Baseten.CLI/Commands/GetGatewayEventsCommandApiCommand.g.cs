#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Baseten.CLI.Commands;

internal static partial class GetGatewayEventsCommandApiCommand
{
    private static Option<global::System.DateTime?> StartTime { get; } = new(
        name: @"--start-time")
    {
        Description = @"Inclusive start (ISO 8601, UTC). Required without a cursor.",
    };

    private static Option<global::System.DateTime?> EndTime { get; } = new(
        name: @"--end-time")
    {
        Description = @"Exclusive end (ISO 8601, UTC). Defaults to now.",
    };

    private static Option<int?> Limit { get; } = new(
        name: @"--limit")
    {
        Description = @"Max events. Default 100, max 1000.",
    };

    private static Option<global::System.Collections.Generic.IList<string>?> ApiKeys { get; } = new(
        name: @"--api-keys")
    {
        Description = @"Return only events for these API key prefixes, repeated once per prefix.",
    };

    private static Option<global::System.Collections.Generic.IList<string>?> ExternalEntityIds { get; } = new(
        name: @"--external-entity-ids")
    {
        Description = @"Return only events for these external entity IDs, repeated once per ID.",
    };

    private static Option<string?> Cursor { get; } = new(
        name: @"--cursor")
    {
        Description = @"Next-page cursor. Other parameters are ignored.",
    };

                    private static string FormatResponse(ParseResult parseResult, global::Baseten.GatewayEventsResponseV1 value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Baseten.GatewayEventsResponseV1 value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"get-gateway-events", @"Lists gateway events");
                        command.Options.Add(StartTime);
                        command.Options.Add(EndTime);
                        command.Options.Add(Limit);
                        command.Options.Add(ApiKeys);
                        command.Options.Add(ExternalEntityIds);
                        command.Options.Add(Cursor);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var startTime = parseResult.GetValue(StartTime);
                        var endTime = parseResult.GetValue(EndTime);
                        var limit = parseResult.GetValue(Limit);
                        var apiKeys = parseResult.GetValue(ApiKeys);
                        var externalEntityIds = parseResult.GetValue(ExternalEntityIds);
                        var cursor = parseResult.GetValue(Cursor);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.GetGatewayEventsAsync(
                                    startTime: startTime,
                                    endTime: endTime,
                                    limit: limit,
                                    apiKeys: apiKeys,
                                    externalEntityIds: externalEntityIds,
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