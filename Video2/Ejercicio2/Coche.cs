using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Coche
    {
        private int Ruedas { get; set; }
        private int Puertas { get; set; }
        private string Marca { get; set; }
        private DateTime FechaITV { get; set; }

        public Coche(int ruedas, int puertas, string marca, DateTime fechaITV)
        {
            this.Ruedas = ruedas;
            this.Puertas = puertas;
            this.Marca = marca;
            this.FechaITV = fechaITV;
        }

        public override string? ToString()
        {
            return string.Format("Coche: {0}, {1}, {2}, {3}", Ruedas, Puertas, Marca, FechaITV);
        }
    }


}
