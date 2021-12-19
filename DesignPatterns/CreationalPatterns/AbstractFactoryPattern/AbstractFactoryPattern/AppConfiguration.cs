using AbstractFactoryPattern.Mac;
using AbstractFactoryPattern.Windows;

namespace AbstractFactoryPattern;

public class AppConfiguration
{
    public IUserInterfaceFactory GetUIConfigurationFactory(UserInterface userInterface) 
    {
        return userInterface switch
        {
            UserInterface.Mac => new MacUserInterfaceFactory(),
            UserInterface.Windows => new WindowsUserInterfaceFactory(),
            _ => throw new NotImplementedException($"UI for {userInterface} not yet implemented"),
        };
    }
}