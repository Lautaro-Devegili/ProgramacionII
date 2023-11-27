namespace CineFront.Presentacion
{
    partial class frmNuevoCliente
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
            btnCancelar = new Button();
            btnAgregar = new Button();
            txtTelefono = new TextBox();
            lblTelefono = new Label();
            dtpFechaNac = new DateTimePicker();
            lblFechaNac = new Label();
            cboSexo = new ComboBox();
            lblSexo = new Label();
            txtDocumento = new TextBox();
            lblDocumento = new Label();
            lblTipo = new Label();
            cboTipo = new ComboBox();
            lblIdCliente = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            lblApellido = new Label();
            lblNombre = new Label();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(34, 380);
            btnCancelar.Margin = new Padding(4, 3, 4, 3);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(88, 27);
            btnCancelar.TabIndex = 68;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(217, 380);
            btnAgregar.Margin = new Padding(4, 3, 4, 3);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(88, 27);
            btnAgregar.TabIndex = 67;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click_1;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(129, 324);
            txtTelefono.Margin = new Padding(4, 3, 4, 3);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(176, 23);
            txtTelefono.TabIndex = 66;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(64, 328);
            lblTelefono.Margin = new Padding(4, 0, 4, 0);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(52, 15);
            lblTelefono.TabIndex = 65;
            lblTelefono.Text = "Telefono";
            // 
            // dtpFechaNac
            // 
            dtpFechaNac.Format = DateTimePickerFormat.Short;
            dtpFechaNac.Location = new Point(129, 275);
            dtpFechaNac.Margin = new Padding(4, 3, 4, 3);
            dtpFechaNac.Name = "dtpFechaNac";
            dtpFechaNac.Size = new Size(111, 23);
            dtpFechaNac.TabIndex = 64;
            // 
            // lblFechaNac
            // 
            lblFechaNac.AutoSize = true;
            lblFechaNac.Location = new Point(3, 281);
            lblFechaNac.Margin = new Padding(4, 0, 4, 0);
            lblFechaNac.Name = "lblFechaNac";
            lblFechaNac.Size = new Size(119, 15);
            lblFechaNac.TabIndex = 63;
            lblFechaNac.Text = "Fecha de Nacimiento";
            // 
            // cboSexo
            // 
            cboSexo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSexo.FormattingEnabled = true;
            cboSexo.Location = new Point(129, 227);
            cboSexo.Margin = new Padding(4, 3, 4, 3);
            cboSexo.Name = "cboSexo";
            cboSexo.Size = new Size(176, 23);
            cboSexo.TabIndex = 62;
            // 
            // lblSexo
            // 
            lblSexo.AutoSize = true;
            lblSexo.Location = new Point(85, 231);
            lblSexo.Margin = new Padding(4, 0, 4, 0);
            lblSexo.Name = "lblSexo";
            lblSexo.Size = new Size(32, 15);
            lblSexo.TabIndex = 61;
            lblSexo.Text = "Sexo";
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new Point(129, 181);
            txtDocumento.Margin = new Padding(4, 3, 4, 3);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(176, 23);
            txtDocumento.TabIndex = 60;
            // 
            // lblDocumento
            // 
            lblDocumento.AutoSize = true;
            lblDocumento.Location = new Point(49, 181);
            lblDocumento.Margin = new Padding(4, 0, 4, 0);
            lblDocumento.Name = "lblDocumento";
            lblDocumento.Size = new Size(70, 15);
            lblDocumento.TabIndex = 59;
            lblDocumento.Text = "Documento";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(4, 141);
            lblTipo.Margin = new Padding(4, 0, 4, 0);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(112, 15);
            lblTipo.TabIndex = 58;
            lblTipo.Text = "Tipo de Documento";
            // 
            // cboTipo
            // 
            cboTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipo.FormattingEnabled = true;
            cboTipo.Location = new Point(129, 137);
            cboTipo.Margin = new Padding(4, 3, 4, 3);
            cboTipo.Name = "cboTipo";
            cboTipo.Size = new Size(176, 23);
            cboTipo.TabIndex = 57;
            // 
            // lblIdCliente
            // 
            lblIdCliente.AutoSize = true;
            lblIdCliente.Location = new Point(13, 9);
            lblIdCliente.Margin = new Padding(4, 0, 4, 0);
            lblIdCliente.Name = "lblIdCliente";
            lblIdCliente.Size = new Size(61, 15);
            lblIdCliente.TabIndex = 56;
            lblIdCliente.Text = "Cliente N°";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(129, 87);
            txtNombre.Margin = new Padding(4, 3, 4, 3);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(176, 23);
            txtNombre.TabIndex = 55;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(129, 46);
            txtApellido.Margin = new Padding(4, 3, 4, 3);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(176, 23);
            txtApellido.TabIndex = 54;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(70, 50);
            lblApellido.Margin = new Padding(4, 0, 4, 0);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(51, 15);
            lblApellido.TabIndex = 53;
            lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(70, 90);
            lblNombre.Margin = new Padding(4, 0, 4, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 52;
            lblNombre.Text = "Nombre";
            // 
            // frmNuevoCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(333, 438);
            Controls.Add(btnCancelar);
            Controls.Add(btnAgregar);
            Controls.Add(txtTelefono);
            Controls.Add(lblTelefono);
            Controls.Add(dtpFechaNac);
            Controls.Add(lblFechaNac);
            Controls.Add(cboSexo);
            Controls.Add(lblSexo);
            Controls.Add(txtDocumento);
            Controls.Add(lblDocumento);
            Controls.Add(lblTipo);
            Controls.Add(cboTipo);
            Controls.Add(lblIdCliente);
            Controls.Add(txtNombre);
            Controls.Add(txtApellido);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Name = "frmNuevoCliente";
            Text = "frmNuevoCliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnAgregar;
        private TextBox txtTelefono;
        private Label lblTelefono;
        private DateTimePicker dtpFechaNac;
        private Label lblFechaNac;
        private ComboBox cboSexo;
        private Label lblSexo;
        private TextBox txtDocumento;
        private Label lblDocumento;
        private Label lblTipo;
        private ComboBox cboTipo;
        private Label lblIdCliente;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private Label lblApellido;
        private Label lblNombre;
    }
}