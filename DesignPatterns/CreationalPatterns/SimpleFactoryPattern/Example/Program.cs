using SimpleFactoryPattern;

// Consumes the car factory class.
// creates an instance of a class contracted to the ICar interface based on the car manafacturer parameter.

var carFactory = new CarFactory();

var car = carFactory.CreateCar(CarManafacturer.Ferrari);
//var car = carFactory.CreateCar(CarManafacturer.Honda);

Console.WriteLine($"A {car.Manafacturer} {car.Model} costs roughtly £{car.Cost}. {car.Description}");