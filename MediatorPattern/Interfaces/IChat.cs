
namespace MediatorPattern.Interfaces
{
    public interface IChat
    {
        void LogInChat(IUser user);
        void SendMessage(string message, IUser sender);
    }
}