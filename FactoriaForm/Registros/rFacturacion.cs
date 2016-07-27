using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;

namespace FactoriaForm.Registros
{
    public partial class rFacturacion : Form
    {
        Venta venta;
        public rFacturacion()
        {
            InitializeComponent();
            venta = new Venta();

        }
        private void rFacturacion_Load(object sender, EventArgs e)
        {
            activar(false);
            DataTable dt = new DataTable();
            Cliente cliente = new Cliente();
            dt = cliente.Listado("ClienteId,Nombre", "1=1", "ClienteId");

            NombreComboBox.DataSource = dt;
            NombreComboBox.ValueMember = "ClienteId";
            NombreComboBox.DisplayMember = "Nombre";

        }
        private void ActivarBotones(bool ok)
        {
            ModificarButton.Enabled = ok;
            EliminarButton.Enabled = ok;
        }
        public void Limpiar()
        {
            NombreComboBox.Focus();
            dataGridView.Rows.Clear();
            TipoFacturaComboBox.SelectedIndex = 0;
            PesocomboBox.SelectedIndex = 0;
            CantidadtextBox.Clear();
            PrecioTextBox.Clear();
            TotalTextBox.Clear();

        }
        private void LlenarDatos()
        {

            venta.VentaId = Utility.ConvierteEntero(FactIdtextBox.Text);
            venta.Cliente = NombreComboBox.Text;
            venta.TipoFactura = TipoFacturaComboBox.Text;
            venta.Total = Utility.ConvierteFloat(TotalTextBox.Text);
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                venta.AddVenta(Utility.ConvierteEntero(row.Cells["Cantidad"].Value.ToString()), row.Cells["Peso"].Value.ToString(), Utility.ConvierteEntero(row.Cells["Precio"].Value.ToString()));
            }
        }
        private void ObteneDatos()
        {
            FactIdtextBox.Text = venta.VentaId.ToString();
            NombreComboBox.Text = venta.Cliente;
            TipoFacturaComboBox.Text = venta.TipoFactura;
            TotalTextBox.Text = venta.Total.ToString();
            foreach (Factorizacion item in venta.factura)
            {
                dataGridView.Rows.Add(item.Cantidad, item.Peso, item.Precio);
            }
        }
        private void activar(bool ok)
        {
            FechaDateTimePicker.Enabled = ok;

            CantidadtextBox.Enabled = ok;
            PrecioTextBox.Enabled = ok;
            PesocomboBox.Enabled = ok;
            AddButton.Enabled = ok;
        }
        private void NuevoButton_Click(object sender, EventArgs e)
        {
            if (NombreComboBox.Text.Equals(""))
            {
                Utility.Mensajes(3, "No hay Clientes Registrados.");
            }
            else
            {
                Limpiar();
                activar(true);
                GuadarButton.Enabled = true;
                ActivarBotones(false);
            }

        }

        private void FactIdtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.TextBoxNuemericos(e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = Utility.ConvierteEntero(FactIdtextBox.Text);
            try
            {

                Utility.Validar(FactIdtextBox, FacturacionErrorProvider, "Digite un Id!");
                if (!FactIdtextBox.Text.Equals(""))
                {
                    if (venta.Buscar(id))
                    {
                        ObteneDatos();
                        activar(true);
                        ActivarBotones(true);
                        GuadarButton.Enabled = false;
                        CantidadtextBox.Focus();
                    }
                    else
                    {
                        Utility.Mensajes(3, "No existe una Factura con este Numero.");
                        Limpiar();
                        FactIdtextBox.Focus();
                    }
                }
            }
            catch (Exception ex)
            {

                Utility.Mensajes(3, ex.Message);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {

            float total = 0;

            try
            {

                Utility.Validar(CantidadtextBox, FacturacionErrorProvider, "Digite Una Cantidad!");
                Utility.Validar(PrecioTextBox, FacturacionErrorProvider, "Digite Un Precio!");
                if (!CantidadtextBox.Text.Equals("") && !PrecioTextBox.Text.Equals(""))
                {

                    dataGridView.Rows.Add(CantidadtextBox.Text, PesocomboBox.Text, PrecioTextBox.Text);

                }
                else
                {
                    Utility.Mensajes(1, "No hay que añadir!");
                }

                foreach (DataGridViewRow item in dataGridView.Rows)
                {
                    total += (float)Convert.ToDecimal(item.Cells["Cantidad"].Value) * (float)Convert.ToDecimal(item.Cells["Precio"].Value);
                }


                TotalTextBox.Text = total.ToString();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ModificarButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (FactIdtextBox.Text != "" && dataGridView.RowCount > 0)
                {
                    LlenarDatos();
                    if (venta.Editar())
                    {
                        Utility.Mensajes(1, "El Cliente \n" + NombreComboBox.Text + " \nFue Modificado Correctamente!");
                        Limpiar();
                        ActivarBotones(false);
                    }
                    else
                    {
                        Utility.Mensajes(2, "El Cliente \n" + NombreComboBox.Text + " \n No Fue Modificado!");
                        Limpiar();
                        ActivarBotones(false);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void GuadarButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (FactIdtextBox.Text.Equals(""))
                {
                    if (dataGridView.RowCount > 0)
                    {
                       
                        LlenarDatos();
                        venta.Liverar();
                        if (venta.Insertar())
                        {
                            Utility.Mensajes(1, "La Factura Numero: " + FactIdtextBox.Text + " \nFue Guardada Correctamente!");
                            Limpiar();
                            ActivarBotones(false);
                        }
                        else
                        {
                            Utility.Mensajes(2, "La Factura Numero: " + FactIdtextBox.Text + " \n No Fue Guardada!");
                            Limpiar();
                            ActivarBotones(false);
                        }
                    }
                    else
                    {
                        Utility.Mensajes(2, "No hay Factura!");
                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {


            DialogResult result;
            int id = Utility.ConvierteEntero(FactIdtextBox.Text);

            try
            {
                if (!FactIdtextBox.Text.Equals("") && venta.Buscar(id))
                {
                    result = MessageBox.Show("¿Esta seguro que desea eliminar la factura Numero: " + FactIdtextBox.Text + "?", "¿?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        LlenarDatos();
                        if (venta.Eliminar())
                        {
                            Utility.Mensajes(1, "La Factura Numero: \n" + FactIdtextBox.Text + " \nFue Eliminadq Correctamente!");
                            Limpiar();
                            ActivarBotones(false);
                        }
                        else
                        {
                            Utility.Mensajes(1, "La Factura Numero: \n" + FactIdtextBox.Text + " \nNO Fue Eliminada!");
                            Limpiar();
                            ActivarBotones(false);
                        }
                    }
                }
                else
                {
                    Utility.Mensajes(3, "La Factura Con el Numero: " + FactIdtextBox.Text + " No existe!");
                    Limpiar();
                    ActivarBotones(false);
                }

            }
            catch (Exception ex)
            {

                Utility.Mensajes(2, ex.Message);
            }



        }

        private void CantidadtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.TextBoxNuemericos(e);
            Utility.Enter(e, PrecioTextBox);
        }

        private void PrecioTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.TextBoxNuemericos(e);
            Utility.Enter(e, AddButton);
        }
    }
}
