using ConsoleApplication1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Size
{
    class SizeComparer
    {
        bool Compare(ISize sizeA, ISize sizeB)
        {
            if (sizeA.Height > sizeB.Height && sizeA.Length > sizeB.Length && sizeA.Width > sizeB.Width)
                return true;
            else
                return false;
        }

        bool CompareVolume(SizeVolume volumeA, SizeVolume volumeB)
        {
            if (volumeA.Volume() > volumeB.Volume())
                return true;
            else
                return false;
        }

    }
}
