namespace MediatorPattern;

public interface IChatRoom
{
    void Notify(IUser subscriber, string message);

    void Subscribe(IUser subscriber);
}