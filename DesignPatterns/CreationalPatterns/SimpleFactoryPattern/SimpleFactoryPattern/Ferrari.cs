namespace SimpleFactoryPattern;

// The 'Ferrari' implementation based on the ICar interface
internal class Ferrari : ICar
{
    public Ferrari()
    {
        Manafacturer = nameof(Ferrari);
        Model = "F430";
        Cost = 120000;
        Description = "It's an iconic italian supercar.";
    }

    public string Manafacturer { get; }

    public string Model { get; }

    public decimal Cost { get; }

    public string Description { get; }
}