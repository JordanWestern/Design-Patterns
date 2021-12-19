namespace AbstractFactoryPattern.Windows.UIElements;

internal class WindowsRadioButton : IRadioButton
{
    public WindowsRadioButton()
    {
        this.Render();
    }

    public void Render()
    {
        Console.WriteLine($"{nameof(WindowsRadioButton)} was rendered to the screen");
    }

    public void Select()
    {
        Console.WriteLine($"{nameof(WindowsRadioButton)} was selected");
    }
}