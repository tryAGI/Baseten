#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Baseten.CLI.Commands;

internal static partial class CreateAccessRolesCommandApiCommand
{
    private static Argument<string> NameOption { get; } = new(
        name: @"name")
    {
        Description = @"Name of the role, unique in your organization",
    };

    private static Option<global::Baseten.AccessRoleKindV1> Kind { get; } = new(
        name: @"--kind")
    {
        Description = @"`ORGANIZATION` to assign the role for the whole organization, or `TEAM` to assign it in teams",
        Required = true,
    };

    private static Option<string?> TeamId { get; } = new(
        name: @"--team-id")
    {
        Description = @"For a team role, ID of the only team it can be assigned in. Omit to let any team use it.",
    };

    private static Option<string?> DescriptionOption { get; } = new(
        name: @"--description")
    {
        Description = @"Description of the role",
    };

    private static Option<global::System.Collections.Generic.IList<string>?> Permissions { get; } = new(
        name: @"--permissions")
    {
        Description = @"Names of the permissions the role grants",
    };

    private static Option<global::System.Collections.Generic.IList<string>?> IncludeRoleIds { get; } = new(
        name: @"--include-role-ids")
    {
        Description = @"IDs of built-in roles whose permissions the role also grants, such as `baseten:reader`",
    };

    private static Option<string?> TemplateRoleId { get; } = new(
        name: @"--template-role-id")
    {
        Description = @"ID of a built-in role whose current permissions to copy into `permissions` once, leaving out those the role's kind can't hold and those not available to your organization. Unlike `include_role_ids`, later changes to that role don't apply.",
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

                    private static string FormatResponse(ParseResult parseResult, global::Baseten.AccessRoleDetailV1 value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Baseten.AccessRoleDetailV1 value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    static partial void CustomizeCommand(ref Command command);

    public static Command Create(string? commandName = null)
    {
        var command = new Command(commandName ?? @"create-access-roles", @"Creates a custom role
Needs `access.role.write` for the organization, or in the role's team while your organization lets team admins manage roles. Unknown, reserved, or unavailable permissions return 400 with the `reason` in the error details.");
                        command.Arguments.Add(NameOption);
                        command.Options.Add(Kind);
                        command.Options.Add(TeamId);
                        command.Options.Add(DescriptionOption);
                        command.Options.Add(Permissions);
                        command.Options.Add(IncludeRoleIds);
                        command.Options.Add(TemplateRoleId);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Baseten.CreateAccessRoleRequestV1>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Baseten.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var name = parseResult.GetRequiredValue(NameOption);
                        var kind = parseResult.GetRequiredValue(Kind);
                        var teamId = CliRuntime.WasSpecified(parseResult, TeamId) ? parseResult.GetValue(TeamId) : (__requestBase is { } __TeamIdBaseValue ? __TeamIdBaseValue.TeamId : default);
                        var description = CliRuntime.WasSpecified(parseResult, DescriptionOption) ? parseResult.GetValue(DescriptionOption) : (__requestBase is { } __DescriptionBaseValue ? __DescriptionBaseValue.Description : default);
                        var permissions = CliRuntime.WasSpecified(parseResult, Permissions) ? parseResult.GetValue(Permissions) : (__requestBase is { } __PermissionsBaseValue ? __PermissionsBaseValue.Permissions : default);
                        var includeRoleIds = CliRuntime.WasSpecified(parseResult, IncludeRoleIds) ? parseResult.GetValue(IncludeRoleIds) : (__requestBase is { } __IncludeRoleIdsBaseValue ? __IncludeRoleIdsBaseValue.IncludeRoleIds : default);
                        var templateRoleId = CliRuntime.WasSpecified(parseResult, TemplateRoleId) ? parseResult.GetValue(TemplateRoleId) : (__requestBase is { } __TemplateRoleIdBaseValue ? __TemplateRoleIdBaseValue.TemplateRoleId : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.CreateAccessRolesAsync(
                                    name: name,
                                    kind: kind,
                                    teamId: teamId,
                                    description: description,
                                    permissions: permissions,
                                    includeRoleIds: includeRoleIds,
                                    templateRoleId: templateRoleId,
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