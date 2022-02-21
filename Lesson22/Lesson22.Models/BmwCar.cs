using System.Collections.Generic;

namespace Lesson22.Models
{
    public class BmwCar : Car 
    {
        public bool IsXDrive { get; private set; }
        public bool IsM3 { get; private set; }
        public BmwCar(bool isXDrive, string model, int fuel) : base(model, fuel)
        {
            IsXDrive = isXDrive;
            IsM3 = true;
        }

        
    }
    public class BmwCarComparer : IComparer<BmwCar>
    {
        int IComparer<BmwCar>.Compare(BmwCar x, BmwCar y)
        {
            return string.Compare(x.Model, y.Model);
        }
    }
}
