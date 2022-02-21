using Lesson22.Models;
using System;
using System.Collections.Generic;

namespace Lesson22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lesson 22 interfaces ");

            // var bmw = new Car("BMW", 50);
            // var audi = new Car("Audi", 26);
            var bmw = new BmwCar(true,"BMW", 50);
            var audi = new AudiCar(false ,"Audi", 26);
            List<BmwCar> bmwList = new List<BmwCar>() 
            { new BmwCar(true, "BMW7", 50),
              new BmwCar(false, "BMW5", 59), 
              new BmwCar(false, "BMW3", 89) 
            };
            List<AudiCar> audiCars = new List<AudiCar>()
            { new AudiCar(true, "Audi100", 50),
              new AudiCar(false, "Audi", 26), 
              new AudiCar(true, "Audi80", 83) 
            };
            var bmwCarComparer = new BmwCarComparer();
            var audiCarComparer = new AudiCarComparer();
            bmwList.Sort(bmwCarComparer);
            audiCars.Sort(audiCarComparer);

            Console.WriteLine(bmw.Drive());
            Console.WriteLine(audi.Drive());
            Console.WriteLine(bmw.Model);
            Console.WriteLine(audi.Model);
            Console.WriteLine(bmw.Fuel);
            Console.WriteLine(audi.Fuel);
            audi.Refuel();
            bmw.Refuel();
            Console.WriteLine(bmw.Fuel);
            Console.WriteLine(audi.Fuel);
            var vehicles = new List<Car>();

            vehicles.AddRange(bmwList);
            vehicles.AddRange(audiCars);
            var carComparer = new CarComparer();
            vehicles.Sort(carComparer);

        }
    }
}
