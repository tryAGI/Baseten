#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Baseten.CLI.Commands;

internal static partial class EditRoutesByRouteIdCommandApiCommand
{
    private static Argument<string> RouteId { get; } = new(
        name: @"route-id")
    {
        Description = @"This is a missing parameter that was added automatically. Please check the OpenAPI spec.",
    };

    private static Option<string?> DescriptionOption { get; } = new(
        name: @"--description")
    {
        Description = @"New description. Omit to keep the current description; use an empty string to clear it. Null is not accepted.",
    };

    private static Option<string?> DisplayName { get; } = new(
        name: @"--display-name")
    {
        Description = @"New display label. Omit to keep the current label; null is not accepted.",
    };

    private static Option<global::Baseten.TargetVariant1?> Target { get; } = new(
        name: @"--target")
    {
        Description = @"Replaces the entire target. Omit to keep the current target; null is not accepted.",
    };

    private static Option<string?> MetadataSlug { get; } = new(
        name: @"--metadata-slug")
    {
        Description = @"Slug of a metadata row to link. Omit to keep the current link, or to re-resolve from the new target when target is provided (OPENAI_COMPATIBLE and VERTEX targets always require an explicit slug). Null is not accepted.",
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

                    private static string FormatResponse(ParseResult parseResult, global::Baseten.RouteV1 value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Baseten.RouteV1 value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"edit-routes-by-route-id", @"Updates a route
Replaces the entire target when provided. The route name and owning team are immutable.");
                        command.Arguments.Add(RouteId);
                        command.Options.Add(DescriptionOption);
                        command.Options.Add(DisplayName);
                        command.Options.Add(Target);
                        command.Options.Add(MetadataSlug);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Baseten.UpdateRouteRequestV1>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Baseten.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var routeId = parseResult.GetRequiredValue(RouteId);
                        var description = CliRuntime.WasSpecified(parseResult, DescriptionOption) ? parseResult.GetValue(DescriptionOption) : (__requestBase is { } __DescriptionBaseValue ? __DescriptionBaseValue.Description : default);
                        var displayName = CliRuntime.WasSpecified(parseResult, DisplayName) ? parseResult.GetValue(DisplayName) : (__requestBase is { } __DisplayNameBaseValue ? __DisplayNameBaseValue.DisplayName : default);
                        var target = CliRuntime.WasSpecified(parseResult, Target) ? parseResult.GetValue(Target) : (__requestBase is { } __TargetBaseValue ? __TargetBaseValue.Target : default);
                        var metadataSlug = CliRuntime.WasSpecified(parseResult, MetadataSlug) ? parseResult.GetValue(MetadataSlug) : (__requestBase is { } __MetadataSlugBaseValue ? __MetadataSlugBaseValue.MetadataSlug : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.EditRoutesByRouteIdAsync(
                                    routeId: routeId,
                                    description: description,
                                    displayName: displayName,
                                    target: target,
                                    metadataSlug: metadataSlug,
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