namespace SimpleFactoryPattern;

// The interface your objects can be contracted to that require various implementations
public interface ICar
{
    public string Manafacturer { get; }

    public string Model { get; }

    public decimal Cost { get; }

    public string Description { get; }
}