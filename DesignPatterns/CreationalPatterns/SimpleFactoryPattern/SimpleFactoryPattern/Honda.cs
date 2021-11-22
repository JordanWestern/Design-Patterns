namespace SimpleFactoryPattern;

// The 'Honda' implementation based on the ICar interface
internal class Honda : ICar
{
    public Honda()
    {
        Manafacturer = nameof(Honda);
        Model = "Jazz";
        Cost = 8000;
        Description = "it's a popular japanese hatchback.";
    }

    public string Manafacturer { get; }

    public string Model { get; }

    public decimal Cost { get; }

    public string Description { get; }
}