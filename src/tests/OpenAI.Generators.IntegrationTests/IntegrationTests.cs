﻿using tryAGI.OpenAI;

namespace H.Ipc.Generator.IntegrationTests;

[TestClass]
public class Tests
{
    [TestMethod]
    [Ignore]
    public async Task SimpleMethod()
    {
        var messages = new List<ChatCompletionRequestMessage>
        {
            "You are a helpful weather assistant.".AsSystemMessage(),
            "What's the weather like today?".AsUserMessage(),
        };
        
        try
        {
            var apiKey =
                Environment.GetEnvironmentVariable("OPENAI_API_KEY") ??
                throw new AssertInconclusiveException("OPENAI_API_KEY is not set.");
            using var httpClient = new HttpClient();
            var api = new OpenAiApi(apiKey, httpClient);
            var service = new WeatherService();
            var functions = service.AsFunctions();
            var result = await api.CreateChatCompletionAsync(new CreateChatCompletionRequest
            {
                Messages = messages,
                Functions = functions,
                Function_call = Function_call4.Auto,
                Model = ModelIds.Gpt35Turbo_0613,
            });
            var resultMessage = result.GetFirstChoiceMessage();
            messages.Add(resultMessage.AsRequestMessage());
            
            messages.Add("Dubai, UAE".AsUserMessage());
            result = await api.CreateChatCompletionAsync(new CreateChatCompletionRequest
            {
                Messages = messages,
                Functions = functions,
                Function_call = Function_call4.Auto,
                Model = ModelIds.Gpt35Turbo_0613,
            });
            resultMessage = result.GetFirstChoiceMessage();
            messages.Add(resultMessage.AsRequestMessage());

            // It's possible that the assistant will also ask you which units you want the temperature in.
            if (!string.IsNullOrWhiteSpace(resultMessage.Content))
            {
                messages.Add("celsius".AsUserMessage());
                result = await api.CreateChatCompletionAsync(new CreateChatCompletionRequest
                {
                    Messages = messages,
                    Functions = functions,
                    Function_call = Function_call4.Auto,
                    Model = ModelIds.Gpt35Turbo_0613,
                });
                resultMessage = result.GetFirstChoiceMessage();
                messages.Add(resultMessage.AsRequestMessage());
            }

            if (resultMessage.Function_call == null)
            {
                throw new InvalidOperationException("Expected a function call.");
            }
            
            var json = await service.CallAsync(
                functionName: resultMessage.Function_call.Name ?? string.Empty,
                argumentsAsJson: resultMessage.Function_call.Arguments ?? string.Empty);
            messages.Add(json.AsFunctionMessage(resultMessage.Function_call?.Name ?? string.Empty));
            
            result = await api.CreateChatCompletionAsync(new CreateChatCompletionRequest
            {
                Messages = messages,
                Functions = functions,
                Function_call = Function_call4.Auto,
                Model = ModelIds.Gpt35Turbo_0613,
            });
            resultMessage = result.GetFirstChoiceMessage();
            messages.Add(resultMessage.AsRequestMessage());
        }
        finally
        {
            PrintMessages(messages);
        }
    }

    private static void PrintMessages(List<ChatCompletionRequestMessage> messages)
    {
        foreach (var message in messages)
        {
            if (message.Function_call != null)
            {
                Console.WriteLine($"{message.Role}(FunctionCall): {message.Function_call.Name}");
                Console.WriteLine($"{message.Function_call.Arguments}");
                continue;
            }
            
            Console.WriteLine($"{message.Role}: {message.Content}");
        }
    }
    
    [TestMethod]
    public async Task Call()
    {
        var json = /* lang=json */ """
                   {
                       "location": "Dubai, UAE"
                   }
                   """;
        var result = new WeatherService().CallGetCurrentWeather(json);

        result.Should().Be(/* lang=json */ """
            {"location":"Dubai, UAE","temperature":22,"unit":"celsius","description":"Sunny"}
            """);

        var result2 = await new WeatherService().CallAsync("GetCurrentWeather", json);
        result2.Should().Be(/* lang=json */ """
            {"location":"Dubai, UAE","temperature":22,"unit":"celsius","description":"Sunny"}
            """);
    }
    
    [TestMethod]
    [Ignore]
    public async Task UpdateCode()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("OPENAI_API_KEY") ??
            throw new AssertInconclusiveException("OPENAI_API_KEY is not set.");
        using var httpClient = new HttpClient();
        var api = new OpenAiApi(apiKey, httpClient);
        var service = new UpdateCodeService();
        var messages = new List<ChatCompletionRequestMessage>
        {
            "You are a Senior C# programmer.".AsSystemMessage(),
            /* lang=markdown */"""
You solve the issue with this description:
```
Hey there. My boss asked me to refactor our legacy project. Can you do that for me? They asked me to use SOLID principles, KISS, YAGNI and DRY as well as clean code
The IUserCreditService and IUserCreditServiceChannel interfaces and the UserCreditServiceClient class are generated code so please don't change them.
Keep in mind that anything withing LegacyApp.Consumer is someone else's code and MUST NOT be changed.
Please don't introduce any breaking changes in the UserService class and its AddUser method.
```
I need new steps to prevent these errors:
```
Non-nullable property 'Firstname' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
```
```
Non-nullable property 'Surname' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
```
```
Non-nullable property 'EmailAddress' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
```
```
Non-nullable property 'Client' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
```
```
Possible null reference assignment.
```
Here is the code:

LegacyApp/User.cs
```csharp
using System;

namespace LegacyApp
{
    public class User
    {
        public int Id { get; set; }

        public string Firstname { get; set; }

        public string Surname { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string EmailAddress { get; set; }

        public bool HasCreditLimit { get; set; }

        public int CreditLimit { get; set; }

        public Client Client { get; set; }
    }
}
```

LegacyApp/UserService.cs
```csharp
using System;

#nullable enable
namespace LegacyApp
{
    public class UserService
    {
        public bool AddUser(string? firname, string? surname, string? email, DateTime dateOfBirth, int clientId)
        {
            if (string.IsNullOrEmpty(firname) || string.IsNullOrEmpty(surname))
            {
                return false;
            }

            if (email == null || (!email.Contains(""@"") && !email.Contains(""."")))
            {
                return false;
            }

            var now = DateTime.Now;
            int age = now.Year - dateOfBirth.Year;
            if (now.Month < dateOfBirth.Month || (now.Month == dateOfBirth.Month && now.Day < dateOfBirth.Day)) age--;

            if (age < 21)
            {
                return false;
            }

            var clientRepository = new ClientRepository();
            var client = clientRepository.GetById(clientId);

            var user = new User
            {
                Client = client,
                DateOfBirth = dateOfBirth,
                EmailAddress = email,
                Firstname = firname,
                Surname = surname
            };

            if (client?.Name == ""VeryImportantClient"")
            {
                // Skip credit check
                user.HasCreditLimit = false;
            }
            else if (client?.Name == ""ImportantClient"")
            {
                // Do credit check and double credit limit
                user.HasCreditLimit = true;
                using (var userCreditService = new UserCreditServiceClient())
                {
                    var creditLimit = userCreditService.GetCreditLimit(user.Firstname, user.Surname, user.DateOfBirth);
                    creditLimit = creditLimit * 2;
                    user.CreditLimit = creditLimit;
                }
            }
            else
            {
                // Do credit check
                user.HasCreditLimit = true;
                using (var userCreditService = new UserCreditServiceClient())
                {
                    var creditLimit = userCreditService.GetCreditLimit(user.Firstname, user.Surname, user.DateOfBirth);
                    user.CreditLimit = creditLimit;
                }
            }

            if (user.HasCreditLimit && user.CreditLimit < 500)
            {
                return false;
            }

            UserDataAccess.AddUser(user);

            return true;
        }
    }
}
```
""".AsUserMessage(),
        };
        var result = await api.CreateChatCompletionAsync(new CreateChatCompletionRequest
        {
            Messages = messages,
            Functions = service.AsFunctions(),
            Function_call = Function_call4.Auto,
            Model = ModelIds.Gpt35Turbo_0613,
        });
        var json = result.GetFirstChoiceMessage().Function_call?.Arguments ?? string.Empty;
        Console.WriteLine(json);
        
        var args = service.AsUpdateCodeArgs(json);
        args.Changes.Should().NotBeEmpty();
    }
}