namespace CineFront.Presentacion
{
    partial class NuevaCompra
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
            lblNroCompra = new Label();
            dtpFechaCompra = new DateTimePicker();
            lblFechaCompra = new Label();
            lblCliente = new Label();
            cboCliente = new ComboBox();
            lblFuncion = new Label();
            cboFuncion = new ComboBox();
            lblDescuento = new Label();
            cboDescuento = new ComboBox();
            rbtPagar = new RadioButton();
            rbtReservar = new RadioButton();
            txtPrecio = new TextBox();
            label1 = new Label();
            txtSala = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtFormato = new TextBox();
            label5 = new Label();
            dtpFechaHora = new DateTimePicker();
            txtDescuento = new TextBox();
            label6 = new Label();
            label7 = new Label();
            btnComprar = new Button();
            txtCant = new TextBox();
            label8 = new Label();
            cboFormaPago = new ComboBox();
            SuspendLayout();
            // 
            // lblNroCompra
            // 
            lblNroCompra.AutoSize = true;
            lblNroCompra.Location = new Point(7, 6);
            lblNroCompra.Name = "lblNroCompra";
            lblNroCompra.Size = new Size(38, 15);
            lblNroCompra.TabIndex = 0;
            lblNroCompra.Text = "label1";
            // 
            // dtpFechaCompra
            // 
            dtpFechaCompra.Enabled = false;
            dtpFechaCompra.Location = new Point(118, 35);
            dtpFechaCompra.Name = "dtpFechaCompra";
            dtpFechaCompra.Size = new Size(447, 23);
            dtpFechaCompra.TabIndex = 1;
            // 
            // lblFechaCompra
            // 
            lblFechaCompra.AutoSize = true;
            lblFechaCompra.Location = new Point(12, 39);
            lblFechaCompra.Name = "lblFechaCompra";
            lblFechaCompra.Size = new Size(87, 15);
            lblFechaCompra.TabIndex = 2;
            lblFechaCompra.Text = "Fecha Compra:";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(52, 80);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(47, 15);
            lblCliente.TabIndex = 3;
            lblCliente.Text = "Cliente:";
            // 
            // cboCliente
            // 
            cboCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCliente.FormattingEnabled = true;
            cboCliente.Location = new Point(118, 77);
            cboCliente.Name = "cboCliente";
            cboCliente.Size = new Size(447, 23);
            cboCliente.TabIndex = 4;
            // 
            // lblFuncion
            // 
            lblFuncion.AutoSize = true;
            lblFuncion.Location = new Point(46, 121);
            lblFuncion.Name = "lblFuncion";
            lblFuncion.Size = new Size(53, 15);
            lblFuncion.TabIndex = 5;
            lblFuncion.Text = "Función:";
            // 
            // cboFuncion
            // 
            cboFuncion.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFuncion.FormattingEnabled = true;
            cboFuncion.Location = new Point(118, 118);
            cboFuncion.Name = "cboFuncion";
            cboFuncion.Size = new Size(447, 23);
            cboFuncion.TabIndex = 6;
            cboFuncion.SelectedIndexChanged += cboFuncion_SelectedIndexChanged;
            // 
            // lblDescuento
            // 
            lblDescuento.AutoSize = true;
            lblDescuento.Location = new Point(33, 160);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(66, 15);
            lblDescuento.TabIndex = 7;
            lblDescuento.Text = "Descuento:";
            // 
            // cboDescuento
            // 
            cboDescuento.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDescuento.FormattingEnabled = true;
            cboDescuento.Location = new Point(118, 157);
            cboDescuento.Name = "cboDescuento";
            cboDescuento.Size = new Size(447, 23);
            cboDescuento.TabIndex = 8;
            cboDescuento.SelectedIndexChanged += cboDescuento_SelectedIndexChanged;
            // 
            // rbtPagar
            // 
            rbtPagar.AutoSize = true;
            rbtPagar.Location = new Point(118, 241);
            rbtPagar.Name = "rbtPagar";
            rbtPagar.Size = new Size(55, 19);
            rbtPagar.TabIndex = 9;
            rbtPagar.TabStop = true;
            rbtPagar.Text = "Pagar";
            rbtPagar.UseVisualStyleBackColor = true;
            // 
            // rbtReservar
            // 
            rbtReservar.AutoSize = true;
            rbtReservar.Location = new Point(202, 241);
            rbtReservar.Name = "rbtReservar";
            rbtReservar.Size = new Size(69, 19);
            rbtReservar.TabIndex = 10;
            rbtReservar.TabStop = true;
            rbtReservar.Text = "Reservar";
            rbtReservar.UseVisualStyleBackColor = true;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(118, 283);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.ReadOnly = true;
            txtPrecio.Size = new Size(100, 23);
            txtPrecio.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 243);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 13;
            label1.Text = "Opción:";
            // 
            // txtSala
            // 
            txtSala.Location = new Point(347, 285);
            txtSala.Name = "txtSala";
            txtSala.ReadOnly = true;
            txtSala.Size = new Size(100, 23);
            txtSala.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 286);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 15;
            label2.Text = "Precio:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(309, 288);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 16;
            label3.Text = "Sala: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(47, 328);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 17;
            label4.Text = "Formato:";
            // 
            // txtFormato
            // 
            txtFormato.Location = new Point(118, 324);
            txtFormato.Name = "txtFormato";
            txtFormato.ReadOnly = true;
            txtFormato.Size = new Size(100, 23);
            txtFormato.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(264, 330);
            label5.Name = "label5";
            label5.Size = new Size(79, 15);
            label5.TabIndex = 19;
            label5.Text = "Fecha y Hora:";
            // 
            // dtpFechaHora
            // 
            dtpFechaHora.Enabled = false;
            dtpFechaHora.Location = new Point(347, 324);
            dtpFechaHora.Name = "dtpFechaHora";
            dtpFechaHora.Size = new Size(218, 23);
            dtpFechaHora.TabIndex = 20;
            // 
            // txtDescuento
            // 
            txtDescuento.Location = new Point(118, 363);
            txtDescuento.Name = "txtDescuento";
            txtDescuento.ReadOnly = true;
            txtDescuento.Size = new Size(100, 23);
            txtDescuento.TabIndex = 22;
            txtDescuento.TextChanged += txtDescuento_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(33, 366);
            label6.Name = "label6";
            label6.Size = new Size(66, 15);
            label6.TabIndex = 21;
            label6.Text = "Descuento:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(237, 368);
            label7.Name = "label7";
            label7.Size = new Size(106, 15);
            label7.TabIndex = 24;
            label7.Text = "Cantidad Entradas:";
            // 
            // btnComprar
            // 
            btnComprar.Location = new Point(204, 419);
            btnComprar.Name = "btnComprar";
            btnComprar.Size = new Size(166, 53);
            btnComprar.TabIndex = 25;
            btnComprar.Text = "Comprar";
            btnComprar.UseVisualStyleBackColor = true;
            btnComprar.Click += btnComprar_Click;
            // 
            // txtCant
            // 
            txtCant.Location = new Point(347, 365);
            txtCant.Name = "txtCant";
            txtCant.Size = new Size(100, 23);
            txtCant.TabIndex = 26;
            txtCant.TextChanged += txtCant_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 200);
            label8.Name = "label8";
            label8.Size = new Size(90, 15);
            label8.TabIndex = 27;
            label8.Text = "Forma de Pago:";
            // 
            // cboFormaPago
            // 
            cboFormaPago.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFormaPago.FormattingEnabled = true;
            cboFormaPago.Location = new Point(118, 197);
            cboFormaPago.Name = "cboFormaPago";
            cboFormaPago.Size = new Size(447, 23);
            cboFormaPago.TabIndex = 28;
            // 
            // NuevaCompra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(577, 508);
            Controls.Add(cboFormaPago);
            Controls.Add(label8);
            Controls.Add(txtCant);
            Controls.Add(btnComprar);
            Controls.Add(label7);
            Controls.Add(txtDescuento);
            Controls.Add(label6);
            Controls.Add(dtpFechaHora);
            Controls.Add(label5);
            Controls.Add(txtFormato);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtSala);
            Controls.Add(label1);
            Controls.Add(txtPrecio);
            Controls.Add(rbtReservar);
            Controls.Add(rbtPagar);
            Controls.Add(cboDescuento);
            Controls.Add(lblDescuento);
            Controls.Add(cboFuncion);
            Controls.Add(lblFuncion);
            Controls.Add(cboCliente);
            Controls.Add(lblCliente);
            Controls.Add(lblFechaCompra);
            Controls.Add(dtpFechaCompra);
            Controls.Add(lblNroCompra);
            Name = "NuevaCompra";
            Text = "NuevaCompra";
            Load += NuevaCompra_LoadAsync;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNroCompra;
        private DateTimePicker dtpFechaCompra;
        private Label lblFechaCompra;
        private Label lblCliente;
        private ComboBox cboCliente;
        private Label lblFuncion;
        private ComboBox cboFuncion;
        private Label lblDescuento;
        private ComboBox cboDescuento;
        private RadioButton rbtPagar;
        private RadioButton rbtReservar;
        private TextBox txtPrecio;
        private Label label1;
        private TextBox txtSala;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtFormato;
        private Label label5;
        private DateTimePicker dtpFechaHora;
        private TextBox txtDescuento;
        private Label label6;
        private Label label7;
        private Button btnComprar;
        private TextBox txtCant;
        private Label label8;
        private ComboBox cboFormaPago;
    }
}