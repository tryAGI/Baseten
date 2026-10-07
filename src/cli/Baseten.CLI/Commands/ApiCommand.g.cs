#nullable enable

using System.CommandLine;

namespace Baseten.CLI.Commands;

internal static partial class ApiCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command("api", "Generated endpoint commands.");

                         command.Subcommands.Add(DefaultApiGroupCommand.Create());
                         command.Subcommands.Add(ImagesApiGroupCommand.Create());
                         command.Subcommands.Add(SandboxesApiGroupCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}