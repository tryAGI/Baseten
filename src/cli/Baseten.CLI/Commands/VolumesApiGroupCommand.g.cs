#nullable enable

using System.CommandLine;

namespace Baseten.CLI.Commands;

internal static partial class VolumesApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"volumes", @"Volumes endpoint commands.");
                         command.Subcommands.Add(VolumesCreateSandboxVolumeCommandApiCommand.Create());
                         command.Subcommands.Add(VolumesDeleteSandboxVolumeCommandApiCommand.Create());
                         command.Subcommands.Add(VolumesGetSandboxVolumeCommandApiCommand.Create());
                         command.Subcommands.Add(VolumesListSandboxVolumesCommandApiCommand.Create());
                         command.Subcommands.Add(VolumesUpdateSandboxVolumeCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}