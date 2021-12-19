namespace MediatorPattern;

public class User : BaseUser
{
    public User(string name, IChatRoom chatRoom) : base(name, chatRoom)
    {
    }
}