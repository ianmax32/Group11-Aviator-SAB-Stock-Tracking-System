namespace Aviator_Systems_Prototype_SAB
{
    partial class reports
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
            this.listBoxReports = new System.Windows.Forms.ListBox();
            this.btnCloseReports = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSaveReports = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // listBoxReports
            // 
            this.listBoxReports.FormattingEnabled = true;
            this.listBoxReports.Location = new System.Drawing.Point(16, 37);
            this.listBoxReports.Name = "listBoxReports";
            this.listBoxReports.Size = new System.Drawing.Size(775, 368);
            this.listBoxReports.TabIndex = 0;
            // 
            // btnCloseReports
            // 
            this.btnCloseReports.Location = new System.Drawing.Point(453, 411);
            this.btnCloseReports.Name = "btnCloseReports";
            this.btnCloseReports.Size = new System.Drawing.Size(223, 23);
            this.btnCloseReports.TabIndex = 1;
            this.btnCloseReports.Text = "Close";
            this.btnCloseReports.UseVisualStyleBackColor = true;
            this.btnCloseReports.Click += new System.EventHandler(this.btnCloseReports_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "SAB Stock Reports";
            // 
            // btnSaveReports
            // 
            this.btnSaveReports.Location = new System.Drawing.Point(109, 412);
            this.btnSaveReports.Name = "btnSaveReports";
            this.btnSaveReports.Size = new System.Drawing.Size(231, 23);
            this.btnSaveReports.TabIndex = 3;
            this.btnSaveReports.Text = "SAVE";
            this.btnSaveReports.UseVisualStyleBackColor = true;
            this.btnSaveReports.Click += new System.EventHandler(this.btnSaveReports_Click);
            // 
            // reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSaveReports);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCloseReports);
            this.Controls.Add(this.listBoxReports);
            this.Name = "reports";
            this.Text = "reports";
            this.Load += new System.EventHandler(this.reports_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxReports;
        private System.Windows.Forms.Button btnCloseReports;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSaveReports;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}