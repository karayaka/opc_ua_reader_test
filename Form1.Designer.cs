namespace opc_ua_reader_test
{
    partial class Form1
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
            this.btnJobInfoPage = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // btnJobInfoPage
            // 
            this.btnJobInfoPage.Location = new System.Drawing.Point(12, 12);
            this.btnJobInfoPage.Name = "btnJobInfoPage";
            this.btnJobInfoPage.Size = new System.Drawing.Size(147, 29);
            this.btnJobInfoPage.TabIndex = 0;
            this.btnJobInfoPage.Text = "İş Bilgileri(JobInfo)";
            this.btnJobInfoPage.Click += new System.EventHandler(this.btnJobInfoPage_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 453);
            this.Controls.Add(this.btnJobInfoPage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnJobInfoPage;
    }
}

