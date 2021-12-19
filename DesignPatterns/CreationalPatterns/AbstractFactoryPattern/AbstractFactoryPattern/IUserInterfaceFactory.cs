namespace AbstractFactoryPattern;

public interface IUserInterfaceFactory
{
    public IButton CreateButton();

    public ITextBox CreateTextBox();

    public ICheckBox CreateCheckBox();

    public IRadioButton CreateRadioButton();
}
