using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    internal class Comisaria
    {
        public int CantidadIncidentes { get; private set; }

        Guardia[] guardias = new Guardia[2]; // como que se crear los lugares

        List<Incidente> incidentes = new List<Incidente>();
        List<Policia> agentes = new List<Policia>();

        public bool AsignarPolicia(Policia unPolicia)
        {
            return false;
        }
        public Policia VerAgente(int numPlaca)
        {
            if (numPlaca >= 0)
            {
                //dos opaciones
                foreach(Policia policia in agentes)
                {
                    if(policia.NumeroPlaca == numPlaca)
                    {
                        return policia;
                    }
                }

                //otra opcion
                //return agentes.FirstOrDefault(p => p.NumeroPlaca == numPlaca);
                
            }
            return null;
        }
        public void RegistrarIncidente(Policia agente, Persona sujeto, string motivo, int h, int m, int tipoIncidente)
        {
            incidentes.Add(new Incidente(agente, sujeto, tipoIncidente, h, m, motivo));

        }
        public void AsignarGuardia(int numero, int h1, int m1, int tiempoMinutos, Policia agente)
        {

        }
        public Incidente VerIncidente(int index)
        {
            return null;
        }

    }
}
