#nullable enable

using System.CommandLine;

namespace Baseten.CLI.Commands;

internal static partial class PreviewsApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"previews", @"Previews endpoint commands.");
                         command.Subcommands.Add(PreviewsCreateSandboxPreviewCommandApiCommand.Create());
                         command.Subcommands.Add(PreviewsCreateSandboxPreviewTokenCommandApiCommand.Create());
                         command.Subcommands.Add(PreviewsDeleteSandboxPreviewCommandApiCommand.Create());
                         command.Subcommands.Add(PreviewsDeleteSandboxPreviewTokenCommandApiCommand.Create());
                         command.Subcommands.Add(PreviewsGetSandboxPreviewCommandApiCommand.Create());
                         command.Subcommands.Add(PreviewsListSandboxPreviewTokensCommandApiCommand.Create());
                         command.Subcommands.Add(PreviewsListSandboxPreviewsCommandApiCommand.Create());
                         command.Subcommands.Add(PreviewsUpdateSandboxPreviewCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}