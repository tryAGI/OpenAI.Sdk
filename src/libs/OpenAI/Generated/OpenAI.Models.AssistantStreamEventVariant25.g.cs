
#nullable enable

namespace OpenAI
{
    /// <summary>
    /// Occurs when a [message](/docs/api-reference/messages/object) ends before it is completed.
    /// </summary>
    public sealed partial class AssistantStreamEventVariant25
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenAI.JsonConverters.AssistantStreamEventVariant25EventJsonConverter))]
        public global::OpenAI.AssistantStreamEventVariant25Event Event { get; set; }

        /// <summary>
        /// Represents a message within a [thread](/docs/api-reference/threads).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenAI.MessageObject Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AssistantStreamEventVariant25" /> class.
        /// </summary>
        /// <param name="event"></param>
        /// <param name="data">
        /// Represents a message within a [thread](/docs/api-reference/threads).
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public AssistantStreamEventVariant25(
            global::OpenAI.MessageObject data,
            global::OpenAI.AssistantStreamEventVariant25Event @event)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Event = @event;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssistantStreamEventVariant25" /> class.
        /// </summary>
        public AssistantStreamEventVariant25()
        {
        }
    }
}