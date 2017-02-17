using ConsoleApplication1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.BoxTypes
{
    class BoxCarton : IBox
    {
        public ISize ISize
        {
            get
            {
                return new Size();
            }

            set
            {
                throw new NotImplementedException();
            }
        }
    }
}
