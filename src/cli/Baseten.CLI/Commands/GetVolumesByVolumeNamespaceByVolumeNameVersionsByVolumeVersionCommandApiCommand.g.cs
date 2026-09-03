#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Baseten.CLI.Commands;

internal static partial class GetVolumesByVolumeNamespaceByVolumeNameVersionsByVolumeVersionCommandApiCommand
{
    private static Argument<string> VolumeNamespace { get; } = new(
        name: @"volume-namespace")
    {
        Description = @"This is a missing parameter that was added automatically. Please check the OpenAPI spec.",
    };

    private static Argument<string> VolumeName { get; } = new(
        name: @"volume-name")
    {
        Description = @"This is a missing parameter that was added automatically. Please check the OpenAPI spec.",
    };

    private static Argument<string> VolumeVersion { get; } = new(
        name: @"volume-version")
    {
        Description = @"This is a missing parameter that was added automatically. Please check the OpenAPI spec.",
    };

                    private static string FormatResponse(ParseResult parseResult, global::Baseten.VolumeVersionV1 value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Baseten.VolumeVersionV1 value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"get-volumes-by-volume-namespace-by-volume-name-versions-by-volume-version", @"Gets one version of a volume
Returns a single version of the volume. Address it with `:&lt;tag&gt;` for a tag, `@&lt;digest&gt;` for a content digest of at least 12 hexadecimal characters, or `head` for the version a reference with no tag or digest resolves to. A digest that matches more than one version is rejected: supply more characters.");
                        command.Arguments.Add(VolumeNamespace);
                        command.Arguments.Add(VolumeName);
                        command.Arguments.Add(VolumeVersion);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var volumeNamespace = parseResult.GetRequiredValue(VolumeNamespace);
                        var volumeName = parseResult.GetRequiredValue(VolumeName);
                        var volumeVersion = parseResult.GetRequiredValue(VolumeVersion);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.GetVolumesByVolumeNamespaceByVolumeNameVersionsByVolumeVersionAsync(
                                    volumeNamespace: volumeNamespace,
                                    volumeName: volumeName,
                                    volumeVersion: volumeVersion,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                if (!await CliRuntime.TryWriteOutputDirectoryAsync(
                                        parseResult,
                                        response,
                                        global::Baseten.SourceGenerationContext.Default,
                                        @"Tags",
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
        return command;
    }
}