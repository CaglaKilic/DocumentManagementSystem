namespace DocumentManagementSystem
{
    partial class PDFForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PDFForm));
            this.acroPDF = new AxAcroPDFLib.AxAcroPDF();
            this.textboxFilePath = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.acroPDF)).BeginInit();
            this.SuspendLayout();
            // 
            // acroPDF
            // 
            this.acroPDF.Enabled = true;
            this.acroPDF.Location = new System.Drawing.Point(0, 0);
            this.acroPDF.Name = "acroPDF";
            this.acroPDF.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("acroPDF.OcxState")));
            this.acroPDF.Size = new System.Drawing.Size(525, 680);
            this.acroPDF.TabIndex = 0;
            // 
            // textboxFilePath
            // 
            this.textboxFilePath.Location = new System.Drawing.Point(12, 12);
            this.textboxFilePath.Name = "textboxFilePath";
            this.textboxFilePath.Size = new System.Drawing.Size(100, 20);
            this.textboxFilePath.TabIndex = 1;
            this.textboxFilePath.Visible = false;
            // 
            // PDFForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 681);
            this.Controls.Add(this.textboxFilePath);
            this.Controls.Add(this.acroPDF);
            this.MaximizeBox = false;
            this.Name = "PDFForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PDF";
            this.Load += new System.EventHandler(this.PDFForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.acroPDF)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxAcroPDFLib.AxAcroPDF acroPDF;
        private System.Windows.Forms.TextBox textboxFilePath;
    }
}