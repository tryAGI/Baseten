
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull
    )]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.SandboxImageBuildLogV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.SandboxImageBuildLogsResponseV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Baseten.SandboxImageBuildLogV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Baseten.SandboxPortV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.SandboxPortV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.SandboxPortV1Protocol), TypeInfoPropertyName = "SandboxPortV1Protocol2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.SandboxApiPaginationV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.ListSandboxImagesResponseV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Baseten.SandboxImageSummaryV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.SandboxImageSummaryV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.ListSandboxImageTagsResponseV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Baseten.SandboxImageTagV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.SandboxImageTagV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.SandboxImageStatusV1), TypeInfoPropertyName = "SandboxImageStatusV12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.SandboxImageV1), TypeInfoPropertyName = "SandboxImageV12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.SandboxImageV1Variant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.PushSandboxImageRequestV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.PushSandboxImageResponseV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.SandboxLibraryImageVolumeV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.SandboxLibraryImageCreationOptionsV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Baseten.SandboxLibraryImageVolumeV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.SandboxLibraryImageV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.ListSandboxLibraryImagesResponseV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Baseten.SandboxLibraryImageV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.CleanupSandboxImagesResponseV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.SandboxPortV1Protocol?), TypeInfoPropertyName = "NullableSandboxPortV1Protocol2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.SandboxImageStatusV1?), TypeInfoPropertyName = "NullableSandboxImageStatusV12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.SandboxImageV1?), TypeInfoPropertyName = "NullableSandboxImageV12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Baseten.SandboxImageBuildLogV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Baseten.SandboxPortV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Baseten.SandboxImageSummaryV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Baseten.SandboxImageTagV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Baseten.SandboxLibraryImageVolumeV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Baseten.SandboxLibraryImageV1>))]
    internal sealed partial class ImagesSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ImagesSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static ImagesSourceGenerationContext Default { get; } = new(DefaultOptions);

        private ImagesSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::Baseten.JsonConverters.SandboxImageV1JsonConverter());
            options.Converters.Add(new global::Baseten.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Baseten.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Baseten.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Baseten.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Baseten.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Baseten.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Baseten.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Baseten.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Baseten.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Baseten.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Baseten.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Baseten.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Baseten.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Baseten.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Baseten.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Baseten.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Baseten.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Baseten.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Baseten.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Baseten.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Baseten.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Baseten.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::Baseten.SandboxPortV1Protocol)

                    || typeToConvert == typeof(global::Baseten.SandboxPortV1Protocol?)

                    || typeToConvert == typeof(global::Baseten.SandboxImageStatusV1)

                    || typeToConvert == typeof(global::Baseten.SandboxImageStatusV1?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Baseten.SandboxPortV1Protocol))
                {
                    return new global::Baseten.JsonConverters.SandboxPortV1ProtocolJsonConverter();
                }

                if (typeToConvert == typeof(global::Baseten.SandboxPortV1Protocol?))
                {
                    return new global::Baseten.JsonConverters.SandboxPortV1ProtocolNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Baseten.SandboxImageStatusV1))
                {
                    return new global::Baseten.JsonConverters.SandboxImageStatusV1JsonConverter();
                }

                if (typeToConvert == typeof(global::Baseten.SandboxImageStatusV1?))
                {
                    return new global::Baseten.JsonConverters.SandboxImageStatusV1NullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new ImagesSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}