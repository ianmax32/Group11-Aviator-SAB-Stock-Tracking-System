namespace Aviator_Systems_Prototype_SAB
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.btnPlantControl = new System.Windows.Forms.Button();
            this.btnStock = new System.Windows.Forms.Button();
            this.btnPackaging = new System.Windows.Forms.Button();
            this.btnTransportation = new System.Windows.Forms.Button();
            this.btnManagement = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(134, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(521, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "South African Breweries";
            // 
            // btnPlantControl
            // 
            this.btnPlantControl.BackColor = System.Drawing.Color.PowderBlue;
            this.btnPlantControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlantControl.Location = new System.Drawing.Point(676, 177);
            this.btnPlantControl.Name = "btnPlantControl";
            this.btnPlantControl.Size = new System.Drawing.Size(112, 65);
            this.btnPlantControl.TabIndex = 4;
            this.btnPlantControl.Text = "Plant Control";
            this.toolTip1.SetToolTip(this.btnPlantControl, "Sales and other departments");
            this.btnPlantControl.UseVisualStyleBackColor = false;
            this.btnPlantControl.Click += new System.EventHandler(this.btnPlantControl_Click);
            // 
            // btnStock
            // 
            this.btnStock.BackColor = System.Drawing.Color.PowderBlue;
            this.btnStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStock.Location = new System.Drawing.Point(171, 177);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(121, 66);
            this.btnStock.TabIndex = 1;
            this.btnStock.Text = "Stock Control";
            this.toolTip1.SetToolTip(this.btnStock, "Login to warehouse stock control\r\n");
            this.btnStock.UseVisualStyleBackColor = false;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // btnPackaging
            // 
            this.btnPackaging.BackColor = System.Drawing.Color.PowderBlue;
            this.btnPackaging.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPackaging.Location = new System.Drawing.Point(507, 178);
            this.btnPackaging.Name = "btnPackaging";
            this.btnPackaging.Size = new System.Drawing.Size(136, 66);
            this.btnPackaging.TabIndex = 2;
            this.btnPackaging.Text = "Packaging";
            this.toolTip1.SetToolTip(this.btnPackaging, "Login to packaging department");
            this.btnPackaging.UseVisualStyleBackColor = false;
            this.btnPackaging.Click += new System.EventHandler(this.btnPackaging_Click);
            // 
            // btnTransportation
            // 
            this.btnTransportation.BackColor = System.Drawing.Color.PowderBlue;
            this.btnTransportation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransportation.Location = new System.Drawing.Point(332, 178);
            this.btnTransportation.Name = "btnTransportation";
            this.btnTransportation.Size = new System.Drawing.Size(136, 65);
            this.btnTransportation.TabIndex = 3;
            this.btnTransportation.Text = "Transportation";
            this.toolTip1.SetToolTip(this.btnTransportation, "Login to transport department");
            this.btnTransportation.UseVisualStyleBackColor = false;
            this.btnTransportation.Click += new System.EventHandler(this.btnTransportation_Click);
            // 
            // btnManagement
            // 
            this.btnManagement.BackColor = System.Drawing.Color.PowderBlue;
            this.btnManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManagement.Location = new System.Drawing.Point(12, 177);
            this.btnManagement.Name = "btnManagement";
            this.btnManagement.Size = new System.Drawing.Size(124, 66);
            this.btnManagement.TabIndex = 0;
            this.btnManagement.Text = "Management";
            this.toolTip1.SetToolTip(this.btnManagement, "Login for Management");
            this.btnManagement.UseVisualStyleBackColor = false;
            this.btnManagement.Click += new System.EventHandler(this.btnManagement_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(255, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 32);
            this.label2.TabIndex = 9;
            this.label2.Text = "Select Department";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Aviator_Systems_Prototype_SAB.Properties.Resources.sab_background;
            this.panel1.Location = new System.Drawing.Point(13, 250);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 197);
            this.panel1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnPackaging);
            this.Controls.Add(this.btnManagement);
            this.Controls.Add(this.btnPlantControl);
            this.Controls.Add(this.btnStock);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTransportation);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "South African Brewieries Stock";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPlantControl;
        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.Button btnPackaging;
        private System.Windows.Forms.Button btnTransportation;
        private System.Windows.Forms.Button btnManagement;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel1;
    }
}

