namespace CineFront.Presentacion
{
    partial class frmDetallesCompra
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
            btnAceptar = new Button();
            dgvDetalleCompra = new DataGridView();
            ColNroCompra = new DataGridViewTextBoxColumn();
            ColFecha = new DataGridViewTextBoxColumn();
            ColCantEntrada = new DataGridViewTextBoxColumn();
            ColNomPeli = new DataGridViewTextBoxColumn();
            ColSala = new DataGridViewTextBoxColumn();
            ColTipoFun = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvDetalleCompra).BeginInit();
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(710, 464);
            btnAceptar.Margin = new Padding(4, 3, 4, 3);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(88, 27);
            btnAceptar.TabIndex = 4;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // dgvDetalleCompra
            // 
            dgvDetalleCompra.AllowUserToAddRows = false;
            dgvDetalleCompra.AllowUserToDeleteRows = false;
            dgvDetalleCompra.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalleCompra.Columns.AddRange(new DataGridViewColumn[] { ColNroCompra, ColFecha, ColCantEntrada, ColNomPeli, ColSala, ColTipoFun });
            dgvDetalleCompra.Location = new Point(32, 27);
            dgvDetalleCompra.Margin = new Padding(4, 3, 4, 3);
            dgvDetalleCompra.Name = "dgvDetalleCompra";
            dgvDetalleCompra.ReadOnly = true;
            dgvDetalleCompra.Size = new Size(765, 419);
            dgvDetalleCompra.TabIndex = 3;
            // 
            // ColNroCompra
            // 
            ColNroCompra.HeaderText = "NroCompra";
            ColNroCompra.Name = "ColNroCompra";
            ColNroCompra.ReadOnly = true;
            ColNroCompra.Visible = false;
            // 
            // ColFecha
            // 
            ColFecha.HeaderText = "Fecha";
            ColFecha.Name = "ColFecha";
            ColFecha.ReadOnly = true;
            // 
            // ColCantEntrada
            // 
            ColCantEntrada.HeaderText = "Cant. Entradas";
            ColCantEntrada.Name = "ColCantEntrada";
            ColCantEntrada.ReadOnly = true;
            // 
            // ColNomPeli
            // 
            ColNomPeli.HeaderText = "Nombre Peli.";
            ColNomPeli.Name = "ColNomPeli";
            ColNomPeli.ReadOnly = true;
            // 
            // ColSala
            // 
            ColSala.HeaderText = "Sala";
            ColSala.Name = "ColSala";
            ColSala.ReadOnly = true;
            // 
            // ColTipoFun
            // 
            ColTipoFun.HeaderText = "Tipo Funcion";
            ColTipoFun.Name = "ColTipoFun";
            ColTipoFun.ReadOnly = true;
            // 
            // frmDetallesCompra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(830, 519);
            Controls.Add(btnAceptar);
            Controls.Add(dgvDetalleCompra);
            Name = "frmDetallesCompra";
            Text = "frmDetallesCompra";
            Load += frmDetallesCompra_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDetalleCompra).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnAceptar;
        private DataGridView dgvDetalleCompra;
        private DataGridViewTextBoxColumn ColNroCompra;
        private DataGridViewTextBoxColumn ColFecha;
        private DataGridViewTextBoxColumn ColCantEntrada;
        private DataGridViewTextBoxColumn ColNomPeli;
        private DataGridViewTextBoxColumn ColSala;
        private DataGridViewTextBoxColumn ColTipoFun;
    }
}