using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Aviator_Systems_Prototype_SAB
{
    public partial class Form1 : Form
    {
        public String getButtonClicked { get; set; }
        private login log = new login();
        private Boolean allowAccess  = false; //checks whether the user is valid or not

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            log.loginPressed = false;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            add addInfo = new add();
            addInfo.Show();
            
        }

        private void btnManagement_Click(object sender, EventArgs e)
        {
            
            log.lblDepartment.Text = btnManagement.Text.ToUpper();
            log.ShowDialog();
            getButtonClicked = "Management";

            if (log.loginPressed)
            {
                management stock = new management();
                stock.ShowDialog();
            }
        }

        private void btnPlantControl_Click(object sender, EventArgs e)
        {
            log.lblDepartment.Text = btnPlantControl.Text.ToUpper();
            log.Show();
            getButtonClicked = "Plant Control";

            if (log.loginPressed)
            {
                //Customers stock = new StockControl();
                //stock.ShowDialog();
            }
        }

        private void btnTransportation_Click(object sender, EventArgs e)
        {
             log.lblDepartment.Text = btnTransportation.Text.ToUpper();
             log.ShowDialog();
            getButtonClicked = "Transportation";
            if (log.loginPressed)
             {
                Transportation trans= new Transportation();
                trans.ShowDialog();
             }
            
        }

        private void btnPackaging_Click(object sender, EventArgs e)
        {
            
            log.lblDepartment.Text = btnPackaging.Text.ToUpper();
            log.ShowDialog();
            getButtonClicked = "Packaging"; ;

            if (log.loginPressed)
            {
                Packaging stock = new Packaging();
                stock.ShowDialog();
            }
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            log.lblDepartment.Text = btnStock.Text.ToUpper();
            log.ShowDialog();
            getButtonClicked ="Stock Control";

            if (log.loginPressed) {
                StockControl stock = new StockControl();
                stock.ShowDialog();
            }
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            
        }
    }
}
