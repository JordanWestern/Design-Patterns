namespace AbstractFactoryPattern.Windows.UIElements;

internal class WindowsCheckBox : ICheckBox
{
    public WindowsCheckBox()
    {
        this.Render();
        this.IsChecked = false;
    }

    public bool IsChecked { get; set; }

    public void Render()
    {
        Console.WriteLine($"{nameof(WindowsCheckBox)} was rendered to the screen");
    }
}