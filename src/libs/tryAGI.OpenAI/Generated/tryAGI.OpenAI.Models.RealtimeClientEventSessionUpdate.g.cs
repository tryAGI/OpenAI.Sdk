
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Send this event to update the session’s default configuration. The client may <br/>
    /// send this event at any time to update the session configuration, and any <br/>
    /// field may be updated at any time, except for "voice". The server will respond <br/>
    /// with a `session.updated` event that shows the full effective configuration. <br/>
    /// Only fields that are present are updated, thus the correct way to clear a <br/>
    /// field like "instructions" is to pass an empty string.
    /// </summary>
    public sealed partial class RealtimeClientEventSessionUpdate
    {
        /// <summary>
        /// Optional client-generated ID used to identify this event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        public string? EventId { get; set; }

        /// <summary>
        /// The event type, must be `session.update`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeClientEventSessionUpdateTypeJsonConverter))]
        public global::tryAGI.OpenAI.RealtimeClientEventSessionUpdateType Type { get; set; }

        /// <summary>
        /// Realtime session object configuration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.RealtimeSessionCreateRequest Session { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeClientEventSessionUpdate" /> class.
        /// </summary>
        /// <param name="eventId">
        /// Optional client-generated ID used to identify this event.
        /// </param>
        /// <param name="type">
        /// The event type, must be `session.update`.
        /// </param>
        /// <param name="session">
        /// Realtime session object configuration.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeClientEventSessionUpdate(
            global::tryAGI.OpenAI.RealtimeSessionCreateRequest session,
            string? eventId,
            global::tryAGI.OpenAI.RealtimeClientEventSessionUpdateType type)
        {
            this.Session = session ?? throw new global::System.ArgumentNullException(nameof(session));
            this.EventId = eventId;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeClientEventSessionUpdate" /> class.
        /// </summary>
        public RealtimeClientEventSessionUpdate()
        {
        }
    }
}