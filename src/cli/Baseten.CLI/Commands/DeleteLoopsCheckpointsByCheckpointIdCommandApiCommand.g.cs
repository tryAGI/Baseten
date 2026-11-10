#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Baseten.CLI.Commands;

internal static partial class DeleteLoopsCheckpointsByCheckpointIdCommandApiCommand
{
    private static Argument<string> CheckpointId { get; } = new(
        name: @"checkpoint-id")
    {
        Description = @"This is a missing parameter that was added automatically. Please check the OpenAPI spec.",
    };

                    private static string FormatResponse(ParseResult parseResult, global::Baseten.LoopsCheckpointTombstoneV1 value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Baseten.LoopsCheckpointTombstoneV1 value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    static partial void CustomizeCommand(ref Command command);

    public static Command Create(string? commandName = null)
    {
        var command = new Command(commandName ?? @"delete-loops-checkpoints-by-checkpoint-id", @"Deletes a Loops checkpoint
Deletes a Loops checkpoint by ID and returns its tombstone. The checkpoint disappears from listings and can't be loaded, sampled, or deployed. Deletion is permanent, and storage for some checkpoints is reclaimed later. A checkpoint that is deployed, read by an unfinished LoRA merge, served by an active sampler, or the start of an active run can't be deleted, and the error says which. Deleting an already-deleted checkpoint returns the same tombstone.");
                        command.Arguments.Add(CheckpointId);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var checkpointId = parseResult.GetRequiredValue(CheckpointId);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.DeleteLoopsCheckpointsByCheckpointIdAsync(
                                    checkpointId: checkpointId,
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