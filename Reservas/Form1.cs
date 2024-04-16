using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reservas
{
    public partial class Form1 : Form
    {
        private Vuelo vuelo;
        public Form1()
        {
            InitializeComponent();
            cboOrigen.Items.Add("Medellín");
            cboOrigen.Items.Add("Cali");
            cboOrigen.Items.Add("Bogotá");
            cboOrigen.Items.Add("Pereira");

            cboDestino.Items.Add("Paris");
            cboDestino.Items.Add("New York");
            cboDestino.Items.Add("Boston");
            cboDestino.Items.Add("Noruega");
        }
        private void btnReservar_Click(object sender, EventArgs e)
        {
            string origen = cboOrigen.Text;
            string destino = cboDestino.Text;
            DateTime fechaSalida = dtpFechaSalida.Value;

            string preferenciaAsiento = "";
            if (rbtPasillo.Checked)
            {
                preferenciaAsiento = "Pasillo";
            }
            else if (rbtCentro.Checked)
            {
                preferenciaAsiento = "Centro";
            }
            else if (rbtVentana.Checked)
            {
                preferenciaAsiento = "Ventana";
            }

            if (!string.IsNullOrEmpty(origen) && !string.IsNullOrEmpty(destino) && !string.IsNullOrEmpty(preferenciaAsiento))
            {
                Vuelo vuelo = new Vuelo(origen, destino, fechaSalida, preferenciaAsiento);
                MessageBox.Show($"Información del vuelo:\n\n{vuelo}");
            }
            else

                MessageBox.Show("Por favor, complete todos los campos.");
        }
    }
}

