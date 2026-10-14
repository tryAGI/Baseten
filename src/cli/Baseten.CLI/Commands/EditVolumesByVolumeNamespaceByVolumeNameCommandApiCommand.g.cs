#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Baseten.CLI.Commands;

internal static partial class EditVolumesByVolumeNamespaceByVolumeNameCommandApiCommand
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

    private static Option<global::System.DateTime?> ExpiresAt { get; } = new(
        name: @"--expires-at")
    {
        Description = @"Time at which the volume expires, in ISO 8601 format, with a UTC offset. It must be in the future and at most ten years ahead. Set it to null to clear the expiration time. A body that sets no field is rejected. When the volume expires, all live versions are deleted, all tags are removed, and the volume disappears from listings. Clearing the expiration time afterward does not restore deleted versions. Each deleted version can be restored until its delete_after time. Setting or clearing the expiration time requires the same permission as deleting the volume.",
    };

    private static Option<int?> ExpectedSequence { get; } = new(
        name: @"--expected-sequence")
    {
        Description = @"Revision the volume is expected to be at. When set, the update fails with a conflict if the volume has changed since. Take the value from a volume's sequence, or from volume_sequence.",
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

                    private static string FormatResponse(ParseResult parseResult, global::Baseten.PatchVolumeResponseV1 value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Baseten.PatchVolumeResponseV1 value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    static partial void CustomizeCommand(ref Command command);

    public static Command Create(string? commandName = null)
    {
        var command = new Command(commandName ?? @"edit-volumes-by-volume-namespace-by-volume-name", @"Updates a volume
Updates a volume's settings, such as its expiration time. Only the settings in the request change.");
                        command.Arguments.Add(VolumeNamespace);
                        command.Arguments.Add(VolumeName);
                        command.Options.Add(ExpiresAt);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Baseten.PatchVolumeRequestV1>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Baseten.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var volumeNamespace = parseResult.GetRequiredValue(VolumeNamespace);
                        var volumeName = parseResult.GetRequiredValue(VolumeName);
                        var expiresAt = CliRuntime.WasSpecified(parseResult, ExpiresAt) ? parseResult.GetValue(ExpiresAt) : (__requestBase is { } __ExpiresAtBaseValue ? __ExpiresAtBaseValue.ExpiresAt : default);
                        var expectedSequence = CliRuntime.WasSpecified(parseResult, ExpectedSequence) ? parseResult.GetValue(ExpectedSequence) : (__requestBase is { } __ExpectedSequenceBaseValue ? __ExpectedSequenceBaseValue.ExpectedSequence : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.EditVolumesByVolumeNamespaceByVolumeNameAsync(
                                    volumeNamespace: volumeNamespace,
                                    volumeName: volumeName,
                                    expiresAt: expiresAt,
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