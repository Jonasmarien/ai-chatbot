using AI.Chatbot.API.models;
using Azure.AI.OpenAI.Assistants;

namespace AI.Chatbot.API.services
{
    public class AssistantAdapter(Assistant assistant) : IAssistant
    {
        private readonly Assistant _assistant = assistant ?? throw new ArgumentNullException(nameof(assistant));

        public Task<IConversation> StartConversationAsync()
        {
            throw new NotImplementedException();
        }
    }
}