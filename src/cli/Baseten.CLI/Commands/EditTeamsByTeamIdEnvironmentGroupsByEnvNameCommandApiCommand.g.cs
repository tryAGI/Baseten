#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Baseten.CLI.Commands;

internal static partial class EditTeamsByTeamIdEnvironmentGroupsByEnvNameCommandApiCommand
{
    private static Argument<string> TeamId { get; } = new(
        name: @"team-id")
    {
        Description = @"This is a missing parameter that was added automatically. Please check the OpenAPI spec.",
    };

    private static Argument<string> EnvName { get; } = new(
        name: @"env-name")
    {
        Description = @"This is a missing parameter that was added automatically. Please check the OpenAPI spec.",
    };
    private static readonly UpdateEnvironmentGroupManageAccessV1OptionSet ManageAccessOptions = UpdateEnvironmentGroupManageAccessV1OptionSet.Create(@"manage-access");
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

                    private static string FormatResponse(ParseResult parseResult, global::Baseten.EnvironmentGroupV1 value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Baseten.EnvironmentGroupV1 value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"edit-teams-by-team-id-environment-groups-by-env-name", @"Updates an environment group's restriction settings
Sets whether the environment is restricted and replaces the list of users granted manage access. The team-scoped path targets the team in the path; the top-level path targets the caller's organization default team.");
                        command.Arguments.Add(TeamId);
                        command.Arguments.Add(EnvName);                        command.Options.Add(ManageAccessOptions.IsRestricted);
                        command.Options.Add(ManageAccessOptions.UserIds);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Baseten.UpdateEnvironmentGroupRequestV1>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Baseten.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var teamId = parseResult.GetRequiredValue(TeamId);
                        var envName = parseResult.GetRequiredValue(EnvName);

                        var __ManageAccessBase = __requestBase is { } __ManageAccessBaseValue ? __ManageAccessBaseValue.ManageAccess : default;                        var manageAccessIsRestricted = parseResult.GetValue(ManageAccessOptions.IsRestricted);
                        var manageAccessUserIds = CliRuntime.WasSpecified(parseResult, ManageAccessOptions.UserIds) ? parseResult.GetValue(ManageAccessOptions.UserIds) : (__ManageAccessBase is { } __ManageAccessuserIdsBaseValue ? __ManageAccessuserIdsBaseValue.UserIds : default);
                        var __ManageAccessSpecified = CliRuntime.WasSpecified(parseResult, ManageAccessOptions.IsRestricted) || CliRuntime.WasSpecified(parseResult, ManageAccessOptions.UserIds);
                        var manageAccess =
                            __ManageAccessSpecified || __ManageAccessBase is not null
                                ? new global::Baseten.UpdateEnvironmentGroupManageAccessV1
                                {
	                                IsRestricted = manageAccessIsRestricted!,
                                UserIds = manageAccessUserIds,

                                }
                                : __ManageAccessBase;
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.EditTeamsByTeamIdEnvironmentGroupsByEnvNameAsync(
                                    teamId: teamId,
                                    envName: envName,
                                    manageAccess: manageAccess,
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