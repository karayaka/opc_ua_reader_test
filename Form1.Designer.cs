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
            this.btnJobInfoForm = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnJobInfoForm
            // 
            this.btnJobInfoForm.Location = new System.Drawing.Point(12, 12);
            this.btnJobInfoForm.Name = "btnJobInfoForm";
            this.btnJobInfoForm.Size = new System.Drawing.Size(206, 34);
            this.btnJobInfoForm.TabIndex = 0;
            this.btnJobInfoForm.Text = "İş Bilgisi (Job Info)";
            this.btnJobInfoForm.UseVisualStyleBackColor = true;
            this.btnJobInfoForm.Click += new System.EventHandler(this.btnJobInfoForm_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(224, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "İş Bilgisi (Job Info)";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 453);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnJobInfoForm);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnJobInfoForm;
        private System.Windows.Forms.Button button1;
    }
}

