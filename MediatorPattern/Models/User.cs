
using MediatorPattern.Interfaces;

namespace MediatorPattern.Models
{
    public class User : IUser
    {
        public string Name { get; private set; }
        private IChat? chat;

        public User(string name)
        {
            Name = name;
        }

        public void SetChat(IChat chat)
        {
            this.chat = chat;
        }

        public void Send(string message)
        {
            Console.WriteLine($"{Name} ENVIANDO: {message}");
            chat?.SendMessage(message, this);
        }

        public void Receive(string message, IUser sender)
        {
            Console.WriteLine($"{Name} RECIBIENDO de {sender.Name}: {message}");
        }
    }
}