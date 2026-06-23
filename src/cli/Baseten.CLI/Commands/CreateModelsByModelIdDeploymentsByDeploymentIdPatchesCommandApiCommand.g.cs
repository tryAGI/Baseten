#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Baseten.CLI.Commands;

internal static partial class CreateModelsByModelIdDeploymentsByDeploymentIdPatchesCommandApiCommand
{
    private static Argument<string> ModelId { get; } = new(
        name: @"model-id")
    {
        Description = @"This is a missing parameter that was added automatically. Please check the OpenAPI spec.",
    };

    private static Argument<string> DeploymentId { get; } = new(
        name: @"deployment-id")
    {
        Description = @"This is a missing parameter that was added automatically. Please check the OpenAPI spec.",
    };

    private static Option<string> PrevPatchHash { get; } = new(
        name: @"--prev-patch-hash")
    {
        Description = @"Content hash of the patch point this patch is applied on - the link the staged patch must build on. A stale value (the base moved underneath the client) is rejected with a conflict.",
        Required = true,
    };

    private static Option<global::Baseten.DeploymentPatchPointV1> NextPatchPoint { get; } = new(
        name: @"--next-patch-point")
    {
        Description = @"The source state after this patch. The server derives its content hash from `content_hashes`.",
        Required = true,
    };

    private static Option<global::System.Collections.Generic.IList<global::Baseten.PatchOpsItem>> PatchOps { get; } = new(
        name: @"--patch-ops")
    {
        Description = @"The ordered ops that make up this patch. At least one op is required; a patch that changes nothing is not a valid request. There is no op for a directory: a directory comes into existence when the first file under it is added, and is removed when its last file is removed, so directory creation and deletion happen implicitly through the file ops. Adding or removing an otherwise empty directory therefore produces no ops even though it changes the source hash; do not send a patch request for such a change.",
        Required = true,
    };

                    private static string FormatResponse(ParseResult parseResult, global::Baseten.CreateDeploymentPatchResponseV1 value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Baseten.CreateDeploymentPatchResponseV1 value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"create-models-by-model-id-deployments-by-deployment-id-patches", @"Stage a patch against a development deployment.
Persists a patch durably without applying it; call the sync endpoint to apply staged patches to the running deployment. The target must be a development deployment (its archive created with `is_development` set to `true`); patching any other deployment is rejected.");
                        command.Arguments.Add(ModelId);
                        command.Arguments.Add(DeploymentId);
                        command.Options.Add(PrevPatchHash);
                        command.Options.Add(NextPatchPoint);
                        command.Options.Add(PatchOps);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var modelId = parseResult.GetRequiredValue(ModelId);
                        var deploymentId = parseResult.GetRequiredValue(DeploymentId);
                        var prevPatchHash = parseResult.GetRequiredValue(PrevPatchHash);
                        var nextPatchPoint = parseResult.GetRequiredValue(NextPatchPoint);
                        var patchOps = parseResult.GetRequiredValue(PatchOps);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.CreateModelsByModelIdDeploymentsByDeploymentIdPatchesAsync(
                                    modelId: modelId,
                                    deploymentId: deploymentId,
                                    prevPatchHash: prevPatchHash,
                                    nextPatchPoint: nextPatchPoint,
                                    patchOps: patchOps,
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