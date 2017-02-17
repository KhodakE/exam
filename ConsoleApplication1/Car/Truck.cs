using ConsoleApplication1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Car
{
    public class Truck : ICar
    {
        public ISize ISize
        {
            get
            {

                return new Size.Size();
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
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public double CountPrice(List<IBox> Boxes)
        {
            throw new NotImplementedException();
        }
    }
}
