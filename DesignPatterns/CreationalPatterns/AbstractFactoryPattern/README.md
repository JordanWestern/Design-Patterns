# Abstract Factory Pattern

## Purpose

The abstract factory pattern's purpose is to hand back implementations of related objects without specifying their concrete class'.

In this example, we are dealing with UI elements.

We need different implementations of UI elements depending on which operating system we want to render them on (e.g. Mac, Windows) as they might need to be handled differently.

We have one interface, ```IUserInterfaceFactory```, from which our concrete inplementations will be subscribed.

```c#
public interface IUserInterfaceFactory
{
    public IButton CreateButton();

    public ITextBox CreateTextBox();

    public ICheckBox CreateCheckBox();

    public IRadioButton CreateRadioButton();
}
```

This means that extending or adding new implementations is easy, as any new class can contract to this interface, although if many implementations are required, you might end up with lots of class files in your project.

In the example, we have two implementations of this interface, one for Windows and one for Mac. here is how the Mac implementation looks -

```c#
public class MacUserInterfaceFactory : IUserInterfaceFactory
{
    public IButton CreateButton()
    {
        return new MacButton();
    }

    public ICheckBox CreateCheckBox()
    {
        return new MacCheckBox();
    }

    public IRadioButton CreateRadioButton()
    {
        return new MacRadioButton();
    }

    public ITextBox CreateTextBox()
    {
        return new MacTextBox();
    }
}
```
The factory returns instances of the UI elements for its respective implementation.

Each UI element 'type' is contracted to its own interface and has it's own behaviour, which is common to each of it's implementations. This way, we can perform the same actions on any UI element, regardless of which implementation has been selected.

```c#
// Interface
public interface IButton : IUIElement
{
    public void Click();
}

// Mac implementation 
internal class MacButton : IButton
{
    public MacButton()
    {
        this.Render();
    }

    public void Click()
    {
        Console.WriteLine($"{nameof(MacButton)} was clicked");
    }

    public void Render()
    {
        Console.WriteLine($"{nameof(MacButton)} was rendered to the screen");
    }
}

// Windows implementation
internal class WindowsButton : IButton
{
    public WindowsButton()
    {
        this.Render();
    }

    public void Click()
    {
        Console.WriteLine($"{nameof(WindowsButton)} was clicked");
    }

    public void Render()
    {
        Console.WriteLine($"{nameof(WindowsButton)} was rendered to the screen");
    }
}
```

our consuming code in ```Program.cs``` gets the factory implementation required from a simulated configuration class, using an Enum parameter -

```c#
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
```

and then simply the relevant implementations are returned from the factory as required, all the implementation is abstracted away! -

```c#
var uiFactory = appConfig.GetUIConfigurationFactory(UserInterface.Mac);

var textBox = uiFactory.CreateTextBox();
```