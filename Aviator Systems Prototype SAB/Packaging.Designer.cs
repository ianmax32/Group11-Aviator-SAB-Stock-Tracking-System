namespace Aviator_Systems_Prototype_SAB
{
    partial class Packaging
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
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Lager");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Milk Stout");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Milk Stout Chocolate");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Lite");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Free");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Castle ", new System.Windows.Forms.TreeNode[] {
            treeNode14,
            treeNode15,
            treeNode16,
            treeNode17,
            treeNode18});
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Newlands Spring");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Flying Fish");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Redd\'s");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Brutal Fruit");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Black Label");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("Hansa");
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("Brand", new System.Windows.Forms.TreeNode[] {
            treeNode19,
            treeNode20,
            treeNode21,
            treeNode22,
            treeNode23,
            treeNode24,
            treeNode25});
            this.btnLogoutManagement = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.listBoxInfoToSend = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnLogoutManagement
            // 
            this.btnLogoutManagement.BackColor = System.Drawing.Color.PowderBlue;
            this.btnLogoutManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogoutManagement.Location = new System.Drawing.Point(754, 12);
            this.btnLogoutManagement.Name = "btnLogoutManagement";
            this.btnLogoutManagement.Size = new System.Drawing.Size(75, 31);
            this.btnLogoutManagement.TabIndex = 6;
            this.btnLogoutManagement.Text = "Logout";
            this.btnLogoutManagement.UseVisualStyleBackColor = false;
            this.btnLogoutManagement.Click += new System.EventHandler(this.btnLogoutManagement_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(23, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 55);
            this.label1.TabIndex = 4;
            this.label1.Text = "SAB Packaging";
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.PowderBlue;
            this.treeView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.Location = new System.Drawing.Point(8, 96);
            this.treeView1.Name = "treeView1";
            treeNode14.Name = "NodeCastleLarger";
            treeNode14.Text = "Lager";
            treeNode15.Name = "NodeCastleMilk";
            treeNode15.Text = "Milk Stout";
            treeNode16.Name = "NodeCastleMilkStoutChoc";
            treeNode16.Text = "Milk Stout Chocolate";
            treeNode17.Name = "NodeCastlLite";
            treeNode17.Text = "Lite";
            treeNode18.Name = "NodeCastleFree";
            treeNode18.Text = "Free";
            treeNode19.Name = "NodeCastle";
            treeNode19.Text = "Castle ";
            treeNode20.Name = "newlands";
            treeNode20.Text = "Newlands Spring";
            treeNode21.Name = "NodeFlyingFish";
            treeNode21.Text = "Flying Fish";
            treeNode22.Name = "NodeRedds";
            treeNode22.Text = "Redd\'s";
            treeNode23.Name = "NodeBrutalFruit";
            treeNode23.Text = "Brutal Fruit";
            treeNode24.Name = "NodeBlackLabel";
            treeNode24.Text = "Black Label";
            treeNode25.Name = "NodeHansa";
            treeNode25.Text = "Hansa";
            treeNode26.Name = "Brand";
            treeNode26.Text = "Brand";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode26});
            this.treeView1.Size = new System.Drawing.Size(212, 341);
            this.treeView1.TabIndex = 0;
            this.treeView1.DoubleClick += new System.EventHandler(this.treeView1_DoubleClick);
            // 
            // listBoxInfoToSend
            // 
            this.listBoxInfoToSend.BackColor = System.Drawing.Color.PowderBlue;
            this.listBoxInfoToSend.FormattingEnabled = true;
            this.listBoxInfoToSend.Location = new System.Drawing.Point(243, 96);
            this.listBoxInfoToSend.Name = "listBoxInfoToSend";
            this.listBoxInfoToSend.Size = new System.Drawing.Size(494, 342);
            this.listBoxInfoToSend.TabIndex = 1;
            this.listBoxInfoToSend.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PowderBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(743, 373);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 62);
            this.button1.TabIndex = 3;
            this.button1.Text = "Ready For Transportation";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "T1234",
            "T4567",
            "T7485",
            "T1245",
            "T3658",
            "T3659"});
            this.comboBox1.Location = new System.Drawing.Point(743, 96);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(89, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // Packaging
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(838, 447);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBoxInfoToSend);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.btnLogoutManagement);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "Packaging";
            this.Text = "Packaging";
            this.Load += new System.EventHandler(this.Packaging_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLogoutManagement;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ListBox listBoxInfoToSend;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.ComboBox comboBox1;
    }
}