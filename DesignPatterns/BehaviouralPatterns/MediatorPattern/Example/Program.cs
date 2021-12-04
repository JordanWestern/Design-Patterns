using MediatorPattern;

IChatRoom chatRoom = new ChatRoom();

IUser userOne = new User(chatRoom) { Name = "David" };
IUser userTwo = new User(chatRoom) { Name = "Paul" };

chatRoom.Subscribe(userOne);
chatRoom.Subscribe(userTwo);

Console.WriteLine("Enter your name: ");
var name = Console.ReadLine();

IUser userThree = new User(chatRoom) { Name = name };
chatRoom.Subscribe(userThree);

while (true)
{
    Console.WriteLine("Write message: ");
    chatRoom.Notify(userThree, Console.ReadLine()); 
}