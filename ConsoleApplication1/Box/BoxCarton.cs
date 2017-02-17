using ConsoleApplication1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Box
{
    class BoxCarton : IBox
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
    }
}
