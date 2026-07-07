#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Baseten.CLI.Commands;

internal static partial class CreateGatewayEndpointsCommandApiCommand
{
    private static Argument<string> Slug { get; } = new(
        name: @"slug")
    {
        Description = @"Globally-unique slug of the form '{org_prefix}/{name}'.",
    };

    private static Option<global::System.Collections.Generic.IList<global::Baseten.EndpointTargetRequestV1>> Targets { get; } = new(
        name: @"--targets")
    {
        Description = @"The endpoint's upstream targets. Exactly one target is supported at this time.",
        Required = true,
    };

                    private static string FormatResponse(ParseResult parseResult, global::Baseten.EndpointV1 value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Baseten.EndpointV1 value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"create-gateway-endpoints", @"Creates a Gateway endpoint
Provisions an endpoint for the given slug and its upstream target. Exactly one target is supported at this time. The slug's prefix must be one your organization owns.");
                        command.Arguments.Add(Slug);
                        command.Options.Add(Targets);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var slug = parseResult.GetRequiredValue(Slug);
                        var targets = parseResult.GetRequiredValue(Targets);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.CreateGatewayEndpointsAsync(
                                    slug: slug,
                                    targets: targets,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                if (!await CliRuntime.TryWriteOutputDirectoryAsync(
                                        parseResult,
                                        response,
                                        global::Baseten.SourceGenerationContext.Default,
                                        @"Targets",
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