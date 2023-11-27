namespace CineFront
{
    partial class NuevaFuncion
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
            lblFuncion = new Label();
            lblPelicula = new Label();
            lblFechaHora = new Label();
            lblSala = new Label();
            lblFormato = new Label();
            cboPelicula = new ComboBox();
            cboSala = new ComboBox();
            cboFormato = new ComboBox();
            dtpFechaHora = new DateTimePicker();
            mtbFechaHora = new MaskedTextBox();
            btnCrearFuncion = new Button();
            SuspendLayout();
            // 
            // lblFuncion
            // 
            lblFuncion.AutoSize = true;
            lblFuncion.Location = new Point(12, 9);
            lblFuncion.Name = "lblFuncion";
            lblFuncion.Size = new Size(38, 15);
            lblFuncion.TabIndex = 0;
            lblFuncion.Text = "label1";
            // 
            // lblPelicula
            // 
            lblPelicula.AutoSize = true;
            lblPelicula.Location = new Point(21, 80);
            lblPelicula.Name = "lblPelicula";
            lblPelicula.Size = new Size(54, 15);
            lblPelicula.TabIndex = 1;
            lblPelicula.Text = "Película: ";
            // 
            // lblFechaHora
            // 
            lblFechaHora.AutoSize = true;
            lblFechaHora.Location = new Point(21, 119);
            lblFechaHora.Name = "lblFechaHora";
            lblFechaHora.Size = new Size(79, 15);
            lblFechaHora.TabIndex = 2;
            lblFechaHora.Text = "Fecha y Hora:";
            // 
            // lblSala
            // 
            lblSala.AutoSize = true;
            lblSala.Location = new Point(21, 166);
            lblSala.Name = "lblSala";
            lblSala.Size = new Size(31, 15);
            lblSala.TabIndex = 3;
            lblSala.Text = "Sala:";
            // 
            // lblFormato
            // 
            lblFormato.AutoSize = true;
            lblFormato.Location = new Point(21, 214);
            lblFormato.Name = "lblFormato";
            lblFormato.Size = new Size(55, 15);
            lblFormato.TabIndex = 4;
            lblFormato.Text = "Formato:";
            // 
            // cboPelicula
            // 
            cboPelicula.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPelicula.FormattingEnabled = true;
            cboPelicula.Location = new Point(108, 77);
            cboPelicula.Name = "cboPelicula";
            cboPelicula.Size = new Size(244, 23);
            cboPelicula.TabIndex = 5;
            cboPelicula.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // cboSala
            // 
            cboSala.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSala.FormattingEnabled = true;
            cboSala.Location = new Point(108, 163);
            cboSala.Name = "cboSala";
            cboSala.Size = new Size(244, 23);
            cboSala.TabIndex = 6;
            cboSala.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // cboFormato
            // 
            cboFormato.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFormato.FormattingEnabled = true;
            cboFormato.Location = new Point(108, 211);
            cboFormato.Name = "cboFormato";
            cboFormato.Size = new Size(244, 23);
            cboFormato.TabIndex = 7;
            cboFormato.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // dtpFechaHora
            // 
            dtpFechaHora.Location = new Point(108, 113);
            dtpFechaHora.Name = "dtpFechaHora";
            dtpFechaHora.Size = new Size(244, 23);
            dtpFechaHora.TabIndex = 8;
            dtpFechaHora.ValueChanged += dtpFechaHora_ValueChanged;
            // 
            // mtbFechaHora
            // 
            mtbFechaHora.Location = new Point(12, 364);
            mtbFechaHora.Name = "mtbFechaHora";
            mtbFechaHora.Size = new Size(100, 23);
            mtbFechaHora.TabIndex = 9;
            mtbFechaHora.Visible = false;
            // 
            // btnCrearFuncion
            // 
            btnCrearFuncion.Location = new Point(119, 275);
            btnCrearFuncion.Name = "btnCrearFuncion";
            btnCrearFuncion.Size = new Size(121, 61);
            btnCrearFuncion.TabIndex = 10;
            btnCrearFuncion.Text = "Crear Función";
            btnCrearFuncion.UseVisualStyleBackColor = true;
            btnCrearFuncion.Click += btnCrearFuncion_Click;
            // 
            // NuevaFuncion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(364, 399);
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
            Name = "NuevaFuncion";
            Text = "NuevaFuncion";
            Load += NuevaFuncion_LoadAsync;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFuncion;
        private Label lblPelicula;
        private Label lblFechaHora;
        private Label lblSala;
        private Label lblFormato;
        private ComboBox cboPelicula;
        private ComboBox cboSala;
        private ComboBox cboFormato;
        private DateTimePicker dtpFechaHora;
        private MaskedTextBox mtbFechaHora;
        private Button btnCrearFuncion;
    }
}