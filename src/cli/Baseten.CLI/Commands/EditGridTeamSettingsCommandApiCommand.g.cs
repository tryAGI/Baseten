#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Baseten.CLI.Commands;

internal static partial class EditGridTeamSettingsCommandApiCommand
{
    private static Option<global::Baseten.UpdateGridHarnessDefaultsV1?> HarnessDefaults { get; } = new(
        name: @"--harness-defaults")
    {
        Description = @"Harnesses to change; harnesses left out are unchanged. Pass null to clear every harness, so each role uses the team's default.",
    };

    private static Option<global::Baseten.UpdateGridTeamSpendLimitSettingV1?> SpendLimit { get; } = new(
        name: @"--spend-limit")
    {
        Description = @"Spend limit fields to change. Pass null to remove the team's limits; omit to leave them unchanged.",
    };

    private static Option<string?> TeamId { get; } = new(
        name: @"--team-id")
    {
        Description = @"ID of the team. When omitted, the team you belong to; required when you belong to several.",
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

                    private static string FormatResponse(ParseResult parseResult, global::Baseten.GridTeamSettingsV1 value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Baseten.GridTeamSettingsV1 value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    static partial void CustomizeCommand(ref Command command);

    public static Command Create(string? commandName = null)
    {
        var command = new Command(commandName ?? @"edit-grid-team-settings", @"Updates a team's Grid settings by team ID or your only team
Changes only the fields in the request, all or nothing. Requires team admin, and organization admin to change the team-wide spend limit. The team comes from `team_id` instead of the path. Omit it to use the team you belong to; when you belong to several, the request fails with a 400.");
                        command.Options.Add(HarnessDefaults);
                        command.Options.Add(SpendLimit);
                        command.Options.Add(TeamId);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Baseten.UpdateGridTeamSettingsRequestV1>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Baseten.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var harnessDefaults = CliRuntime.WasSpecified(parseResult, HarnessDefaults) ? parseResult.GetValue(HarnessDefaults) : (__requestBase is { } __HarnessDefaultsBaseValue ? __HarnessDefaultsBaseValue.HarnessDefaults : default);
                        var spendLimit = CliRuntime.WasSpecified(parseResult, SpendLimit) ? parseResult.GetValue(SpendLimit) : (__requestBase is { } __SpendLimitBaseValue ? __SpendLimitBaseValue.SpendLimit : default);
                        var teamId = CliRuntime.WasSpecified(parseResult, TeamId) ? parseResult.GetValue(TeamId) : (__requestBase is { } __TeamIdBaseValue ? __TeamIdBaseValue.TeamId : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.EditGridTeamSettingsAsync(
                                    harnessDefaults: harnessDefaults,
                                    spendLimit: spendLimit,
                                    teamId: teamId,
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