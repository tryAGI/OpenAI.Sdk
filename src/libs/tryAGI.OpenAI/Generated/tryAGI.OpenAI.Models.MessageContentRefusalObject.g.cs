
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The refusal content generated by the assistant.
    /// </summary>
    public sealed partial class MessageContentRefusalObject
    {
        /// <summary>
        /// Always `refusal`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.MessageContentRefusalObjectTypeJsonConverter))]
        public global::tryAGI.OpenAI.MessageContentRefusalObjectType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("refusal")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Refusal { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageContentRefusalObject" /> class.
        /// </summary>
        /// <param name="type">
        /// Always `refusal`.
        /// </param>
        /// <param name="refusal"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessageContentRefusalObject(
            string refusal,
            global::tryAGI.OpenAI.MessageContentRefusalObjectType type)
        {
            this.Refusal = refusal ?? throw new global::System.ArgumentNullException(nameof(refusal));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageContentRefusalObject" /> class.
        /// </summary>
        public MessageContentRefusalObject()
        {
        }
    }
}