
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Returned when a conversation is created. Emitted right after session creation.
    /// </summary>
    public sealed partial class RealtimeServerEventConversationCreated
    {
        /// <summary>
        /// The unique ID of the server event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EventId { get; set; }

        /// <summary>
        /// The event type, must be `conversation.created`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventConversationCreatedTypeJsonConverter))]
        public global::tryAGI.OpenAI.RealtimeServerEventConversationCreatedType Type { get; set; }

        /// <summary>
        /// The conversation resource.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.RealtimeServerEventConversationCreatedConversation Conversation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeServerEventConversationCreated" /> class.
        /// </summary>
        /// <param name="eventId">
        /// The unique ID of the server event.
        /// </param>
        /// <param name="type">
        /// The event type, must be `conversation.created`.
        /// </param>
        /// <param name="conversation">
        /// The conversation resource.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeServerEventConversationCreated(
            string eventId,
            global::tryAGI.OpenAI.RealtimeServerEventConversationCreatedConversation conversation,
            global::tryAGI.OpenAI.RealtimeServerEventConversationCreatedType type)
        {
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.Conversation = conversation ?? throw new global::System.ArgumentNullException(nameof(conversation));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeServerEventConversationCreated" /> class.
        /// </summary>
        public RealtimeServerEventConversationCreated()
        {
        }
    }
}