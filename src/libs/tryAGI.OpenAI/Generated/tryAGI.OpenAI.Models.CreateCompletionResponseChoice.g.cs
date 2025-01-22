
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateCompletionResponseChoice
    {
        /// <summary>
        /// The reason the model stopped generating tokens. This will be `stop` if the model hit a natural stop point or a provided stop sequence,<br/>
        /// `length` if the maximum number of tokens specified in the request was reached,<br/>
        /// or `content_filter` if content was omitted due to a flag from our content filters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finish_reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.CreateCompletionResponseChoiceFinishReasonJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.CreateCompletionResponseChoiceFinishReason FinishReason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Index { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logprobs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.CreateCompletionResponseChoiceLogprobs? Logprobs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCompletionResponseChoice" /> class.
        /// </summary>
        /// <param name="finishReason">
        /// The reason the model stopped generating tokens. This will be `stop` if the model hit a natural stop point or a provided stop sequence,<br/>
        /// `length` if the maximum number of tokens specified in the request was reached,<br/>
        /// or `content_filter` if content was omitted due to a flag from our content filters.
        /// </param>
        /// <param name="index"></param>
        /// <param name="logprobs"></param>
        /// <param name="text"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CreateCompletionResponseChoice(
            global::tryAGI.OpenAI.CreateCompletionResponseChoiceFinishReason finishReason,
            int index,
            global::tryAGI.OpenAI.CreateCompletionResponseChoiceLogprobs? logprobs,
            string text)
        {
            this.FinishReason = finishReason;
            this.Index = index;
            this.Logprobs = logprobs ?? throw new global::System.ArgumentNullException(nameof(logprobs));
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCompletionResponseChoice" /> class.
        /// </summary>
        public CreateCompletionResponseChoice()
        {
        }
    }
}