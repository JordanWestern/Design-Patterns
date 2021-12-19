namespace AbstractFactoryPattern.Mac.UIElements;

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