namespace CineFront
{
    partial class Funciones
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
            contextMenuStrip1 = new ContextMenuStrip(components);
            contextMenuStrip2 = new ContextMenuStrip(components);
            contextMenuStrip3 = new ContextMenuStrip(components);
            nuevaToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip4 = new ContextMenuStrip(components);
            nuevaToolStripMenuItem1 = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            nuevaToolStripMenuItem2 = new ToolStripMenuItem();
            consultarToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip3.SuspendLayout();
            contextMenuStrip4.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(61, 4);
            // 
            // contextMenuStrip3
            // 
            contextMenuStrip3.Items.AddRange(new ToolStripItem[] { nuevaToolStripMenuItem });
            contextMenuStrip3.Name = "contextMenuStrip3";
            contextMenuStrip3.Size = new Size(109, 26);
            // 
            // nuevaToolStripMenuItem
            // 
            nuevaToolStripMenuItem.Name = "nuevaToolStripMenuItem";
            nuevaToolStripMenuItem.Size = new Size(108, 22);
            nuevaToolStripMenuItem.Text = "Nueva";
            // 
            // contextMenuStrip4
            // 
            contextMenuStrip4.Items.AddRange(new ToolStripItem[] { nuevaToolStripMenuItem1 });
            contextMenuStrip4.Name = "contextMenuStrip4";
            contextMenuStrip4.Size = new Size(109, 26);
            // 
            // nuevaToolStripMenuItem1
            // 
            nuevaToolStripMenuItem1.Name = "nuevaToolStripMenuItem1";
            nuevaToolStripMenuItem1.Size = new Size(108, 22);
            nuevaToolStripMenuItem1.Text = "Nueva";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { nuevaToolStripMenuItem2, consultarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // nuevaToolStripMenuItem2
            // 
            nuevaToolStripMenuItem2.Name = "nuevaToolStripMenuItem2";
            nuevaToolStripMenuItem2.Size = new Size(53, 20);
            nuevaToolStripMenuItem2.Text = "Nueva";
            nuevaToolStripMenuItem2.Click += nuevaToolStripMenuItem2_Click;
            // 
            // consultarToolStripMenuItem
            // 
            consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            consultarToolStripMenuItem.Size = new Size(70, 20);
            consultarToolStripMenuItem.Text = "Consultar";
            consultarToolStripMenuItem.Click += consultarToolStripMenuItem_Click;
            // 
            // Funciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Funciones";
            Text = "Funciones";
            Load += Funciones_Load;
            contextMenuStrip3.ResumeLayout(false);
            contextMenuStrip4.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private ContextMenuStrip contextMenuStrip2;
        private ContextMenuStrip contextMenuStrip3;
        private ToolStripMenuItem nuevaToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip4;
        private ToolStripMenuItem nuevaToolStripMenuItem1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem nuevaToolStripMenuItem2;
        private ToolStripMenuItem consultarToolStripMenuItem;
    }
}