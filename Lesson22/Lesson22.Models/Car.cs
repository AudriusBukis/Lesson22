
using System.Collections.Generic;

namespace Lesson22.Models
{
    //public class Car : IVehicle
    public abstract class Car : IVehicle
    {
        public string Model { get; private set; }
        public int Fuel { get; set; }


        public Car(string model, int fuel)
        {
            Model = model;
            Fuel = fuel;
        }

        public bool Drive()
        {
             if (Fuel > 0)
             {             
                 Fuel--;
                 return true;  
             }
            return false; 

        }
        public void Refuel()
        {
            if (Fuel <= 100)
            {
                Fuel = Fuel + 100 - Fuel;
            }
            else if (Fuel <= 0)
            {
                Fuel = 100; 
            }
            
        }
    }
    public class CarComparer : IComparer<Car>
    {
        int IComparer<Car>.Compare(Car x, Car y)
        {
            if (x.Fuel > y.Fuel) return 1;
            else if (x.Fuel < y.Fuel) return -1;
            else return 0;

        }
    }

}
