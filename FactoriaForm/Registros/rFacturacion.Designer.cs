namespace FactoriaForm.Registros
{
    partial class rFacturacion
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Peso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.GuadarButton = new System.Windows.Forms.Button();
            this.ModificarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.FactIdtextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CantidadtextBox = new System.Windows.Forms.TextBox();
            this.PrecioTextBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.Nombrelabel = new System.Windows.Forms.Label();
            this.Cantidadlabel = new System.Windows.Forms.Label();
            this.Pesolabel = new System.Windows.Forms.Label();
            this.Preciolabel = new System.Windows.Forms.Label();
            this.FechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Fechalabel = new System.Windows.Forms.Label();
            this.FacturacionErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.TotalTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NombreComboBox = new System.Windows.Forms.ComboBox();
            this.TipoFacturaComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PesocomboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FacturacionErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cantidad,
            this.Peso,
            this.Precio});
            this.dataGridView.Location = new System.Drawing.Point(42, 157);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(410, 150);
            this.dataGridView.TabIndex = 0;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // Peso
            // 
            this.Peso.HeaderText = "Peso";
            this.Peso.Name = "Peso";
            this.Peso.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(218, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 27;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EliminarButton
            // 
            this.EliminarButton.Enabled = false;
            this.EliminarButton.Location = new System.Drawing.Point(376, 356);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(75, 23);
            this.EliminarButton.TabIndex = 26;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // GuadarButton
            // 
            this.GuadarButton.Enabled = false;
            this.GuadarButton.Location = new System.Drawing.Point(258, 356);
            this.GuadarButton.Name = "GuadarButton";
            this.GuadarButton.Size = new System.Drawing.Size(75, 23);
            this.GuadarButton.TabIndex = 25;
            this.GuadarButton.Text = "Guardar";
            this.GuadarButton.UseVisualStyleBackColor = true;
            this.GuadarButton.Click += new System.EventHandler(this.GuadarButton_Click);
            // 
            // ModificarButton
            // 
            this.ModificarButton.Enabled = false;
            this.ModificarButton.Location = new System.Drawing.Point(137, 356);
            this.ModificarButton.Name = "ModificarButton";
            this.ModificarButton.Size = new System.Drawing.Size(75, 23);
            this.ModificarButton.TabIndex = 24;
            this.ModificarButton.Text = "Modificar";
            this.ModificarButton.UseVisualStyleBackColor = true;
            this.ModificarButton.Click += new System.EventHandler(this.ModificarButton_Click);
            // 
            // NuevoButton
            // 
            this.NuevoButton.Location = new System.Drawing.Point(33, 356);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(75, 23);
            this.NuevoButton.TabIndex = 23;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // FactIdtextBox
            // 
            this.FactIdtextBox.Location = new System.Drawing.Point(112, 43);
            this.FactIdtextBox.Name = "FactIdtextBox";
            this.FactIdtextBox.Size = new System.Drawing.Size(65, 20);
            this.FactIdtextBox.TabIndex = 28;
            this.FactIdtextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FactIdtextBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "FacturaID";
            // 
            // CantidadtextBox
            // 
            this.CantidadtextBox.Location = new System.Drawing.Point(42, 130);
            this.CantidadtextBox.Name = "CantidadtextBox";
            this.CantidadtextBox.Size = new System.Drawing.Size(153, 20);
            this.CantidadtextBox.TabIndex = 31;
            this.CantidadtextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CantidadtextBox_KeyPress);
            // 
            // PrecioTextBox
            // 
            this.PrecioTextBox.Location = new System.Drawing.Point(299, 131);
            this.PrecioTextBox.Name = "PrecioTextBox";
            this.PrecioTextBox.Size = new System.Drawing.Size(97, 20);
            this.PrecioTextBox.TabIndex = 33;
            this.PrecioTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PrecioTextBox_KeyPress);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(403, 127);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(58, 23);
            this.AddButton.TabIndex = 34;
            this.AddButton.Text = "Añadir";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // Nombrelabel
            // 
            this.Nombrelabel.AutoSize = true;
            this.Nombrelabel.Location = new System.Drawing.Point(42, 78);
            this.Nombrelabel.Name = "Nombrelabel";
            this.Nombrelabel.Size = new System.Drawing.Size(44, 13);
            this.Nombrelabel.TabIndex = 35;
            this.Nombrelabel.Text = "Nombre";
            // 
            // Cantidadlabel
            // 
            this.Cantidadlabel.AutoSize = true;
            this.Cantidadlabel.Location = new System.Drawing.Point(42, 114);
            this.Cantidadlabel.Name = "Cantidadlabel";
            this.Cantidadlabel.Size = new System.Drawing.Size(49, 13);
            this.Cantidadlabel.TabIndex = 36;
            this.Cantidadlabel.Text = "Cantidad";
            // 
            // Pesolabel
            // 
            this.Pesolabel.AutoSize = true;
            this.Pesolabel.Location = new System.Drawing.Point(203, 114);
            this.Pesolabel.Name = "Pesolabel";
            this.Pesolabel.Size = new System.Drawing.Size(31, 13);
            this.Pesolabel.TabIndex = 37;
            this.Pesolabel.Text = "Peso";
            // 
            // Preciolabel
            // 
            this.Preciolabel.AutoSize = true;
            this.Preciolabel.Location = new System.Drawing.Point(296, 114);
            this.Preciolabel.Name = "Preciolabel";
            this.Preciolabel.Size = new System.Drawing.Size(37, 13);
            this.Preciolabel.TabIndex = 38;
            this.Preciolabel.Text = "Precio";
            // 
            // FechaDateTimePicker
            // 
            this.FechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaDateTimePicker.Location = new System.Drawing.Point(376, 39);
            this.FechaDateTimePicker.Name = "FechaDateTimePicker";
            this.FechaDateTimePicker.Size = new System.Drawing.Size(102, 20);
            this.FechaDateTimePicker.TabIndex = 39;
            // 
            // Fechalabel
            // 
            this.Fechalabel.AutoSize = true;
            this.Fechalabel.Location = new System.Drawing.Point(330, 41);
            this.Fechalabel.Name = "Fechalabel";
            this.Fechalabel.Size = new System.Drawing.Size(40, 13);
            this.Fechalabel.TabIndex = 40;
            this.Fechalabel.Text = "Fecha:";
            // 
            // FacturacionErrorProvider
            // 
            this.FacturacionErrorProvider.ContainerControl = this;
            // 
            // TotalTextBox
            // 
            this.TotalTextBox.Location = new System.Drawing.Point(352, 313);
            this.TotalTextBox.Name = "TotalTextBox";
            this.TotalTextBox.ReadOnly = true;
            this.TotalTextBox.Size = new System.Drawing.Size(100, 20);
            this.TotalTextBox.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(312, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Total:";
            // 
            // NombreComboBox
            // 
            this.NombreComboBox.Enabled = false;
            this.NombreComboBox.FormattingEnabled = true;
            this.NombreComboBox.Location = new System.Drawing.Point(112, 75);
            this.NombreComboBox.Name = "NombreComboBox";
            this.NombreComboBox.Size = new System.Drawing.Size(100, 21);
            this.NombreComboBox.TabIndex = 43;
            // 
            // TipoFacturaComboBox
            // 
            this.TipoFacturaComboBox.FormattingEnabled = true;
            this.TipoFacturaComboBox.Items.AddRange(new object[] {
            "Contado",
            "Credito"});
            this.TipoFacturaComboBox.Location = new System.Drawing.Point(339, 75);
            this.TipoFacturaComboBox.Name = "TipoFacturaComboBox";
            this.TipoFacturaComboBox.Size = new System.Drawing.Size(102, 21);
            this.TipoFacturaComboBox.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(248, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "Tipo de Factura:";
            // 
            // PesocomboBox
            // 
            this.PesocomboBox.FormattingEnabled = true;
            this.PesocomboBox.Items.AddRange(new object[] {
            "150 lb",
            "125 lb",
            "100 lb",
            "50 lb",
            "25 lb"});
            this.PesocomboBox.Location = new System.Drawing.Point(201, 130);
            this.PesocomboBox.Name = "PesocomboBox";
            this.PesocomboBox.Size = new System.Drawing.Size(92, 21);
            this.PesocomboBox.TabIndex = 46;
            // 
            // rFacturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 402);
            this.Controls.Add(this.PesocomboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TipoFacturaComboBox);
            this.Controls.Add(this.NombreComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TotalTextBox);
            this.Controls.Add(this.Fechalabel);
            this.Controls.Add(this.FechaDateTimePicker);
            this.Controls.Add(this.Preciolabel);
            this.Controls.Add(this.Pesolabel);
            this.Controls.Add(this.Cantidadlabel);
            this.Controls.Add(this.Nombrelabel);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.PrecioTextBox);
            this.Controls.Add(this.CantidadtextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FactIdtextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.GuadarButton);
            this.Controls.Add(this.ModificarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.dataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "rFacturacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facturacion";
            this.Load += new System.EventHandler(this.rFacturacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FacturacionErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button GuadarButton;
        private System.Windows.Forms.Button ModificarButton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.TextBox FactIdtextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CantidadtextBox;
        private System.Windows.Forms.TextBox PrecioTextBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label Nombrelabel;
        private System.Windows.Forms.Label Cantidadlabel;
        private System.Windows.Forms.Label Pesolabel;
        private System.Windows.Forms.Label Preciolabel;
        private System.Windows.Forms.DateTimePicker FechaDateTimePicker;
        private System.Windows.Forms.Label Fechalabel;
        private System.Windows.Forms.ErrorProvider FacturacionErrorProvider;
        private System.Windows.Forms.ComboBox PesocomboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox TipoFacturaComboBox;
        private System.Windows.Forms.ComboBox NombreComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TotalTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Peso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
    }
}