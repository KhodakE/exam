using ConsoleApplication1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Car
{
    class SmallCar : Car
    {
        public SmallCar()
        {
            Price = 200;
            ISize = new Size.Size();
        }
    }
}
