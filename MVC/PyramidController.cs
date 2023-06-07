using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC
{
    public class PyramidController
    {
        public double Area(double baseSide, double height)
        {
            var model = new Pyramid(baseSide, height);

            var baseArea = model.BaseArea;
            var sideArea = model.Apothem * (model.BaseSide * 3 / 2);

            return baseArea + sideArea;
        }

        public double Volume(double baseSide, double height)
        {
            var model = new Pyramid(baseSide, height);

            var volume = model.Height * model.BaseArea / 3;

            return volume;
        }
    }
}
