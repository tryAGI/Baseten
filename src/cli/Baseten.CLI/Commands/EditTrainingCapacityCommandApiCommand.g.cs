#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Baseten.CLI.Commands;

internal static partial class EditTrainingCapacityCommandApiCommand
{
    private static Option<string> TeamId { get; } = new(
        name: @"--team-id")
    {
        Description = @"Team identifier",
        Required = true,
    };

    private static Option<string> GpuType { get; } = new(
        name: @"--gpu-type")
    {
        Description = @"GPU type identifier (e.g. H100, A100-40GB)",
        Required = true,
    };

    private static Option<int> MaxGpus { get; } = new(
        name: @"--max-gpus")
    {
        Description = @"Max concurrent GPUs of this type the team may use",
        Required = true,
    };

                    private static string FormatResponse(ParseResult parseResult, global::Baseten.PatchTeamTrainingGpuCapacityResponseV1 value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Baseten.PatchTeamTrainingGpuCapacityResponseV1 value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"edit-training-capacity", @"Set a team's training GPU capacity.
Sets the max concurrent GPUs of a given type a team may use. Creates the limit if one doesn't exist for this (team, gpu_type) pair, otherwise updates it in place. Org-admin only: this is a ceiling the org imposes on the team, not something the team manages for itself.");
                        command.Options.Add(TeamId);
                        command.Options.Add(GpuType);
                        command.Options.Add(MaxGpus);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var teamId = parseResult.GetRequiredValue(TeamId);
                        var gpuType = parseResult.GetRequiredValue(GpuType);
                        var maxGpus = parseResult.GetRequiredValue(MaxGpus);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.EditTrainingCapacityAsync(
                                    teamId: teamId,
                                    gpuType: gpuType,
                                    maxGpus: maxGpus,
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