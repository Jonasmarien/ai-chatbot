namespace AI.Chatbot.API.models
{
    public interface IConversation
    {
        public List<IMessage> Messages { get; set; }
    }
}