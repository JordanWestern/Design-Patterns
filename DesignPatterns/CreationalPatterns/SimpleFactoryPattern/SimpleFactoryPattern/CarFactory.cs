namespace SimpleFactoryPattern;

// The class that overrides the method from the abstract base class.
// This class is consumed to provide a variant of the object contacted to your interface, based on some condition.
public class CarFactory : CarFactoryBase
{
    public override ICar CreateCar(CarManafacturer carManafacturer)
    {
        return carManafacturer switch
        {
            CarManafacturer.Honda => new Honda(),
            CarManafacturer.Ferrari => new Ferrari(),
            _ => throw new NotImplementedException($"Car manafacturer {carManafacturer} not yet implemented"),
        };
    }
}