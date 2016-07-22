using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FactoriaForm.Registros
{
    public partial class rCliente : Form
    {
        public rCliente()
        {
            InitializeComponent();
        }


        private void rCliente_Load(object sender, EventArgs e)
        {

        }
        public void Limpiar()
        {
            ClienteIdtextBox.Clear();
            NombretextBox.Clear();
            ApellidotextBox.Clear();
            CedulatextBox.Clear();
            TellMaskedTextBox.Clear();
            TellMaskedTextBox.Mask = "###-###-####";
            EmailtextBox.Clear();
            DireciontextBox.Clear();
        }

        private void ActivarBotones(bool ok)
        {
            ModificarButton.Enabled = ok;
            EliminarButton.Enabled = ok;
        }
        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void ModificarButton_Click(object sender, EventArgs e)
        {

        }

        private void GuadarButton_Click(object sender, EventArgs e)
        {

        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {

        }
       
    }
}
