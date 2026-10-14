#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Baseten.CLI.Commands;

internal static partial class CreateVolumesByVolumeNamespaceByVolumeNameTagsCommandApiCommand
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

    private static Option<string> Tag { get; } = new(
        name: @"--tag")
    {
        Description = @"Name of the tag to set. Tags are case-sensitive. Setting a tag that already exists overwrites it, and the version it pointed at before stays reachable by digest.",
        Required = true,
    };

    private static Option<string> Version { get; } = new(
        name: @"--version")
    {
        Description = @"Version to set the tag on. Address it with `:<tag>` for a tag, `@<digest>` for a full content digest or a prefix of at least 12 hexadecimal characters, or `head` for the version a reference with no tag or digest resolves to.",
        Required = true,
    };

    private static Option<global::System.DateTime?> ExpiresAt { get; } = new(
        name: @"--expires-at")
    {
        Description = @"Time at which the tag expires, in ISO 8601 format, with a UTC offset. It must be in the future and at most ten years ahead. Omit it for a tag with no expiration time of its own. Omitting it also clears the expiration time of an existing tag. Version or volume expiration still deletes the tag. Do not specify it when setting `head`.",
    };

    private static Option<int?> ExpectedSequence { get; } = new(
        name: @"--expected-sequence")
    {
        Description = @"Revision the volume is expected to be at. When set, the request fails with a conflict if the volume has changed since. Take the value from volume_sequence.",
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

                    private static string FormatResponse(ParseResult parseResult, global::Baseten.SetVolumeTagResponseV1 value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Baseten.SetVolumeTagResponseV1 value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    static partial void CustomizeCommand(ref Command command);

    public static Command Create(string? commandName = null)
    {
        var command = new Command(commandName ?? @"create-volumes-by-volume-namespace-by-volume-name-tags", @"Sets a volume tag
Setting an existing tag overwrites it. The previous version remains available by digest. Pass `expires_at` to set the tag's expiration time. Omit `expires_at` to clear any expiration time on the tag. Version or volume expiration still deletes the tag. Setting `head` changes the version used by references without a tag or digest. You cannot set `head` on an expiring version or supply `expires_at` when setting `head`.");
                        command.Arguments.Add(VolumeNamespace);
                        command.Arguments.Add(VolumeName);
                        command.Options.Add(Tag);
                        command.Options.Add(Version);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Baseten.SetVolumeTagRequestV1>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Baseten.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var volumeNamespace = parseResult.GetRequiredValue(VolumeNamespace);
                        var volumeName = parseResult.GetRequiredValue(VolumeName);
                        var tag = parseResult.GetRequiredValue(Tag);
                        var version = parseResult.GetRequiredValue(Version);
                        var expiresAt = CliRuntime.WasSpecified(parseResult, ExpiresAt) ? parseResult.GetValue(ExpiresAt) : (__requestBase is { } __ExpiresAtBaseValue ? __ExpiresAtBaseValue.ExpiresAt : default);
                        var expectedSequence = CliRuntime.WasSpecified(parseResult, ExpectedSequence) ? parseResult.GetValue(ExpectedSequence) : (__requestBase is { } __ExpectedSequenceBaseValue ? __ExpectedSequenceBaseValue.ExpectedSequence : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.CreateVolumesByVolumeNamespaceByVolumeNameTagsAsync(
                                    volumeNamespace: volumeNamespace,
                                    volumeName: volumeName,
                                    tag: tag,
                                    version: version,
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