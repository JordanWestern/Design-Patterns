namespace SimpleFactoryPattern;

public interface ICar
{
    public string Manafacturer { get; }

    public string Model { get; }

    public decimal Cost { get; }

    public string Description { get; }
}