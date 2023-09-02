namespace ABMCCarpinteria_Krlitos.Entidades
{
    partial class FrmDetallePresupuesto
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
            this.dgvDetallePresupuesto = new System.Windows.Forms.DataGridView();
            this.detalle_nro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subTotalProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetallePresupuesto)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDetallePresupuesto
            // 
            this.dgvDetallePresupuesto.AllowUserToAddRows = false;
            this.dgvDetallePresupuesto.AllowUserToDeleteRows = false;
            this.dgvDetallePresupuesto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetallePresupuesto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.detalle_nro,
            this.id_producto,
            this.nomProducto,
            this.precioProducto,
            this.cantProducto,
            this.subTotalProducto});
            this.dgvDetallePresupuesto.Location = new System.Drawing.Point(13, 86);
            this.dgvDetallePresupuesto.Name = "dgvDetallePresupuesto";
            this.dgvDetallePresupuesto.ReadOnly = true;
            this.dgvDetallePresupuesto.Size = new System.Drawing.Size(775, 352);
            this.dgvDetallePresupuesto.TabIndex = 0;
            this.dgvDetallePresupuesto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // detalle_nro
            // 
            this.detalle_nro.HeaderText = "Nro_Detalle";
            this.detalle_nro.Name = "detalle_nro";
            this.detalle_nro.ReadOnly = true;
            // 
            // id_producto
            // 
            this.id_producto.HeaderText = "ID_Producto";
            this.id_producto.Name = "id_producto";
            this.id_producto.ReadOnly = true;
            // 
            // nomProducto
            // 
            this.nomProducto.HeaderText = "Nombre Producto";
            this.nomProducto.Name = "nomProducto";
            this.nomProducto.ReadOnly = true;
            this.nomProducto.Width = 250;
            // 
            // precioProducto
            // 
            this.precioProducto.HeaderText = "Precio";
            this.precioProducto.Name = "precioProducto";
            this.precioProducto.ReadOnly = true;
            // 
            // cantProducto
            // 
            this.cantProducto.HeaderText = "Cantidad";
            this.cantProducto.Name = "cantProducto";
            this.cantProducto.ReadOnly = true;
            // 
            // subTotalProducto
            // 
            this.subTotalProducto.HeaderText = "Subtotal";
            this.subTotalProducto.Name = "subTotalProducto";
            this.subTotalProducto.ReadOnly = true;
            // 
            // FrmDetallePresupuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvDetallePresupuesto);
            this.Name = "FrmDetallePresupuesto";
            this.Text = "FrmDetallePresupuesto";
            this.Load += new System.EventHandler(this.FrmDetallePresupuesto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetallePresupuesto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDetallePresupuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn detalle_nro;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn subTotalProducto;
    }
}