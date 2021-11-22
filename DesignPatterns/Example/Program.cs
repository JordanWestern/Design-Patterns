using SimpleFactoryPattern;

var carFactory = new CarFactory();

var car = carFactory.CreateCar(CarManafacturer.Ferrari);
//var car = carFactory.CreateCar(CarManafacturer.Honda);

Console.WriteLine($"A {car.Manafacturer} {car.Model} costs roughtly £{car.Cost}. {car.Description}");