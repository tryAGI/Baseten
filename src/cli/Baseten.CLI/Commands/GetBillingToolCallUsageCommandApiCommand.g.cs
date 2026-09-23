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


    public static Command Create()
    {
        var command = new Command(@"get-billing-tool-call-usage", @"Gets server-side tool call usage
Returns your organization's server-side tool call usage (web search and fetch tools Baseten executes on your behalf) as daily rows grouped by provider, charge unit (sku), and model.");
                        command.Options.Add(StartDate);
                        command.Options.Add(EndDate);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var startDate = parseResult.GetRequiredValue(StartDate);
                        var endDate = parseResult.GetValue(EndDate);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.GetBillingToolCallUsageAsync(
                                    startDate: startDate,
                                    endDate: endDate,
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