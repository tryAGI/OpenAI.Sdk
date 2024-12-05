#nullable enable

namespace OpenAI.JsonConverters
{
    /// <inheritdoc />
    public sealed class RealtimeServerEventConversationItemTruncatedTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenAI.RealtimeServerEventConversationItemTruncatedType>
    {
        /// <inheritdoc />
        public override global::OpenAI.RealtimeServerEventConversationItemTruncatedType Read(
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
                        return global::OpenAI.RealtimeServerEventConversationItemTruncatedTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::OpenAI.RealtimeServerEventConversationItemTruncatedType)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenAI.RealtimeServerEventConversationItemTruncatedType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::OpenAI.RealtimeServerEventConversationItemTruncatedTypeExtensions.ToValueString(value));
        }
    }
}