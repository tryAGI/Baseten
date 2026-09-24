#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Baseten.CLI.Commands;

internal static partial class CreateRoutesCommandApiCommand
{
    private static Argument<string> NameOption { get; } = new(
        name: @"name")
    {
        Description = @"Immutable, globally unique route name using an organization-owned prefix.",
    };

    private static Option<string?> TeamId { get; } = new(
        name: @"--team-id")
    {
        Description = @"Identifier of the team that owns the route. When omitted, uses your organization's default team.",
    };

    private static Option<string?> DisplayName { get; } = new(
        name: @"--display-name")
    {
        Description = @"Display label. Omit to use the route name; null is not accepted.",
    };

    private static Option<global::Baseten.Target2> Target { get; } = new(
        name: @"--target")
    {
        Description = @"Upstream target for the route.",
        Required = true,
    };

    private static Option<string?> DescriptionOption { get; } = new(
        name: @"--description")
    {
        Description = @"Short description of the route. Omit for no description; null is not accepted.",
    };

    private static Option<string?> MetadataSlug { get; } = new(
        name: @"--metadata-slug")
    {
        Description = @"Slug of a metadata row to link. Omit to auto-resolve from the target; required for OPENAI_COMPATIBLE and VERTEX targets.",
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
        var command = new Command(@"create-routes", @"Creates a route
Dedicated deployment targets are not supported.");
                        command.Arguments.Add(NameOption);
                        command.Options.Add(TeamId);
                        command.Options.Add(DisplayName);
                        command.Options.Add(Target);
                        command.Options.Add(DescriptionOption);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Baseten.CreateRouteRequestV1>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Baseten.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var name = parseResult.GetRequiredValue(NameOption);
                        var teamId = CliRuntime.WasSpecified(parseResult, TeamId) ? parseResult.GetValue(TeamId) : (__requestBase is { } __TeamIdBaseValue ? __TeamIdBaseValue.TeamId : default);
                        var displayName = CliRuntime.WasSpecified(parseResult, DisplayName) ? parseResult.GetValue(DisplayName) : (__requestBase is { } __DisplayNameBaseValue ? __DisplayNameBaseValue.DisplayName : default);
                        var target = parseResult.GetRequiredValue(Target);
                        var description = CliRuntime.WasSpecified(parseResult, DescriptionOption) ? parseResult.GetValue(DescriptionOption) : (__requestBase is { } __DescriptionBaseValue ? __DescriptionBaseValue.Description : default);
                        var metadataSlug = CliRuntime.WasSpecified(parseResult, MetadataSlug) ? parseResult.GetValue(MetadataSlug) : (__requestBase is { } __MetadataSlugBaseValue ? __MetadataSlugBaseValue.MetadataSlug : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.CreateRoutesAsync(
                                    name: name,
                                    teamId: teamId,
                                    displayName: displayName,
                                    target: target,
                                    description: description,
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