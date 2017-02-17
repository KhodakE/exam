using ConsoleApplication1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Car
{
    class SmallCar : ICar
    {
        public ISize ISize
        {
            get
            {
                return new ConsoleApplication1.Size.Size();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public double Price
        {
            get
            {
                return 200;
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public double CountPrice(List<IBox> Boxes)
        {
            //double len = Boxes.Sum(s => s.ISize.Length);
            throw new NotImplementedException();
        }
    }
}
