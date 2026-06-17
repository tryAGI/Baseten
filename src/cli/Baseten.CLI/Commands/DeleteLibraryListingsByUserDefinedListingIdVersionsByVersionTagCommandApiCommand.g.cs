#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Baseten.CLI.Commands;

internal static partial class DeleteLibraryListingsByUserDefinedListingIdVersionsByVersionTagCommandApiCommand
{
    private static Argument<string> UserDefinedListingId { get; } = new(
        name: @"user-defined-listing-id")
    {
        Description = @"This is a missing parameter that was added automatically. Please check the OpenAPI spec.",
    };

    private static Argument<string> VersionTag { get; } = new(
        name: @"version-tag")
    {
        Description = @"This is a missing parameter that was added automatically. Please check the OpenAPI spec.",
    };

                    private static string FormatResponse(ParseResult parseResult, global::Baseten.LibraryListingVersionTombstoneV1 value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Baseten.LibraryListingVersionTombstoneV1 value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"delete-library-listings-by-user-defined-listing-id-versions-by-version-tag", @"Deletes a library listing version
Deletes a specific version of a library listing. Deleting a live version will fail with a 400 error — demote the version first by setting another version as live.");
                        command.Arguments.Add(UserDefinedListingId);
                        command.Arguments.Add(VersionTag);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var userDefinedListingId = parseResult.GetRequiredValue(UserDefinedListingId);
                        var versionTag = parseResult.GetRequiredValue(VersionTag);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.DeleteLibraryListingsByUserDefinedListingIdVersionsByVersionTagAsync(
                                    userDefinedListingId: userDefinedListingId,
                                    versionTag: versionTag,
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