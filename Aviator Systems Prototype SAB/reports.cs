using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.IO;

namespace Aviator_Systems_Prototype_SAB
{
    public partial class reports : Form
    {
        private String connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\SAB System.mdf;Integrated Security=True";
        public SqlDataReader dr;
        private SqlDataAdapter adapter;
        private SqlConnection conn;

        public reports()
        {
            InitializeComponent();
        }

        private void btnCloseReports_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void reports_Load(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(connectionString);
                conn.Open();
                dr = new SqlCommand("Select * from invoices order by amount", conn).ExecuteReader();

                listBoxReports.Items.Add("Invoices");
                while (dr.Read())
                {
                    listBoxReports.Items.Add(dr.GetValue(0) + "\t\t" + dr.GetValue(1) + "\t\t"+ dr.GetValue(2) + "\t\t" + dr.GetValue(3) + "\t\t" + dr.GetValue(5) + "\n");
                }


                conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSaveReports_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Word Documents|*.doc";
            saveFileDialog1.FileName = "Report";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamWriter writeFile = new StreamWriter(saveFileDialog1.FileName);
                    writeFile.Write("Report on All Invoicese " + DateTime.Now + "\n");
                    writeFile.Write("\n");
                    writeFile.Write("\n");
                    for (int a = 0; a < listBoxReports.Items.Count; a++) {
                        writeFile.Write(listBoxReports.Items[a].ToString() + "\n");
                    }

                    writeFile.Close();
                }
                catch (IOException ex)
                {
                    MessageBox.Show(ex.Message);
                }


            }
        }
    }
}
