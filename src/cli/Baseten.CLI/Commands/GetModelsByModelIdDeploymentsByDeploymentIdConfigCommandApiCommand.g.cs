#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Baseten.CLI.Commands;

internal static partial class GetModelsByModelIdDeploymentsByDeploymentIdConfigCommandApiCommand
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

    private static Option<global::Baseten.DeploymentConfigOutputFormat?> OutputFormat { get; } = new(
        name: @"--output-format")
    {
        Description = @"'raw': verbatim config.yaml with comments (not available for deployments created before 2026-04-30). 'parsed': dict with server-side defaults applied (always available). 'both': both fields populated.",
    };

                    private static string FormatResponse(ParseResult parseResult, global::Baseten.DeploymentConfigResponseV1 value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Baseten.DeploymentConfigResponseV1 value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"get-models-by-model-id-deployments-by-deployment-id-config", @"Gets a deployment's config
Returns the deployment's config. `output_format` query param picks the shape: 'raw' (config.yaml text), 'parsed' (dict with defaults), or 'both' (default).");
                        command.Arguments.Add(ModelId);
                        command.Arguments.Add(DeploymentId);
                        command.Options.Add(OutputFormat);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var modelId = parseResult.GetRequiredValue(ModelId);
                        var deploymentId = parseResult.GetRequiredValue(DeploymentId);
                        var outputFormat = parseResult.GetValue(OutputFormat);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.GetModelsByModelIdDeploymentsByDeploymentIdConfigAsync(
                                    modelId: modelId,
                                    deploymentId: deploymentId,
                                    outputFormat: outputFormat,
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