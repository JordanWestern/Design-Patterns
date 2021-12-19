namespace MediatorPattern
{
    public interface IUser
    {
        public string Name { get; }

        void SendMessage(string message);

        void RecieveMessage(string message);
    }
}