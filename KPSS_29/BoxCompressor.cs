using ConsoleApplication1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPSS_29
{
    public static class BoxCompressor
    {
        public static ISize GetSize(List<IBox> boxes)
        {
            ISize size = new Size();

            foreach (var box in boxes)
            {
                size.Height += box.ISize.Height;

                if (size.Length < box.ISize.Length)
                    size.Length = box.ISize.Length;

                if (size.Width < box.ISize.Width)
                    size.Width = box.ISize.Width;
            }

            return size;
        }
    }
}
