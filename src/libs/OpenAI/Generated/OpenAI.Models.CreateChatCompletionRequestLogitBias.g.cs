
#nullable enable

namespace OpenAI
{
    /// <summary>
    /// Modify the likelihood of specified tokens appearing in the completion.<br/>
    /// Accepts a JSON object that maps tokens (specified by their token ID in the<br/>
    /// tokenizer) to an associated bias value from -100 to 100. Mathematically,<br/>
    /// the bias is added to the logits generated by the model prior to sampling.<br/>
    /// The exact effect will vary per model, but values between -1 and 1 should<br/>
    /// decrease or increase likelihood of selection; values like -100 or 100<br/>
    /// should result in a ban or exclusive selection of the relevant token.
    /// </summary>
    public sealed partial class CreateChatCompletionRequestLogitBias
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}