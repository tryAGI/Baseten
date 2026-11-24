#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Baseten.CLI.Commands;

internal static partial class CreateAccessAssignmentsCommandApiCommand
{
    private static Option<string> RoleId { get; } = new(
        name: @"--role-id")
    {
        Description = @"ID of the role to assign",
        Required = true,
    };

    private static Option<global::Baseten.AccessSubjectTypeV1> SubjectType { get; } = new(
        name: @"--subject-type")
    {
        Description = @"Type of the subject to give the role to",
        Required = true,
    };

    private static Option<string> SubjectId { get; } = new(
        name: @"--subject-id")
    {
        Description = @"ID of the user, service account, or directory group to give the role to",
        Required = true,
    };

    private static Option<string?> TeamId { get; } = new(
        name: @"--team-id")
    {
        Description = @"ID of the team to assign a team role in. Omit for an organization role.",
    };

    private static Option<global::System.Collections.Generic.IList<global::Baseten.AccessResourceSetRequestV1>?> ResourceSets { get; } = new(
        name: @"--resource-sets")
    {
        Description = @"Sets of resources the role applies to. It applies to what any set matches, and a set matches what every resource in its `all_of` matches. For example, one set for a model in staging and another for a different model in production. An environment name no deployment uses yet applies once one does. Omit for every resource where the role applies.",
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

                    private static string FormatResponse(ParseResult parseResult, global::Baseten.AccessAssignmentV1 value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Baseten.AccessAssignmentV1 value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    static partial void CustomizeCommand(ref Command command);

    public static Command Create(string? commandName = null)
    {
        var command = new Command(commandName ?? @"create-access-assignments", @"Assigns a role
Gives a user, service account, or directory group a role, for the organization or in a team. Needs `access.member.write` there, or `access.group.write` for a directory group. A service account's roles also need `service_account.write` where the account belongs.");
                        command.Options.Add(RoleId);
                        command.Options.Add(SubjectType);
                        command.Options.Add(SubjectId);
                        command.Options.Add(TeamId);
                        command.Options.Add(ResourceSets);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Baseten.CreateAccessAssignmentRequestV1>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Baseten.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var roleId = parseResult.GetRequiredValue(RoleId);
                        var subjectType = parseResult.GetRequiredValue(SubjectType);
                        var subjectId = parseResult.GetRequiredValue(SubjectId);
                        var teamId = CliRuntime.WasSpecified(parseResult, TeamId) ? parseResult.GetValue(TeamId) : (__requestBase is { } __TeamIdBaseValue ? __TeamIdBaseValue.TeamId : default);
                        var resourceSets = CliRuntime.WasSpecified(parseResult, ResourceSets) ? parseResult.GetValue(ResourceSets) : (__requestBase is { } __ResourceSetsBaseValue ? __ResourceSetsBaseValue.ResourceSets : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.CreateAccessAssignmentsAsync(
                                    roleId: roleId,
                                    subjectType: subjectType,
                                    subjectId: subjectId,
                                    teamId: teamId,
                                    resourceSets: resourceSets,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                if (!await CliRuntime.TryWriteOutputDirectoryAsync(
                                        parseResult,
                                        response,
                                        global::Baseten.SourceGenerationContext.Default,
                                        @"ResourceSets",
                                        cancellationToken).ConfigureAwait(false))
                                {
                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::Baseten.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
                                }
            }, cancellationToken).ConfigureAwait(false));
        CustomizeCommand(ref command);
        return command;
    }
}