#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Baseten.CLI.Commands;

internal static partial class CreateLoopsTrainersCommandApiCommand
{
    private static readonly CreateLoopsTrainerRequestV1OptionSet CreateLoopsTrainerRequestV1OptionSetOptions = CreateLoopsTrainerRequestV1OptionSet.Create();
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


    static partial void CustomizeCommand(ref Command command);

    public static Command Create(string? commandName = null)
    {
        var command = new Command(commandName ?? @"create-loops-trainers", @"Creates a Loops trainer
Creates a trainer-only Loops run in the given session, without a sampler. To sample from it, create a sampler with POST /v1/loops/samplers and pass this run's ID as run_id to pair the two. List and read the trainer through the /v1/loops/runs endpoints.");
                        command.Options.Add(CreateLoopsTrainerRequestV1OptionSetOptions.SessionId);
                        command.Options.Add(CreateLoopsTrainerRequestV1OptionSetOptions.BaseModel);
                        command.Options.Add(CreateLoopsTrainerRequestV1OptionSetOptions.NameOption);
                        command.Options.Add(CreateLoopsTrainerRequestV1OptionSetOptions.MaxSeqLen);
                        command.Options.Add(CreateLoopsTrainerRequestV1OptionSetOptions.LoraRank);
                        command.Options.Add(CreateLoopsTrainerRequestV1OptionSetOptions.Seed);
                        command.Options.Add(CreateLoopsTrainerRequestV1OptionSetOptions.ScaleDownDelaySeconds);
                        command.Options.Add(CreateLoopsTrainerRequestV1OptionSetOptions.AvailabilityModel);
                        command.Options.Add(CreateLoopsTrainerRequestV1OptionSetOptions.Replicas);
                        command.Options.Add(CreateLoopsTrainerRequestV1OptionSetOptions.Path);
                        command.Options.Add(CreateLoopsTrainerRequestV1OptionSetOptions.ReuseFromRunId);
                        command.Options.Add(CreateLoopsTrainerRequestV1OptionSetOptions.ReuseFromSessionId);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Baseten.CreateLoopsTrainerRequestV1>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Baseten.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);                        var sessionId = parseResult.GetRequiredValue(CreateLoopsTrainerRequestV1OptionSetOptions.SessionId);
                        var baseModel = parseResult.GetRequiredValue(CreateLoopsTrainerRequestV1OptionSetOptions.BaseModel);
                        var name = CliRuntime.WasSpecified(parseResult, CreateLoopsTrainerRequestV1OptionSetOptions.NameOption) ? parseResult.GetValue(CreateLoopsTrainerRequestV1OptionSetOptions.NameOption) : (__requestBase is { } __NameBaseValue ? __NameBaseValue.Name : default);
                        var maxSeqLen = CliRuntime.WasSpecified(parseResult, CreateLoopsTrainerRequestV1OptionSetOptions.MaxSeqLen) ? parseResult.GetValue(CreateLoopsTrainerRequestV1OptionSetOptions.MaxSeqLen) : (__requestBase is { } __MaxSeqLenBaseValue ? __MaxSeqLenBaseValue.MaxSeqLen : default);
                        var loraRank = CliRuntime.WasSpecified(parseResult, CreateLoopsTrainerRequestV1OptionSetOptions.LoraRank) ? parseResult.GetValue(CreateLoopsTrainerRequestV1OptionSetOptions.LoraRank) : (__requestBase is { } __LoraRankBaseValue ? __LoraRankBaseValue.LoraRank : default);
                        var seed = CliRuntime.WasSpecified(parseResult, CreateLoopsTrainerRequestV1OptionSetOptions.Seed) ? parseResult.GetValue(CreateLoopsTrainerRequestV1OptionSetOptions.Seed) : (__requestBase is { } __SeedBaseValue ? __SeedBaseValue.Seed : default);
                        var scaleDownDelaySeconds = CliRuntime.WasSpecified(parseResult, CreateLoopsTrainerRequestV1OptionSetOptions.ScaleDownDelaySeconds) ? parseResult.GetValue(CreateLoopsTrainerRequestV1OptionSetOptions.ScaleDownDelaySeconds) : (__requestBase is { } __ScaleDownDelaySecondsBaseValue ? __ScaleDownDelaySecondsBaseValue.ScaleDownDelaySeconds : default);
                        var availabilityModel = CliRuntime.WasSpecified(parseResult, CreateLoopsTrainerRequestV1OptionSetOptions.AvailabilityModel) ? parseResult.GetValue(CreateLoopsTrainerRequestV1OptionSetOptions.AvailabilityModel) : (__requestBase is { } __AvailabilityModelBaseValue ? __AvailabilityModelBaseValue.AvailabilityModel : default);
                        var replicas = CliRuntime.WasSpecified(parseResult, CreateLoopsTrainerRequestV1OptionSetOptions.Replicas) ? parseResult.GetValue(CreateLoopsTrainerRequestV1OptionSetOptions.Replicas) : (__requestBase is { } __ReplicasBaseValue ? __ReplicasBaseValue.Replicas : default);
                        var path = CliRuntime.WasSpecified(parseResult, CreateLoopsTrainerRequestV1OptionSetOptions.Path) ? parseResult.GetValue(CreateLoopsTrainerRequestV1OptionSetOptions.Path) : (__requestBase is { } __PathBaseValue ? __PathBaseValue.Path : default);
                        var reuseFromRunId = CliRuntime.WasSpecified(parseResult, CreateLoopsTrainerRequestV1OptionSetOptions.ReuseFromRunId) ? parseResult.GetValue(CreateLoopsTrainerRequestV1OptionSetOptions.ReuseFromRunId) : (__requestBase is { } __ReuseFromRunIdBaseValue ? __ReuseFromRunIdBaseValue.ReuseFromRunId : default);
                        var reuseFromSessionId = CliRuntime.WasSpecified(parseResult, CreateLoopsTrainerRequestV1OptionSetOptions.ReuseFromSessionId) ? parseResult.GetValue(CreateLoopsTrainerRequestV1OptionSetOptions.ReuseFromSessionId) : (__requestBase is { } __ReuseFromSessionIdBaseValue ? __ReuseFromSessionIdBaseValue.ReuseFromSessionId : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.CreateLoopsTrainersAsync(
                                    sessionId: sessionId,
                                    baseModel: baseModel,
                                    name: name,
                                    maxSeqLen: maxSeqLen,
                                    loraRank: loraRank,
                                    seed: seed,
                                    scaleDownDelaySeconds: scaleDownDelaySeconds,
                                    availabilityModel: availabilityModel,
                                    replicas: replicas,
                                    path: path,
                                    reuseFromRunId: reuseFromRunId,
                                    reuseFromSessionId: reuseFromSessionId,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::Baseten.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        CustomizeCommand(ref command);
        return command;
    }
}