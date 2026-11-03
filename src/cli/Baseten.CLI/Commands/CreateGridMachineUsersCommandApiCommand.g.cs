#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Baseten.CLI.Commands;

internal static partial class CreateGridMachineUsersCommandApiCommand
{
    private static Argument<string> NameOption { get; } = new(
        name: @"name")
    {
        Description = @"Name of the machine user, unique within the team. At most 255 characters.",
    };

    private static Option<string?> TeamId { get; } = new(
        name: @"--team-id")
    {
        Description = @"Identifier of the team that owns the machine user. Defaults to your only team, if you belong to exactly one.",
    };
    private static readonly CreateGridMachineUserAPIKeyRequestV1OptionSet ApiKeyOptions = CreateGridMachineUserAPIKeyRequestV1OptionSet.Create(@"api-key");
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

                    private static string FormatResponse(ParseResult parseResult, global::Baseten.CreatedGridMachineUserV1 value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Baseten.CreatedGridMachineUserV1 value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    static partial void CustomizeCommand(ref Command command);

    public static Command Create(string? commandName = null)
    {
        var command = new Command(commandName ?? @"create-grid-machine-users", @"Creates a machine user
Creates a team-owned identity for an application, with its own Grid budget. Set `api_key` to also create its first API key, which the response returns only once. Set the machine user's spend limit with the user settings endpoint, using its `id` as the user ID. Requires team admin.");
                        command.Arguments.Add(NameOption);
                        command.Options.Add(TeamId);                        command.Options.Add(ApiKeyOptions.NameOption);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Baseten.CreateGridMachineUserRequestV1>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Baseten.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var name = parseResult.GetRequiredValue(NameOption);
                        var teamId = CliRuntime.WasSpecified(parseResult, TeamId) ? parseResult.GetValue(TeamId) : (__requestBase is { } __TeamIdBaseValue ? __TeamIdBaseValue.TeamId : default);

                        var __ApiKeyBase = __requestBase is { } __ApiKeyBaseValue ? __ApiKeyBaseValue.ApiKey : default;                        var apiKeyNameOption = CliRuntime.WasSpecified(parseResult, ApiKeyOptions.NameOption) ? parseResult.GetValue(ApiKeyOptions.NameOption) : (__ApiKeyBase is { } __ApiKeynameBaseValue ? __ApiKeynameBaseValue.Name : default);
                        var __ApiKeySpecified = CliRuntime.WasSpecified(parseResult, ApiKeyOptions.NameOption);
                        var apiKey =
                            __ApiKeySpecified || __ApiKeyBase is not null
                                ? new global::Baseten.CreateGridMachineUserAPIKeyRequestV1
                                {
	                                Name = apiKeyNameOption,

                                }
                                : __ApiKeyBase;
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.CreateGridMachineUsersAsync(
                                    name: name,
                                    teamId: teamId,
                                    apiKey: apiKey,
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