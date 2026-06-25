#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Baseten.CLI.Commands;

internal static partial class CreateLoopsRunsCommandApiCommand
{
    private static Option<string> SessionId { get; } = new(
        name: @"--session-id")
    {
        Description = @"ID of the Loops session this run belongs to.",
        Required = true,
    };

    private static Option<string> BaseModel { get; } = new(
        name: @"--base-model")
    {
        Description = @"Base model ID (e.g. 'Qwen/Qwen3-8B').",
        Required = true,
    };

    private static Option<string?> NameOption { get; } = new(
        name: @"--name")
    {
        Description = @"Optional display name for the run. Defaults to the base model name when omitted.",
    };

    private static Option<int?> MaxSeqLen { get; } = new(
        name: @"--max-seq-len")
    {
        Description = @"Maximum prompt length (in tokens) the run must handle. Set this to the longest training example you plan to send. Defaults to the maximum supported by the model configuration.",
    };

    private static Option<int?> LoraRank { get; } = new(
        name: @"--lora-rank")
    {
        Description = @"LoRA rank.",
    };

    private static Option<int?> Seed { get; } = new(
        name: @"--seed")
    {
        Description = @"Random seed for reproducibility.",
    };

    private static Option<int?> ScaleDownDelaySeconds { get; } = new(
        name: @"--scale-down-delay-seconds")
    {
        Description = @"Seconds of inactivity before the run scales to zero. Must be between 1 and 3600 (1 hour). Defaults to 3600.",
    };

    private static Option<int?> Replicas { get; } = new(
        name: @"--replicas")
    {
        Description = @"Number of data-parallel trainer replicas. Each replica is one full copy of the model's preset node group, so the trainer deployment runs (preset node_count * replicas) nodes (e.g. replicas=4 on a 4-node preset → 16 nodes, 4 DP workers). Must be a positive integer. Defaults to 1.",
    };

    private static Option<string?> Path { get; } = new(
        name: @"--path")
    {
        Description = @"Optional bt:// URI of an existing checkpoint to load weights from on startup. Form: bt://loops:<run_id>/weights/<checkpoint_name>.",
    };

    private static Option<string?> ReuseFromSessionId { get; } = new(
        name: @"--reuse-from-session-id")
    {
        Description = @"Optional Loops session ID whose trainer deployment should be reused for this run, sharing the infrastructure across sessions instead of provisioning fresh. The named session must belong to the same team. Reuse is best-effort: if the prior deployment is stopped, failed, its sampler is unhealthy, or this run requests replicas != 1, a new deployment is provisioned instead.",
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

                    private static string FormatResponse(ParseResult parseResult, global::Baseten.CreateLoopsRunResponseV1 value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Baseten.CreateLoopsRunResponseV1 value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"create-loops-runs", @"Create a Loops run.
Creates a Loops run with an associated sampler in the given session.");
                        command.Options.Add(SessionId);
                        command.Options.Add(BaseModel);
                        command.Options.Add(NameOption);
                        command.Options.Add(MaxSeqLen);
                        command.Options.Add(LoraRank);
                        command.Options.Add(Seed);
                        command.Options.Add(ScaleDownDelaySeconds);
                        command.Options.Add(Replicas);
                        command.Options.Add(Path);
                        command.Options.Add(ReuseFromSessionId);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Baseten.CreateLoopsRunRequestV1>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Baseten.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var sessionId = parseResult.GetRequiredValue(SessionId);
                        var baseModel = parseResult.GetRequiredValue(BaseModel);
                        var name = CliRuntime.WasSpecified(parseResult, NameOption) ? parseResult.GetValue(NameOption) : (__requestBase is { } __NameBaseValue ? __NameBaseValue.Name : default);
                        var maxSeqLen = CliRuntime.WasSpecified(parseResult, MaxSeqLen) ? parseResult.GetValue(MaxSeqLen) : (__requestBase is { } __MaxSeqLenBaseValue ? __MaxSeqLenBaseValue.MaxSeqLen : default);
                        var loraRank = CliRuntime.WasSpecified(parseResult, LoraRank) ? parseResult.GetValue(LoraRank) : (__requestBase is { } __LoraRankBaseValue ? __LoraRankBaseValue.LoraRank : default);
                        var seed = CliRuntime.WasSpecified(parseResult, Seed) ? parseResult.GetValue(Seed) : (__requestBase is { } __SeedBaseValue ? __SeedBaseValue.Seed : default);
                        var scaleDownDelaySeconds = CliRuntime.WasSpecified(parseResult, ScaleDownDelaySeconds) ? parseResult.GetValue(ScaleDownDelaySeconds) : (__requestBase is { } __ScaleDownDelaySecondsBaseValue ? __ScaleDownDelaySecondsBaseValue.ScaleDownDelaySeconds : default);
                        var replicas = CliRuntime.WasSpecified(parseResult, Replicas) ? parseResult.GetValue(Replicas) : (__requestBase is { } __ReplicasBaseValue ? __ReplicasBaseValue.Replicas : default);
                        var path = CliRuntime.WasSpecified(parseResult, Path) ? parseResult.GetValue(Path) : (__requestBase is { } __PathBaseValue ? __PathBaseValue.Path : default);
                        var reuseFromSessionId = CliRuntime.WasSpecified(parseResult, ReuseFromSessionId) ? parseResult.GetValue(ReuseFromSessionId) : (__requestBase is { } __ReuseFromSessionIdBaseValue ? __ReuseFromSessionIdBaseValue.ReuseFromSessionId : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.CreateLoopsRunsAsync(
                                    sessionId: sessionId,
                                    baseModel: baseModel,
                                    name: name,
                                    maxSeqLen: maxSeqLen,
                                    loraRank: loraRank,
                                    seed: seed,
                                    scaleDownDelaySeconds: scaleDownDelaySeconds,
                                    replicas: replicas,
                                    path: path,
                                    reuseFromSessionId: reuseFromSessionId,
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