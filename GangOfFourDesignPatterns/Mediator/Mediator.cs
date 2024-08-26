using System;

namespace GangOfFourDesignPatterns.Mediator
{
    public interface IChatMediator
    {
        void RegisterUser(User user);
        void SendMessage(string message, User user);
    }

    public abstract class User(string name)
    {
        protected string Name = name;
        public IChatMediator mediator { get; set;} = null!;
        public abstract void SendMessage(string message);
        public abstract void ReceiveMessage(string message);
    }

    public class ChatUser : User
    {
        public ChatUser(string name) : base(name)
        {
        }

        public override void SendMessage(string message)
        {
            Console.WriteLine(this.Name +" : Sent Message - "+ message);
            mediator.SendMessage(message, this);
        }

        public override void ReceiveMessage(string message)
        {
             Console.WriteLine(this.Name +" : Received Message - "+ message);
        }
    }

    public class ChatMediator : IChatMediator
    {
        private List<User> users= new List<User>();

        public void RegisterUser(User user)
        {
            users.Add(user);
            user.mediator = this;
        }

        public void SendMessage(string message, User user)
        {
          foreach(User u in users)
          {
            if(u == user) continue;
            u.ReceiveMessage(message);
          }
        }
    }
}
