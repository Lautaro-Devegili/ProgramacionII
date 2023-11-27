namespace CineFront.Presentacion
{
    partial class Login
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            txtUsu = new TextBox();
            txtPass = new TextBox();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 24);
            label1.Name = "label1";
            label1.Size = new Size(414, 65);
            label1.TabIndex = 0;
            label1.Text = "INICIO DE SESIÓN";
            // 
            // txtUsu
            // 
            txtUsu.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsu.Location = new Point(175, 137);
            txtUsu.Name = "txtUsu";
            txtUsu.Size = new Size(295, 57);
            txtUsu.TabIndex = 1;
            // 
            // txtPass
            // 
            txtPass.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtPass.Location = new Point(175, 227);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(295, 57);
            txtPass.TabIndex = 3;
            txtPass.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(55, 150);
            label2.Name = "label2";
            label2.Size = new Size(114, 37);
            label2.TabIndex = 4;
            label2.Text = "Usuario:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 240);
            label3.Name = "label3";
            label3.Size = new Size(157, 37);
            label3.TabIndex = 5;
            label3.Text = "Contraseña:";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(175, 341);
            button1.Name = "button1";
            button1.Size = new Size(295, 73);
            button1.TabIndex = 6;
            button1.Text = "LOGIN";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(482, 452);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtPass);
            Controls.Add(txtUsu);
            Controls.Add(label1);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtUsu;
        private TextBox txtPass;
        private Label label2;
        private Label label3;
        private Button button1;
        private System.Windows.Forms.Timer timer1;
    }
}