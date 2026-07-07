#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Baseten.CLI.Commands;

internal static partial class EditTrainingProjectsByTrainingProjectIdJobsByTrainingJobIdCommandApiCommand
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

    private static Option<int> Priority { get; } = new(
        name: @"--priority")
    {
        Description = @"New queue priority for a PENDING training job. Higher values are dequeued first. Only jobs in the PENDING state can have their priority changed.",
        Required = true,
    };

                    private static string FormatResponse(ParseResult parseResult, global::Baseten.UpdateTrainingJobResponseV1 value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Baseten.UpdateTrainingJobResponseV1 value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"edit-training-projects-by-training-project-id-jobs-by-training-job-id", @"Updates a training job
Updates mutable fields on a training job. Currently supports changing the queue priority of a PENDING job; higher priorities are dequeued first.");
                        command.Arguments.Add(TrainingProjectId);
                        command.Arguments.Add(TrainingJobId);
                        command.Options.Add(Priority);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var trainingProjectId = parseResult.GetRequiredValue(TrainingProjectId);
                        var trainingJobId = parseResult.GetRequiredValue(TrainingJobId);
                        var priority = parseResult.GetRequiredValue(Priority);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.EditTrainingProjectsByTrainingProjectIdJobsByTrainingJobIdAsync(
                                    trainingProjectId: trainingProjectId,
                                    trainingJobId: trainingJobId,
                                    priority: priority,
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