namespace Aviator_Systems_Prototype_SAB
{
    partial class viewOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(viewOrders));
            this.btnApprove = new System.Windows.Forms.Button();
            this.btnDecline = new System.Windows.Forms.Button();
            this.btnExitOrders = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnApprove
            // 
            this.btnApprove.Location = new System.Drawing.Point(33, 326);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(154, 48);
            this.btnApprove.TabIndex = 0;
            this.btnApprove.Text = "Approve";
            this.btnApprove.UseVisualStyleBackColor = true;
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
            // 
            // btnDecline
            // 
            this.btnDecline.Location = new System.Drawing.Point(371, 326);
            this.btnDecline.Name = "btnDecline";
            this.btnDecline.Size = new System.Drawing.Size(186, 48);
            this.btnDecline.TabIndex = 1;
            this.btnDecline.Text = "Decline";
            this.btnDecline.Click += new System.EventHandler(this.btnDecline_Click);
            // 
            // btnExitOrders
            // 
            this.btnExitOrders.Location = new System.Drawing.Point(712, 326);
            this.btnExitOrders.Name = "btnExitOrders";
            this.btnExitOrders.Size = new System.Drawing.Size(155, 48);
            this.btnExitOrders.TabIndex = 2;
            this.btnExitOrders.Text = "Exit";
            this.btnExitOrders.UseVisualStyleBackColor = true;
            this.btnExitOrders.Click += new System.EventHandler(this.btnExitOrders_Click);
            // 
            // viewOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 392);
            this.Controls.Add(this.btnExitOrders);
            this.Controls.Add(this.btnDecline);
            this.Controls.Add(this.btnApprove);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "viewOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Orders Available";
            this.Load += new System.EventHandler(this.viewOrders_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.Button btnDecline;
        private System.Windows.Forms.Button btnExitOrders;
    }
}