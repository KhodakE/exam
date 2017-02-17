using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public interface ISize
    {
        double Width { get; set; }
        double Height { get; set; }
        double Length { get; set; }
    }
}