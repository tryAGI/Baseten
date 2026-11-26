#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Baseten.CLI.Commands;

internal static partial class EditAccessRolesByRoleIdCommandApiCommand
{
    private static Argument<string> RoleId { get; } = new(
        name: @"role-id")
    {
        Description = @"This is a missing parameter that was added automatically. Please check the OpenAPI spec.",
    };

    private static Option<string?> NameOption { get; } = new(
        name: @"--name")
    {
        Description = @"New name of the role",
    };

    private static Option<string?> DescriptionOption { get; } = new(
        name: @"--description")
    {
        Description = @"New description of the role",
    };

    private static Option<global::System.Collections.Generic.IList<string>?> Permissions { get; } = new(
        name: @"--permissions")
    {
        Description = @"Names of permissions to add to the role",
    };

    private static Option<global::System.Collections.Generic.IList<string>?> PermissionsToDelete { get; } = new(
        name: @"--permissions-to-delete")
    {
        Description = @"Names of permissions to remove from the role",
    };

    private static Option<global::System.Collections.Generic.IList<string>?> IncludeRoleIds { get; } = new(
        name: @"--include-role-ids")
    {
        Description = @"IDs of built-in roles for the role to include",
    };

    private static Option<global::System.Collections.Generic.IList<string>?> IncludeRoleIdsToDelete { get; } = new(
        name: @"--include-role-ids-to-delete")
    {
        Description = @"IDs of built-in roles for the role to stop including",
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
        var command = new Command(commandName ?? @"edit-access-roles-by-role-id", @"Updates a custom role
Changes the fields you send. `permissions` and `include_role_ids` add to the role's lists, and the `_to_delete` fields remove from them. Needs `access.role.write` where the role applies; for a team's role, for the organization unless it lets team admins manage roles. Built-in roles return 400.");
                        command.Arguments.Add(RoleId);
                        command.Options.Add(NameOption);
                        command.Options.Add(DescriptionOption);
                        command.Options.Add(Permissions);
                        command.Options.Add(PermissionsToDelete);
                        command.Options.Add(IncludeRoleIds);
                        command.Options.Add(IncludeRoleIdsToDelete);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Baseten.UpdateAccessRoleRequestV1>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Baseten.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var roleId = parseResult.GetRequiredValue(RoleId);
                        var name = CliRuntime.WasSpecified(parseResult, NameOption) ? parseResult.GetValue(NameOption) : (__requestBase is { } __NameBaseValue ? __NameBaseValue.Name : default);
                        var description = CliRuntime.WasSpecified(parseResult, DescriptionOption) ? parseResult.GetValue(DescriptionOption) : (__requestBase is { } __DescriptionBaseValue ? __DescriptionBaseValue.Description : default);
                        var permissions = CliRuntime.WasSpecified(parseResult, Permissions) ? parseResult.GetValue(Permissions) : (__requestBase is { } __PermissionsBaseValue ? __PermissionsBaseValue.Permissions : default);
                        var permissionsToDelete = CliRuntime.WasSpecified(parseResult, PermissionsToDelete) ? parseResult.GetValue(PermissionsToDelete) : (__requestBase is { } __PermissionsToDeleteBaseValue ? __PermissionsToDeleteBaseValue.PermissionsToDelete : default);
                        var includeRoleIds = CliRuntime.WasSpecified(parseResult, IncludeRoleIds) ? parseResult.GetValue(IncludeRoleIds) : (__requestBase is { } __IncludeRoleIdsBaseValue ? __IncludeRoleIdsBaseValue.IncludeRoleIds : default);
                        var includeRoleIdsToDelete = CliRuntime.WasSpecified(parseResult, IncludeRoleIdsToDelete) ? parseResult.GetValue(IncludeRoleIdsToDelete) : (__requestBase is { } __IncludeRoleIdsToDeleteBaseValue ? __IncludeRoleIdsToDeleteBaseValue.IncludeRoleIdsToDelete : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.EditAccessRolesByRoleIdAsync(
                                    roleId: roleId,
                                    name: name,
                                    description: description,
                                    permissions: permissions,
                                    permissionsToDelete: permissionsToDelete,
                                    includeRoleIds: includeRoleIds,
                                    includeRoleIdsToDelete: includeRoleIdsToDelete,
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