#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Baseten.CLI.Commands;

internal static partial class DeleteVolumesByVolumeNamespaceByVolumeNameTagsByVolumeTagCommandApiCommand
{
    private static Argument<string> VolumeNamespace { get; } = new(
        name: @"volume-namespace")
    {
        Description = @"This is a missing parameter that was added automatically. Please check the OpenAPI spec.",
    };

    private static Argument<string> VolumeName { get; } = new(
        name: @"volume-name")
    {
        Description = @"This is a missing parameter that was added automatically. Please check the OpenAPI spec.",
    };

    private static Argument<string> VolumeTag { get; } = new(
        name: @"volume-tag")
    {
        Description = @"This is a missing parameter that was added automatically. Please check the OpenAPI spec.",
    };

    private static Option<int?> ExpectedSequence { get; } = new(
        name: @"--expected-sequence")
    {
        Description = @"Revision the volume is expected to be at. When set, the delete fails with a conflict if the volume has changed since, so it cannot delete a tag someone else has just set on another version. Take the value from volume_sequence.",
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

                    private static string FormatResponse(ParseResult parseResult, global::Baseten.DeleteVolumeTagResponseV1 value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Baseten.DeleteVolumeTagResponseV1 value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    static partial void CustomizeCommand(ref Command command);

    public static Command Create(string? commandName = null)
    {
        var command = new Command(commandName ?? @"delete-volumes-by-volume-namespace-by-volume-name-tags-by-volume-tag", @"Deletes a volume tag
The version remains available by digest and any other tags. If the tag is absent, the request succeeds with `deleted` set to `false`. Deleting `head` makes references without a tag or digest stop resolving until `head` is set again.");
                        command.Arguments.Add(VolumeNamespace);
                        command.Arguments.Add(VolumeName);
                        command.Arguments.Add(VolumeTag);
                        command.Options.Add(ExpectedSequence);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Baseten.DeleteVolumeTagRequestV1>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Baseten.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var volumeNamespace = parseResult.GetRequiredValue(VolumeNamespace);
                        var volumeName = parseResult.GetRequiredValue(VolumeName);
                        var volumeTag = parseResult.GetRequiredValue(VolumeTag);
                        var expectedSequence = CliRuntime.WasSpecified(parseResult, ExpectedSequence) ? parseResult.GetValue(ExpectedSequence) : (__requestBase is { } __ExpectedSequenceBaseValue ? __ExpectedSequenceBaseValue.ExpectedSequence : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.DeleteVolumesByVolumeNamespaceByVolumeNameTagsByVolumeTagAsync(
                                    volumeNamespace: volumeNamespace,
                                    volumeName: volumeName,
                                    volumeTag: volumeTag,
                                    expectedSequence: expectedSequence,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::Baseten.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        CustomizeCommand(ref command);
        return command;
    }
}