using AbstractFactoryPattern.Mac.UIElements;

namespace AbstractFactoryPattern.Mac;

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