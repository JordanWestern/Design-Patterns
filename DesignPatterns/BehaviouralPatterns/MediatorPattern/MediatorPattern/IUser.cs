namespace MediatorPattern
{
    public interface IUser
    {
        public string Name { get; set; }

        void SendMessage(string message);

        void RecieveMessage(string message);
    }
}