namespace CineFront.Presentacion
{
    partial class frmCompraDetalles
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
            dgvCompraDetalle = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            colFecha = new DataGridViewTextBoxColumn();
            colCantEntradas = new DataGridViewTextBoxColumn();
            colPeli = new DataGridViewTextBoxColumn();
            colSala = new DataGridViewTextBoxColumn();
            colFormato = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvCompraDetalle).BeginInit();
            SuspendLayout();
            // 
            // dgvCompraDetalle
            // 
            dgvCompraDetalle.AllowUserToAddRows = false;
            dgvCompraDetalle.AllowUserToDeleteRows = false;
            dgvCompraDetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCompraDetalle.Columns.AddRange(new DataGridViewColumn[] { colID, colFecha, colCantEntradas, colPeli, colSala, colFormato });
            dgvCompraDetalle.Location = new Point(21, 18);
            dgvCompraDetalle.Name = "dgvCompraDetalle";
            dgvCompraDetalle.ReadOnly = true;
            dgvCompraDetalle.RowTemplate.Height = 25;
            dgvCompraDetalle.Size = new Size(546, 150);
            dgvCompraDetalle.TabIndex = 0;
            // 
            // colID
            // 
            colID.HeaderText = "ID";
            colID.Name = "colID";
            colID.ReadOnly = true;
            colID.Visible = false;
            // 
            // colFecha
            // 
            colFecha.HeaderText = "Fecha de Compra";
            colFecha.Name = "colFecha";
            colFecha.ReadOnly = true;
            // 
            // colCantEntradas
            // 
            colCantEntradas.HeaderText = "Cantidad de Entradas";
            colCantEntradas.Name = "colCantEntradas";
            colCantEntradas.ReadOnly = true;
            // 
            // colPeli
            // 
            colPeli.HeaderText = "Pelicula";
            colPeli.Name = "colPeli";
            colPeli.ReadOnly = true;
            // 
            // colSala
            // 
            colSala.HeaderText = "Sala";
            colSala.Name = "colSala";
            colSala.ReadOnly = true;
            // 
            // colFormato
            // 
            colFormato.HeaderText = "Formato";
            colFormato.Name = "colFormato";
            colFormato.ReadOnly = true;
            // 
            // frmCompraDetalles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(579, 179);
            Controls.Add(dgvCompraDetalle);
            Name = "frmCompraDetalles";
            Text = "frmCompraDetalles";
            Load += frmCompraDetalles_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCompraDetalle).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvCompraDetalle;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colFecha;
        private DataGridViewTextBoxColumn colCantEntradas;
        private DataGridViewTextBoxColumn colPeli;
        private DataGridViewTextBoxColumn colSala;
        private DataGridViewTextBoxColumn colFormato;
    }
}