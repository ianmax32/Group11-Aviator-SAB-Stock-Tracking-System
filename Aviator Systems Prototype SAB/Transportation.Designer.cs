namespace Aviator_Systems_Prototype_SAB
{
    partial class Transportation
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transportation));
            this.listBoxTrailersLoaded = new System.Windows.Forms.ListBox();
            this.btnLogoutManagement = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.listBoxTrailers = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.File = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.waToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerStatsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxTrailersLoaded
            // 
            this.listBoxTrailersLoaded.BackColor = System.Drawing.Color.PowderBlue;
            this.listBoxTrailersLoaded.Font = new System.Drawing.Font("Segoe MDL2 Assets", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxTrailersLoaded.FormattingEnabled = true;
            this.listBoxTrailersLoaded.ItemHeight = 15;
            this.listBoxTrailersLoaded.Location = new System.Drawing.Point(244, 96);
            this.listBoxTrailersLoaded.Name = "listBoxTrailersLoaded";
            this.listBoxTrailersLoaded.Size = new System.Drawing.Size(579, 334);
            this.listBoxTrailersLoaded.TabIndex = 1;
            // 
            // btnLogoutManagement
            // 
            this.btnLogoutManagement.BackColor = System.Drawing.Color.PowderBlue;
            this.btnLogoutManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogoutManagement.Location = new System.Drawing.Point(760, 32);
            this.btnLogoutManagement.Name = "btnLogoutManagement";
            this.btnLogoutManagement.Size = new System.Drawing.Size(75, 31);
            this.btnLogoutManagement.TabIndex = 3;
            this.btnLogoutManagement.Text = "Logout";
            this.btnLogoutManagement.UseVisualStyleBackColor = false;
            this.btnLogoutManagement.Click += new System.EventHandler(this.btnLogoutManagement_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(461, 55);
            this.label1.TabIndex = 11;
            this.label1.Text = "SAB Transportation";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PowderBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(412, 442);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 62);
            this.button1.TabIndex = 2;
            this.button1.Text = "Generate Report";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipTitle = "Generate report for management";
            // 
            // listBoxTrailers
            // 
            this.listBoxTrailers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxTrailers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxTrailers.FormattingEnabled = true;
            this.listBoxTrailers.ItemHeight = 21;
            this.listBoxTrailers.Items.AddRange(new object[] {
            "T1234",
            "T4567",
            "T7485",
            "T1245",
            "T3658",
            "T3659"});
            this.listBoxTrailers.Location = new System.Drawing.Point(13, 96);
            this.listBoxTrailers.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.listBoxTrailers.Name = "listBoxTrailers";
            this.listBoxTrailers.Size = new System.Drawing.Size(212, 340);
            this.listBoxTrailers.TabIndex = 19;
            this.toolTip1.SetToolTip(this.listBoxTrailers, "Click on a trailer to vierw wat is loaded");
            this.listBoxTrailers.SelectedIndexChanged += new System.EventHandler(this.listBoxTrailers_SelectedIndexChanged);
            this.listBoxTrailers.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxTrailers_MouseDoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(835, 29);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File,
            this.exitToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(45, 25);
            this.toolStripMenuItem1.Text = "file";
            // 
            // File
            // 
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(103, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(106, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.waToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(50, 25);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // waToolStripMenuItem
            // 
            this.waToolStripMenuItem.Name = "waToolStripMenuItem";
            this.waToolStripMenuItem.Size = new System.Drawing.Size(138, 26);
            this.waToolStripMenuItem.Text = "Reports";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerStatsToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(57, 25);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // customerStatsToolStripMenuItem
            // 
            this.customerStatsToolStripMenuItem.Name = "customerStatsToolStripMenuItem";
            this.customerStatsToolStripMenuItem.Size = new System.Drawing.Size(155, 26);
            this.customerStatsToolStripMenuItem.Text = "All Trailers";
            this.customerStatsToolStripMenuItem.Click += new System.EventHandler(this.customerStatsToolStripMenuItem_Click);
            // 
            // Transportation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 507);
            this.Controls.Add(this.listBoxTrailers);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBoxTrailersLoaded);
            this.Controls.Add(this.btnLogoutManagement);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Transportation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Transportation";
            this.Load += new System.EventHandler(this.Transportation_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxTrailersLoaded;
        private System.Windows.Forms.Button btnLogoutManagement;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator File;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem waToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerStatsToolStripMenuItem;
        private System.Windows.Forms.ListBox listBoxTrailers;
    }
}