using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    internal class Guardia
    {
        public Policia oficialAsignado {  get; private set; }
        public int HoraDesde {  get; private set; }
        public int MinutoDesde { get; private set; }
        public int HoraHasta { get; private set; }
        public int MinutoHasta { get; private set; }

        public Guardia() { }

        public void AsignarPolicia( Policia unPolicia, int h, int m , int CantM)
        {
            oficialAsignado = unPolicia;

        }


    }
}
