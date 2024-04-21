using AI.Chatbot.API.models;
using AI.Chatbot.API.services;
using Azure.AI.OpenAI.Assistants;
using Microsoft.Extensions.Options;

public interface IAssistantFactory {
    IAssistant Create();
}

public class AssistantFactory : IAssistantFactory
{
    private readonly AzureOpenAIConfiguration _config;
    private readonly AssistantsClient _client;

    public AssistantFactory(IOptions<AzureOpenAIConfiguration> options)
    {
        _config = options?.Value ?? throw new ArgumentNullException(nameof(options));
        _client = new AssistantsClient(
            endpoint: new Uri(_config.ResourceUrl),
            keyCredential: new Azure.AzureKeyCredential(_config.ApiKey)
        );
    }

    public IAssistant Create()
    {
        var response = _client.CreateAssistant(
            new AssistantCreationOptions(_config.LanguageModel) {
                Name = _config.Name,
                Instructions = _config.Instructions,
                Tools = { new CodeInterpreterToolDefinition() }
            }
        );

        return new AssistantAdapter(response.Value);
    }
}