
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.SandboxLifecycleV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Baseten.SandboxExpirationPolicyV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.SandboxExpirationPolicyV1), TypeInfoPropertyName = "SandboxExpirationPolicyV12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.SandboxTTLIdleExpirationPolicyV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.SandboxTTLMaxAgeExpirationPolicyV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.SandboxDateExpirationPolicyV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.SandboxExpirationPolicyV1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.SandboxExpirationPolicyV1DiscriminatorType), TypeInfoPropertyName = "SandboxExpirationPolicyV1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.SandboxTTLIdleExpirationPolicyV1Action), TypeInfoPropertyName = "SandboxTTLIdleExpirationPolicyV1Action2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.SandboxTTLIdleExpirationPolicyV1Type), TypeInfoPropertyName = "SandboxTTLIdleExpirationPolicyV1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.SandboxTTLMaxAgeExpirationPolicyV1Action), TypeInfoPropertyName = "SandboxTTLMaxAgeExpirationPolicyV1Action2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.SandboxTTLMaxAgeExpirationPolicyV1Type), TypeInfoPropertyName = "SandboxTTLMaxAgeExpirationPolicyV1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.SandboxDateExpirationPolicyV1Action), TypeInfoPropertyName = "SandboxDateExpirationPolicyV1Action2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.SandboxDateExpirationPolicyV1Type), TypeInfoPropertyName = "SandboxDateExpirationPolicyV1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.SandboxNetworkV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.SandboxProxyConfigV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Baseten.SandboxProxyTargetV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.SandboxProxyTargetV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.SandboxEnvV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Baseten.SandboxPortV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.SandboxPortV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.SandboxPortV1Protocol), TypeInfoPropertyName = "SandboxPortV1Protocol2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.SandboxConfigurationV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Baseten.SandboxEnvV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.CreateSandboxRequestV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.UpdateSandboxRequestV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.SandboxV1), TypeInfoPropertyName = "SandboxV12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.SandboxV1Variant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.SandboxStatusV1), TypeInfoPropertyName = "SandboxStatusV12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.SandboxV1Variant2State), TypeInfoPropertyName = "SandboxV1Variant2State2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.SandboxApiPaginationV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.ListSandboxesResponseV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Baseten.SandboxV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.SandboxExpirationPolicyV1?), TypeInfoPropertyName = "NullableSandboxExpirationPolicyV12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.SandboxExpirationPolicyV1DiscriminatorType?), TypeInfoPropertyName = "NullableSandboxExpirationPolicyV1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.SandboxTTLIdleExpirationPolicyV1Action?), TypeInfoPropertyName = "NullableSandboxTTLIdleExpirationPolicyV1Action2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.SandboxTTLIdleExpirationPolicyV1Type?), TypeInfoPropertyName = "NullableSandboxTTLIdleExpirationPolicyV1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.SandboxTTLMaxAgeExpirationPolicyV1Action?), TypeInfoPropertyName = "NullableSandboxTTLMaxAgeExpirationPolicyV1Action2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.SandboxTTLMaxAgeExpirationPolicyV1Type?), TypeInfoPropertyName = "NullableSandboxTTLMaxAgeExpirationPolicyV1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.SandboxDateExpirationPolicyV1Action?), TypeInfoPropertyName = "NullableSandboxDateExpirationPolicyV1Action2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.SandboxDateExpirationPolicyV1Type?), TypeInfoPropertyName = "NullableSandboxDateExpirationPolicyV1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.SandboxPortV1Protocol?), TypeInfoPropertyName = "NullableSandboxPortV1Protocol2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.SandboxV1?), TypeInfoPropertyName = "NullableSandboxV12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.SandboxStatusV1?), TypeInfoPropertyName = "NullableSandboxStatusV12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.SandboxV1Variant2State?), TypeInfoPropertyName = "NullableSandboxV1Variant2State2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Baseten.SandboxExpirationPolicyV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Baseten.SandboxProxyTargetV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Baseten.SandboxPortV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Baseten.SandboxEnvV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Baseten.SandboxV1>))]
    internal sealed partial class SandboxesSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SandboxesSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SandboxesSourceGenerationContext Default { get; } = new(DefaultOptions);

        private SandboxesSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Baseten.JsonConverters.SandboxExpirationPolicyV1JsonConverter());
            options.Converters.Add(new global::Baseten.JsonConverters.SandboxV1JsonConverter());
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
                    typeToConvert == typeof(global::Baseten.SandboxExpirationPolicyV1DiscriminatorType)

                    || typeToConvert == typeof(global::Baseten.SandboxExpirationPolicyV1DiscriminatorType?)

                    || typeToConvert == typeof(global::Baseten.SandboxTTLIdleExpirationPolicyV1Action)

                    || typeToConvert == typeof(global::Baseten.SandboxTTLIdleExpirationPolicyV1Action?)

                    || typeToConvert == typeof(global::Baseten.SandboxTTLIdleExpirationPolicyV1Type)

                    || typeToConvert == typeof(global::Baseten.SandboxTTLIdleExpirationPolicyV1Type?)

                    || typeToConvert == typeof(global::Baseten.SandboxTTLMaxAgeExpirationPolicyV1Action)

                    || typeToConvert == typeof(global::Baseten.SandboxTTLMaxAgeExpirationPolicyV1Action?)

                    || typeToConvert == typeof(global::Baseten.SandboxTTLMaxAgeExpirationPolicyV1Type)

                    || typeToConvert == typeof(global::Baseten.SandboxTTLMaxAgeExpirationPolicyV1Type?)

                    || typeToConvert == typeof(global::Baseten.SandboxDateExpirationPolicyV1Action)

                    || typeToConvert == typeof(global::Baseten.SandboxDateExpirationPolicyV1Action?)

                    || typeToConvert == typeof(global::Baseten.SandboxDateExpirationPolicyV1Type)

                    || typeToConvert == typeof(global::Baseten.SandboxDateExpirationPolicyV1Type?)

                    || typeToConvert == typeof(global::Baseten.SandboxPortV1Protocol)

                    || typeToConvert == typeof(global::Baseten.SandboxPortV1Protocol?)

                    || typeToConvert == typeof(global::Baseten.SandboxV1Variant2State)

                    || typeToConvert == typeof(global::Baseten.SandboxV1Variant2State?)

                    || typeToConvert == typeof(global::Baseten.SandboxStatusV1)

                    || typeToConvert == typeof(global::Baseten.SandboxStatusV1?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Baseten.SandboxExpirationPolicyV1DiscriminatorType))
                {
                    return new global::Baseten.JsonConverters.SandboxExpirationPolicyV1DiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Baseten.SandboxExpirationPolicyV1DiscriminatorType?))
                {
                    return new global::Baseten.JsonConverters.SandboxExpirationPolicyV1DiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Baseten.SandboxTTLIdleExpirationPolicyV1Action))
                {
                    return new global::Baseten.JsonConverters.SandboxTTLIdleExpirationPolicyV1ActionJsonConverter();
                }

                if (typeToConvert == typeof(global::Baseten.SandboxTTLIdleExpirationPolicyV1Action?))
                {
                    return new global::Baseten.JsonConverters.SandboxTTLIdleExpirationPolicyV1ActionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Baseten.SandboxTTLIdleExpirationPolicyV1Type))
                {
                    return new global::Baseten.JsonConverters.SandboxTTLIdleExpirationPolicyV1TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Baseten.SandboxTTLIdleExpirationPolicyV1Type?))
                {
                    return new global::Baseten.JsonConverters.SandboxTTLIdleExpirationPolicyV1TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Baseten.SandboxTTLMaxAgeExpirationPolicyV1Action))
                {
                    return new global::Baseten.JsonConverters.SandboxTTLMaxAgeExpirationPolicyV1ActionJsonConverter();
                }

                if (typeToConvert == typeof(global::Baseten.SandboxTTLMaxAgeExpirationPolicyV1Action?))
                {
                    return new global::Baseten.JsonConverters.SandboxTTLMaxAgeExpirationPolicyV1ActionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Baseten.SandboxTTLMaxAgeExpirationPolicyV1Type))
                {
                    return new global::Baseten.JsonConverters.SandboxTTLMaxAgeExpirationPolicyV1TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Baseten.SandboxTTLMaxAgeExpirationPolicyV1Type?))
                {
                    return new global::Baseten.JsonConverters.SandboxTTLMaxAgeExpirationPolicyV1TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Baseten.SandboxDateExpirationPolicyV1Action))
                {
                    return new global::Baseten.JsonConverters.SandboxDateExpirationPolicyV1ActionJsonConverter();
                }

                if (typeToConvert == typeof(global::Baseten.SandboxDateExpirationPolicyV1Action?))
                {
                    return new global::Baseten.JsonConverters.SandboxDateExpirationPolicyV1ActionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Baseten.SandboxDateExpirationPolicyV1Type))
                {
                    return new global::Baseten.JsonConverters.SandboxDateExpirationPolicyV1TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Baseten.SandboxDateExpirationPolicyV1Type?))
                {
                    return new global::Baseten.JsonConverters.SandboxDateExpirationPolicyV1TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Baseten.SandboxPortV1Protocol))
                {
                    return new global::Baseten.JsonConverters.SandboxPortV1ProtocolJsonConverter();
                }

                if (typeToConvert == typeof(global::Baseten.SandboxPortV1Protocol?))
                {
                    return new global::Baseten.JsonConverters.SandboxPortV1ProtocolNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Baseten.SandboxV1Variant2State))
                {
                    return new global::Baseten.JsonConverters.SandboxV1Variant2StateJsonConverter();
                }

                if (typeToConvert == typeof(global::Baseten.SandboxV1Variant2State?))
                {
                    return new global::Baseten.JsonConverters.SandboxV1Variant2StateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Baseten.SandboxStatusV1))
                {
                    return new global::Baseten.JsonConverters.SandboxStatusV1JsonConverter();
                }

                if (typeToConvert == typeof(global::Baseten.SandboxStatusV1?))
                {
                    return new global::Baseten.JsonConverters.SandboxStatusV1NullableJsonConverter();
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
                    0 => new SandboxesSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}