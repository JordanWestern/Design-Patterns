using MediatorPattern;

IChatRoom chatRoom = new ChatRoom();

IUser userOne = new User("David", chatRoom);
IUser userTwo = new User("Paul", chatRoom);

chatRoom.Subscribe(userOne);
chatRoom.Subscribe(userTwo);

Console.WriteLine("Enter your name: ");
var name = Console.ReadLine();

IUser userThree = new User(name!, chatRoom);

chatRoom.Subscribe(userThree);

while (true)
{
    Console.WriteLine("Write message: ");
    chatRoom.Notify(userThree, Console.ReadLine()!); 
}