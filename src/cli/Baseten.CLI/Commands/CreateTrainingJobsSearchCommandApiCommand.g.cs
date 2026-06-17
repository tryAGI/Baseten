#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Baseten.CLI.Commands;

internal static partial class CreateTrainingJobsSearchCommandApiCommand
{
    private static Option<string?> ProjectId { get; } = new(
        name: @"--project-id")
    {
        Description = @"Filter the training jobs by project ID.",
    };

    private static Option<string?> JobId { get; } = new(
        name: @"--job-id")
    {
        Description = @"Filter the training jobs by job ID.",
    };

    private static Option<global::System.Collections.Generic.IList<string>?> Statuses { get; } = new(
        name: @"--statuses")
    {
        Description = @"Filter the training jobs by status.",
    };

    private static Option<global::System.Collections.Generic.IList<global::Baseten.OrderByV1>?> OrderBy { get; } = new(
        name: @"--order-by")
    {
        Description = @"Order the training jobs by a field. Currently supports created_at",
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

                    private static string FormatResponse(ParseResult parseResult, global::Baseten.SearchTrainingJobsResponseV1 value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Baseten.SearchTrainingJobsResponseV1 value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"create-training-jobs-search", @"Search training jobs.
Search training jobs for the organization.");
                        command.Options.Add(ProjectId);
                        command.Options.Add(JobId);
                        command.Options.Add(Statuses);
                        command.Options.Add(OrderBy);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Baseten.SearchTrainingJobsRequestV1>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Baseten.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var projectId = CliRuntime.WasSpecified(parseResult, ProjectId) ? parseResult.GetValue(ProjectId) : (__requestBase is { } __ProjectIdBaseValue ? __ProjectIdBaseValue.ProjectId : default);
                        var jobId = CliRuntime.WasSpecified(parseResult, JobId) ? parseResult.GetValue(JobId) : (__requestBase is { } __JobIdBaseValue ? __JobIdBaseValue.JobId : default);
                        var statuses = CliRuntime.WasSpecified(parseResult, Statuses) ? parseResult.GetValue(Statuses) : (__requestBase is { } __StatusesBaseValue ? __StatusesBaseValue.Statuses : default);
                        var orderBy = CliRuntime.WasSpecified(parseResult, OrderBy) ? parseResult.GetValue(OrderBy) : (__requestBase is { } __OrderByBaseValue ? __OrderByBaseValue.OrderBy : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.CreateTrainingJobsSearchAsync(
                                    projectId: projectId,
                                    jobId: jobId,
                                    statuses: statuses,
                                    orderBy: orderBy,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                if (!await CliRuntime.TryWriteOutputDirectoryAsync(
                                        parseResult,
                                        response,
                                        global::Baseten.SourceGenerationContext.Default,
                                        @"TrainingJobs",
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