namespace SimpleFactoryPattern;

public abstract class CarFactoryBase
{
    public abstract ICar CreateCar(CarManafacturer carManafacturer);
}