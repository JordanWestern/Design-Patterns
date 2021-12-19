namespace AbstractFactoryPattern.Mac.UIElements;

internal class MacTextBox : ITextBox
{
    public MacTextBox()
    {
        this.Render();
        this.Text = $"I am a {nameof(MacTextBox)}";
    }

    public string Text { get; set; }

    public void Render()
    {
        Console.WriteLine($"{nameof(MacTextBox)} was rendered to the screen");
    }
}
