#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Baseten.CLI.Commands;

internal static partial class CreateLoopsCheckpointsDeployCommandApiCommand
{
    private static Option<global::System.Collections.Generic.IList<string>> CheckpointIds { get; } = new(
        name: @"--checkpoint-ids")
    {
        Description = @"Sampler checkpoint IDs to deploy together.",
        Required = true,
    };

    private static Option<string> ModelName { get; } = new(
        name: @"--model-name")
    {
        Description = @"Name for the created model.",
        Required = true,
    };

    private static Option<string> InstanceTypeId { get; } = new(
        name: @"--instance-type-id")
    {
        Description = @"Instance type ID for the deployment.",
        Required = true,
    };

    private static Option<string> HfSecretName { get; } = new(
        name: @"--hf-secret-name")
    {
        Description = @"Name of the team-scoped secret that supplies HF_TOKEN.",
        Required = true,
    };

                    private static string FormatResponse(ParseResult parseResult, global::Baseten.DeployLoopsCheckpointResponseV1 value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Baseten.DeployLoopsCheckpointResponseV1 value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    static partial void CustomizeCommand(ref Command command);

    public static Command Create(string? commandName = null)
    {
        var command = new Command(commandName ?? @"create-loops-checkpoints-deploy", @"Deploys Loops checkpoints
Creates an inference deployment from one or more Loops sampler checkpoints. Confirm the user intends to create billable resources before calling it. This operation is not idempotent; repeating the request can create another deployment.");
                        command.Options.Add(CheckpointIds);
                        command.Options.Add(ModelName);
                        command.Options.Add(InstanceTypeId);
                        command.Options.Add(HfSecretName);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var checkpointIds = parseResult.GetRequiredValue(CheckpointIds);
                        var modelName = parseResult.GetRequiredValue(ModelName);
                        var instanceTypeId = parseResult.GetRequiredValue(InstanceTypeId);
                        var hfSecretName = parseResult.GetRequiredValue(HfSecretName);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.CreateLoopsCheckpointsDeployAsync(
                                    checkpointIds: checkpointIds,
                                    modelName: modelName,
                                    instanceTypeId: instanceTypeId,
                                    hfSecretName: hfSecretName,
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