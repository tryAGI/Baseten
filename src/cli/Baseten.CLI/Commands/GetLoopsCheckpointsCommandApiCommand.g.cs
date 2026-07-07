#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Baseten.CLI.Commands;

internal static partial class GetLoopsCheckpointsCommandApiCommand
{
    private static Option<string?> RunId { get; } = new(
        name: @"--run-id")
    {
        Description = @"Filter by run ID. Returns all checkpoints saved by the run.",
    };

    private static Option<string?> BaseModel { get; } = new(
        name: @"--base-model")
    {
        Description = @"Filter by base model. Returns checkpoints across the caller's runs of this base model.",
    };

    private static Option<string?> CheckpointPath { get; } = new(
        name: @"--checkpoint-path")
    {
        Description = @"bt:// URI of a Loops checkpoint. Form: bt://loops:<run_id>/(weights|sampler_weights)/<checkpoint_name>.",
    };

                    private static string FormatResponse(ParseResult parseResult, global::Baseten.ListLoopsCheckpointsResponseV1 value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Baseten.ListLoopsCheckpointsResponseV1 value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"get-loops-checkpoints", @"Lists Loops checkpoints
Lists Loops checkpoints filtered by run id, base model, or bt:// URI. Provide exactly one filter.");
                        command.Options.Add(RunId);
                        command.Options.Add(BaseModel);
                        command.Options.Add(CheckpointPath);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var runId = parseResult.GetValue(RunId);
                        var baseModel = parseResult.GetValue(BaseModel);
                        var checkpointPath = parseResult.GetValue(CheckpointPath);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.GetLoopsCheckpointsAsync(
                                    runId: runId,
                                    baseModel: baseModel,
                                    checkpointPath: checkpointPath,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                if (!await CliRuntime.TryWriteOutputDirectoryAsync(
                                        parseResult,
                                        response,
                                        global::Baseten.SourceGenerationContext.Default,
                                        @"Checkpoints",
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