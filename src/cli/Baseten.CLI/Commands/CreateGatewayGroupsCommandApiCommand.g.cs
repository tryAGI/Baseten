#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Baseten.CLI.Commands;

internal static partial class CreateGatewayGroupsCommandApiCommand
{
    private static Option<global::Baseten.GroupMetadataV1> Metadata { get; } = new(
        name: @"--metadata")
    {
        Description = @"Group identity + display metadata.",
        Required = true,
    };

    private static Option<global::System.Collections.Generic.IList<global::Baseten.ModelConfigV1>> Models { get; } = new(
        name: @"--models")
    {
        Description = @"Per-model rate and usage limit configuration. Defines the group's complete model set. Must be non-empty.",
        Required = true,
    };

    private static Option<global::Baseten.GroupHierarchyV1> Hierarchy { get; } = new(
        name: @"--hierarchy")
    {
        Description = @"Parent linkage and limit enforcement mode. Immutable after creation.",
        Required = true,
    };

                    private static string FormatResponse(ParseResult parseResult, global::Baseten.GroupV1 value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Baseten.GroupV1 value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"create-gateway-groups", @"Creates a group
Creates a group and its endpoint configuration.");
                        command.Options.Add(Metadata);
                        command.Options.Add(Models);
                        command.Options.Add(Hierarchy);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var metadata = parseResult.GetRequiredValue(Metadata);
                        var models = parseResult.GetRequiredValue(Models);
                        var hierarchy = parseResult.GetRequiredValue(Hierarchy);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.CreateGatewayGroupsAsync(
                                    metadata: metadata,
                                    models: models,
                                    hierarchy: hierarchy,
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