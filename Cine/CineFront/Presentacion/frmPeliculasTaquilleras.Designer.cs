namespace CineFront.Presentacion
{
    partial class frmPeliculasTaquilleras
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
            rptPelis = new Microsoft.Reporting.WinForms.ReportViewer();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            SuspendLayout();
            // 
            // rptPelis
            // 
            rptPelis.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rptPelis.Location = new Point(0, 0);
            rptPelis.Name = "ReportViewer";
            rptPelis.ServerReport.BearerToken = null;
            rptPelis.Size = new Size(1029, 776);
            rptPelis.TabIndex = 1;
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            // 
            // frmPeliculasTaquilleras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1013, 737);
            Controls.Add(rptPelis);
            Name = "frmPeliculasTaquilleras";
            Text = "frmPeliculasTaquilleras";
            Load += frmPeliculasTaquilleras_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Microsoft.Reporting.WinForms.ReportViewer rptPelis;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}