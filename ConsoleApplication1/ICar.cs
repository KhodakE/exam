using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public interface ICar
    {
        ISize ISize { get; set; }
        double Price { get; set; }
        double CountPrice(List<IBox> Boxes);
    }
}