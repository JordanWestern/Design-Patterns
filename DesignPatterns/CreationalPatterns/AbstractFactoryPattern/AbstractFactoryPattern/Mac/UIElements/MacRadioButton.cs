namespace AbstractFactoryPattern.Mac.UIElements;

internal class MacRadioButton : IRadioButton
{
    public MacRadioButton()
    {
        this.Render();
    }

    public void Render()
    {
        Console.WriteLine($"{nameof(MacRadioButton)} was rendered to the screen");
    }

    public void Select()
    {
        Console.WriteLine($"{nameof(MacRadioButton)} was selected");
    }
}