
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateTranslationResponseVerboseJson
    {
        /// <summary>
        /// The language of the output translation (always `english`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Language { get; set; }

        /// <summary>
        /// The duration of the input audio.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Duration { get; set; }

        /// <summary>
        /// The translated text.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Segments of the translated text and their corresponding details.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("segments")]
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.TranscriptionSegment>? Segments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTranslationResponseVerboseJson" /> class.
        /// </summary>
        /// <param name="language">
        /// The language of the output translation (always `english`).
        /// </param>
        /// <param name="duration">
        /// The duration of the input audio.
        /// </param>
        /// <param name="text">
        /// The translated text.
        /// </param>
        /// <param name="segments">
        /// Segments of the translated text and their corresponding details.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CreateTranslationResponseVerboseJson(
            string language,
            string duration,
            string text,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.TranscriptionSegment>? segments)
        {
            this.Language = language ?? throw new global::System.ArgumentNullException(nameof(language));
            this.Duration = duration ?? throw new global::System.ArgumentNullException(nameof(duration));
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Segments = segments;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTranslationResponseVerboseJson" /> class.
        /// </summary>
        public CreateTranslationResponseVerboseJson()
        {
        }
    }
}