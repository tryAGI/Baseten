#nullable enable

namespace Baseten.JsonConverters
{
    /// <inheritdoc />
    public sealed class LibraryListingMetadataV1OutputModalitieJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Baseten.LibraryListingMetadataV1OutputModalitie>
    {
        /// <inheritdoc />
        public override global::Baseten.LibraryListingMetadataV1OutputModalitie Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::Baseten.LibraryListingMetadataV1OutputModalitieExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Baseten.LibraryListingMetadataV1OutputModalitie)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Baseten.LibraryListingMetadataV1OutputModalitie);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Baseten.LibraryListingMetadataV1OutputModalitie value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Baseten.LibraryListingMetadataV1OutputModalitieExtensions.ToValueString(value));
        }
    }
}
