namespace CineFront.Presentacion
{
    partial class frmEditarCliente
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
            label3 = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            lblApellido = new Label();
            lblNombre = new Label();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(66, 380);
            btnCancelar.Margin = new Padding(4, 3, 4, 3);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(88, 27);
            btnCancelar.TabIndex = 34;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(249, 380);
            btnAgregar.Margin = new Padding(4, 3, 4, 3);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(88, 27);
            btnAgregar.TabIndex = 33;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(161, 324);
            txtTelefono.Margin = new Padding(4, 3, 4, 3);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(176, 23);
            txtTelefono.TabIndex = 32;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(96, 328);
            lblTelefono.Margin = new Padding(4, 0, 4, 0);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(52, 15);
            lblTelefono.TabIndex = 31;
            lblTelefono.Text = "Telefono";
            // 
            // dtpFechaNac
            // 
            dtpFechaNac.Format = DateTimePickerFormat.Short;
            dtpFechaNac.Location = new Point(161, 275);
            dtpFechaNac.Margin = new Padding(4, 3, 4, 3);
            dtpFechaNac.Name = "dtpFechaNac";
            dtpFechaNac.Size = new Size(111, 23);
            dtpFechaNac.TabIndex = 30;
            // 
            // lblFechaNac
            // 
            lblFechaNac.AutoSize = true;
            lblFechaNac.Location = new Point(28, 282);
            lblFechaNac.Margin = new Padding(4, 0, 4, 0);
            lblFechaNac.Name = "lblFechaNac";
            lblFechaNac.Size = new Size(119, 15);
            lblFechaNac.TabIndex = 29;
            lblFechaNac.Text = "Fecha de Nacimiento";
            // 
            // cboSexo
            // 
            cboSexo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSexo.FormattingEnabled = true;
            cboSexo.Location = new Point(161, 227);
            cboSexo.Margin = new Padding(4, 3, 4, 3);
            cboSexo.Name = "cboSexo";
            cboSexo.Size = new Size(176, 23);
            cboSexo.TabIndex = 28;
            // 
            // lblSexo
            // 
            lblSexo.AutoSize = true;
            lblSexo.Location = new Point(117, 231);
            lblSexo.Margin = new Padding(4, 0, 4, 0);
            lblSexo.Name = "lblSexo";
            lblSexo.Size = new Size(32, 15);
            lblSexo.TabIndex = 27;
            lblSexo.Text = "Sexo";
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new Point(161, 181);
            txtDocumento.Margin = new Padding(4, 3, 4, 3);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(176, 23);
            txtDocumento.TabIndex = 26;
            // 
            // lblDocumento
            // 
            lblDocumento.AutoSize = true;
            lblDocumento.Location = new Point(81, 181);
            lblDocumento.Margin = new Padding(4, 0, 4, 0);
            lblDocumento.Name = "lblDocumento";
            lblDocumento.Size = new Size(70, 15);
            lblDocumento.TabIndex = 25;
            lblDocumento.Text = "Documento";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(36, 141);
            lblTipo.Margin = new Padding(4, 0, 4, 0);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(112, 15);
            lblTipo.TabIndex = 24;
            lblTipo.Text = "Tipo de Documento";
            // 
            // cboTipo
            // 
            cboTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipo.FormattingEnabled = true;
            cboTipo.Location = new Point(161, 137);
            cboTipo.Margin = new Padding(4, 3, 4, 3);
            cboTipo.Name = "cboTipo";
            cboTipo.Size = new Size(176, 23);
            cboTipo.TabIndex = 23;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 9);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 22;
            label3.Text = "Cliente N°";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(161, 87);
            txtNombre.Margin = new Padding(4, 3, 4, 3);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(176, 23);
            txtNombre.TabIndex = 21;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(161, 46);
            txtApellido.Margin = new Padding(4, 3, 4, 3);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(176, 23);
            txtApellido.TabIndex = 20;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(102, 50);
            lblApellido.Margin = new Padding(4, 0, 4, 0);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(51, 15);
            lblApellido.TabIndex = 19;
            lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(102, 90);
            lblNombre.Margin = new Padding(4, 0, 4, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 18;
            lblNombre.Text = "Nombre";
            // 
            // frmEditarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(385, 437);
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
            Controls.Add(label3);
            Controls.Add(txtNombre);
            Controls.Add(txtApellido);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Name = "frmEditarCliente";
            Text = "frmEditarCliente";
            Load += frmEditarCliente_Load;
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
        private Label label3;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private Label lblApellido;
        private Label lblNombre;
    }
}