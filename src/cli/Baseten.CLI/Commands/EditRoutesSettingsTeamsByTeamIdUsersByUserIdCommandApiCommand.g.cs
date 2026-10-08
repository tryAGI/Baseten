#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Baseten.CLI.Commands;

internal static partial class EditRoutesSettingsTeamsByTeamIdUsersByUserIdCommandApiCommand
{
    private static Argument<string> TeamId { get; } = new(
        name: @"team-id")
    {
        Description = @"This is a missing parameter that was added automatically. Please check the OpenAPI spec.",
    };

    private static Argument<string> UserId { get; } = new(
        name: @"user-id")
    {
        Description = @"This is a missing parameter that was added automatically. Please check the OpenAPI spec.",
    };
    private static readonly UpdateRouteSpendLimitSettingV1OptionSet SpendLimitOptions = UpdateRouteSpendLimitSettingV1OptionSet.Create(@"spend-limit");
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

                    private static string FormatResponse(ParseResult parseResult, global::Baseten.RouteTeamUserSettingsV1 value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Baseten.RouteTeamUserSettingsV1 value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    static partial void CustomizeCommand(ref Command command);

    public static Command Create(string? commandName = null)
    {
        var command = new Command(commandName ?? @"edit-routes-settings-teams-by-team-id-users-by-user-id", @"Updates a user's route settings in a team
Changes only the fields in the request. Once the user's metered spend in the team in a month reaches the spend limit, requests with Routes keys they created in the team are rejected until the limit is raised or the next month starts. Spend is metered every 15 minutes and can lag, so a user can go over the limit. Requires organization admin.");
                        command.Arguments.Add(TeamId);
                        command.Arguments.Add(UserId);                        command.Options.Add(SpendLimitOptions.UserMonthlyLimitUsd);
                        command.Options.Add(SpendLimitOptions.MonthOverrideUsd);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Baseten.UpdateRouteUserSettingsRequestV1>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Baseten.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var teamId = parseResult.GetRequiredValue(TeamId);
                        var userId = parseResult.GetRequiredValue(UserId);

                        var __SpendLimitBase = __requestBase is { } __SpendLimitBaseValue ? __SpendLimitBaseValue.SpendLimit : default;                        var spendLimitUserMonthlyLimitUsd = CliRuntime.WasSpecified(parseResult, SpendLimitOptions.UserMonthlyLimitUsd) ? parseResult.GetValue(SpendLimitOptions.UserMonthlyLimitUsd) : (__SpendLimitBase is { } __SpendLimituserMonthlyLimitUsdBaseValue ? __SpendLimituserMonthlyLimitUsdBaseValue.UserMonthlyLimitUsd : default);
                        var spendLimitMonthOverrideUsd = CliRuntime.WasSpecified(parseResult, SpendLimitOptions.MonthOverrideUsd) ? parseResult.GetValue(SpendLimitOptions.MonthOverrideUsd) : (__SpendLimitBase is { } __SpendLimitmonthOverrideUsdBaseValue ? __SpendLimitmonthOverrideUsdBaseValue.MonthOverrideUsd : default);
                        var __SpendLimitSpecified = CliRuntime.WasSpecified(parseResult, SpendLimitOptions.UserMonthlyLimitUsd) || CliRuntime.WasSpecified(parseResult, SpendLimitOptions.MonthOverrideUsd);
                        var spendLimit =
                            __SpendLimitSpecified || __SpendLimitBase is not null
                                ? new global::Baseten.UpdateRouteSpendLimitSettingV1
                                {
	                                UserMonthlyLimitUsd = spendLimitUserMonthlyLimitUsd,
                                MonthOverrideUsd = spendLimitMonthOverrideUsd,

                                }
                                : __SpendLimitBase;
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.EditRoutesSettingsTeamsByTeamIdUsersByUserIdAsync(
                                    teamId: teamId,
                                    userId: userId,
                                    spendLimit: spendLimit,
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