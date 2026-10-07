#nullable enable

using System.CommandLine;

namespace Baseten.CLI.Commands;

internal static partial class ImagesApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"images", @"Images endpoint commands.");
                         command.Subcommands.Add(ImagesCleanupImagesCommandApiCommand.Create());
                         command.Subcommands.Add(ImagesDeleteImageCommandApiCommand.Create());
                         command.Subcommands.Add(ImagesDeleteImageTagCommandApiCommand.Create());
                         command.Subcommands.Add(ImagesGetImageCommandApiCommand.Create());
                         command.Subcommands.Add(ImagesListImageTagsCommandApiCommand.Create());
                         command.Subcommands.Add(ImagesListImagesCommandApiCommand.Create());
                         command.Subcommands.Add(ImagesPushImageCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}