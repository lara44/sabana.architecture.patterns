
namespace MediatorPattern.Interfaces
{
    public interface IUser
    {
        string Name { get; }
        void SetChat(IChat chat);
        void Send(string message);
        void Receive(string message, IUser sender);
    }
}