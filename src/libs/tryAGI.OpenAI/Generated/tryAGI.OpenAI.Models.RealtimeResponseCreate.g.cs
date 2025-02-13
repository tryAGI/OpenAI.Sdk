
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Send this event to trigger a response generation.
    /// </summary>
    public sealed partial class RealtimeResponseCreate
    {
        /// <summary>
        /// Optional client-generated ID used to identify this event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        public string? EventId { get; set; }

        /// <summary>
        /// The event type, must be 'response.create'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeResponseCreateTypeJsonConverter))]
        public global::tryAGI.OpenAI.RealtimeResponseCreateType? Type { get; set; }

        /// <summary>
        /// Configuration for the response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response")]
        public global::tryAGI.OpenAI.RealtimeResponseCreateResponse? Response { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeResponseCreate" /> class.
        /// </summary>
        /// <param name="eventId">
        /// Optional client-generated ID used to identify this event.
        /// </param>
        /// <param name="type">
        /// The event type, must be 'response.create'.
        /// </param>
        /// <param name="response">
        /// Configuration for the response.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeResponseCreate(
            string? eventId,
            global::tryAGI.OpenAI.RealtimeResponseCreateType? type,
            global::tryAGI.OpenAI.RealtimeResponseCreateResponse? response)
        {
            this.EventId = eventId;
            this.Type = type;
            this.Response = response;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeResponseCreate" /> class.
        /// </summary>
        public RealtimeResponseCreate()
        {
        }
    }
}