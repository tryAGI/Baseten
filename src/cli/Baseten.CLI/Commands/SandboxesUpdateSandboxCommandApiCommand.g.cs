#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Baseten.CLI.Commands;

internal static partial class SandboxesUpdateSandboxCommandApiCommand
{
    private static Argument<string> SandboxName { get; } = new(
        name: @"sandbox-name")
    {
        Description = @"This is a missing parameter that was added automatically. Please check the OpenAPI spec.",
    };

    private static Option<string?> TeamId { get; } = new(
        name: @"--team-id")
    {
        Description = @"Optional team ID. Must match X-Team-Id when both are supplied. If neither selector is supplied, defaults to the caller's only accessible team. Callers with multiple accessible teams must select a team. Requests without access to any team are forbidden.",
    };

    private static Option<string?> XTeamId { get; } = new(
        name: @"--x-team-id")
    {
        Description = @"Optional team ID. Must match the team_id query parameter when both are supplied. If neither selector is supplied, defaults to the caller's only accessible team. Callers with multiple accessible teams must select a team. Requests without access to any team are forbidden.",
    };

    private static Option<global::System.Collections.Generic.IList<global::Baseten.SandboxEnvV1>?> Envs { get; } = new(
        name: @"--envs")
    {
        Description = @"Environment variables injected into the sandbox.",
    };

    private static Option<string?> ExternalId { get; } = new(
        name: @"--external-id")
    {
        Description = @"Caller-owned identifier for external lookups. Max 64 chars, alphanumeric + dash.",
    };

    private static Option<global::System.Collections.Generic.Dictionary<string, string>?> Labels { get; } = new(
        name: @"--labels")
    {
        Description = @"Key-value pairs for organizing and filtering resources. Labels can be used to categorize resources by environment, project, team, or any custom taxonomy.",
    };
    private static readonly SandboxLifecycleV1OptionSet LifecycleOptions = SandboxLifecycleV1OptionSet.Create(@"lifecycle");
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

                    private static string FormatResponse(ParseResult parseResult, global::Baseten.SandboxV1 value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Baseten.SandboxV1 value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    static partial void CustomizeCommand(ref Command command);

    public static Command Create(string? commandName = null)
    {
        var command = new Command(commandName ?? @"update-sandbox", @"Update a sandbox
Partially update configuration. Omitted fields remain unchanged; supplied arrays and maps replace their previous values. Structured objects update only supplied fields. The name, memory, network, region, image, and ports are immutable after creation. Supplying any of these fields returns 400, including unchanged, empty, or null values.");
                        command.Arguments.Add(SandboxName);
                        command.Options.Add(TeamId);
                        command.Options.Add(XTeamId);
                        command.Options.Add(Envs);
                        command.Options.Add(ExternalId);
                        command.Options.Add(Labels);                        command.Options.Add(LifecycleOptions.TerminatedRetention);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Baseten.UpdateSandboxRequestV1>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Baseten.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var sandboxName = parseResult.GetRequiredValue(SandboxName);
                        var teamId = parseResult.GetValue(TeamId);
                        var xTeamId = parseResult.GetValue(XTeamId);
                        var envs = CliRuntime.WasSpecified(parseResult, Envs) ? parseResult.GetValue(Envs) : (__requestBase is { } __EnvsBaseValue ? __EnvsBaseValue.Envs : default);
                        var externalId = CliRuntime.WasSpecified(parseResult, ExternalId) ? parseResult.GetValue(ExternalId) : (__requestBase is { } __ExternalIdBaseValue ? __ExternalIdBaseValue.ExternalId : default);
                        var labels = CliRuntime.WasSpecified(parseResult, Labels) ? parseResult.GetValue(Labels) : (__requestBase is { } __LabelsBaseValue ? __LabelsBaseValue.Labels : default);

                        var __LifecycleBase = __requestBase is { } __LifecycleBaseValue ? __LifecycleBaseValue.Lifecycle : default;                        var lifecycleTerminatedRetention = CliRuntime.WasSpecified(parseResult, LifecycleOptions.TerminatedRetention) ? parseResult.GetValue(LifecycleOptions.TerminatedRetention) : (__LifecycleBase is { } __LifecycleterminatedRetentionBaseValue ? __LifecycleterminatedRetentionBaseValue.TerminatedRetention : default);
                        var __LifecycleSpecified = CliRuntime.WasSpecified(parseResult, LifecycleOptions.TerminatedRetention);
                        var lifecycle =
                            __LifecycleSpecified || __LifecycleBase is not null
                                ? new global::Baseten.SandboxLifecycleV1
                                {
	                                TerminatedRetention = lifecycleTerminatedRetention,

                                }
                                : __LifecycleBase;
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Sandboxes.UpdateSandboxAsync(
                                    sandboxName: sandboxName,
                                    teamId: teamId,
                                    xTeamId: xTeamId,
                                    envs: envs,
                                    externalId: externalId,
                                    labels: labels,
                                    lifecycle: lifecycle,
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