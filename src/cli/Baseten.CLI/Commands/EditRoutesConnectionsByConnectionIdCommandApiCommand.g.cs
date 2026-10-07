#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Baseten.CLI.Commands;

internal static partial class EditRoutesConnectionsByConnectionIdCommandApiCommand
{
    private static Argument<string> ConnectionId { get; } = new(
        name: @"connection-id")
    {
        Description = @"This is a missing parameter that was added automatically. Please check the OpenAPI spec.",
    };

    private static Option<global::Baseten.Config3> Config { get; } = new(
        name: @"--config")
    {
        Description = @"Connection fields to change. The provider must match the connection and is immutable.",
        Required = true,
    };

                    private static string FormatResponse(ParseResult parseResult, global::Baseten.RouteConnectionV1 value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Baseten.RouteConnectionV1 value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    static partial void CustomizeCommand(ref Command command);

    public static Command Create(string? commandName = null)
    {
        var command = new Command(commandName ?? @"edit-routes-connections-by-connection-id", @"Updates a connection
Updates the connection's fields. The provider and owning team are immutable; point the connection at a new team secret to change its API key, or rotate the key itself by updating the secret.");
                        command.Arguments.Add(ConnectionId);
                        command.Options.Add(Config);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var connectionId = parseResult.GetRequiredValue(ConnectionId);
                        var config = parseResult.GetRequiredValue(Config);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.EditRoutesConnectionsByConnectionIdAsync(
                                    connectionId: connectionId,
                                    config: config,
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