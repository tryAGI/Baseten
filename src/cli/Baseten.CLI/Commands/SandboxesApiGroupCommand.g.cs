#nullable enable

using System.CommandLine;

namespace Baseten.CLI.Commands;

internal static partial class SandboxesApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"sandboxes", @"Sandboxes endpoint commands.");
                         command.Subcommands.Add(SandboxesCreateSandboxCommandApiCommand.Create());
                         command.Subcommands.Add(SandboxesDeleteSandboxCommandApiCommand.Create());
                         command.Subcommands.Add(SandboxesGetSandboxCommandApiCommand.Create());
                         command.Subcommands.Add(SandboxesListSandboxesCommandApiCommand.Create());
                         command.Subcommands.Add(SandboxesUpdateSandboxCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}