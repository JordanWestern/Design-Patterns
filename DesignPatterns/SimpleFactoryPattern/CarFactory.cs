namespace SimpleFactoryPattern;

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