namespace MediatorPattern;

public abstract class BaseUser : IUser
{
    private readonly IChatRoom chatRoom;

    public BaseUser(IChatRoom chatRoom)
    {
        this.chatRoom = chatRoom;
    }

    public string Name { get; set; }

    public void RecieveMessage(string message)
    {
        Console.WriteLine(message);
    }

    public void SendMessage(string message)
    {
        this.chatRoom.Notify(this, message);
    }
}