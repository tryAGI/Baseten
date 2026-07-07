#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Baseten.CLI.Commands;

internal static partial class EditLoopsUserConfigCommandApiCommand
{
    private static Option<global::System.Collections.Generic.IList<string>?> TrainerAcceleratorPriority { get; } = new(
        name: @"--trainer-accelerator-priority")
    {
        Description = @"Ordered list of GPU types for trainer deployments, highest priority first. Send a list to set; send null to clear (inherit org allowlist); omit to leave unchanged. Empty list is rejected.",
    };

    private static Option<global::System.Collections.Generic.IList<string>?> SamplerAcceleratorPriority { get; } = new(
        name: @"--sampler-accelerator-priority")
    {
        Description = @"Ordered list of GPU types for sampler deployments, highest priority first. Send a list to set; send null to clear (inherit org allowlist); omit to leave unchanged. Empty list is rejected.",
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

                    private static string FormatResponse(ParseResult parseResult, global::Baseten.PatchLoopsUserConfigResponseV1 value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Baseten.PatchLoopsUserConfigResponseV1 value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"edit-loops-user-config", @"Patches the caller's Loops user config
Updates the caller's Loops user config using JSON Merge Patch (RFC 7396) semantics per field: omit a field to leave it unchanged, send null to clear (inherit the org-level allowlist), or send a list to set the allowlist. Empty lists are rejected.");
                        command.Options.Add(TrainerAcceleratorPriority);
                        command.Options.Add(SamplerAcceleratorPriority);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Baseten.PatchLoopsUserConfigRequestV1>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Baseten.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var trainerAcceleratorPriority = CliRuntime.WasSpecified(parseResult, TrainerAcceleratorPriority) ? parseResult.GetValue(TrainerAcceleratorPriority) : (__requestBase is { } __TrainerAcceleratorPriorityBaseValue ? __TrainerAcceleratorPriorityBaseValue.TrainerAcceleratorPriority : default);
                        var samplerAcceleratorPriority = CliRuntime.WasSpecified(parseResult, SamplerAcceleratorPriority) ? parseResult.GetValue(SamplerAcceleratorPriority) : (__requestBase is { } __SamplerAcceleratorPriorityBaseValue ? __SamplerAcceleratorPriorityBaseValue.SamplerAcceleratorPriority : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.EditLoopsUserConfigAsync(
                                    trainerAcceleratorPriority: trainerAcceleratorPriority,
                                    samplerAcceleratorPriority: samplerAcceleratorPriority,
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