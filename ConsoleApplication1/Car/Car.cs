using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1.Size;
using ConsoleApplication1.Box;

namespace ConsoleApplication1.Car
{
    class Car : ICar
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

        public virtual double CountPrice(List<IBox> Boxes)
        {
            var result_size = BoxCompressor.GetSize(Boxes);
            var carsize = new Car();
            var result = new SizeComparer();

            if (result.Compare(result_size, carsize.ISize))
            {
                return 0;
            }
            else
            {
                return 5;
            }
        }
    }
}
