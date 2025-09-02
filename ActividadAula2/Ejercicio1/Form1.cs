using Ejercicio1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        Comisaria laComisaria;
        public Form1()
        {
            InitializeComponent();
            grBadmin.Enabled = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void btnCrearComisaria_Click(object sender, EventArgs e)
        {
            laComisaria = new Comisaria();
            grBadmin.Enabled = true;
            btnCrearComisaria.Enabled = false;


            //esto esta hacordeado acorde al problema

            Policia agenteJ = new Policia(123456789, "Juan", 33);
            Policia agenteA = new Policia(789456123, "Ana", 44);
            laComisaria.AsignarPolicia(agenteJ);
            laComisaria.AsignarPolicia(agenteA);

            comboAgente.Items.Clear();
            comboAgente.Items.Add(agenteJ.NumeroPlaca);
            comboAgente.Items.Add(agenteA.NumeroPlaca);

        }

        private void btnAsignarGuardia_Click(object sender, EventArgs e)
        {
            Policia agente = laComisaria.VerAgente(comboAgente.SelectedIndex);
            int nGuardia = comboGuardia.SelectedIndex;
            int h = int.Parse(tbHG.Text);
            int m = int.Parse(tbMG.Text);
            int md = int.Parse(tbMDesde.Text);
            int tipo = comboGuardia.SelectedIndex;

            laComisaria.AsignarGuardia(tipo, h, m,md, agente);



        }

        private void btnRegistrarIncidente_Click(object sender, EventArgs e)
        {
            Policia agenteDeTurno = laComisaria.VerAgente(Convert.ToInt32(comboAgente.SelectedItem));
            int nGuardia = comboGuardia.SelectedIndex;
            int h = int.Parse(tbHI.Text);
            int m = int.Parse(tbMI.Text);
            int dni = int.Parse(tbDNI.Text);
            string nombre = tbNombrePersona.Text;
            Persona sujeto = new Persona(dni, nombre);
            string motivo = tbMotivo.Text;
            int tipo = comboTipoI.SelectedIndex;
            laComisaria.RegistrarIncidente(agenteDeTurno, sujeto, motivo, h, m, tipo);
        }

        private void btnListaIncidentes_Click(object sender, EventArgs e)
        {
            FListar VListar = new FListar();
            laComisaria.ListarIncidente(VListar.lbLista);

            VListar.ShowDialog();
        }
    }
}
