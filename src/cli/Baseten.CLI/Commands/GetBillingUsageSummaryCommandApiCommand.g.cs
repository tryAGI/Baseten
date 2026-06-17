#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Baseten.CLI.Commands;

internal static partial class GetBillingUsageSummaryCommandApiCommand
{
    private static Option<global::System.DateTime> StartDate { get; } = new(
        name: @"--start-date")
    {
        Description = @"Start date (ISO 8601, UTC). Earliest queryable: 2026-01-01.",
        Required = true,
    };

    private static Option<global::System.DateTime> EndDate { get; } = new(
        name: @"--end-date")
    {
        Description = @"End date in ISO 8601 format (UTC). Date range cannot exceed 31 days.",
        Required = true,
    };

                    private static string FormatResponse(ParseResult parseResult, global::Baseten.UsageSummaryV1 value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Baseten.UsageSummaryV1 value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"get-billing-usage-summary", @"Gets billing usage summary for a date range
Returns billing usage data within the specified date range. Includes dedicated model serving, training, and model APIs usage. The date range must not exceed 31 days.");
                        command.Options.Add(StartDate);
                        command.Options.Add(EndDate);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var startDate = parseResult.GetRequiredValue(StartDate);
                        var endDate = parseResult.GetRequiredValue(EndDate);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.GetBillingUsageSummaryAsync(
                                    startDate: startDate,
                                    endDate: endDate,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::Baseten.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}