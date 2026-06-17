#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Baseten.CLI.Commands;

internal static partial class CreateTrainingProjectsCommandApiCommand
{
    private static readonly UpsertTrainingProjectV1OptionSet TrainingProjectOptions = UpsertTrainingProjectV1OptionSet.Create(@"training-project");

                    private static string FormatResponse(ParseResult parseResult, global::Baseten.UpsertTrainingProjectResponseV1 value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Baseten.UpsertTrainingProjectResponseV1 value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"create-training-projects", @"Upsert a training project.
Upserts a training project with the specified metadata.");
                        command.Options.Add(TrainingProjectOptions.NameOption);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
	                        var trainingProjectNameOption = parseResult.GetValue(TrainingProjectOptions.NameOption);
                        var __TrainingProjectSpecified = CliRuntime.WasSpecified(parseResult, TrainingProjectOptions.NameOption);
                        var trainingProject =
                            __TrainingProjectSpecified || false
                                ? new global::Baseten.UpsertTrainingProjectV1
                                {
	                                Name = trainingProjectNameOption!,

                                }
                                : null;
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.CreateTrainingProjectsAsync(
                                    trainingProject: trainingProject!,
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