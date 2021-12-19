namespace AbstractFactoryPattern.Windows.UIElements;

internal class WindowsTextBox : ITextBox
{
    public WindowsTextBox()
    {
        this.Render();
        this.Text = this.Text = $"I am a {nameof(WindowsTextBox)}";
    }

    public string Text { get; set; }

    public void Render()
    {
        Console.WriteLine($"{nameof(WindowsTextBox)} was rendered to the screen");
    }
}