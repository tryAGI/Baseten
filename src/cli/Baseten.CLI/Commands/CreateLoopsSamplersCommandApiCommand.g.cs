#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Baseten.CLI.Commands;

internal static partial class CreateLoopsSamplersCommandApiCommand
{
    private static Option<string> SessionId { get; } = new(
        name: @"--session-id")
    {
        Description = @"ID of the Loops session this sampler belongs to.",
        Required = true,
    };

    private static Option<string?> BaseModel { get; } = new(
        name: @"--base-model")
    {
        Description = @"Base model ID for a standalone sampler (for example, a baseline). Required unless run_id is set, in which case the base model is inherited from the run.",
    };

    private static Option<string?> RunId { get; } = new(
        name: @"--run-id")
    {
        Description = @"ID of an existing run to attach this sampler to. When set, the sampler is paired to the run and weight-syncs from its trainer, and base_model is inherited from the run. Omit to create a standalone sampler.",
    };

    private static Option<int?> MaxSeqLength { get; } = new(
        name: @"--max-seq-length")
    {
        Description = @"Maximum prompt length (in tokens) the sampler must handle. Set this to the longest prompt you plan to send. Omit to use the default for the base model.",
    };

    private static Option<string?> ModelPath { get; } = new(
        name: @"--model-path")
    {
        Description = @"Optional bt:// URI of an existing sampler-target checkpoint to load weights from on startup. Form: bt://loops:<run_id>/sampler_weights/<checkpoint_name>.",
    };

    private static Option<string?> ReuseFromSessionId { get; } = new(
        name: @"--reuse-from-session-id")
    {
        Description = @"Optional Loops session ID to reuse infrastructure from. Best-effort.",
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

                    private static string FormatResponse(ParseResult parseResult, global::Baseten.CreateLoopsSamplerResponseV1 value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Baseten.CreateLoopsSamplerResponseV1 value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"create-loops-samplers", @"Creates a Loops sampler
Creates a standalone Loops sampler not linked to a run.");
                        command.Options.Add(SessionId);
                        command.Options.Add(BaseModel);
                        command.Options.Add(RunId);
                        command.Options.Add(MaxSeqLength);
                        command.Options.Add(ModelPath);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Baseten.CreateLoopsSamplerRequestV1>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Baseten.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var sessionId = parseResult.GetRequiredValue(SessionId);
                        var baseModel = CliRuntime.WasSpecified(parseResult, BaseModel) ? parseResult.GetValue(BaseModel) : (__requestBase is { } __BaseModelBaseValue ? __BaseModelBaseValue.BaseModel : default);
                        var runId = CliRuntime.WasSpecified(parseResult, RunId) ? parseResult.GetValue(RunId) : (__requestBase is { } __RunIdBaseValue ? __RunIdBaseValue.RunId : default);
                        var maxSeqLength = CliRuntime.WasSpecified(parseResult, MaxSeqLength) ? parseResult.GetValue(MaxSeqLength) : (__requestBase is { } __MaxSeqLengthBaseValue ? __MaxSeqLengthBaseValue.MaxSeqLength : default);
                        var modelPath = CliRuntime.WasSpecified(parseResult, ModelPath) ? parseResult.GetValue(ModelPath) : (__requestBase is { } __ModelPathBaseValue ? __ModelPathBaseValue.ModelPath : default);
                        var reuseFromSessionId = CliRuntime.WasSpecified(parseResult, ReuseFromSessionId) ? parseResult.GetValue(ReuseFromSessionId) : (__requestBase is { } __ReuseFromSessionIdBaseValue ? __ReuseFromSessionIdBaseValue.ReuseFromSessionId : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.CreateLoopsSamplersAsync(
                                    sessionId: sessionId,
                                    baseModel: baseModel,
                                    runId: runId,
                                    maxSeqLength: maxSeqLength,
                                    modelPath: modelPath,
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