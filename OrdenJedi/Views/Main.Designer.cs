namespace OrdenJedi
{
    partial class FrmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.DGVReport = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGVReport)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVReport
            // 
            this.DGVReport.AllowUserToAddRows = false;
            this.DGVReport.AllowUserToDeleteRows = false;
            this.DGVReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVReport.Location = new System.Drawing.Point(10, 10);
            this.DGVReport.Margin = new System.Windows.Forms.Padding(10);
            this.DGVReport.Name = "DGVReport";
            this.DGVReport.ReadOnly = true;
            this.DGVReport.Size = new System.Drawing.Size(780, 430);
            this.DGVReport.TabIndex = 0;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DGVReport);
            this.Name = "FrmMain";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Main";
            this.Shown += new System.EventHandler(this.FrmMain_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.DGVReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.DataGridView DGVReport;
    }
}

