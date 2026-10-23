#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Baseten.CLI.Commands;

internal static partial class PreviewsCreateSandboxPreviewTokenCommandApiCommand
{
    private static Argument<string> SandboxName { get; } = new(
        name: @"sandbox-name")
    {
        Description = @"This is a missing parameter that was added automatically. Please check the OpenAPI spec.",
    };

    private static Argument<string> PreviewName { get; } = new(
        name: @"preview-name")
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

    private static Option<bool?> CreateIfNotExists { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--create-if-not-exists",
        description: @"When true, may return an existing unexpired token of this preview that stays valid at least until expires_at instead of creating a new one. A token created a moment earlier may not be found yet, in which case a new token is created. Defaults to false when omitted.");

    private static Option<global::System.DateTime> ExpiresAt { get; } = new(
        name: @"--expires-at")
    {
        Description = @"Time at which the token stops working. Must be in the future.",
        Required = true,
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

                    private static string FormatResponse(ParseResult parseResult, global::Baseten.SandboxPreviewTokenV1 value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Baseten.SandboxPreviewTokenV1 value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    static partial void CustomizeCommand(ref Command command);

    public static Command Create(string? commandName = null)
    {
        var command = new Command(commandName ?? @"create-sandbox-preview-token", @"Create a preview token
Create a token granting access to a private preview until expires_at. Append it to the preview URL as ?preview_token=&lt;token&gt;.");
                        command.Arguments.Add(SandboxName);
                        command.Arguments.Add(PreviewName);
                        command.Options.Add(TeamId);
                        command.Options.Add(XTeamId);
                        command.Options.Add(CreateIfNotExists);
                        command.Options.Add(ExpiresAt);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Baseten.CreateSandboxPreviewTokenRequestV1>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Baseten.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var sandboxName = parseResult.GetRequiredValue(SandboxName);
                        var previewName = parseResult.GetRequiredValue(PreviewName);
                        var teamId = parseResult.GetValue(TeamId);
                        var xTeamId = parseResult.GetValue(XTeamId);
                        var createIfNotExists = CliRuntime.WasSpecified(parseResult, CreateIfNotExists) ? parseResult.GetValue(CreateIfNotExists) : (__requestBase is { } __CreateIfNotExistsBaseValue ? __CreateIfNotExistsBaseValue.CreateIfNotExists : default);
                        var expiresAt = parseResult.GetRequiredValue(ExpiresAt);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Previews.CreateSandboxPreviewTokenAsync(
                                    sandboxName: sandboxName,
                                    previewName: previewName,
                                    teamId: teamId,
                                    xTeamId: xTeamId,
                                    createIfNotExists: createIfNotExists,
                                    expiresAt: expiresAt,
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