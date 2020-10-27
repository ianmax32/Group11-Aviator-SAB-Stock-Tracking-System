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

namespace Aviator_Systems_Prototype_SAB
{
    public partial class viewOrders : Form
    {
        private String connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\SAB System.mdf;Integrated Security=True";
        public bool btnapproveClicked { get; set; }
        public bool btnDeclineClicked { get; set; }
        public DataSet ds = new DataSet();
        public SqlDataReader dr;
        private SqlDataAdapter adapter;
        private SqlConnection conn;


        public viewOrders()
        {
            InitializeComponent();
        }

        private void viewOrders_Load(object sender, EventArgs e)
        {
            StockControl view = new StockControl();
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            btnapproveClicked = true;
            Dictionary<string, int> dict = new Dictionary<string, int>();
            Dictionary<string, int> dict2 = new Dictionary<string, int>();
            Dictionary<string, int> dict3 = new Dictionary<string, int>();
            string[] names = new string[25];
            string[] names2 = new string[25];
            string dates = "";
           
            try
            {
                conn = new SqlConnection(connectionString);
                
                conn.Open();
                dr = new SqlCommand("Select brand_name, amount,order_date,customer_name from order_request join customer on customer.Liqour_License = order_request.liquor_licence", conn).ExecuteReader();

                int count = 0;
                while (dr.Read())
                {
                    dict2.Add(dr.GetValue(0).ToString(), int.Parse(dr.GetValue(1).ToString()));
                    dates = dr.GetValue(2).ToString();
                    names[count] = dr.GetValue(3).ToString();
                    count++;
                }
                conn.Close();

                for (int a = 0; a < dict2.Count; a++) {
                    conn.Open();
                    dr = new SqlCommand("Select Product_Id, product_amount from warehouse where Product_Id='" + dict2.ElementAt(a).Key.ToString() + "'", conn).ExecuteReader();

                    int count2 = 0;
                    while (dr.Read())
                    {
                        dict.Add(dr.GetValue(0).ToString(), int.Parse(dr.GetValue(1).ToString()));
                        names2[count2] = dr.GetValue(0).ToString();
                        count2++;
                    }
                    conn.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            for (int a = 0; a < dict.Count; a++) {
                dict3.Add(dict.ElementAt(a).Key.ToString(),(dict[dict.ElementAt(a).Key.ToString()] - dict2[dict2.ElementAt(a).Key.ToString()]));
            }

            try
            {
                conn.Open();
                adapter = new SqlDataAdapter();
                DateTime date = new DateTime();
                for (int a = 0; a < dict3.Count; a++)
                {
                    adapter.InsertCommand = new SqlCommand("update warehouse set product_amount='" + dict3[dict3.ElementAt(a).Key.ToString()] + "' where Product_Id = '" + dict3.ElementAt(a).Key.ToString() + "';", conn);

                    adapter.InsertCommand.ExecuteNonQuery();
                }
                conn.Close();

                for (int a = 0; a < dict2.Count; a++)
                {
                    conn.Open();
                    adapter.DeleteCommand = new SqlCommand("delete from order_request where brand_name='" + dict2.ElementAt(a).Key.ToString() + "'", conn);
                    adapter.DeleteCommand.ExecuteNonQuery();
                    
                    conn.Close();
                }
                InitializeComponent();

                for (int a = 0; a < dict2.Count; a++)
                {
                    conn.Open();
                    adapter.InsertCommand = new SqlCommand("insert into Invoices values('"+(generateInvoice() + 1)+"','" + dict2.ElementAt(a).Key.ToString() + "','"+dates+"','"+dict2[dict2.ElementAt(a).Key.ToString()] +"','null','"+names[a]+"')", conn);
                    adapter.InsertCommand.ExecuteNonQuery();

                    conn.Close();
                }
                conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("Customer will receive the invoice","Orders Confirmed");
            this.Close();
        }

        private void btnDecline_Click(object sender, EventArgs e)
        {
            btnDeclineClicked = true;
            try {
                
                    conn.Open();
                    adapter.DeleteCommand = new SqlCommand("delete from order_request", conn);
                    adapter.DeleteCommand.ExecuteNonQuery();

                    conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("Emails will be sent to the Customers about the decline");
        }

        private void btnExitOrders_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public int generateInvoice()
        {
            int invoiceId = 0;
            invoiceId = 100000 + new Random().Next(999999);
            return invoiceId;
        }
    }
}

