#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Baseten.CLI.Commands;

internal static partial class CreateLoopsTrainersCommandApiCommand
{
    private static readonly CreateLoopsRunRequestV1OptionSet CreateLoopsRunRequestV1OptionSetOptions = CreateLoopsRunRequestV1OptionSet.Create();
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
        var command = new Command(@"create-loops-trainers", @"Creates a Loops trainer
Creates a trainer-only Loops run in the given session, without a sampler. To sample from it, create a sampler with POST /v1/loops/samplers and pass this run's ID as run_id to pair the two. List and read the trainer through the /v1/loops/runs endpoints.");
                        command.Options.Add(CreateLoopsRunRequestV1OptionSetOptions.SessionId);
                        command.Options.Add(CreateLoopsRunRequestV1OptionSetOptions.BaseModel);
                        command.Options.Add(CreateLoopsRunRequestV1OptionSetOptions.NameOption);
                        command.Options.Add(CreateLoopsRunRequestV1OptionSetOptions.MaxSeqLen);
                        command.Options.Add(CreateLoopsRunRequestV1OptionSetOptions.LoraRank);
                        command.Options.Add(CreateLoopsRunRequestV1OptionSetOptions.Seed);
                        command.Options.Add(CreateLoopsRunRequestV1OptionSetOptions.ScaleDownDelaySeconds);
                        command.Options.Add(CreateLoopsRunRequestV1OptionSetOptions.Replicas);
                        command.Options.Add(CreateLoopsRunRequestV1OptionSetOptions.Path);
                        command.Options.Add(CreateLoopsRunRequestV1OptionSetOptions.ReuseFromSessionId);
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
                            cancellationToken).ConfigureAwait(false);                        var sessionId = parseResult.GetRequiredValue(CreateLoopsRunRequestV1OptionSetOptions.SessionId);
                        var baseModel = parseResult.GetRequiredValue(CreateLoopsRunRequestV1OptionSetOptions.BaseModel);
                        var name = CliRuntime.WasSpecified(parseResult, CreateLoopsRunRequestV1OptionSetOptions.NameOption) ? parseResult.GetValue(CreateLoopsRunRequestV1OptionSetOptions.NameOption) : (__requestBase is { } __NameBaseValue ? __NameBaseValue.Name : default);
                        var maxSeqLen = CliRuntime.WasSpecified(parseResult, CreateLoopsRunRequestV1OptionSetOptions.MaxSeqLen) ? parseResult.GetValue(CreateLoopsRunRequestV1OptionSetOptions.MaxSeqLen) : (__requestBase is { } __MaxSeqLenBaseValue ? __MaxSeqLenBaseValue.MaxSeqLen : default);
                        var loraRank = CliRuntime.WasSpecified(parseResult, CreateLoopsRunRequestV1OptionSetOptions.LoraRank) ? parseResult.GetValue(CreateLoopsRunRequestV1OptionSetOptions.LoraRank) : (__requestBase is { } __LoraRankBaseValue ? __LoraRankBaseValue.LoraRank : default);
                        var seed = CliRuntime.WasSpecified(parseResult, CreateLoopsRunRequestV1OptionSetOptions.Seed) ? parseResult.GetValue(CreateLoopsRunRequestV1OptionSetOptions.Seed) : (__requestBase is { } __SeedBaseValue ? __SeedBaseValue.Seed : default);
                        var scaleDownDelaySeconds = CliRuntime.WasSpecified(parseResult, CreateLoopsRunRequestV1OptionSetOptions.ScaleDownDelaySeconds) ? parseResult.GetValue(CreateLoopsRunRequestV1OptionSetOptions.ScaleDownDelaySeconds) : (__requestBase is { } __ScaleDownDelaySecondsBaseValue ? __ScaleDownDelaySecondsBaseValue.ScaleDownDelaySeconds : default);
                        var replicas = CliRuntime.WasSpecified(parseResult, CreateLoopsRunRequestV1OptionSetOptions.Replicas) ? parseResult.GetValue(CreateLoopsRunRequestV1OptionSetOptions.Replicas) : (__requestBase is { } __ReplicasBaseValue ? __ReplicasBaseValue.Replicas : default);
                        var path = CliRuntime.WasSpecified(parseResult, CreateLoopsRunRequestV1OptionSetOptions.Path) ? parseResult.GetValue(CreateLoopsRunRequestV1OptionSetOptions.Path) : (__requestBase is { } __PathBaseValue ? __PathBaseValue.Path : default);
                        var reuseFromSessionId = CliRuntime.WasSpecified(parseResult, CreateLoopsRunRequestV1OptionSetOptions.ReuseFromSessionId) ? parseResult.GetValue(CreateLoopsRunRequestV1OptionSetOptions.ReuseFromSessionId) : (__requestBase is { } __ReuseFromSessionIdBaseValue ? __ReuseFromSessionIdBaseValue.ReuseFromSessionId : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.CreateLoopsTrainersAsync(
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