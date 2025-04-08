namespace BlazoroOgDependencyInjection.Services
{
    public interface IMessageService
    {
        string GetWelcomeMessage(string userName);
    }

    public class MessageService : IMessageService
    {
        public string GetWelcomeMessage(string userName)
        {
            return $"Velkommen til vores Blazor app, {userName}!";
        }
    }
}
