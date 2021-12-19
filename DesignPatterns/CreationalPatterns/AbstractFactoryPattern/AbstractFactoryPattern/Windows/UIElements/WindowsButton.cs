namespace AbstractFactoryPattern.Windows.UIElements;

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