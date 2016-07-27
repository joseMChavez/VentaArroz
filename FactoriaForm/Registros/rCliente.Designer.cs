namespace FactoriaForm.Registros
{
    partial class rCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ClienteIDlabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Nombrelabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ClienteErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.NuevoButton = new System.Windows.Forms.Button();
            this.ModificarButton = new System.Windows.Forms.Button();
            this.GuadarButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.ClienteIdtextBox = new System.Windows.Forms.TextBox();
            this.NombretextBox = new System.Windows.Forms.TextBox();
            this.DireciontextBox = new System.Windows.Forms.TextBox();
            this.EmailtextBox = new System.Windows.Forms.TextBox();
            this.ApellidotextBox = new System.Windows.Forms.TextBox();
            this.TellMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.CedulaMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ClienteErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // ClienteIDlabel
            // 
            this.ClienteIDlabel.AutoSize = true;
            this.ClienteIDlabel.Location = new System.Drawing.Point(38, 50);
            this.ClienteIDlabel.Name = "ClienteIDlabel";
            this.ClienteIDlabel.Size = new System.Drawing.Size(53, 13);
            this.ClienteIDlabel.TabIndex = 0;
            this.ClienteIDlabel.Text = "ClienteID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellidos:";
            // 
            // Nombrelabel
            // 
            this.Nombrelabel.AutoSize = true;
            this.Nombrelabel.Location = new System.Drawing.Point(38, 72);
            this.Nombrelabel.Name = "Nombrelabel";
            this.Nombrelabel.Size = new System.Drawing.Size(47, 13);
            this.Nombrelabel.TabIndex = 2;
            this.Nombrelabel.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cedula:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Telefono:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Email:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Direccion:";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 23);
            this.label8.TabIndex = 8;
            // 
            // ClienteErrorProvider
            // 
            this.ClienteErrorProvider.ContainerControl = this;
            // 
            // NuevoButton
            // 
            this.NuevoButton.Location = new System.Drawing.Point(25, 281);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(75, 23);
            this.NuevoButton.TabIndex = 9;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // ModificarButton
            // 
            this.ModificarButton.Enabled = false;
            this.ModificarButton.Location = new System.Drawing.Point(122, 281);
            this.ModificarButton.Name = "ModificarButton";
            this.ModificarButton.Size = new System.Drawing.Size(75, 23);
            this.ModificarButton.TabIndex = 10;
            this.ModificarButton.Text = "Modificar";
            this.ModificarButton.UseVisualStyleBackColor = true;
            this.ModificarButton.Click += new System.EventHandler(this.ModificarButton_Click);
            // 
            // GuadarButton
            // 
            this.GuadarButton.Enabled = false;
            this.GuadarButton.Location = new System.Drawing.Point(221, 281);
            this.GuadarButton.Name = "GuadarButton";
            this.GuadarButton.Size = new System.Drawing.Size(75, 23);
            this.GuadarButton.TabIndex = 11;
            this.GuadarButton.Text = "Guardar";
            this.GuadarButton.UseVisualStyleBackColor = true;
            this.GuadarButton.Click += new System.EventHandler(this.GuadarButton_Click);
            // 
            // EliminarButton
            // 
            this.EliminarButton.Enabled = false;
            this.EliminarButton.Location = new System.Drawing.Point(312, 281);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(75, 23);
            this.EliminarButton.TabIndex = 12;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // ClienteIdtextBox
            // 
            this.ClienteIdtextBox.Location = new System.Drawing.Point(112, 43);
            this.ClienteIdtextBox.Name = "ClienteIdtextBox";
            this.ClienteIdtextBox.Size = new System.Drawing.Size(85, 20);
            this.ClienteIdtextBox.TabIndex = 13;
            this.ClienteIdtextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ClienteIdtextBox_KeyPress);
            // 
            // NombretextBox
            // 
            this.NombretextBox.Location = new System.Drawing.Point(112, 69);
            this.NombretextBox.Name = "NombretextBox";
            this.NombretextBox.Size = new System.Drawing.Size(194, 20);
            this.NombretextBox.TabIndex = 14;
            this.NombretextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NombretextBox_KeyPress);
            // 
            // DireciontextBox
            // 
            this.DireciontextBox.Location = new System.Drawing.Point(112, 217);
            this.DireciontextBox.Name = "DireciontextBox";
            this.DireciontextBox.Size = new System.Drawing.Size(275, 20);
            this.DireciontextBox.TabIndex = 15;
            // 
            // EmailtextBox
            // 
            this.EmailtextBox.Location = new System.Drawing.Point(112, 189);
            this.EmailtextBox.Name = "EmailtextBox";
            this.EmailtextBox.Size = new System.Drawing.Size(275, 20);
            this.EmailtextBox.TabIndex = 16;
            this.EmailtextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EmailtextBox_KeyPress);
            // 
            // ApellidotextBox
            // 
            this.ApellidotextBox.Location = new System.Drawing.Point(112, 100);
            this.ApellidotextBox.Name = "ApellidotextBox";
            this.ApellidotextBox.Size = new System.Drawing.Size(194, 20);
            this.ApellidotextBox.TabIndex = 17;
            this.ApellidotextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ApellidotextBox_KeyPress);
            // 
            // TellMaskedTextBox
            // 
            this.TellMaskedTextBox.Location = new System.Drawing.Point(112, 161);
            this.TellMaskedTextBox.Mask = "000-000-0000";
            this.TellMaskedTextBox.Name = "TellMaskedTextBox";
            this.TellMaskedTextBox.Size = new System.Drawing.Size(85, 20);
            this.TellMaskedTextBox.TabIndex = 18;
            this.TellMaskedTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TellMaskedTextBox_KeyPress);
            // 
            // BuscarButton
            // 
            this.BuscarButton.Location = new System.Drawing.Point(231, 40);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(75, 23);
            this.BuscarButton.TabIndex = 22;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // CedulaMaskedTextBox
            // 
            this.CedulaMaskedTextBox.Location = new System.Drawing.Point(112, 133);
            this.CedulaMaskedTextBox.Mask = "000-0000000-0";
            this.CedulaMaskedTextBox.Name = "CedulaMaskedTextBox";
            this.CedulaMaskedTextBox.Size = new System.Drawing.Size(85, 20);
            this.CedulaMaskedTextBox.TabIndex = 23;
            this.CedulaMaskedTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CedulaMaskedTextBox_KeyPress);
            // 
            // rCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 326);
            this.Controls.Add(this.CedulaMaskedTextBox);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.TellMaskedTextBox);
            this.Controls.Add(this.ApellidotextBox);
            this.Controls.Add(this.EmailtextBox);
            this.Controls.Add(this.DireciontextBox);
            this.Controls.Add(this.NombretextBox);
            this.Controls.Add(this.ClienteIdtextBox);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.GuadarButton);
            this.Controls.Add(this.ModificarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Nombrelabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ClienteIDlabel);
            this.MaximizeBox = false;
            this.Name = "rCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Cliente.";
            this.Load += new System.EventHandler(this.rCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClienteErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ClienteIDlabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Nombrelabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ErrorProvider ClienteErrorProvider;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.MaskedTextBox TellMaskedTextBox;
        private System.Windows.Forms.TextBox ApellidotextBox;
        private System.Windows.Forms.TextBox EmailtextBox;
        private System.Windows.Forms.TextBox DireciontextBox;
        private System.Windows.Forms.TextBox NombretextBox;
        private System.Windows.Forms.TextBox ClienteIdtextBox;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button GuadarButton;
        private System.Windows.Forms.Button ModificarButton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.MaskedTextBox CedulaMaskedTextBox;
    }
}