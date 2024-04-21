namespace AI.Chatbot.API.models
{
    public interface IAssistant
    {
        public Task<IConversation> StartConversationAsync();
    }
}