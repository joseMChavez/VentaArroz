using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FactoriaForm
{
    public partial class Factoria : Form
    {
        public Factoria()
        {
            InitializeComponent();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registros.rCliente cliente = new Registros.rCliente();
            cliente.Show();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registros.rFacturacion factura = new Registros.rFacturacion();

            factura.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sobreToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Jose Maximino Chavez/ 2013-0747", "Tarea de Lenguaje");
        }
    }
}
