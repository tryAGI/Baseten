#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Baseten.CLI.Commands;

internal static partial class CreateLibraryListingsCommandApiCommand
{
    private static Option<string> DisplayName { get; } = new(
        name: @"--display-name")
    {
        Description = @"Display name of the library listing",
        Required = true,
    };

    private static Option<string> UserDefinedId { get; } = new(
        name: @"--user-defined-id")
    {
        Description = @"User-defined identifier of the library listing",
        Required = true,
    };

    private static Option<bool?> IsPublic { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--is-public",
        description: @"Whether the listing is publicly accessible");

    private static Option<bool?> ClosedSource { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--closed-source",
        description: @"Whether the listing is closed source (deployers cannot view or download the Truss, and forks copy mirrored weights instead of re-mirroring from upstream)");
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

                    private static string FormatResponse(ParseResult parseResult, global::Baseten.LibraryListingV1 value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Baseten.LibraryListingV1 value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"create-library-listings", @"Creates a new library listing
Creates a new library listing for the authenticated user's organization.");
                        command.Options.Add(DisplayName);
                        command.Options.Add(UserDefinedId);
                        command.Options.Add(IsPublic);
                        command.Options.Add(ClosedSource);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Baseten.CreateLibraryListingRequestV1>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Baseten.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var displayName = parseResult.GetRequiredValue(DisplayName);
                        var userDefinedId = parseResult.GetRequiredValue(UserDefinedId);
                        var isPublic = CliRuntime.WasSpecified(parseResult, IsPublic) ? parseResult.GetValue(IsPublic) : (__requestBase is { } __IsPublicBaseValue ? __IsPublicBaseValue.IsPublic : default);
                        var closedSource = CliRuntime.WasSpecified(parseResult, ClosedSource) ? parseResult.GetValue(ClosedSource) : (__requestBase is { } __ClosedSourceBaseValue ? __ClosedSourceBaseValue.ClosedSource : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.CreateLibraryListingsAsync(
                                    displayName: displayName,
                                    userDefinedId: userDefinedId,
                                    isPublic: isPublic,
                                    closedSource: closedSource,
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