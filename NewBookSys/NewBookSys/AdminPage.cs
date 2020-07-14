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
    public partial class AdminPage : Form
    {
        public AdminPage()
        {
            InitializeComponent();
            CenterToScreen();
        }

        //define connection string and assigned to a string variable
        string connectString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=NewBooking;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        private void AdminPage_Load(object sender, EventArgs e)
        {
            //x values represent the month, y values represent No. of Bookings
            //call the function that returns the monthly booking contents (DataTable GetData())
            MonthlyBookingsChart.DataSource = GetData();
            MonthlyBookingsChart.Series["MonthlyBookings"].XValueMember = "Month";
            MonthlyBookingsChart.Series["MonthlyBookings"].YValueMembers = "No. Of Bookings";

            //x value = Year, y values = no. of bookings
            //call the function that returns the yearlt booking contents (DataTable GetData2())
            YearlyBookingsChart.DataSource = GetData2();
            YearlyBookingsChart.Series["YearlyBookings"].XValueMember = "Year";
            YearlyBookingsChart.Series["YearlyBookings"].YValueMembers = "No. Of Bookings";
        }

        private DataTable GetData2()
        {
            //virtual table created
            DataTable dtData = new DataTable();

            //SQL connection established
            using (SqlConnection con = new SqlConnection(connectString))
            {
                //SQL command created calling stored procedure 'YearlyBookings'
                using (SqlCommand cmd = new SqlCommand("YearlyBookings", con))
                {
                    //defining the type of command
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();

                    //get query results as a DataReader object
                    SqlDataReader reader = cmd.ExecuteReader();

                    //populates the dataTable using the query results from the DataReader
                    dtData.Load(reader);
                }
            }

            //return the contents stored in the DataTable
            return dtData;
        }

        private DataTable GetData()
        {
            //new virtual table created
            DataTable dtData = new DataTable();

            //SQL connection defined
            using (SqlConnection con = new SqlConnection(connectString))
            {
                //new SQL command created called stored procedure "MonthlyBooking"
                using (SqlCommand cmd = new SqlCommand("MonthlyBookings", con))
                {
                    //define the command type
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();

                    //get query results as a DataReader object
                    SqlDataReader reader = cmd.ExecuteReader();

                    //contents of DataReader object loaded into DataTable
                    dtData.Load(reader);
                }
            }

                //return the contents stored in DataTable
                return dtData;
        }

        //Bookings report tab

        private void btnLoad_Click(object sender, EventArgs e)
        {
            //establish and open SQL connection to DB
            using (SqlConnection con = new SqlConnection(connectString))
            {
                con.Open();
                //Run query to select all the rows of data in the booking table
                SqlDataAdapter adminControl = new SqlDataAdapter("SELECT * FROM BookingTBL", con);
                //hold results of query in a virtual table
                DataTable controlDT = new DataTable();
                adminControl.Fill(controlDT);

                //link data panel and virtual table to display contents.
                adminViewer.DataSource = controlDT;
                //disconnect from database
                con.Close();
            }
        }
    }
}
