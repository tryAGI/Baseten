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

    private static Option<int?> Priority { get; } = new(
        name: @"--priority")
    {
        Description = @"New queue priority for a PENDING training job. Higher values are dequeued first. Only jobs in the PENDING state can have their priority changed.",
    };

    private static Option<global::Baseten.V1AvailabilityModel?> AvailabilityModel { get; } = new(
        name: @"--availability-model")
    {
        Description = @"New capacity guarantee for a PENDING training job. 'dedicated' runs on on-demand capacity that is not preempted. 'spot' runs on interruptible capacity that may be preempted; the user is responsible for checkpointing their own progress. Only jobs in the PENDING state can have their availability model changed.",
    };
      private static Option<string?> Input { get; } = new(@"--input")
      {
          Description = "Load request JSON from a file path, '-' for stdin, or an inline JSON object/array string.",
      };

      private static Option<string?> RequestJson { get; } = new(@"--request-json")
      {
          Description = "Request body as JSON.",
          Hidden = true,
      };

      private static Option<string?> RequestFile { get; } = new(@"--request-file")
      {
          Description = "Path to a JSON request file, or '-' for stdin.",
          Hidden = true,
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
Updates mutable fields on a PENDING training job: the queue priority (higher priorities are dequeued first) and the availability model (dedicated or spot capacity). Changes take effect on the next queue evaluation, which is triggered immediately.");
                        command.Arguments.Add(TrainingProjectId);
                        command.Arguments.Add(TrainingJobId);
                        command.Options.Add(Priority);
                        command.Options.Add(AvailabilityModel);
          command.Options.Add(Input);
          command.Options.Add(RequestJson);
          command.Options.Add(RequestFile);
          command.Validators.Add(result =>
          {
              var hasInput = result.GetResult(Input) is not null;
              var hasRequestJson = result.GetResult(RequestJson) is not null;
              var hasRequestFile = result.GetResult(RequestFile) is not null;
              var specifiedCount = (hasInput ? 1 : 0) + (hasRequestJson ? 1 : 0) + (hasRequestFile ? 1 : 0);
              if (specifiedCount > 1)
              {
                  result.AddError(@"Specify at most one of --input, --request-json, or --request-file.");
              }
          });

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Baseten.UpdateTrainingJobRequestV1>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Baseten.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var trainingProjectId = parseResult.GetRequiredValue(TrainingProjectId);
                        var trainingJobId = parseResult.GetRequiredValue(TrainingJobId);
                        var priority = CliRuntime.WasSpecified(parseResult, Priority) ? parseResult.GetValue(Priority) : (__requestBase is { } __PriorityBaseValue ? __PriorityBaseValue.Priority : default);
                        var availabilityModel = CliRuntime.WasSpecified(parseResult, AvailabilityModel) ? parseResult.GetValue(AvailabilityModel) : (__requestBase is { } __AvailabilityModelBaseValue ? __AvailabilityModelBaseValue.AvailabilityModel : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.EditTrainingProjectsByTrainingProjectIdJobsByTrainingJobIdAsync(
                                    trainingProjectId: trainingProjectId,
                                    trainingJobId: trainingJobId,
                                    priority: priority,
                                    availabilityModel: availabilityModel,
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