#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Baseten.CLI.Commands;

internal static partial class CreateTrainingProjectsByTrainingProjectIdJobsCommandApiCommand
{
    private static Argument<string> TrainingProjectId { get; } = new(
        name: @"training-project-id")
    {
        Description = @"This is a missing parameter that was added automatically. Please check the OpenAPI spec.",
    };

    private static Option<global::Baseten.CreateTrainingJobV1> TrainingJob { get; } = new(
        name: @"--training-job")
    {
        Description = @"The training job to create.",
        Required = true,
    };

                    private static string FormatResponse(ParseResult parseResult, global::Baseten.CreateTrainingJobResponseV1 value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Baseten.CreateTrainingJobResponseV1 value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"create-training-projects-by-training-project-id-jobs", @"Creates a training job
Creates a training job with the specified configuration.");
                        command.Arguments.Add(TrainingProjectId);
                        command.Options.Add(TrainingJob);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var trainingProjectId = parseResult.GetRequiredValue(TrainingProjectId);
                        var trainingJob = parseResult.GetRequiredValue(TrainingJob);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.CreateTrainingProjectsByTrainingProjectIdJobsAsync(
                                    trainingProjectId: trainingProjectId,
                                    trainingJob: trainingJob,
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