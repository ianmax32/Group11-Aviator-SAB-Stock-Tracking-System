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
    public partial class Packaging : Form
    {
        private String connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\SAB SYSTEM.MDF";
        public DataSet ds = new DataSet();
        public SqlDataReader dr;
        private SqlDataAdapter adapter;
        private SqlConnection conn;
        public Dictionary<string, string> getInfoPackaged = new Dictionary<string, string>();

        public Packaging()
        {
            InitializeComponent();
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void treeView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(connectionString);
                conn.Open();
                dr = new SqlCommand("Select * from product where product_name like '%"+treeView1.SelectedNode.Text.ToString()+"'", conn).ExecuteReader();

                String output = "";
                listBoxInfoToSend.Items.Clear();
                listBoxInfoToSend.Items.Add("-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                listBoxInfoToSend.Items.Add("Product ID    " + "\t" + "Product Name  " + "\t" + "Product Size  " + "\t" + "Product Amount" + "\t" + "Color         ");
                listBoxInfoToSend.Items.Add("----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");


                while (dr.Read())
                {
                    output = (dr.GetValue(0) + "\t " + dr.GetValue(1) + "\t   " + dr.GetValue(2) + "\t\t" + dr.GetValue(3) + "\t\t" + dr.GetValue(4));
                    listBoxInfoToSend.Items.Add(output);
                }
                conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBoxInfoToSend.SelectedItem !=  null && comboBox1.SelectedItem != null)
            {
                getInfoPackaged[comboBox1.SelectedItem.ToString()] = listBoxInfoToSend.SelectedItem.ToString();
            }
            else if(listBoxInfoToSend.SelectedItem != null)
            {
                
            }
            
            MessageBox.Show("Information Sent to the Transport Department");
        }

        private void btnLogoutManagement_Click(object sender, EventArgs e)
        {
            login log = new login();
            log.loginPressed = false;
            this.Close();
        }

        private void Packaging_Load(object sender, EventArgs e)
        {
            for (int a = 0; a < comboBox1.Items.Count; a++)
            {
                getInfoPackaged.Add(comboBox1.Items[a].ToString(), "Nothing loaded on this trailer");
            }
        }
    }
}
