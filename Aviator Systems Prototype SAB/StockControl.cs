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
using System.Collections;

namespace Aviator_Systems_Prototype_SAB
{
    public partial class StockControl : Form
    {
        private String connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\SAB System.mdf;Integrated Security = True";
        public DataSet ds = new DataSet();
        public SqlDataReader dr;
        private SqlDataAdapter adapter;
        private SqlConnection conn;
        private ArrayList orders = new ArrayList();
        private String[] ordersString = new String[100000];
        viewOrders viewOrderAvailable = new viewOrders();

        public StockControl()
        {
            InitializeComponent();
        }

        private void StockControl_Load(object sender, EventArgs e)
        {
            displayInfo();
            
            if (viewOrderAvailable.btnapproveClicked)
            {
                displayInfo();
            }
        }

        private void btnViewOrders_Click(object sender, EventArgs e)//this button will call he viewcurrentOrders to get the current orders from the database
        {
            //viewCurrentOrders();
            ListBox list = new ListBox();
            list.Width = viewOrderAvailable.Width;
            list.Height = viewOrderAvailable.Height;
            list.Font = new Font(FontFamily.GenericSansSerif,9,FontStyle.Bold);
            
             list.Items.Add(String.Format("{0,-40}{1,-50}{2,-40}{3,-40}{4,-40}","Order ID", "Brand", "Size", "Amount", "Date"));

            for (int a = 0; a < orders.Count; a++) {
                list.Items.Add(ordersString[a]);
            }

            try
            {
                conn = new SqlConnection(connectionString);
                conn.Open();
                dr = new SqlCommand("Select order_request.order_number,order_request.brand_name,order_request.size,order_request.amount,order_request.order_date from order_request join customer on customer.Liqour_License = order_request.liquor_licence", conn).ExecuteReader();

                while (dr.Read())
                {
                    list.Items.Add(String.Format("{0,-40}{1,-50}{2,-40}{3,-40}{4,-40}", dr.GetValue(0).ToString(), dr.GetValue(1).ToString(), dr.GetValue(2).ToString(), dr.GetValue(3).ToString(), dr.GetValue(4).ToString()));
                }
                conn.Close();
               
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            viewOrderAvailable.Controls.Add(list);
            viewOrderAvailable.Show();
          
        }

        public String[] viewCurrentOrders()
        {
            int count = 0;
            try
            {
                conn = new SqlConnection(connectionString);
                conn.Open();
                dr = new SqlCommand("Select order_request.order_number,order_request.brand_name,order_request.size,order_request.amount,order_request.order_date from order_request join customer on customer.Liqour_License = order_request.liquor_licence", conn).ExecuteReader();


                while (dr.Read())
                {
                    //ordersString[count] = "\n\n" + dr.GetValue(0).ToString() + "\t\t" + dr.GetValue(1) + "\t\t" + dr.GetValue(2) + "\t\t" + dr.GetValue(3) + "\t\t" + dr.GetValue(4) + "\n\n";
                    ordersString[count] = string.Format("{0,-40}{1,-40}{2,-40}{3,-40}{4,-40}", dr.GetValue(0).ToString(),dr.GetValue(1).ToString(), dr.GetValue(2).ToString(), dr.GetValue(3).ToString(), dr.GetValue(4).ToString());
                    count++;
                }
                conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return ordersString;
        }

        private void btnUpdateSTock_Click(object sender, EventArgs e)
        {
            updateStock();
            InitializeComponent();
        }

        public void displayInfo() {
            try
            {
                    conn = new SqlConnection(connectionString);
                    conn.Open();
                    dr = new SqlCommand("Select * from warehouse where warehouse_id='1'", conn).ExecuteReader();

                    String output = "";
                    listBoxStockInfo.Items.Clear();
                    listBoxStockInfo.Items.Add("------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                    listBoxStockInfo.Items.Add("WAREHOUSE ID" + "\t\t\t" + "LOCATION" + "\t\t" + "STOCK TAKER" + "\t\t" + "DATE" + "\t\t" + "PRODUCT" + "\t\t" + "AMOUNT");
                    listBoxStockInfo.Items.Add("------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");


                    while (dr.Read())
                    {
                        output = ( dr.GetValue(0) + "\t\t\t\t" + dr.GetValue(1) + "\t\t" + dr.GetValue(2) + "\t\t\t"  + dr.GetValue(4) + "\t" + dr.GetValue(5) + "\t\t" + dr.GetValue(6));
                        listBoxStockInfo.Items.Add(output);
                        //MessageBox.Show(output);
                    }
                    conn.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
            }
           
        }

        

        private void btnLogoutManagement_Click(object sender, EventArgs e)
        {
            this.Close();
            login log = new login();
            log.loginPressed = false;
        }

        private void waToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updateStock();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void updateStock() {
            UpdateStock update = new UpdateStock();
            update.ShowDialog();
            if (update.doneClicked)
            {
                try
                {
                    conn.Open();
                    adapter = new SqlDataAdapter();
                    for (int a = 0; a < update.updateinfo.Count; a++) {
                        adapter.InsertCommand = new SqlCommand("update warehouse set Date='" + update.date + "', product_amount = '" +
                                                              update.updateinfo[update.updateinfo.ElementAt(a).Key.ToString()] + "' where Product_Id='"+update.updateinfo.ElementAt(a).Key.ToString() + "';", conn);

                        adapter.InsertCommand.ExecuteNonQuery();
                    }
                    
                    conn.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            displayInfo();

        }

        private void customerPerformanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(connectionString);
                conn.Open();
                dr = new SqlCommand("Select order_request.brand_name, order_request.size, order_request.amount, customer.customer_name" +
                    " from order_request inner join customer on order_request.liquor_licence= customer.Liqour_License", conn).ExecuteReader();

                String output = "";
                listBoxStockInfo.Items.Clear();
                listBoxStockInfo.Items.Add("------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                listBoxStockInfo.Items.Add(" CUSTOMER PERFOMANCE");
                listBoxStockInfo.Items.Add("------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");


                while (dr.Read())
                {
                    output = (dr.GetValue(0) + "\t" + dr.GetValue(1) + "\t" + dr.GetValue(2) + "\t\t" + dr.GetValue(3));
                    listBoxStockInfo.Items.Add(output);
                }
                conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void mostOrderedProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(connectionString);
                conn.Open();
                dr = new SqlCommand("Select order_request.brand_name, order_request.size, order_request.amount from order_request order by order_request.amount DESC", conn).ExecuteReader();

                String output = "";
                listBoxStockInfo.Items.Clear();
                listBoxStockInfo.Items.Add("------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                listBoxStockInfo.Items.Add(" MOST ORDERED PRODUCT");
                listBoxStockInfo.Items.Add("------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");


                while (dr.Read())
                {
                    output = String.Format("{0,-100}{1,-15}{2,10}",dr.GetValue(0),dr.GetValue(1),dr.GetValue(2));
                    listBoxStockInfo.Items.Add(output);
                }
                conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}
