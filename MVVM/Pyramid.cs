using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM
{
    public class Pyramid
    {
        public double BaseSide { get; set; }
        public double Height { get; set; }

        public double BaseArea => (Math.Sqrt(3) / 4) * BaseSide * BaseSide;
        public double Apothem => Math.Sqrt(Math.Pow(Height, 2) + 
            Math.Pow((Math.Sqrt(3) * BaseSide / 2) - BaseSide / Math.Sqrt(3), 2));

        public bool IsValid => BaseSide > 0 && Height > 0;

        public Pyramid() : this(0, 0)
        {
        }

        public Pyramid(double baseSide, double height)
        {
            BaseSide = baseSide;
            Height = height;
        }
    }
}
