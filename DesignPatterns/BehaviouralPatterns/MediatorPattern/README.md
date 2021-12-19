# Mediator Pattern

## Purpose

The mediator pattern is a behavioural pattern that aims to simplify communication with many objects that need to communicate with one another.

In this example, we have a chat room; this is our mediator. The chat rooms' job is to handle communication with any ```IUser``` object which is subscribed to the chat room iteself.

This means that any communication is handled soley by our mediator, and not directly between objects, reducing spaghetti code and confusing references between multiple objects that need to talk to one another.

```c#
public interface IChatRoom
{
    void Notify(IUser subscriber, string message);

    void Subscribe(IUser subscriber);
}
```

The concrete implementation of our chat room is as follows -

```c#
public class ChatRoom : IChatRoom
    {
        private readonly IList<IUser> users;

        public ChatRoom()
        {
            users = new List<IUser>();
        }

        public void Subscribe(IUser user) 
        { 
            this.users.Add(user);
            Console.WriteLine($"{user.Name} joined the chat room");
        }

        public void Notify(IUser notifyingUser, string message)
        {
            var toNotify = users.Where(x => x.Name != notifyingUser.Name);

            foreach (var user in toNotify)
            {
                user.RecieveMessage($"{user.Name} recieved message from {notifyingUser.Name}: {message}");
            }
        }
    }
```

Any ```IUser``` implementation can subscribe to the chat room so that they can be notified by the mediator, ```ChatRoom``` when the ```Notify()``` method is called.

```c#
public abstract class BaseUser : IUser
{
    private readonly IChatRoom chatRoom;

    public BaseUser(string Name, IChatRoom chatRoom)
    {
        this.Name = Name;
        this.chatRoom = chatRoom;
    }

    public string Name { get; private set; }

    public void RecieveMessage(string message)
    {
        Console.WriteLine(message);
    }

    public void SendMessage(string message)
    {
        this.chatRoom.Notify(this, message);
    }
}
```

The users have no awareness of who is subscribed to the chat room, and the chat room is responsible for the communication between all the users. This means that only one common class handles actions between all subscribed objects, and no direct communication between objects is required.