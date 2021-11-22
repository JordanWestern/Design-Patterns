namespace SimpleFactoryPattern;

// The base class for the car factory, marked as abstract so that it cannot be directly instantiated
public abstract class CarFactoryBase
{
    public abstract ICar CreateCar(CarManafacturer carManafacturer);
}