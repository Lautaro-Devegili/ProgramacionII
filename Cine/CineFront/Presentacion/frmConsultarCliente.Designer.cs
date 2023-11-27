namespace CineFront.Presentacion
{
    partial class frmConsultarCliente
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
            rbtOtro = new RadioButton();
            btnBuscar = new Button();
            rbtFemenino = new RadioButton();
            rbtMasculino = new RadioButton();
            txtDocumento = new TextBox();
            txtNombre = new TextBox();
            lblBSexo = new Label();
            lblBDoc = new Label();
            lblBCliente = new Label();
            btnVerDetalles = new Button();
            btnCancelar = new Button();
            btnAceptar = new Button();
            dgvDetalleC = new DataGridView();
            ColId = new DataGridViewTextBoxColumn();
            ColApellido = new DataGridViewTextBoxColumn();
            ColNombre = new DataGridViewTextBoxColumn();
            ColTipoDoc = new DataGridViewTextBoxColumn();
            ColDocumento = new DataGridViewTextBoxColumn();
            ColFechaNac = new DataGridViewTextBoxColumn();
            ColNroTelefono = new DataGridViewTextBoxColumn();
            ColIdSexo = new DataGridViewTextBoxColumn();
            ColAcciones = new DataGridViewButtonColumn();
            ColEliminar = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgvDetalleC).BeginInit();
            SuspendLayout();
            // 
            // rbtOtro
            // 
            rbtOtro.AutoSize = true;
            rbtOtro.Location = new Point(330, 158);
            rbtOtro.Margin = new Padding(4, 3, 4, 3);
            rbtOtro.Name = "rbtOtro";
            rbtOtro.Size = new Size(49, 19);
            rbtOtro.TabIndex = 27;
            rbtOtro.TabStop = true;
            rbtOtro.Text = "Otro";
            rbtOtro.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(942, 150);
            btnBuscar.Margin = new Padding(4, 3, 4, 3);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(111, 37);
            btnBuscar.TabIndex = 26;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // rbtFemenino
            // 
            rbtFemenino.AutoSize = true;
            rbtFemenino.Location = new Point(226, 159);
            rbtFemenino.Margin = new Padding(4, 3, 4, 3);
            rbtFemenino.Name = "rbtFemenino";
            rbtFemenino.Size = new Size(78, 19);
            rbtFemenino.TabIndex = 25;
            rbtFemenino.TabStop = true;
            rbtFemenino.Text = "Femenino";
            rbtFemenino.UseVisualStyleBackColor = true;
            // 
            // rbtMasculino
            // 
            rbtMasculino.AutoSize = true;
            rbtMasculino.Location = new Point(128, 159);
            rbtMasculino.Margin = new Padding(4, 3, 4, 3);
            rbtMasculino.Name = "rbtMasculino";
            rbtMasculino.Size = new Size(80, 19);
            rbtMasculino.TabIndex = 24;
            rbtMasculino.TabStop = true;
            rbtMasculino.Text = "Masculino";
            rbtMasculino.UseVisualStyleBackColor = true;
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new Point(128, 93);
            txtDocumento.Margin = new Padding(4, 3, 4, 3);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(383, 23);
            txtDocumento.TabIndex = 23;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(128, 33);
            txtNombre.Margin = new Padding(4, 3, 4, 3);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(473, 23);
            txtNombre.TabIndex = 22;
            // 
            // lblBSexo
            // 
            lblBSexo.AutoSize = true;
            lblBSexo.Location = new Point(81, 161);
            lblBSexo.Margin = new Padding(4, 0, 4, 0);
            lblBSexo.Name = "lblBSexo";
            lblBSexo.Size = new Size(35, 15);
            lblBSexo.TabIndex = 21;
            lblBSexo.Text = "Sexo:";
            // 
            // lblBDoc
            // 
            lblBDoc.AutoSize = true;
            lblBDoc.Location = new Point(45, 98);
            lblBDoc.Margin = new Padding(4, 0, 4, 0);
            lblBDoc.Name = "lblBDoc";
            lblBDoc.Size = new Size(73, 15);
            lblBDoc.TabIndex = 20;
            lblBDoc.Text = "Documento:";
            // 
            // lblBCliente
            // 
            lblBCliente.AutoSize = true;
            lblBCliente.Location = new Point(72, 38);
            lblBCliente.Margin = new Padding(4, 0, 4, 0);
            lblBCliente.Name = "lblBCliente";
            lblBCliente.Size = new Size(47, 15);
            lblBCliente.TabIndex = 19;
            lblBCliente.Text = "Cliente:";
            // 
            // btnVerDetalles
            // 
            btnVerDetalles.Location = new Point(502, 460);
            btnVerDetalles.Margin = new Padding(4, 3, 4, 3);
            btnVerDetalles.Name = "btnVerDetalles";
            btnVerDetalles.Size = new Size(98, 46);
            btnVerDetalles.TabIndex = 18;
            btnVerDetalles.Text = "Ver Detalles";
            btnVerDetalles.UseVisualStyleBackColor = true;
            btnVerDetalles.Click += btnVerDetalles_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(214, 460);
            btnCancelar.Margin = new Padding(4, 3, 4, 3);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(98, 46);
            btnCancelar.TabIndex = 17;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(775, 460);
            btnAceptar.Margin = new Padding(4, 3, 4, 3);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(98, 46);
            btnAceptar.TabIndex = 16;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // dgvDetalleC
            // 
            dgvDetalleC.AllowUserToAddRows = false;
            dgvDetalleC.AllowUserToDeleteRows = false;
            dgvDetalleC.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalleC.Columns.AddRange(new DataGridViewColumn[] { ColId, ColApellido, ColNombre, ColTipoDoc, ColDocumento, ColFechaNac, ColNroTelefono, ColIdSexo, ColAcciones, ColEliminar });
            dgvDetalleC.Location = new Point(50, 227);
            dgvDetalleC.Margin = new Padding(4, 3, 4, 3);
            dgvDetalleC.Name = "dgvDetalleC";
            dgvDetalleC.ReadOnly = true;
            dgvDetalleC.RowHeadersWidth = 51;
            dgvDetalleC.Size = new Size(1003, 210);
            dgvDetalleC.TabIndex = 15;
            dgvDetalleC.CellContentClick += dgvDetalleC_CellContentClick;
            // 
            // ColId
            // 
            ColId.HeaderText = "ID";
            ColId.MinimumWidth = 6;
            ColId.Name = "ColId";
            ColId.ReadOnly = true;
            ColId.Visible = false;
            ColId.Width = 125;
            // 
            // ColApellido
            // 
            ColApellido.HeaderText = "Apellido";
            ColApellido.MinimumWidth = 6;
            ColApellido.Name = "ColApellido";
            ColApellido.ReadOnly = true;
            // 
            // ColNombre
            // 
            ColNombre.HeaderText = "Nombre";
            ColNombre.MinimumWidth = 6;
            ColNombre.Name = "ColNombre";
            ColNombre.ReadOnly = true;
            // 
            // ColTipoDoc
            // 
            ColTipoDoc.HeaderText = "Tipo Doc.";
            ColTipoDoc.MinimumWidth = 6;
            ColTipoDoc.Name = "ColTipoDoc";
            ColTipoDoc.ReadOnly = true;
            ColTipoDoc.Width = 80;
            // 
            // ColDocumento
            // 
            ColDocumento.HeaderText = "Documento";
            ColDocumento.MinimumWidth = 6;
            ColDocumento.Name = "ColDocumento";
            ColDocumento.ReadOnly = true;
            // 
            // ColFechaNac
            // 
            ColFechaNac.HeaderText = "Fecha Nac.";
            ColFechaNac.MinimumWidth = 6;
            ColFechaNac.Name = "ColFechaNac";
            ColFechaNac.ReadOnly = true;
            // 
            // ColNroTelefono
            // 
            ColNroTelefono.HeaderText = "Nro Tel.";
            ColNroTelefono.MinimumWidth = 6;
            ColNroTelefono.Name = "ColNroTelefono";
            ColNroTelefono.ReadOnly = true;
            // 
            // ColIdSexo
            // 
            ColIdSexo.HeaderText = "Sexo";
            ColIdSexo.MinimumWidth = 6;
            ColIdSexo.Name = "ColIdSexo";
            ColIdSexo.ReadOnly = true;
            ColIdSexo.Width = 50;
            // 
            // ColAcciones
            // 
            ColAcciones.HeaderText = "";
            ColAcciones.MinimumWidth = 6;
            ColAcciones.Name = "ColAcciones";
            ColAcciones.ReadOnly = true;
            ColAcciones.Width = 80;
            // 
            // ColEliminar
            // 
            ColEliminar.HeaderText = "";
            ColEliminar.Name = "ColEliminar";
            ColEliminar.ReadOnly = true;
            ColEliminar.Width = 80;
            // 
            // frmConsultarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1099, 539);
            Controls.Add(rbtOtro);
            Controls.Add(btnBuscar);
            Controls.Add(rbtFemenino);
            Controls.Add(rbtMasculino);
            Controls.Add(txtDocumento);
            Controls.Add(txtNombre);
            Controls.Add(lblBSexo);
            Controls.Add(lblBDoc);
            Controls.Add(lblBCliente);
            Controls.Add(btnVerDetalles);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(dgvDetalleC);
            Name = "frmConsultarCliente";
            Text = "frmConsultarCliente";
            Load += frmConsultarCliente_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDetalleC).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton rbtOtro;
        private Button btnBuscar;
        private RadioButton rbtFemenino;
        private RadioButton rbtMasculino;
        private TextBox txtDocumento;
        private TextBox txtNombre;
        private Label lblBSexo;
        private Label lblBDoc;
        private Label lblBCliente;
        private Button btnVerDetalles;
        private Button btnCancelar;
        private Button btnAceptar;
        private DataGridView dgvDetalleC;
        private DataGridViewTextBoxColumn ColId;
        private DataGridViewTextBoxColumn ColApellido;
        private DataGridViewTextBoxColumn ColNombre;
        private DataGridViewTextBoxColumn ColTipoDoc;
        private DataGridViewTextBoxColumn ColDocumento;
        private DataGridViewTextBoxColumn ColFechaNac;
        private DataGridViewTextBoxColumn ColNroTelefono;
        private DataGridViewTextBoxColumn ColIdSexo;
        private DataGridViewButtonColumn ColAcciones;
        private DataGridViewButtonColumn ColEliminar;
    }
}