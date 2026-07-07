#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Baseten.CLI.Commands;

internal static partial class EditTrainingProjectsByTrainingProjectIdJobsByTrainingJobIdInteractiveSessionsBySessionIdCommandApiCommand
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

    private static Argument<string> SessionId { get; } = new(
        name: @"session-id")
    {
        Description = @"This is a missing parameter that was added automatically. Please check the OpenAPI spec.",
    };

    private static Option<int?> TimeoutMinutes { get; } = new(
        name: @"--timeout-minutes")
    {
        Description = @"For on_startup sessions, minutes to add to the expiration. For on_demand/on_failure sessions, minutes to add to the timeout. Use -1 for infinite timeout (bumps by 10 years).",
    };

    private static Option<global::Baseten.V1InteractiveSessionTrigger?> Trigger { get; } = new(
        name: @"--trigger")
    {
        Description = @"Update when the interactive session is created. Cannot be changed if the session trigger is 'on_startup'.",
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

                    private static string FormatResponse(ParseResult parseResult, global::Baseten.PatchInteractiveSessionResponseV1 value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Baseten.PatchInteractiveSessionResponseV1 value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"edit-training-projects-by-training-project-id-jobs-by-training-job-id-interactive-sessions-by-session-id", @"Patches an interactive session
Updates specific fields on a training job's interactive session. Only provided (non-null) fields are updated.");
                        command.Arguments.Add(TrainingProjectId);
                        command.Arguments.Add(TrainingJobId);
                        command.Arguments.Add(SessionId);
                        command.Options.Add(TimeoutMinutes);
                        command.Options.Add(Trigger);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Baseten.PatchInteractiveSessionRequestV1>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Baseten.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var trainingProjectId = parseResult.GetRequiredValue(TrainingProjectId);
                        var trainingJobId = parseResult.GetRequiredValue(TrainingJobId);
                        var sessionId = parseResult.GetRequiredValue(SessionId);
                        var timeoutMinutes = CliRuntime.WasSpecified(parseResult, TimeoutMinutes) ? parseResult.GetValue(TimeoutMinutes) : (__requestBase is { } __TimeoutMinutesBaseValue ? __TimeoutMinutesBaseValue.TimeoutMinutes : default);
                        var trigger = CliRuntime.WasSpecified(parseResult, Trigger) ? parseResult.GetValue(Trigger) : (__requestBase is { } __TriggerBaseValue ? __TriggerBaseValue.Trigger : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.EditTrainingProjectsByTrainingProjectIdJobsByTrainingJobIdInteractiveSessionsBySessionIdAsync(
                                    trainingProjectId: trainingProjectId,
                                    trainingJobId: trainingJobId,
                                    sessionId: sessionId,
                                    timeoutMinutes: timeoutMinutes,
                                    trigger: trigger,
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