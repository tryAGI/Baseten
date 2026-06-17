#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Baseten.CLI.Commands;

internal static partial class CreatePrepareModelUploadCommandApiCommand
{
    private static Option<global::Baseten.DeploymentArchivePayloadV1> Deployment { get; } = new(
        name: @"--deployment")
    {
        Description = @"Deployment-level payload, identical to the payload sent at commit.",
        Required = true,
    };

    private static Option<string?> NameOption { get; } = new(
        name: @"--name")
    {
        Description = @"Set to validate a new-model push. Exactly one of `name` or `model_id` is required.",
    };

    private static Option<string?> TeamId { get; } = new(
        name: @"--team-id")
    {
        Description = @"Team the new model will belong to. Only valid when `name` is set; defaults to the organization's default team when omitted. Must not be set when `model_id` is set (the existing model already has a team).",
    };

    private static Option<string?> ModelId { get; } = new(
        name: @"--model-id")
    {
        Description = @"Set to validate an add-deployment push to an existing model. Exactly one of `name` or `model_id` is required.",
    };

    private static Option<bool?> DryRun { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--dry-run",
        description: @"If true, validate the payload only and do not issue upload credentials. The response sets `creds`, `s3_bucket`, and `s3_key` to `null`.");

    private static Option<bool?> IsDevelopment { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--is-development",
        description: @"If true, validate a development-deployment push. Only valid when `name` is set. The following `deployment` fields must be left at their defaults: `environment_name`, `preserve_env_instance_type`, `deployment_name`.");
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

                    private static string FormatResponse(ParseResult parseResult, global::Baseten.PrepareModelUploadResponseV1 value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Baseten.PrepareModelUploadResponseV1 value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"create-prepare-model-upload", @"Validates a model push payload and issues upload credentials");
                        command.Options.Add(Deployment);
                        command.Options.Add(NameOption);
                        command.Options.Add(TeamId);
                        command.Options.Add(ModelId);
                        command.Options.Add(DryRun);
                        command.Options.Add(IsDevelopment);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Baseten.PrepareModelUploadRequestV1>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Baseten.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var deployment = parseResult.GetRequiredValue(Deployment);
                        var name = CliRuntime.WasSpecified(parseResult, NameOption) ? parseResult.GetValue(NameOption) : (__requestBase is { } __NameBaseValue ? __NameBaseValue.Name : default);
                        var teamId = CliRuntime.WasSpecified(parseResult, TeamId) ? parseResult.GetValue(TeamId) : (__requestBase is { } __TeamIdBaseValue ? __TeamIdBaseValue.TeamId : default);
                        var modelId = CliRuntime.WasSpecified(parseResult, ModelId) ? parseResult.GetValue(ModelId) : (__requestBase is { } __ModelIdBaseValue ? __ModelIdBaseValue.ModelId : default);
                        var dryRun = CliRuntime.WasSpecified(parseResult, DryRun) ? parseResult.GetValue(DryRun) : (__requestBase is { } __DryRunBaseValue ? __DryRunBaseValue.DryRun : default);
                        var isDevelopment = CliRuntime.WasSpecified(parseResult, IsDevelopment) ? parseResult.GetValue(IsDevelopment) : (__requestBase is { } __IsDevelopmentBaseValue ? __IsDevelopmentBaseValue.IsDevelopment : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.CreatePrepareModelUploadAsync(
                                    deployment: deployment,
                                    name: name,
                                    teamId: teamId,
                                    modelId: modelId,
                                    dryRun: dryRun,
                                    isDevelopment: isDevelopment,
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