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
    public partial class management : Form
    {
        private String connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\SAB System.mdf;Integrated Security=True";
        public DataSet ds = new DataSet();
        public SqlDataReader dr;
        private SqlDataAdapter adapter;
        private SqlConnection conn;
        private login log = new login();


        public management()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            add addMoreInfor = new add();
            addMoreInfor.ShowDialog();
        }

        private void management_Load(object sender, EventArgs e)
        {
            //lblName.Text = log.employeeNameSurname.ToString();
            //log.userLog();
            try
            {
                conn = new SqlConnection(connectionString);
                adapter = new SqlDataAdapter();
                conn.Open();
                adapter.SelectCommand = new SqlCommand("select warehouse_id,location,Manager,Product_id,product_amount from warehouse order by Date desc", conn);
                adapter.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Refresh();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }

        private void btnLogoutManagement_Click(object sender, EventArgs e)
        {
            this.Close();
            login log = new login();
            log.loginPressed = false;
        }

        private void brandPerfomanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                tabControl1.SelectTab(1);
                conn = new SqlConnection(connectionString);
                adapter = new SqlDataAdapter();
                conn.Open();
                adapter.SelectCommand = new SqlCommand("select Product_Id, product_amount from warehouse order by product_amount desc", conn);
                adapter.Fill(ds);

                dataGridView2.DataSource = ds.Tables[0];
                dataGridView2.Refresh();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }

        private void mostOrderedProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                tabControl1.SelectTab(0);
                conn = new SqlConnection(connectionString);
                conn.Open();

                adapter.SelectCommand = new SqlCommand("Select order_request.brand_name, order_request.size, order_request.amount from order_request order by order_request.amount DESC", conn);
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Refresh();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void customerPerformanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                tabControl1.SelectTab(1);
                dataGridView2.DataSource = null;
                conn = new SqlConnection(connectionString);
                conn.Open();
                adapter.SelectCommand = new SqlCommand("Select order_request.brand_name, order_request.size, order_request.amount, customer.customer_name from order_request inner join customer on order_request.liquor_licence= customer.Liqour_License", conn);

                adapter.Fill(ds);

                dataGridView2.DataSource = ds.Tables[0];
                dataGridView2.AutoResizeColumns(); 
                dataGridView2.Refresh();
                conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void waToolStripMenuItem_Click(object sender, EventArgs e)
        {
            add addMoreInfor = new add();
            addMoreInfor.ShowDialog();
        }

        private void addCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            add addMoreInfor = new add();
            addMoreInfor.ShowDialog();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            add addMoreInfor = new add();
            addMoreInfor.ShowDialog();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void warehousePerfomanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                tabControl1.SelectTab(0);
                dataGridView1.Refresh();
                conn = new SqlConnection(connectionString);
                conn.Open();
                adapter.SelectCommand = new SqlCommand("Select  * from warehouse order by Warehouse_Id ", conn);

                adapter.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.AutoResizeColumns();
                dataGridView1.Refresh();
                conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                dataGridView2.Refresh();
            }
            else if (tabControl1.SelectedIndex == 0)
            {
                dataGridView1.Refresh();
            }
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reports report = new reports();
            report.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
