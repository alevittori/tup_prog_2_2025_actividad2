using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    internal class Incidente
    {
        public string Motivo { get; set; }
        public int Hora { get; set; }
        public int Minuto { get; set; }
        public int TipoIncidente { get; set; }

        public Policia OficialACargo {  get; private set; }
        public Persona Sujeto { get; private set; }

        public Incidente(Policia oficial, Persona sujeto,int tipoIncidente, int h, int min, string motivo)
        {
            OficialACargo = oficial;
            Sujeto = sujeto;
            TipoIncidente = tipoIncidente;
            Minuto = min;
            Hora = h;
            Motivo = motivo;
        }

        public string VerDescripcion()
        {
            return $@" Incidente {TipoIncidente} ,
                        Hora {Hora}:{Minuto},
                        Motivo {Motivo},
                        Oficial a Cago {OficialACargo.VerDatos()}
                        Persona {Sujeto.VerDatos()}
                    ";
        }

    }
}
