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
    public partial class UpdateStock : Form
    {
        public Boolean doneClicked { get; set; }
        public string amountOnGround { get; set; }
        public String date { get; set; }
        public String getBrand { get; set; }
        public Dictionary<string, int> updateinfo = new Dictionary<string, int>();
        public String[] names = new string[1000];
        
        
        
        private String connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\SAB System.mdf;Integrated Security=True";
        public SqlDataReader dr;
        private SqlConnection conn;

        public UpdateStock()
        {
            InitializeComponent();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(comboBox1.SelectedItem.ToString() + "\t" + textBoxAmount.Text);
            updateinfo.Add(comboBox1.SelectedItem.ToString(), int.Parse(textBoxAmount.Text));
      

            textBoxAmount.Clear();
            date = dateTimePicker1.Value.Day + "/" + dateTimePicker1.Value.Month + "/" + dateTimePicker1.Value.Year;
        }

        private void UpdateStock_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            try
            {
                conn = new SqlConnection(connectionString);
                conn.Open();
                dr = new SqlCommand("select Product_Id from warehouse", conn).ExecuteReader();
                int count = 0;
                while (dr.Read())
                {
                    comboBox1.Items.Add(dr.GetValue(0));
                    names[count] = dr.GetValue(0).ToString();
                    Console.WriteLine(dr.GetValue(0).ToString());
                    count++;
                }
                conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            doneClicked = true;
            this.Close();
        }
    }
}
