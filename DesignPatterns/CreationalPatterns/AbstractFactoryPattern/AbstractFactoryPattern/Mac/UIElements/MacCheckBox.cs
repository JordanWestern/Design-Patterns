namespace AbstractFactoryPattern.Mac.UIElements;

internal class MacCheckBox : ICheckBox
{
    public bool IsChecked => false;

    public void Render()
    {
        Console.WriteLine($"{nameof(MacCheckBox)} was rendered to the screen");
    }
}