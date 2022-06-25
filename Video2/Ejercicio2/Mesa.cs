using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Mesa
    {

        private double Weight { get; set; }
        private double Length { get; set; }
        private string Color { get; set; }
        private string Material { get; set; }

        public Mesa(double weight, double length, string color, string material)
        {
            Weight = weight;
            Length = length;
            Color = color;
            Material = material;
        }

        public override string? ToString()
        {
            return string.Format("Mesa: {0}, {1}, {2}, {3}", Weight, Length, Color, Material);
        }
    }
}
