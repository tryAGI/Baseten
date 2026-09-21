#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Baseten.CLI.Commands;

internal static partial class CreateVolumesSyncsCommandApiCommand
{
    private static Option<global::Baseten.Source2> Source { get; } = new(
        name: @"--source")
    {
        Description = @"Remote source to sync from.",
        Required = true,
    };

    private static Option<global::Baseten.VolumeSyncDestinationV1> Destination { get; } = new(
        name: @"--destination")
    {
        Description = @"BDN volume to sync into.",
        Required = true,
    };

                    private static string FormatResponse(ParseResult parseResult, global::Baseten.VolumeSyncV1 value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Baseten.VolumeSyncV1 value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"create-volumes-syncs", @"Starts a volume sync
Starts one durable asynchronous transfer from a remote source into a BDN volume.");
                        command.Options.Add(Source);
                        command.Options.Add(Destination);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var source = parseResult.GetRequiredValue(Source);
                        var destination = parseResult.GetRequiredValue(Destination);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.CreateVolumesSyncsAsync(
                                    source: source,
                                    destination: destination,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::Baseten.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}