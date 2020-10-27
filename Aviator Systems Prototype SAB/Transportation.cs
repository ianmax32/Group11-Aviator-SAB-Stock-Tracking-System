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
using System.IO;

namespace Aviator_Systems_Prototype_SAB
{
    public partial class Transportation : Form
    {
        private String connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\SAB System.mdf";
        public DataSet ds = new DataSet();
        public SqlDataReader dr;
        private SqlDataAdapter adapter;
        private SqlConnection conn;
        private Packaging packedItems = new Packaging();

        public Transportation()
        {
            InitializeComponent();
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Word Documents|*.doc";
            saveFileDialog1.FileName = "Report";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK) {
                try
                {
                    StreamWriter writeFile = new StreamWriter(saveFileDialog1.FileName);
                    writeFile.Write("Report on the stock that was tranfered on " + DateTime.Now + " from the Plant to Warehouse Number 1\n");
                    for (int a = 0; a < listBoxTrailersLoaded.Items.Count; a++) {
                        writeFile.Write(listBoxTrailersLoaded.Items[a].ToString() + "\n");
                    }

                    writeFile.Close();
                }
                catch (IOException ex)
                {
                    MessageBox.Show(ex.Message);
                }

               
            }
        }

        private void Transportation_Load(object sender, EventArgs e)
        {
            listBoxTrailers.SelectedIndex = 0;
        }

        private void btnLogoutManagement_Click(object sender, EventArgs e)
        {
            this.Close();
            login log = new login();
            log.loginPressed = false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void customerStatsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listBoxTrailers_SelectedIndexChanged(object sender, EventArgs e)
        {
            //listBoxTrailersLoaded.Items.Add(packedItems.getInfoPackaged[listBoxTrailers.SelectedItem.ToString()]);
        }

        private void listBoxTrailers_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
                if (listBoxTrailers.SelectedItem.ToString().Equals("T1234"))
                {
                    try
                    {
                        conn = new SqlConnection(connectionString);
                        conn.Open();
                        dr = new SqlCommand("Select * from product", conn).ExecuteReader();

                        String output = "";
                        listBoxTrailersLoaded.Items.Clear();
                        listBoxTrailersLoaded.Items.Add("-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                        listBoxTrailersLoaded.Items.Add("Product ID    " + "\t" + "Product Name  " + "\t" + "Product Size  " + "\t" + "Product Amount" + "\t" + "Color         " + "\t" + "Trailer Number");
                        listBoxTrailersLoaded.Items.Add("----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");


                        while (dr.Read())
                        {
                            output = (dr.GetValue(0) + "\t " + dr.GetValue(1) + "\t   " + dr.GetValue(2) + "\t\t" + dr.GetValue(3) + "\t\t" + dr.GetValue(4) + "\t\t" + listBoxTrailers.SelectedItem.ToString());
                            listBoxTrailersLoaded.Items.Add(output);
                        }
                        conn.Close();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else {
                    listBoxTrailersLoaded.Items.Add(listBoxTrailers.SelectedItem.ToString() + " is trailer is not loaded");
                }
            
        }
            
    }
}
