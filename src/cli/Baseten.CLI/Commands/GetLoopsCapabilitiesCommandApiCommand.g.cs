#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Baseten.CLI.Commands;

internal static partial class GetLoopsCapabilitiesCommandApiCommand
{
    private static Option<string?> Model { get; } = new(
        name: @"--model")
    {
        Description = @"Restrict the response to one model, identified by its HuggingFace repo id. A supported model comes back with its 'enabled' flag and, when false, its 'enablement_details'. An empty list means Baseten does not support that model. Omit to list every supported model.",
    };

    private static Option<global::Baseten.LoopsUseCaseV1?> UseCase { get; } = new(
        name: @"--use-case")
    {
        Description = @"What the caller intends to run. Defaults to 'rl', the stricter of the two: an RL run needs both a trainer and a sampler, so anything enabled for 'rl' is also enabled for 'sft'.",
    };

    private static Option<int?> MaxSeqLen { get; } = new(
        name: @"--max-seq-len")
    {
        Description = @"The sequence length the caller intends to train at — the same value they would pass as 'max_seq_len' when creating the run. Models that cannot serve it are reported as not enabled rather than returned with a ceiling the caller cannot use. Omit for the model's highest enabled sequence length.",
    };

                    private static string FormatResponse(ParseResult parseResult, global::Baseten.GetLoopsCapabilitiesResponseV1 value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Baseten.GetLoopsCapabilitiesResponseV1 value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"get-loops-capabilities", @"Gets Loops server capabilities
Returns the list of models supported by the Loops server, including each model's maximum context length and whether it supports vision-language inputs. Each entry carries an 'enabled' flag saying whether this workspace can run it now, and 'enablement_details' explaining why when it cannot; filter on 'enabled' for the usable set. Capacity is resolved when the run is created, not here. Pass ?model= to ask about one model — an empty list means Baseten does not support it. Pass ?use_case=sft for a run that needs no sampler, and ?max_seq_len= to check a specific sequence length.");
                        command.Options.Add(Model);
                        command.Options.Add(UseCase);
                        command.Options.Add(MaxSeqLen);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var model = parseResult.GetValue(Model);
                        var useCase = parseResult.GetValue(UseCase);
                        var maxSeqLen = parseResult.GetValue(MaxSeqLen);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.GetLoopsCapabilitiesAsync(
                                    model: model,
                                    useCase: useCase,
                                    maxSeqLen: maxSeqLen,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                if (!await CliRuntime.TryWriteOutputDirectoryAsync(
                                        parseResult,
                                        response,
                                        global::Baseten.SourceGenerationContext.Default,
                                        @"SupportedModels",
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