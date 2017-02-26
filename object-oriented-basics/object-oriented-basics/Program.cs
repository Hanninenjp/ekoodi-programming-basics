using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace object_oriented_basics
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<Car> cars = new List<Car>();
            cars.Add(new Car("Seat", 120));
            cars.Add(new Car("Skoda", 100));
            cars.Add(new Car("Volkswagen", 80));
            Console.WriteLine("Cars are cruising on a highway!");
            foreach(Car car in cars)
            {
                Console.WriteLine(car.ShowInformation());
            }
            decimal speedIncrease = 20;
            Console.WriteLine("\nCars will now accelerate {0} km/h!", speedIncrease);
            foreach (Car car in cars)
            {
                car.Accelerate(speedIncrease);
            }
            foreach (Car car in cars)
            {
                Console.WriteLine(car.ShowInformation());
            }
            Console.WriteLine("\nCars will now decelerate!");
            foreach (Car car in cars)
            {
                car.Decelerate();
            }
            foreach (Car car in cars)
            {
                Console.WriteLine(car.ShowInformation());
            }
            Console.WriteLine("\nPress any key to exit!");
            Console.ReadKey();
        }
    }
}
