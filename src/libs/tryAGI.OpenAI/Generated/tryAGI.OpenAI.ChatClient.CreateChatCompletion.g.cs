
#nullable enable

namespace tryAGI.OpenAI
{
    public partial class ChatClient
    {
        partial void PrepareCreateChatCompletionArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::tryAGI.OpenAI.CreateChatCompletionRequest request);
        partial void PrepareCreateChatCompletionRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::tryAGI.OpenAI.CreateChatCompletionRequest request);
        partial void ProcessCreateChatCompletionResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateChatCompletionResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Creates a model response for the given chat conversation. Learn more in the<br/>
        /// [text generation](/docs/guides/text-generation), [vision](/docs/guides/vision),<br/>
        /// and [audio](/docs/guides/audio) guides.<br/>
        /// Parameter support can differ depending on the model used to generate the<br/>
        /// response, particularly for newer reasoning models. Parameters that are only<br/>
        /// supported for reasoning models are noted below. For the current state of <br/>
        /// unsupported parameters in reasoning models, <br/>
        /// [refer to the reasoning guide](/docs/guides/reasoning).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.CreateChatCompletionResponse> CreateChatCompletionAsync(
            global::tryAGI.OpenAI.CreateChatCompletionRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateChatCompletionArguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: "/chat/completions",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in Authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }
            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareCreateChatCompletionRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCreateChatCompletionResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessCreateChatCompletionResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();
                }
                catch (global::System.Net.Http.HttpRequestException __ex)
                {
                    throw new global::tryAGI.OpenAI.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }

                return
                    global::tryAGI.OpenAI.CreateChatCompletionResponse.FromJson(__content, JsonSerializerContext) ??
                    throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();
                }
                catch (global::System.Net.Http.HttpRequestException __ex)
                {
                    throw new global::tryAGI.OpenAI.ApiException(
                        message: __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }

                using var __content = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);

                return
                    await global::tryAGI.OpenAI.CreateChatCompletionResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                    throw new global::System.InvalidOperationException("Response deserialization failed.");
            }
        }

        /// <summary>
        /// Creates a model response for the given chat conversation. Learn more in the<br/>
        /// [text generation](/docs/guides/text-generation), [vision](/docs/guides/vision),<br/>
        /// and [audio](/docs/guides/audio) guides.<br/>
        /// Parameter support can differ depending on the model used to generate the<br/>
        /// response, particularly for newer reasoning models. Parameters that are only<br/>
        /// supported for reasoning models are noted below. For the current state of <br/>
        /// unsupported parameters in reasoning models, <br/>
        /// [refer to the reasoning guide](/docs/guides/reasoning).
        /// </summary>
        /// <param name="messages">
        /// A list of messages comprising the conversation so far. Depending on the<br/>
        /// [model](/docs/models) you use, different message types (modalities) are<br/>
        /// supported, like [text](/docs/guides/text-generation),<br/>
        /// [images](/docs/guides/vision), and [audio](/docs/guides/audio).
        /// </param>
        /// <param name="model">
        /// ID of the model to use. See the [model endpoint compatibility](/docs/models#model-endpoint-compatibility) table for details on which models work with the Chat API.<br/>
        /// Example: gpt-4o
        /// </param>
        /// <param name="store">
        /// Whether or not to store the output of this chat completion request for <br/>
        /// use in our [model distillation](/docs/guides/distillation) or<br/>
        /// [evals](/docs/guides/evals) products.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="reasoningEffort">
        /// **o1 models only** <br/>
        /// Constrains effort on reasoning for <br/>
        /// [reasoning models](https://platform.openai.com/docs/guides/reasoning).<br/>
        /// Currently supported values are `low`, `medium`, and `high`. Reducing<br/>
        /// reasoning effort can result in faster responses and fewer tokens used<br/>
        /// on reasoning in a response.<br/>
        /// Default Value: medium
        /// </param>
        /// <param name="metadata">
        /// Developer-defined tags and values used for filtering completions<br/>
        /// in the [dashboard](https://platform.openai.com/chat-completions).
        /// </param>
        /// <param name="frequencyPenalty">
        /// Number between -2.0 and 2.0. Positive values penalize new tokens based on<br/>
        /// their existing frequency in the text so far, decreasing the model's<br/>
        /// likelihood to repeat the same line verbatim.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="logitBias">
        /// Modify the likelihood of specified tokens appearing in the completion.<br/>
        /// Accepts a JSON object that maps tokens (specified by their token ID in the<br/>
        /// tokenizer) to an associated bias value from -100 to 100. Mathematically,<br/>
        /// the bias is added to the logits generated by the model prior to sampling.<br/>
        /// The exact effect will vary per model, but values between -1 and 1 should<br/>
        /// decrease or increase likelihood of selection; values like -100 or 100<br/>
        /// should result in a ban or exclusive selection of the relevant token.
        /// </param>
        /// <param name="logprobs">
        /// Whether to return log probabilities of the output tokens or not. If true,<br/>
        /// returns the log probabilities of each output token returned in the<br/>
        /// `content` of `message`.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="topLogprobs">
        /// An integer between 0 and 20 specifying the number of most likely tokens to<br/>
        /// return at each token position, each with an associated log probability.<br/>
        /// `logprobs` must be set to `true` if this parameter is used.
        /// </param>
        /// <param name="maxCompletionTokens">
        /// An upper bound for the number of tokens that can be generated for a completion, including visible output tokens and [reasoning tokens](/docs/guides/reasoning).
        /// </param>
        /// <param name="n">
        /// How many chat completion choices to generate for each input message. Note that you will be charged based on the number of generated tokens across all of the choices. Keep `n` as `1` to minimize costs.<br/>
        /// Default Value: 1<br/>
        /// Example: 1
        /// </param>
        /// <param name="modalities">
        /// Output types that you would like the model to generate for this request.<br/>
        /// Most models are capable of generating text, which is the default:<br/>
        /// `["text"]`<br/>
        /// The `gpt-4o-audio-preview` model can also be used to [generate audio](/docs/guides/audio). To<br/>
        /// request that this model generate both text and audio responses, you can<br/>
        /// use:<br/>
        /// `["text", "audio"]`
        /// </param>
        /// <param name="prediction">
        /// Configuration for a [Predicted Output](/docs/guides/predicted-outputs),<br/>
        /// which can greatly improve response times when large parts of the model<br/>
        /// response are known ahead of time. This is most common when you are<br/>
        /// regenerating a file with only minor changes to most of the content.
        /// </param>
        /// <param name="audio">
        /// Parameters for audio output. Required when audio output is requested with<br/>
        /// `modalities: ["audio"]`. [Learn more](/docs/guides/audio).
        /// </param>
        /// <param name="presencePenalty">
        /// Number between -2.0 and 2.0. Positive values penalize new tokens based on<br/>
        /// whether they appear in the text so far, increasing the model's likelihood<br/>
        /// to talk about new topics.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="responseFormat">
        /// An object specifying the format that the model must output.<br/>
        /// Setting to `{ "type": "json_schema", "json_schema": {...} }` enables<br/>
        /// Structured Outputs which ensures the model will match your supplied JSON<br/>
        /// schema. Learn more in the [Structured Outputs<br/>
        /// guide](/docs/guides/structured-outputs).<br/>
        /// Setting to `{ "type": "json_object" }` enables JSON mode, which ensures<br/>
        /// the message the model generates is valid JSON.<br/>
        /// **Important:** when using JSON mode, you **must** also instruct the model<br/>
        /// to produce JSON yourself via a system or user message. Without this, the<br/>
        /// model may generate an unending stream of whitespace until the generation<br/>
        /// reaches the token limit, resulting in a long-running and seemingly "stuck"<br/>
        /// request. Also note that the message content may be partially cut off if<br/>
        /// `finish_reason="length"`, which indicates the generation exceeded<br/>
        /// `max_tokens` or the conversation exceeded the max context length.
        /// </param>
        /// <param name="seed">
        /// This feature is in Beta.<br/>
        /// If specified, our system will make a best effort to sample deterministically, such that repeated requests with the same `seed` and parameters should return the same result.<br/>
        /// Determinism is not guaranteed, and you should refer to the `system_fingerprint` response parameter to monitor changes in the backend.
        /// </param>
        /// <param name="serviceTier">
        /// Specifies the latency tier to use for processing the request. This parameter is relevant for customers subscribed to the scale tier service:<br/>
        ///   - If set to 'auto', and the Project is Scale tier enabled, the system will utilize scale tier credits until they are exhausted.<br/>
        ///   - If set to 'auto', and the Project is not Scale tier enabled, the request will be processed using the default service tier with a lower uptime SLA and no latency guarentee.<br/>
        ///   - If set to 'default', the request will be processed using the default service tier with a lower uptime SLA and no latency guarentee.<br/>
        ///   - When not set, the default behavior is 'auto'.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="stop">
        /// Up to 4 sequences where the API will stop generating further tokens.
        /// </param>
        /// <param name="stream">
        /// If set, partial message deltas will be sent, like in ChatGPT. Tokens will be sent as data-only [server-sent events](https://developer.mozilla.org/en-US/docs/Web/API/Server-sent_events/Using_server-sent_events#Event_stream_format) as they become available, with the stream terminated by a `data: [DONE]` message. [Example Python code](https://cookbook.openai.com/examples/how_to_stream_completions).<br/>
        /// Default Value: false
        /// </param>
        /// <param name="streamOptions">
        /// Options for streaming response. Only set this when you set `stream: true`.
        /// </param>
        /// <param name="temperature">
        /// What sampling temperature to use, between 0 and 2. Higher values like 0.8 will make the output more random, while lower values like 0.2 will make it more focused and deterministic.<br/>
        /// We generally recommend altering this or `top_p` but not both.<br/>
        /// Default Value: 1<br/>
        /// Example: 1
        /// </param>
        /// <param name="topP">
        /// An alternative to sampling with temperature, called nucleus sampling,<br/>
        /// where the model considers the results of the tokens with top_p probability<br/>
        /// mass. So 0.1 means only the tokens comprising the top 10% probability mass<br/>
        /// are considered.<br/>
        /// We generally recommend altering this or `temperature` but not both.<br/>
        /// Default Value: 1<br/>
        /// Example: 1
        /// </param>
        /// <param name="tools">
        /// A list of tools the model may call. Currently, only functions are supported as a tool. Use this to provide a list of functions the model may generate JSON inputs for. A max of 128 functions are supported.
        /// </param>
        /// <param name="toolChoice">
        /// Controls which (if any) tool is called by the model.<br/>
        /// `none` means the model will not call any tool and instead generates a message.<br/>
        /// `auto` means the model can pick between generating a message or calling one or more tools.<br/>
        /// `required` means the model must call one or more tools.<br/>
        /// Specifying a particular tool via `{"type": "function", "function": {"name": "my_function"}}` forces the model to call that tool.<br/>
        /// `none` is the default when no tools are present. `auto` is the default if tools are present.
        /// </param>
        /// <param name="parallelToolCalls">
        /// Whether to enable [parallel function calling](/docs/guides/function-calling#configuring-parallel-function-calling) during tool use.
        /// </param>
        /// <param name="user">
        /// A unique identifier representing your end-user, which can help OpenAI to monitor and detect abuse. [Learn more](/docs/guides/safety-best-practices#end-user-ids).<br/>
        /// Example: user-1234
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.CreateChatCompletionResponse> CreateChatCompletionAsync(
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionRequestMessage> messages,
            global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateChatCompletionRequestModel?> model,
            bool? store = default,
            global::tryAGI.OpenAI.CreateChatCompletionRequestReasoningEffort? reasoningEffort = default,
            global::System.Collections.Generic.Dictionary<string, string>? metadata = default,
            double? frequencyPenalty = default,
            global::System.Collections.Generic.Dictionary<string, int>? logitBias = default,
            bool? logprobs = default,
            int? topLogprobs = default,
            int? maxCompletionTokens = default,
            int? n = default,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionModalitie>? modalities = default,
            global::tryAGI.OpenAI.PredictionContent? prediction = default,
            global::tryAGI.OpenAI.CreateChatCompletionRequestAudio? audio = default,
            double? presencePenalty = default,
            global::tryAGI.OpenAI.ResponseFormat3? responseFormat = default,
            long? seed = default,
            global::tryAGI.OpenAI.CreateChatCompletionRequestServiceTier? serviceTier = default,
            global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<string>>? stop = default,
            bool? stream = default,
            global::tryAGI.OpenAI.ChatCompletionStreamOptions? streamOptions = default,
            double? temperature = default,
            double? topP = default,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionTool>? tools = default,
            global::tryAGI.OpenAI.ChatCompletionToolChoiceOption? toolChoice = default,
            bool? parallelToolCalls = default,
            string? user = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::tryAGI.OpenAI.CreateChatCompletionRequest
            {
                Messages = messages,
                Model = model,
                Store = store,
                ReasoningEffort = reasoningEffort,
                Metadata = metadata,
                FrequencyPenalty = frequencyPenalty,
                LogitBias = logitBias,
                Logprobs = logprobs,
                TopLogprobs = topLogprobs,
                MaxCompletionTokens = maxCompletionTokens,
                N = n,
                Modalities = modalities,
                Prediction = prediction,
                Audio = audio,
                PresencePenalty = presencePenalty,
                ResponseFormat = responseFormat,
                Seed = seed,
                ServiceTier = serviceTier,
                Stop = stop,
                Stream = stream,
                StreamOptions = streamOptions,
                Temperature = temperature,
                TopP = topP,
                Tools = tools,
                ToolChoice = toolChoice,
                ParallelToolCalls = parallelToolCalls,
                User = user,
            };

            return await CreateChatCompletionAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}