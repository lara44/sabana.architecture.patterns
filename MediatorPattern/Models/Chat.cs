
using MediatorPattern.Interfaces;

namespace MediatorPattern.Models
{
    public class Chat : IChat
    {
        private readonly List<IUser> users = new List<IUser>();
        public void LogInChat(IUser user)
        {
            users.Add(user);
            user.SetChat(this);
        }

        public void SendMessage(string message, IUser sender)
        {
            foreach (var user in users)
            {
                if (user != sender)
                {
                    user.Receive(message, sender);
                }
            }
        }
    }
}