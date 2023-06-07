using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP
{
    public interface IPyramidModel
    {
        double Height { get; set; }
        double BaseSide { get; set; }

        double BaseArea { get; }
        double Apothem { get; }
    }
}
