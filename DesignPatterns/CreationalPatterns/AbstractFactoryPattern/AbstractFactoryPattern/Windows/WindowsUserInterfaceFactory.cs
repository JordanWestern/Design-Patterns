using AbstractFactoryPattern.Windows.UIElements;

namespace AbstractFactoryPattern.Windows;

internal class WindowsUserInterfaceFactory : IUserInterfaceFactory
{
    public IButton CreateButton()
    {
        return new WindowsButton();
    }

    public ICheckBox CreateCheckBox()
    {
        return new WindowsCheckBox();
    }

    public IRadioButton CreateRadioButton()
    {
        return new WindowsRadioButton();
    }

    public ITextBox CreateTextBox()
    {
        return new WindowsTextBox();
    }
}