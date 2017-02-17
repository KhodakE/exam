using ConsoleApplication1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    class Car : ICar
    {
      
   
        public ISize ISize
        {
            get
            {
                return new CarSize();
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
