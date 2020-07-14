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

namespace NewBookSys
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
            CenterToScreen();
        }

        //connection string assigned to string variable
        string connectString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=NewBooking;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        private void btnLogin2_Click(object sender, EventArgs e)
        {
            //checks to see if any of the fields have been left empty
            if (txtAdmin.Text != "" && txtAdminPass.Text != "")
            {
                //Fields contain data and SQL connection is defined using string variable
                SqlConnection Con = new SqlConnection(connectString);
                //database connection opened
                Con.Open();
                //Retrieving data from UserTBL through SQL query and storing it in a virtual table
                SqlDataAdapter adminHolder = new SqlDataAdapter("SELECT COUNT(*) FROM UserTBL WHERE Username ='" + txtAdmin.Text + "' AND Password ='" + txtAdminPass.Text + "'", Con);
                DataTable dt = new DataTable();
                adminHolder.Fill(dt);

                //checks to see if a value has been returned
                if (dt.Rows[0][0].ToString() == "1")
                {
                    //Username and password match values in UserTBL
                    //Output message indicating successful login
                    MessageBox.Show("Login Successful!");
                    //Current window closes, Admin management page made visible
                    this.Hide();
                    AdminPage admin_PageForm = new AdminPage();
                    admin_PageForm.Show();
                }
                else
                {
                    //invalid user credentials associated with admin
                    MessageBox.Show("Login Failed! User credentials invalid!");
                }
            }
            else
            {
                //Empty fields detected
                MessageBox.Show("Complete all fields!");
            }
        }
    }
}
