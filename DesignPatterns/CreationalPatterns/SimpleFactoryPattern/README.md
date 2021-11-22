# Simple Factory Pattern

## Purpose

The Simple factory pattern describes a class that has one creation method with a large conditional that based on method parameters chooses which product class to instantiate and then return.

### The Factory

In this case, the ```CarFactory``` class is the creator here. It has one method, ```CreateCar()```, which returns an object contracted to the ```ICar``` interface based on an enum parameter.

```c#
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
```

### Product Classes

The product classed in this example are the ```Ferarri``` and ```Honda``` classes. They are both contracted to the ```ICar``` interface.

```c#
public interface ICar
{
    public string Manafacturer { get; }

    public string Model { get; }

    public decimal Cost { get; }

    public string Description { get; }
}
```

```c#
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
```

```c#
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
```