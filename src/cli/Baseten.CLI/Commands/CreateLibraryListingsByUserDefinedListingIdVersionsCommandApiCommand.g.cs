#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Baseten.CLI.Commands;

internal static partial class CreateLibraryListingsByUserDefinedListingIdVersionsCommandApiCommand
{
    private static Argument<string> UserDefinedListingId { get; } = new(
        name: @"user-defined-listing-id")
    {
        Description = @"This is a missing parameter that was added automatically. Please check the OpenAPI spec.",
    };

    private static Option<string?> DisplayName { get; } = new(
        name: @"--display-name")
    {
        Description = @"Display name of the library listing. Required when creating a new listing.",
    };

    private static Option<bool?> IsPublic { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--is-public",
        description: @"Whether the listing is publicly accessible. Only used when creating a new listing.");

    private static Option<string> OracleVersionId { get; } = new(
        name: @"--oracle-version-id")
    {
        Description = @"Id of the source model version to publish",
        Required = true,
    };

    private static Option<bool?> AllowTrussDownload { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--allow-truss-download",
        description: @"Whether users deploying this model can download the Truss");

    private static Option<bool?> ClosedSource { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--closed-source",
        description: @"Whether the listing is closed source (deployers cannot view or download the Truss, and forks copy mirrored weights instead of re-mirroring from upstream). Only used when creating a new listing.");

    private static Option<string> VersionTag { get; } = new(
        name: @"--version-tag")
    {
        Description = @"Human-readable tag for this version",
        Required = true,
    };
      private static Option<string?> Input { get; } = new(@"--input")
      {
          Description = "Load request JSON from a file path, '-' for stdin, or an inline JSON object/array string.",
      };

      private static Option<string?> RequestJson { get; } = new(@"--request-json")
      {
          Description = "Request body as JSON.",
          Hidden = true,
      };

      private static Option<string?> RequestFile { get; } = new(@"--request-file")
      {
          Description = "Path to a JSON request file, or '-' for stdin.",
          Hidden = true,
      };

                    private static string FormatResponse(ParseResult parseResult, global::Baseten.LibraryListingVersionV1 value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Baseten.LibraryListingVersionV1 value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"create-library-listings-by-user-defined-listing-id-versions", @"Creates a new library listing version
Creates a new library listing version from an existing model version. The model version must be fully built (have an image_uri). If a listing with the given id already exists for the org, a new version is added. Otherwise, a new listing is created.");
                        command.Arguments.Add(UserDefinedListingId);
                        command.Options.Add(DisplayName);
                        command.Options.Add(IsPublic);
                        command.Options.Add(OracleVersionId);
                        command.Options.Add(AllowTrussDownload);
                        command.Options.Add(ClosedSource);
                        command.Options.Add(VersionTag);
          command.Options.Add(Input);
          command.Options.Add(RequestJson);
          command.Options.Add(RequestFile);
          command.Validators.Add(result =>
          {
              var hasInput = result.GetResult(Input) is not null;
              var hasRequestJson = result.GetResult(RequestJson) is not null;
              var hasRequestFile = result.GetResult(RequestFile) is not null;
              var specifiedCount = (hasInput ? 1 : 0) + (hasRequestJson ? 1 : 0) + (hasRequestFile ? 1 : 0);
              if (specifiedCount > 1)
              {
                  result.AddError(@"Specify at most one of --input, --request-json, or --request-file.");
              }
          });

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Baseten.CreateLibraryListingVersionRequestV1>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Baseten.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var userDefinedListingId = parseResult.GetRequiredValue(UserDefinedListingId);
                        var displayName = CliRuntime.WasSpecified(parseResult, DisplayName) ? parseResult.GetValue(DisplayName) : (__requestBase is { } __DisplayNameBaseValue ? __DisplayNameBaseValue.DisplayName : default);
                        var isPublic = CliRuntime.WasSpecified(parseResult, IsPublic) ? parseResult.GetValue(IsPublic) : (__requestBase is { } __IsPublicBaseValue ? __IsPublicBaseValue.IsPublic : default);
                        var oracleVersionId = parseResult.GetRequiredValue(OracleVersionId);
                        var allowTrussDownload = CliRuntime.WasSpecified(parseResult, AllowTrussDownload) ? parseResult.GetValue(AllowTrussDownload) : (__requestBase is { } __AllowTrussDownloadBaseValue ? __AllowTrussDownloadBaseValue.AllowTrussDownload : default);
                        var closedSource = CliRuntime.WasSpecified(parseResult, ClosedSource) ? parseResult.GetValue(ClosedSource) : (__requestBase is { } __ClosedSourceBaseValue ? __ClosedSourceBaseValue.ClosedSource : default);
                        var versionTag = parseResult.GetRequiredValue(VersionTag);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.CreateLibraryListingsByUserDefinedListingIdVersionsAsync(
                                    userDefinedListingId: userDefinedListingId,
                                    displayName: displayName,
                                    isPublic: isPublic,
                                    oracleVersionId: oracleVersionId,
                                    allowTrussDownload: allowTrussDownload,
                                    closedSource: closedSource,
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