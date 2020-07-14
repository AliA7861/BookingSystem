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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            CenterToScreen();
        }

        //define SQL connection details to relevant database and assigned to string variable
        string connectString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=NewBooking;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //Display register window if 'Register' button pressed. Hides this window.
            this.Hide();
            Register registerForm = new Register();
            registerForm.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //checking to see both fields haven't been left empty
            if (txtUsername.Text != "" && txtPassword.Text != "")
            {
                //Defined SQL connection by referring to variable holding the connection string
                SqlConnection sqlCon = new SqlConnection(connectString);
                //Retrieves the necessary data relating to SQL query
                SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM UserTBL WHERE Username ='" + txtUsername.Text + "' AND Password = '" + txtPassword.Text + "'", sqlCon);
                //Holds data into a virtual table
                DataTable dt = new DataTable();
                sda.Fill(dt);

                //checks if the table contains a returned value
                if (dt.Rows[0][0].ToString() == "1")
                {
                    //Output message displayed to user
                    MessageBox.Show("Login Successful!");
                    //Current window closed and booking page is made visible
                    this.Hide();
                    BookingPage bookingForm = new BookingPage();
                    bookingForm.Show();

                }
                else
                {
                    //Error message to indicate the user has entered invalid credentials
                    MessageBox.Show("Login failed!");
                }
            }
            else
            {
                //Error message to enter data into all fields
                MessageBox.Show("Complete all fields!");
            }
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            //Admin login page displayed and normal user login window closed
            this.Hide();
            AdminLogin adminForm = new AdminLogin();
            adminForm.Show();
        }
    }
}