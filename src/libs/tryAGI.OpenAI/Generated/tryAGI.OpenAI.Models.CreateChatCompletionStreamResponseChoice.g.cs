
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateChatCompletionStreamResponseChoice
    {
        /// <summary>
        /// A chat completion delta generated by streamed model responses.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delta")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.ChatCompletionStreamResponseDelta Delta { get; set; }

        /// <summary>
        /// Log probability information for the choice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logprobs")]
        public global::tryAGI.OpenAI.CreateChatCompletionStreamResponseChoiceLogprobs? Logprobs { get; set; }

        /// <summary>
        /// The reason the model stopped generating tokens. This will be `stop` if the model hit a natural stop point or a provided stop sequence,<br/>
        /// `length` if the maximum number of tokens specified in the request was reached,<br/>
        /// `content_filter` if content was omitted due to a flag from our content filters,<br/>
        /// `tool_calls` if the model called a tool, or `function_call` (deprecated) if the model called a function.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finish_reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.CreateChatCompletionStreamResponseChoiceFinishReasonJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.CreateChatCompletionStreamResponseChoiceFinishReason? FinishReason { get; set; }

        /// <summary>
        /// The index of the choice in the list of choices.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Index { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChatCompletionStreamResponseChoice" /> class.
        /// </summary>
        /// <param name="delta">
        /// A chat completion delta generated by streamed model responses.
        /// </param>
        /// <param name="logprobs">
        /// Log probability information for the choice.
        /// </param>
        /// <param name="finishReason">
        /// The reason the model stopped generating tokens. This will be `stop` if the model hit a natural stop point or a provided stop sequence,<br/>
        /// `length` if the maximum number of tokens specified in the request was reached,<br/>
        /// `content_filter` if content was omitted due to a flag from our content filters,<br/>
        /// `tool_calls` if the model called a tool, or `function_call` (deprecated) if the model called a function.
        /// </param>
        /// <param name="index">
        /// The index of the choice in the list of choices.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateChatCompletionStreamResponseChoice(
            global::tryAGI.OpenAI.ChatCompletionStreamResponseDelta delta,
            global::tryAGI.OpenAI.CreateChatCompletionStreamResponseChoiceFinishReason? finishReason,
            int index,
            global::tryAGI.OpenAI.CreateChatCompletionStreamResponseChoiceLogprobs? logprobs)
        {
            this.Delta = delta ?? throw new global::System.ArgumentNullException(nameof(delta));
            this.FinishReason = finishReason;
            this.Index = index;
            this.Logprobs = logprobs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChatCompletionStreamResponseChoice" /> class.
        /// </summary>
        public CreateChatCompletionStreamResponseChoice()
        {
        }
    }
}