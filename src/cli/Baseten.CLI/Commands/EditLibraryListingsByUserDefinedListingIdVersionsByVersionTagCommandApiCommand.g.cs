#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Baseten.CLI.Commands;

internal static partial class EditLibraryListingsByUserDefinedListingIdVersionsByVersionTagCommandApiCommand
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

    private static Option<bool?> IsLive { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--is-live",
        description: @"Whether this version should be the live version. Setting to true demotes the current live version.");

    private static Option<bool?> AllowTrussDownload { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--allow-truss-download",
        description: @"Whether users deploying this model can download the Truss");
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
        var command = new Command(@"edit-library-listings-by-user-defined-listing-id-versions-by-version-tag", @"Updates a library listing version
Updates a library listing version. Setting is_live to true will demote the current live version.");
                        command.Arguments.Add(UserDefinedListingId);
                        command.Arguments.Add(VersionTag);
                        command.Options.Add(IsLive);
                        command.Options.Add(AllowTrussDownload);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Baseten.UpdateLibraryListingVersionRequestV1>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Baseten.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var userDefinedListingId = parseResult.GetRequiredValue(UserDefinedListingId);
                        var versionTag = parseResult.GetRequiredValue(VersionTag);
                        var isLive = CliRuntime.WasSpecified(parseResult, IsLive) ? parseResult.GetValue(IsLive) : (__requestBase is { } __IsLiveBaseValue ? __IsLiveBaseValue.IsLive : default);
                        var allowTrussDownload = CliRuntime.WasSpecified(parseResult, AllowTrussDownload) ? parseResult.GetValue(AllowTrussDownload) : (__requestBase is { } __AllowTrussDownloadBaseValue ? __AllowTrussDownloadBaseValue.AllowTrussDownload : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.EditLibraryListingsByUserDefinedListingIdVersionsByVersionTagAsync(
                                    userDefinedListingId: userDefinedListingId,
                                    versionTag: versionTag,
                                    isLive: isLive,
                                    allowTrussDownload: allowTrussDownload,
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