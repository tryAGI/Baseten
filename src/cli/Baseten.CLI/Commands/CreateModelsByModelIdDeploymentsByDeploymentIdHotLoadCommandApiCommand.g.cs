#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Baseten.CLI.Commands;

internal static partial class CreateModelsByModelIdDeploymentsByDeploymentIdHotLoadCommandApiCommand
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

    private static Option<string> Identity { get; } = new(
        name: @"--identity")
    {
        Description = @"Snapshot directory below the checkpoint prefix, for example, anchors/step000001.",
        Required = true,
    };

    private static Option<global::Baseten.HotLoadIncrementalSnapshotMetadataV1?> IncrementalSnapshotMetadata { get; } = new(
        name: @"--incremental-snapshot-metadata")
    {
        Description = @"Required when identity is a delta snapshot.",
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

                    private static string FormatResponse(ParseResult parseResult, global::Baseten.HotLoadResponseV1 value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Baseten.HotLoadResponseV1 value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    static partial void CustomizeCommand(ref Command command);

    public static Command Create(string? commandName = null)
    {
        var command = new Command(commandName ?? @"create-models-by-model-id-deployments-by-deployment-id-hot-load", @"Sets the snapshot a deployment's replicas hot-load
Stores the request as the deployment's RL weight-sync target; every replica loads it, and the newest request wins. Returns 400 if the body is not a JSON object of at most 16384 bytes as compact JSON, or has an invalid identity or incremental_snapshot_metadata. Snapshots are not checked here; a replica that rejects one reports it in its status. Only RL deployments can hot-load, and source.token and source.api are not accepted.");
                        command.Arguments.Add(ModelId);
                        command.Arguments.Add(DeploymentId);
                        command.Options.Add(Identity);
                        command.Options.Add(IncrementalSnapshotMetadata);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Baseten.HotLoadRequestV1>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Baseten.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var modelId = parseResult.GetRequiredValue(ModelId);
                        var deploymentId = parseResult.GetRequiredValue(DeploymentId);
                        var identity = parseResult.GetRequiredValue(Identity);
                        var incrementalSnapshotMetadata = CliRuntime.WasSpecified(parseResult, IncrementalSnapshotMetadata) ? parseResult.GetValue(IncrementalSnapshotMetadata) : (__requestBase is { } __IncrementalSnapshotMetadataBaseValue ? __IncrementalSnapshotMetadataBaseValue.IncrementalSnapshotMetadata : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.CreateModelsByModelIdDeploymentsByDeploymentIdHotLoadAsync(
                                    modelId: modelId,
                                    deploymentId: deploymentId,
                                    identity: identity,
                                    incrementalSnapshotMetadata: incrementalSnapshotMetadata,
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