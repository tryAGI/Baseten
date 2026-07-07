#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Baseten.CLI.Commands;

internal static partial class CreateLoopsDeploymentsByDeploymentIdMetricsCommandApiCommand
{
    private static Argument<string> DeploymentId { get; } = new(
        name: @"deployment-id")
    {
        Description = @"This is a missing parameter that was added automatically. Please check the OpenAPI spec.",
    };

    private static Option<int?> EndEpochMillis { get; } = new(
        name: @"--end-epoch-millis")
    {
        Description = @"Epoch millis to end fetching metrics.",
    };

    private static Option<int?> StartEpochMillis { get; } = new(
        name: @"--start-epoch-millis")
    {
        Description = @"Epoch millis to start fetching metrics.",
    };

    private static Option<int?> StepSeconds { get; } = new(
        name: @"--step-seconds")
    {
        Description = @"Resolution of the returned series, in seconds. When omitted, a step is derived from the time range so large windows return fewer points.",
    };

    private static Option<int?> TimeDivisorSeconds { get; } = new(
        name: @"--time-divisor-seconds")
    {
        Description = @"Unit of time for request-volume metrics, in seconds (e.g. 60 for requests/minute). Defaults to per-second.",
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

                    private static string FormatResponse(ParseResult parseResult, global::Baseten.GetLoopsDeploymentMetricsResponseV1 value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Baseten.GetLoopsDeploymentMetricsResponseV1 value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"create-loops-deployments-by-deployment-id-metrics", @"Gets metrics for a Loops trainer deployment
Returns per-node GPU/CPU/memory utilization and Knative queue-proxy request rate / concurrency / latency for the trainer pods. The sampler half of a Loops deployment is an OracleVersion and uses the existing model-metrics endpoint.");
                        command.Arguments.Add(DeploymentId);
                        command.Options.Add(EndEpochMillis);
                        command.Options.Add(StartEpochMillis);
                        command.Options.Add(StepSeconds);
                        command.Options.Add(TimeDivisorSeconds);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Baseten.GetLoopsDeploymentMetricsRequestV1>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Baseten.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var deploymentId = parseResult.GetRequiredValue(DeploymentId);
                        var endEpochMillis = CliRuntime.WasSpecified(parseResult, EndEpochMillis) ? parseResult.GetValue(EndEpochMillis) : (__requestBase is { } __EndEpochMillisBaseValue ? __EndEpochMillisBaseValue.EndEpochMillis : default);
                        var startEpochMillis = CliRuntime.WasSpecified(parseResult, StartEpochMillis) ? parseResult.GetValue(StartEpochMillis) : (__requestBase is { } __StartEpochMillisBaseValue ? __StartEpochMillisBaseValue.StartEpochMillis : default);
                        var stepSeconds = CliRuntime.WasSpecified(parseResult, StepSeconds) ? parseResult.GetValue(StepSeconds) : (__requestBase is { } __StepSecondsBaseValue ? __StepSecondsBaseValue.StepSeconds : default);
                        var timeDivisorSeconds = CliRuntime.WasSpecified(parseResult, TimeDivisorSeconds) ? parseResult.GetValue(TimeDivisorSeconds) : (__requestBase is { } __TimeDivisorSecondsBaseValue ? __TimeDivisorSecondsBaseValue.TimeDivisorSeconds : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.CreateLoopsDeploymentsByDeploymentIdMetricsAsync(
                                    deploymentId: deploymentId,
                                    endEpochMillis: endEpochMillis,
                                    startEpochMillis: startEpochMillis,
                                    stepSeconds: stepSeconds,
                                    timeDivisorSeconds: timeDivisorSeconds,
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