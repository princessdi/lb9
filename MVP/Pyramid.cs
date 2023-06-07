using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP
{
    public class Pyramid : IPyramidModel
    {
        public double BaseSide { get; set; }
        public double Height { get; set; }

        public double BaseArea => (Math.Sqrt(3) / 4) * BaseSide * BaseSide;
        public double Apothem => Math.Sqrt(Math.Pow(Height, 2) + Math.Pow((Math.Sqrt(3) * BaseSide / 2) - BaseSide / Math.Sqrt(3), 2));

        public Pyramid() : this(5, 5)
        {
        }

        public Pyramid(double baseSide, double height)
        {
            BaseSide = baseSide;
            Height = height;
        }
    }
}
