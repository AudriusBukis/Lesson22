using System.Collections.Generic;

namespace Lesson22.Models
{
    public class AudiCar : Car
    {
        public bool IsQuattro { get; private set; }
        public AudiCar(bool isQuattro, string model, int fuel) : base(model, fuel)
        {
            IsQuattro = isQuattro;
        }

    }
    public class AudiCarComparer : IComparer<AudiCar>
    {
        int IComparer<AudiCar>.Compare(AudiCar x, AudiCar y)
        {
            if (x.Fuel > y.Fuel) return 1;
            else if (x.Fuel < y.Fuel) return -1; 
            else return 0;

        }
    }
}
