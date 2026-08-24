#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Baseten.CLI.Commands;

internal static partial class GetLoopsDeploymentsByDeploymentIdDebugArchiveFilesCommandApiCommand
{
    private static Argument<string> DeploymentId { get; } = new(
        name: @"deployment-id")
    {
        Description = @"This is a missing parameter that was added automatically. Please check the OpenAPI spec.",
    };

    private static Option<int?> PageSize { get; } = new(
        name: @"--page-size")
    {
        Description = @"Max files per page (default and maximum 1000).",
    };

    private static Option<string?> PageToken { get; } = new(
        name: @"--page-token")
    {
        Description = @"Opaque token for the next page.",
    };

                    private static string FormatResponse(ParseResult parseResult, global::Baseten.LoopsDebugArchiveFilesResponseV1 value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Baseten.LoopsDebugArchiveFilesResponseV1 value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"get-loops-deployments-by-deployment-id-debug-archive-files", @"Gets Loops debug archive files
Gets presigned download URLs for a Loops deployment's debug archive.");
                        command.Arguments.Add(DeploymentId);
                        command.Options.Add(PageSize);
                        command.Options.Add(PageToken);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var deploymentId = parseResult.GetRequiredValue(DeploymentId);
                        var pageSize = parseResult.GetValue(PageSize);
                        var pageToken = parseResult.GetValue(PageToken);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.GetLoopsDeploymentsByDeploymentIdDebugArchiveFilesAsync(
                                    deploymentId: deploymentId,
                                    pageSize: pageSize,
                                    pageToken: pageToken,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                if (!await CliRuntime.TryWriteOutputDirectoryAsync(
                                        parseResult,
                                        response,
                                        global::Baseten.SourceGenerationContext.Default,
                                        @"PresignedUrls",
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