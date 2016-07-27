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
    public partial class rCliente : Form
    {
        public rCliente()
        {
            InitializeComponent();
        }

        private void rCliente_Load(object sender, EventArgs e)
        {
            CedulaMaskedTextBox.Mask = "###-#######-#";
        }

        public void Limpiar()
        {
            ClienteIdtextBox.Clear();
            NombretextBox.Clear();
            ApellidotextBox.Clear();
            CedulaMaskedTextBox.Clear();
            CedulaMaskedTextBox.Mask = "###-#######-#";
            TellMaskedTextBox.Clear();
            TellMaskedTextBox.Mask = "###-###-####";
            EmailtextBox.Clear();
            DireciontextBox.Clear();
        }

        public void LlenarDatos(Cliente cliente)
        {
            cliente.ClienteId = Utility.ConvierteEntero(ClienteIdtextBox.Text);
            cliente.Nombre = NombretextBox.Text;
            cliente.Apellido = ApellidotextBox.Text;
            cliente.Cedula = CedulaMaskedTextBox.Text;
            cliente.Telefono = TellMaskedTextBox.Text;
            cliente.Email = EmailtextBox.Text;
            cliente.Direccion = DireciontextBox.Text;

        }
        public void ObtenerDatos(Cliente cliente)
        {
            
            NombretextBox.Text = cliente.Nombre;
            ApellidotextBox.Text = cliente.Apellido;
            CedulaMaskedTextBox.Text = cliente.Cedula;
            TellMaskedTextBox.Text = cliente.Telefono;
            EmailtextBox.Text = cliente.Email;
            DireciontextBox.Text = cliente.Direccion;
        }
        private void ActivarBotones(bool ok)
        {

            ModificarButton.Enabled = ok;
            EliminarButton.Enabled = ok;
        }
        private void ValidarTodo()
        {
            Utility.Validar(NombretextBox, ClienteErrorProvider, "Introduzca el Nombre!");
            Utility.Validar(ApellidotextBox, ClienteErrorProvider, "Introduzca el Apellido!");
            Utility.Validar(TellMaskedTextBox, ClienteErrorProvider, "Introduzca el Apellido!");
            Utility.Validar(CedulaMaskedTextBox, ClienteErrorProvider, "Introduzca el Apellido!");
            if (CedulaMaskedTextBox.MaskCompleted == false)
            {
                ClienteErrorProvider.SetError(CedulaMaskedTextBox, "Complete la Cedula Correctamente!");
                CedulaMaskedTextBox.Clear();
                CedulaMaskedTextBox.Focus();
            }
            if (TellMaskedTextBox.MaskCompleted == false)
            {
                ClienteErrorProvider.SetError(TellMaskedTextBox, "Complete El Telefono Correctamente!");
                TellMaskedTextBox.Clear();
                TellMaskedTextBox.Focus();
            }
            Utility.Validar(EmailtextBox, ClienteErrorProvider, "Introduzca el Email!");
            Utility.Validar(DireciontextBox, ClienteErrorProvider, "Introduzca la Direccion!");


        }
        private void BuscarButton_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            int id = Utility.ConvierteEntero(ClienteIdtextBox.Text);
            try
            {
                Utility.Validar(ClienteIdtextBox, ClienteErrorProvider, "Digite el Id a Buscar!");
                if (!ClienteIdtextBox.Text.Equals(""))
                {
                    if (cliente.Buscar(id))
                    {
                        ObtenerDatos(cliente);
                        GuadarButton.Enabled = false;
                        ActivarBotones(true);
                        NombretextBox.Focus();
                    }
                    else
                    {
                        Utility.Mensajes(3, "Id No encontrado!");
                        ClienteIdtextBox.Focus();
                        ActivarBotones(false);
                        Limpiar();
                    }

                }

            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message);
            }
        }
        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
            NombretextBox.Focus();
            GuadarButton.Enabled = true;
        }

        private void ModificarButton_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            try
            {
                if (!ClienteIdtextBox.Text.Equals("") && !NombretextBox.Text.Equals("") && !ApellidotextBox.Text.Equals("") && CedulaMaskedTextBox.MaskCompleted == true && TellMaskedTextBox.MaskCompleted == true && !EmailtextBox.Text.Equals("") && !DireciontextBox.Text.Equals(""))
                {

                    if (Utility.ComprobarFormatoEmail(EmailtextBox.Text))
                    {
                        LlenarDatos(cliente);
                        if (cliente.Editar())
                        {
                            Utility.Mensajes(1, "El Cliente \n" + NombretextBox.Text + " " + ApellidotextBox.Text + " \nFue Modificado Correctamente!");
                            Limpiar();
                            ActivarBotones(false);
                        }
                        else
                        {
                            Utility.Mensajes(2, "El Cliente \n" + NombretextBox.Text + " " + ApellidotextBox.Text + " \n No Fue Modificado!");
                            Limpiar();
                            ActivarBotones(false);
                        }
                    }
                    else
                    {
                        ClienteErrorProvider.SetError(EmailtextBox, "Email Invalido");
                        EmailtextBox.Clear();
                        EmailtextBox.Focus();
                    }
                }
                else
                {
                    ActivarBotones(false);
                }



            }
            catch (Exception ex)
            {

                Utility.Mensajes(2, ex.Message);
            }
        }

        private void GuadarButton_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            ValidarTodo();
            try
            {
                if (ClienteIdtextBox.Text.Equals("") && !NombretextBox.Text.Equals("") && !ApellidotextBox.Text.Equals("") && CedulaMaskedTextBox.MaskCompleted == true && TellMaskedTextBox.MaskCompleted == true && !EmailtextBox.Text.Equals("") && !DireciontextBox.Text.Equals(""))
                {

                    if (Utility.ComprobarFormatoEmail(EmailtextBox.Text))
                    {
                        LlenarDatos(cliente);
                        if (cliente.Insertar())
                        {
                            Utility.Mensajes(1, "El Cliente \n" + NombretextBox.Text + " " + ApellidotextBox.Text + " \nFue Guardado Correctamente!");
                            Limpiar();

                        }
                        else
                        {
                            Utility.Mensajes(2, "El Cliente \n" + NombretextBox.Text + " " + ApellidotextBox.Text + " \n No Fue Guardado!");
                            Limpiar();

                        }
                    }
                    else
                    {
                        ClienteErrorProvider.SetError(EmailtextBox, "Email Invalido");
                        EmailtextBox.Clear();
                        EmailtextBox.Focus();
                    }
                }
                else
                {
                    Limpiar();

                }



            }
            catch (Exception ex)
            {

                Utility.Mensajes(2, ex.Message);
            }
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            DialogResult result;
            int id = Utility.ConvierteEntero(ClienteIdtextBox.Text);

            try
            {
                if (!ClienteIdtextBox.Text.Equals("") && cliente.Buscar(id))
                {
                    result = MessageBox.Show("¿Esta seguro que desea eliminar a " + NombretextBox.Text + "?", "¿?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        LlenarDatos(cliente);
                        if (cliente.Eliminar())
                        {
                            Utility.Mensajes(1, "El Cliente \n" + NombretextBox.Text + " " + ApellidotextBox.Text + " \nFue Eliminado Correctamente!");
                            Limpiar();
                            ActivarBotones(false);
                        }
                        else
                        {
                            Utility.Mensajes(1, "El Cliente \n" + NombretextBox.Text + " " + ApellidotextBox.Text + " \nNO Fue Eliminado!");
                            Limpiar();
                            ActivarBotones(false);
                        }
                    }
                }
                else
                {
                    Utility.Mensajes(3, "El Cliente con el Id: " + ClienteIdtextBox.Text + " No existe!");
                    Limpiar();
                    ActivarBotones(false);
                }

            }
            catch (Exception ex)
            {

                Utility.Mensajes(2, ex.Message);
            }
        }

        private void NombretextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.TextBoxSoloTexto(e);
            Utility.Enter(e, ApellidotextBox);
        }

        private void ApellidotextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.TextBoxSoloTexto(e);
            Utility.Enter(e, CedulaMaskedTextBox);
        }

        private void CedulaMaskedTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.Enter(e, TellMaskedTextBox);
        }

        private void TellMaskedTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.Enter(e, EmailtextBox);
        }

        private void EmailtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.TextBoxEspecial(e);
            Utility.Enter(e, DireciontextBox);
        }



        private void ClienteIdtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.TextBoxNuemericos(e);
        }
    }
}
