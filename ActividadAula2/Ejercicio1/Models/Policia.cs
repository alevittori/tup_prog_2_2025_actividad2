using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    internal class Policia
    {
        public int DNI { get; private set; }
        public string Nombre { get; private set; }
        public int NumeroPlaca { get; private set; }

        public Policia(int dNI, string nombre, int numeroPlaca)
        {
            DNI = dNI;
            Nombre = nombre;
            NumeroPlaca = numeroPlaca;
        }

        public string VerDatos() { 
            return $"Policia: {Nombre} - N° Placa: {NumeroPlaca}.";
        }


    }
}
