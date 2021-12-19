namespace AbstractFactoryPattern;

public interface ICheckBox : IUIElement
{
    bool IsChecked { get; }
}