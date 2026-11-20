#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Baseten.CLI.Commands;

internal static partial class GetAccessAssignmentsCommandApiCommand
{
    private static Option<string?> Cursor { get; } = new(
        name: @"--cursor")
    {
        Description = @"Opaque cursor returned by a previous page. Omit to fetch the first page.",
    };

    private static Option<int?> Limit { get; } = new(
        name: @"--limit")
    {
        Description = @"Maximum number of items to return.",
    };

    private static Option<string?> TeamId { get; } = new(
        name: @"--team-id")
    {
        Description = @"ID of a team. Lists only the assignments in it.",
    };

    private static Option<string?> RoleId { get; } = new(
        name: @"--role-id")
    {
        Description = @"ID of a role. Lists only its assignments.",
    };

    private static Option<global::Baseten.AccessSubjectTypeV1?> SubjectType { get; } = new(
        name: @"--subject-type")
    {
        Description = @"Lists only the assignments to this type of subject",
    };

    private static Option<string?> SubjectId { get; } = new(
        name: @"--subject-id")
    {
        Description = @"ID of a user, service account, or directory group. Lists only its assignments.",
    };

                    private static string FormatResponse(ParseResult parseResult, global::Baseten.AccessAssignmentsV1 value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Baseten.AccessAssignmentsV1 value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    static partial void CustomizeCommand(ref Command command);

    public static Command Create(string? commandName = null)
    {
        var command = new Command(commandName ?? @"get-access-assignments", @"Lists role assignments
Needs `access.member.read` for the organization, or in the team you pass as `team_id`. Roles held through organization and team membership aren't listed.");
                        command.Options.Add(Cursor);
                        command.Options.Add(Limit);
                        command.Options.Add(TeamId);
                        command.Options.Add(RoleId);
                        command.Options.Add(SubjectType);
                        command.Options.Add(SubjectId);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var cursor = parseResult.GetValue(Cursor);
                        var limit = parseResult.GetValue(Limit);
                        var teamId = parseResult.GetValue(TeamId);
                        var roleId = parseResult.GetValue(RoleId);
                        var subjectType = parseResult.GetValue(SubjectType);
                        var subjectId = parseResult.GetValue(SubjectId);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.GetAccessAssignmentsAsync(
                                    cursor: cursor,
                                    limit: limit,
                                    teamId: teamId,
                                    roleId: roleId,
                                    subjectType: subjectType,
                                    subjectId: subjectId,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                if (!await CliRuntime.TryWriteOutputDirectoryAsync(
                                        parseResult,
                                        response,
                                        global::Baseten.SourceGenerationContext.Default,
                                        @"Items",
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