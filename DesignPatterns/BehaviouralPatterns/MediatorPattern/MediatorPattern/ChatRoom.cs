namespace MediatorPattern
{
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
}