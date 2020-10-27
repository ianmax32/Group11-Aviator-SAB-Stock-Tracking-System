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
using MySql.Data.MySqlClient;

namespace Aviator_Systems_Prototype_SAB
{
    public partial class login : Form
    {
        public String employeeNameSurname { get; set; }
        public String productInfomation { get; set; }
        public Boolean loginPressed { get; set; }

        string server = "db4free.net";
        string databasename = "sabsystem";
        string username = "sabdatabase";
        string password = "6991@Ian";

        private String connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\SAB System.mdf;Integrated Security=True";
     
        public SqlDataReader dr;
        private SqlDataAdapter adapter;
        private SqlConnection conn;
        

        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //if(btnLogin.Click)
            userLog();
            textBoxUsername.Clear();
            textBoxPassword.Clear();
            this.Visible = false;
        }

        public void userLog()
        {
            conn = new SqlConnection(connectionString);
            adapter = new SqlDataAdapter();

            adapter.SelectCommand = new SqlCommand("Select * from employees where employee_id = '" + textBoxUsername.Text + "' and password='" + textBoxPassword.Text + "'", conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
                
            
                if (dt.Rows.Count == 1)
                {
                    employeeNameSurname = textBoxUsername.Text;
                    loginPressed = true;
                }
                else
                {
                    MessageBox.Show("User does not Exist!");
                    loginPressed = false;
                }
            conn.Close();
        }

        
    }
}
