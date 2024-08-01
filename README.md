# OpenAI

[![Nuget package](https://img.shields.io/nuget/vpre/tryAGI.OpenAI)](https://www.nuget.org/packages/tryAGI.OpenAI/)
[![dotnet](https://github.com/tryAGI/OpenAI/actions/workflows/dotnet.yml/badge.svg?branch=main)](https://github.com/tryAGI/OpenAI/actions/workflows/dotnet.yml)
[![License: MIT](https://img.shields.io/github/license/tryAGI/OpenAI)](https://github.com/tryAGI/OpenAI/blob/main/LICENSE.txt)
[![Discord](https://img.shields.io/discord/1115206893015662663?label=Discord&logo=discord&logoColor=white&color=d82679)](https://discord.gg/Ca2xhfBf3v)

## Features 🔥
- Fully generated C# SDK based on [official OpenAI OpenAPI specification](https://raw.githubusercontent.com/openai/openai-openapi/master/openapi.yaml) using [OpenApiGenerator](https://github.com/HavenDV/OpenApiGenerator)
- Same day update to support new features
- Updated and supported automatically if there are no breaking changes
- Contains a supported list of constants such as current prices, models, and other
- Source generator to define functions natively through C# interfaces

### Usage
```csharp
using OpenAI;

public enum Unit
{
    Celsius,
    Fahrenheit,
}

public class Weather
{
    public string Location { get; set; } = string.Empty;
    public double Temperature { get; set; }
    public Unit Unit { get; set; }
    public string Description { get; set; } = string.Empty;
}

[OpenAiFunctions]
public interface IWeatherFunctions
{
    [Description("Get the current weather in a given location")]
    public Task<Weather> GetCurrentWeatherAsync(
        [Description("The city and state, e.g. San Francisco, CA")] string location,
        Unit unit = Unit.Celsius,
        CancellationToken cancellationToken = default);
}

public class WeatherService : IWeatherFunctions
{
    public Task<Weather> GetCurrentWeatherAsync(string location, Unit unit = Unit.Celsius, CancellationToken cancellationToken = default)
    {
        return Task.FromResult(new Weather
        {
            Location = location,
            Temperature = 22.0,
            Unit = unit,
            Description = "Sunny",
        });
    }
}

using var api = new OpenAiApi();
api.AuthorizeUsingBearer(apiKey);

var service = new WeatherService();
var tools = service.AsTools();

var messages = new List<ChatCompletionRequestMessage>
{
    "You are a helpful weather assistant.".AsSystemMessage(),
    "What is the current temperature in Dubai, UAE in Celsius?".AsUserMessage(),
};
var model = CreateChatCompletionRequestModel.Gpt35Turbo;
var result = await api.Chat.CreateChatCompletionAsync(
    messages,
    model: model,
    tools: tools);
var resultMessage = result.Choices.First().Message;
messages.Add(resultMessage.AsRequestMessage());

foreach (var call in resultMessage.ToolCalls)
{
    var json = await service.CallAsync(
        functionName: call.Function.Name,
        argumentsAsJson: call.Function.Arguments);
    messages.Add(json.AsToolMessage(call.Id));
}

var result = await api.Chat.CreateChatCompletionAsync(
    messages,
    model: model,
    tools: tools);
var resultMessage = result.Choices.First().Message;
messages.Add(resultMessage.AsRequestMessage());
```
```
> System: 
You are a helpful weather assistant.
> User: 
What is the current temperature in Dubai, UAE in Celsius?
> Assistant: 
call_3sptsiHzKnaxF8bs8BWxPo0B:
GetCurrentWeather({"location":"Dubai, UAE","unit":"celsius"})
> Tool(call_3sptsiHzKnaxF8bs8BWxPo0B):
{"location":"Dubai, UAE","temperature":22,"unit":"celsius","description":"Sunny"}
> Assistant: 
The current temperature in Dubai, UAE is 22°C with sunny weather.
```

### Constants
All `tryGetXXX` methods return `null` if the value is not found.  
There also non-try methods that throw an exception if the value is not found.
```cs
using OpenAI;

// Chat
var model = CreateChatCompletionRequestModel.Gpt4oMini;
double? priceInUsd = model.TryGetPriceInUsd(
    inputTokens: 500,
    outputTokens: 500)
double? priceInUsd = model.TryGetFineTunePriceInUsd(
    trainingTokens: 500,
    inputTokens: 500,
    outputTokens: 500)
int contextLength = model.TryGetContextLength() // 128_000
int outputLength = model.TryGetOutputLength() // 16_000

// Embeddings
var model = CreateEmbeddingRequestModel.TextEmbedding3Small;
int? maxInputTokens = model.TryGetMaxInputTokens() // 8191
double? priceInUsd = model.TryGetPriceInUsd(tokens: 500)

// Images
double? priceInUsd = CreateImageRequestModel.DallE3.TryGetPriceInUsd(
    size: CreateImageRequestSize.x1024x1024,
    quality: CreateImageRequestQuality.Hd)

// Speech to Text
double? priceInUsd = CreateTranscriptionRequestModel.Whisper1.TryGetPriceInUsd(
    seconds: 60)

// Text to Speech
double? priceInUsd = CreateSpeechRequestModel.Tts1Hd.TryGetPriceInUsd(
    characters: 1000)
```

## Support

Priority place for bugs: https://github.com/tryAGI/OpenAI/issues  
Priority place for ideas and general questions: https://github.com/tryAGI/OpenAI/discussions  
Discord: https://discord.gg/Ca2xhfBf3v  