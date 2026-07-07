#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Baseten.CLI.Commands;

internal static partial class GetTrainingProjectsByTrainingProjectIdJobsByTrainingJobIdMetricsCommandApiCommand
{
    private static Argument<string> TrainingProjectId { get; } = new(
        name: @"training-project-id")
    {
        Description = @"This is a missing parameter that was added automatically. Please check the OpenAPI spec.",
    };

    private static Argument<string> TrainingJobId { get; } = new(
        name: @"training-job-id")
    {
        Description = @"This is a missing parameter that was added automatically. Please check the OpenAPI spec.",
    };

    private static Option<int?> EndEpochMillis { get; } = new(
        name: @"--end-epoch-millis")
    {
        Description = @"Epoch millis timestamp to end fetching metrics",
    };

    private static Option<int?> StartEpochMillis { get; } = new(
        name: @"--start-epoch-millis")
    {
        Description = @"Epoch millis timestamp to start fetching metrics.",
    };

    private static Option<int?> StepSeconds { get; } = new(
        name: @"--step-seconds")
    {
        Description = @"Resolution of the returned series, in seconds. When omitted, a step is derived from the time range so large windows return fewer points.",
    };

                    private static string FormatResponse(ParseResult parseResult, global::Baseten.GetTrainingJobMetricsResponseV1 value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Baseten.GetTrainingJobMetricsResponseV1 value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"get-training-projects-by-training-project-id-jobs-by-training-job-id-metrics", @"Gets the metrics for a training job
Gets the metrics for a training job.");
                        command.Arguments.Add(TrainingProjectId);
                        command.Arguments.Add(TrainingJobId);
                        command.Options.Add(EndEpochMillis);
                        command.Options.Add(StartEpochMillis);
                        command.Options.Add(StepSeconds);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var trainingProjectId = parseResult.GetRequiredValue(TrainingProjectId);
                        var trainingJobId = parseResult.GetRequiredValue(TrainingJobId);
                        var endEpochMillis = parseResult.GetValue(EndEpochMillis);
                        var startEpochMillis = parseResult.GetValue(StartEpochMillis);
                        var stepSeconds = parseResult.GetValue(StepSeconds);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.GetTrainingProjectsByTrainingProjectIdJobsByTrainingJobIdMetricsAsync(
                                    trainingProjectId: trainingProjectId,
                                    trainingJobId: trainingJobId,
                                    endEpochMillis: endEpochMillis,
                                    startEpochMillis: startEpochMillis,
                                    stepSeconds: stepSeconds,
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