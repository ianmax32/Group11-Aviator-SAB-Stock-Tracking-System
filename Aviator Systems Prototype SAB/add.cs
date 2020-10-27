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
using System.Security.Cryptography;

namespace Aviator_Systems_Prototype_SAB
{
    public partial class add : Form
    {
        private String connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\masag\Desktop\Aviator Systems Prototype SAB\Aviator Systems Prototype SAB\SAB System.mdf;Integrated Security=True";
        private SqlConnection conn;
        private DataSet ds;
        private SqlDataAdapter adapter;

        public add()
        {
            InitializeComponent();
        }

        private void add_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(connectionString);
            adapter = new SqlDataAdapter();
            tabControl1.Visible = false;
        }

        private void treeView1_DoubleClick(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode.Text.Equals("Employees"))
            {
                tabControl1.SelectTab(0);

                tabControl1.Visible = true;
            }
            else if (treeView1.SelectedNode.Text.Equals("Customers"))
            {
                tabControl1.SelectTab(1);
                tabControl1.Visible = true;
            }
            else if (treeView1.SelectedNode.Text.Equals("Brand"))
            {
                tabControl1.SelectTab(2);
                tabControl1.Visible = true;
                tabControl2.SelectTab(0);
            }
            else if (treeView1.SelectedNode.Text.Equals("Warehouse")) {
                tabControl1.SelectTab(3);
                tabControl1.Visible = true;
            }
        }

        private void btnAddEmpl_Click(object sender, EventArgs e)
        {
            String employee_id = textBoxEName.Text.Substring(0,2) + textBoxESurn.Text.Substring(0,2) + (100 + new Random().Next(999) + textBoxPosition.Text.Substring(0,2));
            String employee_password = textBoxEName.Text; //Has to be generated
            try
            {
                MessageBox.Show("Name :" +textBoxEName.Text + "\nSurname:" + textBoxESurn.Text + "\nEmployee Position:" + textBoxPosition.Text + "\nLocation:" + textBoxLocation.Text + "\n\nHas been added");
                //conn.Open();
                adapter.InsertCommand = new SqlCommand("insert into employees values('" + employee_id + "','" + textBoxEName.Text + "','" + textBoxESurn.Text + "','" + textBoxPosition.Text + "','" + employee_password + "','" + textBoxLocation.Text + "');", conn);
                adapter.InsertCommand.ExecuteNonQuery();
                conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            lblEmployeePassword.Text = employee_password;
            lblUsername.Text = employee_id;
        }

        private void btnAddCust_Click(object sender, EventArgs e)
        {
            String liqour_licence = (1000 + new Random().Next(9999)) + textBoxCustSurn.Text.Substring(0, 2).ToUpper()  + textBoxCustLoc.Text.Substring(0,2).ToUpper() + (10 + new Random().Next(99));
            String customer_password = textBoxEName.Text;
            try
            {
                conn.Open();
                adapter.InsertCommand = new SqlCommand("insert into customer values('" + liqour_licence + "','" + textBoxCustName.Text + "','" + textBoxCustSurn.Text + "','" + textBoxCustLoc.Text + "','" + textBoxStoreName.Text + "');",conn);
                adapter.InsertCommand.ExecuteNonQuery();
                conn.Close();
            }
            catch (SqlException ex) {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("Customer aded successfully");
            lblCustomerPassword.Text = customer_password;
            lblCustomerLicence.Text = liqour_licence;
            textBoxCustLoc.Text = "";
            textBoxCustName.Text = "";
            textBoxCustSurn.Text = "";
            textBoxStoreName.Text = "";
        }

        private void btnAddBrand_Click(object sender, EventArgs e)
        {
            String product_Id = textBoxBrandName.Text + textBoxBrandSize.Text;
            
            try
            {
                conn.Open();
                adapter.InsertCommand = new SqlCommand("insert into  product values('" + product_Id+ "','" + textBoxBrandName.Text + "','" + int.Parse(textBoxBrandSize.Text) + "','" + int.Parse(textBoxBrandAmount.Text) + "','" + textBoxBrandColor.Text + "');", conn);
                adapter.InsertCommand.ExecuteNonQuery();
                conn.Close();

                conn.Open();
                adapter.InsertCommand = new SqlCommand("update warehouse set  product_amount='" + int.Parse(textBoxBrandAmount.Text) + "' where Product_Id = '"+ textBoxBrandName.Text + "';", conn);
                adapter.InsertCommand.ExecuteNonQuery();
                conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void treeView1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddWarehouse_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                DataTable dt = new DataTable();
                adapter.SelectCommand = new SqlCommand("Select * from warehouse", conn);
                adapter.Fill(dt);
                int count = 0;
                if (dt.Rows.Count > 0)
                {
                    count = dt.Rows.Count;
                }
                conn.Close();

                conn.Open();
                adapter = new SqlDataAdapter();
                adapter.InsertCommand = new SqlCommand("insert into  warehouse values('" + count++ + "','" +textBoxWareHouseLocation.Text + "','0','0','0','0','0','0','0','0','0','0','null','" + textBoxWarehouseManager.Text+ "');", conn);
                adapter.InsertCommand.ExecuteNonQuery();
                conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
