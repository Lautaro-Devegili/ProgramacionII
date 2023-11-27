namespace CineFront.Presentacion
{
    partial class ConsultarCompras
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
            txtIdCliente = new TextBox();
            lblBDoc = new Label();
            lblApellidoC = new Label();
            dtpCompra = new DateTimePicker();
            dgvConsultarCompra = new DataGridView();
            ColNroCompra = new DataGridViewTextBoxColumn();
            ColIdFormaPago = new DataGridViewTextBoxColumn();
            ColIdCliente = new DataGridViewTextBoxColumn();
            ColApeCliente = new DataGridViewTextBoxColumn();
            ColFechaCompra = new DataGridViewTextBoxColumn();
            ColEstado = new DataGridViewTextBoxColumn();
            ColAccion1 = new DataGridViewButtonColumn();
            ColAccion2 = new DataGridViewButtonColumn();
            btnConsultar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvConsultarCompra).BeginInit();
            SuspendLayout();
            // 
            // txtIdCliente
            // 
            txtIdCliente.Location = new Point(120, 46);
            txtIdCliente.Margin = new Padding(4, 3, 4, 3);
            txtIdCliente.Name = "txtIdCliente";
            txtIdCliente.Size = new Size(126, 23);
            txtIdCliente.TabIndex = 26;
            // 
            // lblBDoc
            // 
            lblBDoc.AutoSize = true;
            lblBDoc.Location = new Point(315, 49);
            lblBDoc.Margin = new Padding(4, 0, 4, 0);
            lblBDoc.Name = "lblBDoc";
            lblBDoc.Size = new Size(103, 15);
            lblBDoc.TabIndex = 25;
            lblBDoc.Text = "Fecha de Compra ";
            // 
            // lblApellidoC
            // 
            lblApellidoC.AutoSize = true;
            lblApellidoC.Location = new Point(33, 46);
            lblApellidoC.Margin = new Padding(4, 0, 4, 0);
            lblApellidoC.Name = "lblApellidoC";
            lblApellidoC.Size = new Size(79, 15);
            lblApellidoC.TabIndex = 24;
            lblApellidoC.Text = "Id del Cliente ";
            // 
            // dtpCompra
            // 
            dtpCompra.Format = DateTimePickerFormat.Short;
            dtpCompra.Location = new Point(425, 49);
            dtpCompra.Name = "dtpCompra";
            dtpCompra.Size = new Size(126, 23);
            dtpCompra.TabIndex = 27;
            // 
            // dgvConsultarCompra
            // 
            dgvConsultarCompra.AllowUserToAddRows = false;
            dgvConsultarCompra.AllowUserToDeleteRows = false;
            dgvConsultarCompra.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConsultarCompra.Columns.AddRange(new DataGridViewColumn[] { ColNroCompra, ColIdFormaPago, ColIdCliente, ColApeCliente, ColFechaCompra, ColEstado, ColAccion1, ColAccion2 });
            dgvConsultarCompra.Location = new Point(33, 94);
            dgvConsultarCompra.Name = "dgvConsultarCompra";
            dgvConsultarCompra.ReadOnly = true;
            dgvConsultarCompra.RowTemplate.Height = 25;
            dgvConsultarCompra.Size = new Size(773, 236);
            dgvConsultarCompra.TabIndex = 28;
            dgvConsultarCompra.CellContentClick += dgvConsultarCompra_CellContentClick;
            // 
            // ColNroCompra
            // 
            ColNroCompra.HeaderText = "NroCompra";
            ColNroCompra.Name = "ColNroCompra";
            ColNroCompra.ReadOnly = true;
            ColNroCompra.Width = 80;
            // 
            // ColIdFormaPago
            // 
            ColIdFormaPago.HeaderText = "FormaPago";
            ColIdFormaPago.Name = "ColIdFormaPago";
            ColIdFormaPago.ReadOnly = true;
            // 
            // ColIdCliente
            // 
            ColIdCliente.HeaderText = "IdCliente";
            ColIdCliente.Name = "ColIdCliente";
            ColIdCliente.ReadOnly = true;
            // 
            // ColApeCliente
            // 
            ColApeCliente.HeaderText = "Apellido Cliente";
            ColApeCliente.Name = "ColApeCliente";
            ColApeCliente.ReadOnly = true;
            // 
            // ColFechaCompra
            // 
            ColFechaCompra.HeaderText = "Fecha de Compra";
            ColFechaCompra.Name = "ColFechaCompra";
            ColFechaCompra.ReadOnly = true;
            // 
            // ColEstado
            // 
            ColEstado.HeaderText = "Estado";
            ColEstado.Name = "ColEstado";
            ColEstado.ReadOnly = true;
            ColEstado.Width = 50;
            // 
            // ColAccion1
            // 
            ColAccion1.HeaderText = "Accion1";
            ColAccion1.Name = "ColAccion1";
            ColAccion1.ReadOnly = true;
            ColAccion1.Resizable = DataGridViewTriState.True;
            ColAccion1.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // ColAccion2
            // 
            ColAccion2.HeaderText = "Accion2";
            ColAccion2.Name = "ColAccion2";
            ColAccion2.ReadOnly = true;
            ColAccion2.Resizable = DataGridViewTriState.True;
            ColAccion2.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(685, 47);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(121, 31);
            btnConsultar.TabIndex = 29;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // ConsultarCompras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(822, 363);
            Controls.Add(btnConsultar);
            Controls.Add(dgvConsultarCompra);
            Controls.Add(dtpCompra);
            Controls.Add(txtIdCliente);
            Controls.Add(lblBDoc);
            Controls.Add(lblApellidoC);
            Name = "ConsultarCompras";
            Text = "ConsultarCompras";
            Load += ConsultarCompras_LoadAsync;
            ((System.ComponentModel.ISupportInitialize)dgvConsultarCompra).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtIdCliente;
        private Label lblBDoc;
        private Label lblApellidoC;
        private DateTimePicker dtpCompra;
        private DataGridView dgvConsultarCompra;
        private Button btnConsultar;
        private DataGridViewTextBoxColumn ColNroCompra;
        private DataGridViewTextBoxColumn ColIdFormaPago;
        private DataGridViewTextBoxColumn ColIdCliente;
        private DataGridViewTextBoxColumn ColApeCliente;
        private DataGridViewTextBoxColumn ColFechaCompra;
        private DataGridViewTextBoxColumn ColEstado;
        private DataGridViewButtonColumn ColAccion1;
        private DataGridViewButtonColumn ColAccion2;
    }
}