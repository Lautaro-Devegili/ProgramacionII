namespace CineFront.Presentacion
{
    partial class ConsultarFunciones
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
            label1 = new Label();
            dgvFunciones = new DataGridView();
            label2 = new Label();
            cboPelicula2 = new ComboBox();
            label3 = new Label();
            cboFuncion2 = new ComboBox();
            label4 = new Label();
            dtpFecha = new DateTimePicker();
            btnConsultar = new Button();
            btnSalir = new Button();
            CodFuncion = new DataGridViewTextBoxColumn();
            colPelicula = new DataGridViewTextBoxColumn();
            colNroSala = new DataGridViewTextBoxColumn();
            colFechaHora = new DataGridViewTextBoxColumn();
            colAccion1 = new DataGridViewButtonColumn();
            colAccion2 = new DataGridViewButtonColumn();
            colIdPel = new DataGridViewTextBoxColumn();
            colIdFormat = new DataGridViewTextBoxColumn();
            IdSal = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvFunciones).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Filtros";
            // 
            // dgvFunciones
            // 
            dgvFunciones.AllowUserToAddRows = false;
            dgvFunciones.AllowUserToDeleteRows = false;
            dgvFunciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFunciones.Columns.AddRange(new DataGridViewColumn[] { CodFuncion, colPelicula, colNroSala, colFechaHora, colAccion1, colAccion2, colIdPel, colIdFormat, IdSal });
            dgvFunciones.Location = new Point(12, 137);
            dgvFunciones.Name = "dgvFunciones";
            dgvFunciones.ReadOnly = true;
            dgvFunciones.RowTemplate.Height = 25;
            dgvFunciones.Size = new Size(634, 235);
            dgvFunciones.TabIndex = 1;
            dgvFunciones.CellContentClick += dgvFunciones_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(66, 52);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 2;
            label2.Text = "Pelicula";
            label2.Click += label2_Click;
            // 
            // cboPelicula2
            // 
            cboPelicula2.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPelicula2.FormattingEnabled = true;
            cboPelicula2.Location = new Point(120, 49);
            cboPelicula2.Name = "cboPelicula2";
            cboPelicula2.Size = new Size(121, 23);
            cboPelicula2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(263, 102);
            label3.Name = "label3";
            label3.Size = new Size(92, 15);
            label3.TabIndex = 4;
            label3.Text = "Tipo de Funcion";
            // 
            // cboFuncion2
            // 
            cboFuncion2.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFuncion2.FormattingEnabled = true;
            cboFuncion2.Location = new Point(361, 99);
            cboFuncion2.Name = "cboFuncion2";
            cboFuncion2.Size = new Size(121, 23);
            cboFuncion2.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(66, 105);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 6;
            label4.Text = "Fecha";
            // 
            // dtpFecha
            // 
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(110, 99);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(93, 23);
            dtpFecha.TabIndex = 7;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(543, 94);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(103, 31);
            btnConsultar.TabIndex = 8;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(570, 378);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(76, 23);
            btnSalir.TabIndex = 9;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // CodFuncion
            // 
            CodFuncion.HeaderText = "CodFuncion";
            CodFuncion.Name = "CodFuncion";
            CodFuncion.ReadOnly = true;
            CodFuncion.Resizable = DataGridViewTriState.True;
            CodFuncion.Width = 80;
            // 
            // colPelicula
            // 
            colPelicula.HeaderText = "Pelicula";
            colPelicula.Name = "colPelicula";
            colPelicula.ReadOnly = true;
            // 
            // colNroSala
            // 
            colNroSala.HeaderText = "NroSala";
            colNroSala.Name = "colNroSala";
            colNroSala.ReadOnly = true;
            // 
            // colFechaHora
            // 
            colFechaHora.HeaderText = "Fecha y Hora";
            colFechaHora.Name = "colFechaHora";
            colFechaHora.ReadOnly = true;
            // 
            // colAccion1
            // 
            colAccion1.HeaderText = "Accion1";
            colAccion1.Name = "colAccion1";
            colAccion1.ReadOnly = true;
            colAccion1.Resizable = DataGridViewTriState.True;
            colAccion1.Text = "Eliminar";
            colAccion1.UseColumnTextForButtonValue = true;
            // 
            // colAccion2
            // 
            colAccion2.HeaderText = "Modificar";
            colAccion2.Name = "colAccion2";
            colAccion2.ReadOnly = true;
            colAccion2.Resizable = DataGridViewTriState.True;
            colAccion2.SortMode = DataGridViewColumnSortMode.Automatic;
            colAccion2.Text = "Modificar";
            colAccion2.UseColumnTextForButtonValue = true;
            // 
            // colIdPel
            // 
            colIdPel.HeaderText = "IdPeli";
            colIdPel.Name = "colIdPel";
            colIdPel.ReadOnly = true;
            colIdPel.Visible = false;
            // 
            // colIdFormat
            // 
            colIdFormat.HeaderText = "IdFormato";
            colIdFormat.Name = "colIdFormat";
            colIdFormat.ReadOnly = true;
            colIdFormat.Visible = false;
            // 
            // IdSal
            // 
            IdSal.HeaderText = "IdSala";
            IdSal.Name = "IdSal";
            IdSal.ReadOnly = true;
            IdSal.Visible = false;
            // 
            // ConsultarFunciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(658, 410);
            Controls.Add(btnSalir);
            Controls.Add(btnConsultar);
            Controls.Add(dtpFecha);
            Controls.Add(label4);
            Controls.Add(cboFuncion2);
            Controls.Add(label3);
            Controls.Add(cboPelicula2);
            Controls.Add(label2);
            Controls.Add(dgvFunciones);
            Controls.Add(label1);
            Name = "ConsultarFunciones";
            Text = "ConsultarFunciones";
            Load += ConsultarFunciones_LoadAsync;
            ((System.ComponentModel.ISupportInitialize)dgvFunciones).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvFunciones;
        private Label label2;
        private ComboBox cboPelicula2;
        private Label label3;
        private ComboBox cboFuncion2;
        private Label label4;
        private DateTimePicker dtpFecha;
        private Button btnConsultar;
        private Button btnSalir;
        private DataGridViewTextBoxColumn CodFuncion;
        private DataGridViewTextBoxColumn colPelicula;
        private DataGridViewTextBoxColumn colNroSala;
        private DataGridViewTextBoxColumn colFechaHora;
        private DataGridViewButtonColumn colAccion1;
        private DataGridViewButtonColumn colAccion2;
        private DataGridViewTextBoxColumn colIdPel;
        private DataGridViewTextBoxColumn colIdFormat;
        private DataGridViewTextBoxColumn IdSal;
    }
}