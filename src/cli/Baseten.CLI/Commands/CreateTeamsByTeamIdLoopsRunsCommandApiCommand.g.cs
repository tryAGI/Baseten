#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Baseten.CLI.Commands;

internal static partial class CreateTeamsByTeamIdLoopsRunsCommandApiCommand
{
    private static Argument<string> TeamId { get; } = new(
        name: @"team-id")
    {
        Description = @"This is a missing parameter that was added automatically. Please check the OpenAPI spec.",
    };
    private static readonly CreateLoopsRunRequestV1OptionSet CreateLoopsRunRequestV1OptionSetOptions = CreateLoopsRunRequestV1OptionSet.Create();

    private static readonly TrainingWeightAuthV1OptionSet BaseCheckpointAuthOptions = TrainingWeightAuthV1OptionSet.Create(@"base-checkpoint-auth");
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

                    private static string FormatResponse(ParseResult parseResult, global::Baseten.CreateLoopsRunResponseV1 value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Baseten.CreateLoopsRunResponseV1 value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    static partial void CustomizeCommand(ref Command command);

    public static Command Create(string? commandName = null)
    {
        var command = new Command(commandName ?? @"create-teams-by-team-id-loops-runs", @"Creates a Loops run in a team
Creates a Loops run with an associated sampler in the given session; the run's infrastructure belongs to the given team.");
                        command.Arguments.Add(TeamId);                        command.Options.Add(CreateLoopsRunRequestV1OptionSetOptions.SessionId);
                        command.Options.Add(CreateLoopsRunRequestV1OptionSetOptions.BaseModel);
                        command.Options.Add(CreateLoopsRunRequestV1OptionSetOptions.NameOption);
                        command.Options.Add(CreateLoopsRunRequestV1OptionSetOptions.MaxSeqLen);
                        command.Options.Add(CreateLoopsRunRequestV1OptionSetOptions.LoraRank);
                        command.Options.Add(CreateLoopsRunRequestV1OptionSetOptions.Seed);
                        command.Options.Add(CreateLoopsRunRequestV1OptionSetOptions.ScaleDownDelaySeconds);
                        command.Options.Add(CreateLoopsRunRequestV1OptionSetOptions.AvailabilityModel);
                        command.Options.Add(CreateLoopsRunRequestV1OptionSetOptions.Replicas);
                        command.Options.Add(CreateLoopsRunRequestV1OptionSetOptions.Path);
                        command.Options.Add(CreateLoopsRunRequestV1OptionSetOptions.ReuseFromRunId);
                        command.Options.Add(CreateLoopsRunRequestV1OptionSetOptions.ReuseFromSessionId);
                        command.Options.Add(CreateLoopsRunRequestV1OptionSetOptions.BaseCheckpoint);
                        command.Options.Add(CreateLoopsRunRequestV1OptionSetOptions.SamplerNumReplicas);                        command.Options.Add(BaseCheckpointAuthOptions.AuthMethod);
                        command.Options.Add(BaseCheckpointAuthOptions.AuthSecretName);
                        command.Options.Add(BaseCheckpointAuthOptions.AwsOidcRoleArn);
                        command.Options.Add(BaseCheckpointAuthOptions.AwsOidcRegion);
                        command.Options.Add(BaseCheckpointAuthOptions.GcpOidcServiceAccount);
                        command.Options.Add(BaseCheckpointAuthOptions.GcpOidcWorkloadIdProvider);
                        command.Options.Add(BaseCheckpointAuthOptions.AwsAssumeRoleArn);
                        command.Options.Add(BaseCheckpointAuthOptions.AwsAssumeRoleRegion);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Baseten.CreateLoopsRunRequestV1>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Baseten.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var teamId = parseResult.GetRequiredValue(TeamId);                        var sessionId = parseResult.GetRequiredValue(CreateLoopsRunRequestV1OptionSetOptions.SessionId);
                        var baseModel = parseResult.GetRequiredValue(CreateLoopsRunRequestV1OptionSetOptions.BaseModel);
                        var name = CliRuntime.WasSpecified(parseResult, CreateLoopsRunRequestV1OptionSetOptions.NameOption) ? parseResult.GetValue(CreateLoopsRunRequestV1OptionSetOptions.NameOption) : (__requestBase is { } __NameBaseValue ? __NameBaseValue.Name : default);
                        var maxSeqLen = CliRuntime.WasSpecified(parseResult, CreateLoopsRunRequestV1OptionSetOptions.MaxSeqLen) ? parseResult.GetValue(CreateLoopsRunRequestV1OptionSetOptions.MaxSeqLen) : (__requestBase is { } __MaxSeqLenBaseValue ? __MaxSeqLenBaseValue.MaxSeqLen : default);
                        var loraRank = CliRuntime.WasSpecified(parseResult, CreateLoopsRunRequestV1OptionSetOptions.LoraRank) ? parseResult.GetValue(CreateLoopsRunRequestV1OptionSetOptions.LoraRank) : (__requestBase is { } __LoraRankBaseValue ? __LoraRankBaseValue.LoraRank : default);
                        var seed = CliRuntime.WasSpecified(parseResult, CreateLoopsRunRequestV1OptionSetOptions.Seed) ? parseResult.GetValue(CreateLoopsRunRequestV1OptionSetOptions.Seed) : (__requestBase is { } __SeedBaseValue ? __SeedBaseValue.Seed : default);
                        var scaleDownDelaySeconds = CliRuntime.WasSpecified(parseResult, CreateLoopsRunRequestV1OptionSetOptions.ScaleDownDelaySeconds) ? parseResult.GetValue(CreateLoopsRunRequestV1OptionSetOptions.ScaleDownDelaySeconds) : (__requestBase is { } __ScaleDownDelaySecondsBaseValue ? __ScaleDownDelaySecondsBaseValue.ScaleDownDelaySeconds : default);
                        var availabilityModel = CliRuntime.WasSpecified(parseResult, CreateLoopsRunRequestV1OptionSetOptions.AvailabilityModel) ? parseResult.GetValue(CreateLoopsRunRequestV1OptionSetOptions.AvailabilityModel) : (__requestBase is { } __AvailabilityModelBaseValue ? __AvailabilityModelBaseValue.AvailabilityModel : default);
                        var replicas = CliRuntime.WasSpecified(parseResult, CreateLoopsRunRequestV1OptionSetOptions.Replicas) ? parseResult.GetValue(CreateLoopsRunRequestV1OptionSetOptions.Replicas) : (__requestBase is { } __ReplicasBaseValue ? __ReplicasBaseValue.Replicas : default);
                        var path = CliRuntime.WasSpecified(parseResult, CreateLoopsRunRequestV1OptionSetOptions.Path) ? parseResult.GetValue(CreateLoopsRunRequestV1OptionSetOptions.Path) : (__requestBase is { } __PathBaseValue ? __PathBaseValue.Path : default);
                        var reuseFromRunId = CliRuntime.WasSpecified(parseResult, CreateLoopsRunRequestV1OptionSetOptions.ReuseFromRunId) ? parseResult.GetValue(CreateLoopsRunRequestV1OptionSetOptions.ReuseFromRunId) : (__requestBase is { } __ReuseFromRunIdBaseValue ? __ReuseFromRunIdBaseValue.ReuseFromRunId : default);
                        var reuseFromSessionId = CliRuntime.WasSpecified(parseResult, CreateLoopsRunRequestV1OptionSetOptions.ReuseFromSessionId) ? parseResult.GetValue(CreateLoopsRunRequestV1OptionSetOptions.ReuseFromSessionId) : (__requestBase is { } __ReuseFromSessionIdBaseValue ? __ReuseFromSessionIdBaseValue.ReuseFromSessionId : default);
                        var baseCheckpoint = CliRuntime.WasSpecified(parseResult, CreateLoopsRunRequestV1OptionSetOptions.BaseCheckpoint) ? parseResult.GetValue(CreateLoopsRunRequestV1OptionSetOptions.BaseCheckpoint) : (__requestBase is { } __BaseCheckpointBaseValue ? __BaseCheckpointBaseValue.BaseCheckpoint : default);
                        var samplerNumReplicas = CliRuntime.WasSpecified(parseResult, CreateLoopsRunRequestV1OptionSetOptions.SamplerNumReplicas) ? parseResult.GetValue(CreateLoopsRunRequestV1OptionSetOptions.SamplerNumReplicas) : (__requestBase is { } __SamplerNumReplicasBaseValue ? __SamplerNumReplicasBaseValue.SamplerNumReplicas : default);

                        var __BaseCheckpointAuthBase = __requestBase is { } __BaseCheckpointAuthBaseValue ? __BaseCheckpointAuthBaseValue.BaseCheckpointAuth : default;                        var baseCheckpointAuthAuthMethod = parseResult.GetValue(BaseCheckpointAuthOptions.AuthMethod);
                        var baseCheckpointAuthAuthSecretName = CliRuntime.WasSpecified(parseResult, BaseCheckpointAuthOptions.AuthSecretName) ? parseResult.GetValue(BaseCheckpointAuthOptions.AuthSecretName) : (__BaseCheckpointAuthBase is { } __BaseCheckpointAuthauthSecretNameBaseValue ? __BaseCheckpointAuthauthSecretNameBaseValue.AuthSecretName : default);
                        var baseCheckpointAuthAwsOidcRoleArn = CliRuntime.WasSpecified(parseResult, BaseCheckpointAuthOptions.AwsOidcRoleArn) ? parseResult.GetValue(BaseCheckpointAuthOptions.AwsOidcRoleArn) : (__BaseCheckpointAuthBase is { } __BaseCheckpointAuthawsOidcRoleArnBaseValue ? __BaseCheckpointAuthawsOidcRoleArnBaseValue.AwsOidcRoleArn : default);
                        var baseCheckpointAuthAwsOidcRegion = CliRuntime.WasSpecified(parseResult, BaseCheckpointAuthOptions.AwsOidcRegion) ? parseResult.GetValue(BaseCheckpointAuthOptions.AwsOidcRegion) : (__BaseCheckpointAuthBase is { } __BaseCheckpointAuthawsOidcRegionBaseValue ? __BaseCheckpointAuthawsOidcRegionBaseValue.AwsOidcRegion : default);
                        var baseCheckpointAuthGcpOidcServiceAccount = CliRuntime.WasSpecified(parseResult, BaseCheckpointAuthOptions.GcpOidcServiceAccount) ? parseResult.GetValue(BaseCheckpointAuthOptions.GcpOidcServiceAccount) : (__BaseCheckpointAuthBase is { } __BaseCheckpointAuthgcpOidcServiceAccountBaseValue ? __BaseCheckpointAuthgcpOidcServiceAccountBaseValue.GcpOidcServiceAccount : default);
                        var baseCheckpointAuthGcpOidcWorkloadIdProvider = CliRuntime.WasSpecified(parseResult, BaseCheckpointAuthOptions.GcpOidcWorkloadIdProvider) ? parseResult.GetValue(BaseCheckpointAuthOptions.GcpOidcWorkloadIdProvider) : (__BaseCheckpointAuthBase is { } __BaseCheckpointAuthgcpOidcWorkloadIdProviderBaseValue ? __BaseCheckpointAuthgcpOidcWorkloadIdProviderBaseValue.GcpOidcWorkloadIdProvider : default);
                        var baseCheckpointAuthAwsAssumeRoleArn = CliRuntime.WasSpecified(parseResult, BaseCheckpointAuthOptions.AwsAssumeRoleArn) ? parseResult.GetValue(BaseCheckpointAuthOptions.AwsAssumeRoleArn) : (__BaseCheckpointAuthBase is { } __BaseCheckpointAuthawsAssumeRoleArnBaseValue ? __BaseCheckpointAuthawsAssumeRoleArnBaseValue.AwsAssumeRoleArn : default);
                        var baseCheckpointAuthAwsAssumeRoleRegion = CliRuntime.WasSpecified(parseResult, BaseCheckpointAuthOptions.AwsAssumeRoleRegion) ? parseResult.GetValue(BaseCheckpointAuthOptions.AwsAssumeRoleRegion) : (__BaseCheckpointAuthBase is { } __BaseCheckpointAuthawsAssumeRoleRegionBaseValue ? __BaseCheckpointAuthawsAssumeRoleRegionBaseValue.AwsAssumeRoleRegion : default);
                        var __BaseCheckpointAuthSpecified = CliRuntime.WasSpecified(parseResult, BaseCheckpointAuthOptions.AuthMethod) || CliRuntime.WasSpecified(parseResult, BaseCheckpointAuthOptions.AuthSecretName) || CliRuntime.WasSpecified(parseResult, BaseCheckpointAuthOptions.AwsOidcRoleArn) || CliRuntime.WasSpecified(parseResult, BaseCheckpointAuthOptions.AwsOidcRegion) || CliRuntime.WasSpecified(parseResult, BaseCheckpointAuthOptions.GcpOidcServiceAccount) || CliRuntime.WasSpecified(parseResult, BaseCheckpointAuthOptions.GcpOidcWorkloadIdProvider) || CliRuntime.WasSpecified(parseResult, BaseCheckpointAuthOptions.AwsAssumeRoleArn) || CliRuntime.WasSpecified(parseResult, BaseCheckpointAuthOptions.AwsAssumeRoleRegion);
                        var baseCheckpointAuth =
                            __BaseCheckpointAuthSpecified || __BaseCheckpointAuthBase is not null
                                ? new global::Baseten.TrainingWeightAuthV1
                                {
	                                AuthMethod = baseCheckpointAuthAuthMethod!,
                                AuthSecretName = baseCheckpointAuthAuthSecretName,
                                AwsOidcRoleArn = baseCheckpointAuthAwsOidcRoleArn,
                                AwsOidcRegion = baseCheckpointAuthAwsOidcRegion,
                                GcpOidcServiceAccount = baseCheckpointAuthGcpOidcServiceAccount,
                                GcpOidcWorkloadIdProvider = baseCheckpointAuthGcpOidcWorkloadIdProvider,
                                AwsAssumeRoleArn = baseCheckpointAuthAwsAssumeRoleArn,
                                AwsAssumeRoleRegion = baseCheckpointAuthAwsAssumeRoleRegion,

                                }
                                : __BaseCheckpointAuthBase;
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.CreateTeamsByTeamIdLoopsRunsAsync(
                                    teamId: teamId,
                                    sessionId: sessionId,
                                    baseModel: baseModel,
                                    name: name,
                                    maxSeqLen: maxSeqLen,
                                    loraRank: loraRank,
                                    seed: seed,
                                    scaleDownDelaySeconds: scaleDownDelaySeconds,
                                    availabilityModel: availabilityModel,
                                    replicas: replicas,
                                    path: path,
                                    reuseFromRunId: reuseFromRunId,
                                    reuseFromSessionId: reuseFromSessionId,
                                    baseCheckpoint: baseCheckpoint,
                                    samplerNumReplicas: samplerNumReplicas,
                                    baseCheckpointAuth: baseCheckpointAuth,
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