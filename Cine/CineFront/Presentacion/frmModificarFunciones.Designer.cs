namespace CineFront.Presentacion
{
    partial class frmModificarFunciones
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
            btnCrearFuncion = new Button();
            mtbFechaHora = new MaskedTextBox();
            dtpFechaHora = new DateTimePicker();
            cboFormato = new ComboBox();
            cboSala = new ComboBox();
            cboPelicula = new ComboBox();
            lblFormato = new Label();
            lblSala = new Label();
            lblFechaHora = new Label();
            lblPelicula = new Label();
            lblFuncion = new Label();
            SuspendLayout();
            // 
            // btnCrearFuncion
            // 
            btnCrearFuncion.Location = new Point(112, 285);
            btnCrearFuncion.Name = "btnCrearFuncion";
            btnCrearFuncion.Size = new Size(121, 61);
            btnCrearFuncion.TabIndex = 21;
            btnCrearFuncion.Text = "Modificar Función";
            btnCrearFuncion.UseVisualStyleBackColor = true;
            btnCrearFuncion.Click += btnCrearFuncion_Click;
            // 
            // mtbFechaHora
            // 
            mtbFechaHora.Location = new Point(5, 374);
            mtbFechaHora.Name = "mtbFechaHora";
            mtbFechaHora.Size = new Size(100, 23);
            mtbFechaHora.TabIndex = 20;
            mtbFechaHora.Visible = false;
            // 
            // dtpFechaHora
            // 
            dtpFechaHora.Location = new Point(101, 123);
            dtpFechaHora.Name = "dtpFechaHora";
            dtpFechaHora.Size = new Size(244, 23);
            dtpFechaHora.TabIndex = 19;
            // 
            // cboFormato
            // 
            cboFormato.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFormato.FormattingEnabled = true;
            cboFormato.Location = new Point(101, 221);
            cboFormato.Name = "cboFormato";
            cboFormato.Size = new Size(244, 23);
            cboFormato.TabIndex = 18;
            // 
            // cboSala
            // 
            cboSala.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSala.FormattingEnabled = true;
            cboSala.Location = new Point(101, 173);
            cboSala.Name = "cboSala";
            cboSala.Size = new Size(244, 23);
            cboSala.TabIndex = 17;
            // 
            // cboPelicula
            // 
            cboPelicula.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPelicula.FormattingEnabled = true;
            cboPelicula.Location = new Point(101, 87);
            cboPelicula.Name = "cboPelicula";
            cboPelicula.Size = new Size(244, 23);
            cboPelicula.TabIndex = 16;
            // 
            // lblFormato
            // 
            lblFormato.AutoSize = true;
            lblFormato.Location = new Point(14, 224);
            lblFormato.Name = "lblFormato";
            lblFormato.Size = new Size(55, 15);
            lblFormato.TabIndex = 15;
            lblFormato.Text = "Formato:";
            // 
            // lblSala
            // 
            lblSala.AutoSize = true;
            lblSala.Location = new Point(14, 176);
            lblSala.Name = "lblSala";
            lblSala.Size = new Size(31, 15);
            lblSala.TabIndex = 14;
            lblSala.Text = "Sala:";
            // 
            // lblFechaHora
            // 
            lblFechaHora.AutoSize = true;
            lblFechaHora.Location = new Point(14, 129);
            lblFechaHora.Name = "lblFechaHora";
            lblFechaHora.Size = new Size(79, 15);
            lblFechaHora.TabIndex = 13;
            lblFechaHora.Text = "Fecha y Hora:";
            // 
            // lblPelicula
            // 
            lblPelicula.AutoSize = true;
            lblPelicula.Location = new Point(14, 90);
            lblPelicula.Name = "lblPelicula";
            lblPelicula.Size = new Size(54, 15);
            lblPelicula.TabIndex = 12;
            lblPelicula.Text = "Película: ";
            // 
            // lblFuncion
            // 
            lblFuncion.AutoSize = true;
            lblFuncion.Location = new Point(5, 19);
            lblFuncion.Name = "lblFuncion";
            lblFuncion.Size = new Size(38, 15);
            lblFuncion.TabIndex = 11;
            lblFuncion.Text = "label1";
            // 
            // frmModificarFunciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(352, 418);
            Controls.Add(btnCrearFuncion);
            Controls.Add(mtbFechaHora);
            Controls.Add(dtpFechaHora);
            Controls.Add(cboFormato);
            Controls.Add(cboSala);
            Controls.Add(cboPelicula);
            Controls.Add(lblFormato);
            Controls.Add(lblSala);
            Controls.Add(lblFechaHora);
            Controls.Add(lblPelicula);
            Controls.Add(lblFuncion);
            Name = "frmModificarFunciones";
            Text = "frmModificarFunciones";
            Load += frmModificarFunciones_LoadAsync;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCrearFuncion;
        private MaskedTextBox mtbFechaHora;
        private DateTimePicker dtpFechaHora;
        private ComboBox cboFormato;
        private ComboBox cboSala;
        private ComboBox cboPelicula;
        private Label lblFormato;
        private Label lblSala;
        private Label lblFechaHora;
        private Label lblPelicula;
        private Label lblFuncion;
    }
}