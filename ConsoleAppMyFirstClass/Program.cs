using System;
using System.Collections.Generic;

namespace ConsoleAppMyFirstClass
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();

            Console.WriteLine("Cars: " + Car.CarsCreated);

            cars.Add(new Car("Audi", "RS 6", "Black", 2019, 0, 0));
            cars.Add(new Car("Volvo", "740", "Red", 1998, 56_000, 0));
            cars.Add(new Car("Lambogini", "Diablo", "Yellow", 2020, 0, 0));

            Console.WriteLine("Cars: " + Car.CarsCreated);

            //foreach (Car aCar in cars)
            //{
            //    Console.WriteLine(aCar);
            //}

            int numberA = 37;

            IncrementInt(numberA);

            Console.WriteLine("utside method: " + numberA);

            Car myCar = cars[0];

            Console.WriteLine("Car miles before: " + myCar.miles);

            IncrementObject(myCar);

            Console.WriteLine("Car miles after: " + myCar.miles);

            Console.ReadKey(true);
        }

        static void IncrementObject(Car car)
        {
            car.miles++;
        }

        static void IncrementInt(int number)
        {
            number++;
            Console.WriteLine("inside method: " + number);
        }
    }
}
