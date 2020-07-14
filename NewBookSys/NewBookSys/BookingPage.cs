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
    public partial class BookingPage : Form
    {
        //Define the SQL connection details
        string connectString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=NewBooking;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public BookingPage()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void BookingPage_Load(object sender, EventArgs e)
        {
            
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            //check if any of the fields have been left empty or not
            if (txtUserID.Text == "" && txtRoomID.Text == "")
            {
                //Error message to request the user to complete the page
                MessageBox.Show("Complete the booking form!");
            }
            else
            {
                //connection details defined to access database
                SqlConnection con = new SqlConnection(connectString);
                con.Open();

                //Validation to check if the user has booked multiple rooms for the same date and times
                //If true, user should be restricted from completing the reservation and make amendments

                SqlCommand userCheck = new SqlCommand("SELECT COUNT(*) FROM BookingTBL WHERE UserID = @UserID", con);
                userCheck.Parameters.AddWithValue("@UserID", txtUserID.Text.Trim());
                int userPresent = (int)userCheck.ExecuteScalar();

                //if the integer return is greater than 0, user is present in BookingTBL
                if (userPresent > 0)
                {
                    //User exists in booking table
                    MessageBox.Show("User has booking. Checking for any clashes");

                    //SQL command to return the number of rows in a table matching the Date
                    SqlCommand date = new SqlCommand("SELECT COUNT(*) FROM BookingTBL WHERE Date = @Date", con);
                    date.Parameters.AddWithValue("@Date", Convert.ToDateTime(txtDate.Text));
                    //Storing returned result in an integer variable
                    int sameDate = (int)date.ExecuteScalar();

                    //if the integer return is greater than 0, the date in the booking is the same
                    if (sameDate > 0)
                    {
                        //booking date is the same, checking number of rows in the table matching the start time
                        SqlCommand sTime = new SqlCommand("SELECT COUNT(*) FROM BookingTBL WHERE StartTime = @StartTime", con);
                        sTime.Parameters.AddWithValue("@StartTime", startTime.Text);
                        //return query result storeed in integer variable
                        int start = (int)sTime.ExecuteScalar();
                        
                        //if the start time exists in the table, check the end time
                        if (start > 0)
                        {
                            //start time does exist, SQL query to return rows where it matches the end time
                            SqlCommand eTime = new SqlCommand("SELECT COUNT(*) FROM BookingTBL WHERE EndTime = @EndTime", con);
                            eTime.Parameters.AddWithValue("@EndTime", endTime.Text);
                            int end = (int)eTime.ExecuteScalar();

                            //if the end time exists in the table, booking clash
                            if (end > 0)
                            {
                                //Clashed booking
                                MessageBox.Show("Bookings clash. Change the date and times");
                            }
                            //end time not the same but start time is - clashed booking
                            else
                            {
                                MessageBox.Show("Bookings clash. Change the date and times");
                            }
                        }
                        //condition where the start time isn't the same but the end time is - clashed booking
                        else
                        {
                            SqlCommand eTime = new SqlCommand("SELECT COUNT(*) FROM BookingTBL WHERE EndTime = @EndTime", con);
                            eTime.Parameters.AddWithValue("@EndTime", endTime.Text);
                            int end = (int)eTime.ExecuteScalar();

                            if (end > 0)
                            {
                                MessageBox.Show("User has bookings that clash. Change date and time");
                            }
                            //if neither are the same, booking process begins
                            else
                            {
                                MessageBox.Show("Booking in process");

                                //now perform checks on all bookings when the date is the same but times are different

                                //SQL Command to count the number of rows matching the specific date give
                                SqlCommand dateCheck1 = new SqlCommand("SELECT COUNT(*) FROM BookingTBL WHERE Date = @Date", con);
                                dateCheck1.Parameters.AddWithValue("@Date", Convert.ToDateTime(txtDate.Text));
                                //records the number of times the date appears in the booking table
                                int dateExist = (int)dateCheck1.ExecuteScalar();

                                //if the total number for specific date is greater than 1
                                if (dateExist > 0)
                                {
                                    //Date is present in the table
                                    //Needs to check if the room is also present on the same date
                                    //returns no. of rows where the RoomID is equivalent to user's input
                                    SqlDataAdapter roomHolder = new SqlDataAdapter("SELECT COUNT(*) FROM BookingTBL WHERE RoomID ='" + txtRoomID.Text + "'", con);
                                    //held query results in a virtual table
                                    DataTable dt = new DataTable();
                                    roomHolder.Fill(dt);

                                    if (dt.Rows[0][0].ToString() == "1")
                                    {
                                        //room is present in the table
                                        //query run to retrieve the number of rows matching the start time give
                                        SqlDataAdapter sTimeHolder = new SqlDataAdapter("SELECT COUNT(*) FROM BookingTBL WHERE StartTime ='" + startTime.Text + "'", con);
                                        //query results held in virtual table
                                        DataTable dt2 = new DataTable();
                                        sTimeHolder.Fill(dt2);

                                        if (dt2.Rows[0][0].ToString() == "1")
                                        {
                                            //room is present in table at start time
                                            SqlDataAdapter eTimeHolder = new SqlDataAdapter("SELECT COUNT(*) FROM BookingTBL WHERE EndTime ='" + endTime.Text + "'", con);
                                            DataTable dt3 = new DataTable();
                                            eTimeHolder.Fill(dt3);

                                            if (dt3.Rows[0][0].ToString() == "1")
                                            {
                                                //occupied room
                                                MessageBox.Show("Room is occupied during this time. Choose a different start and end time");
                                            }
                                            else
                                            {
                                                //room is available for user to book
                                                MessageBox.Show("Room occupied during this time!");
                                            }
                                        }
                                        else
                                        {
                                            //StartTime not present but the query run to check end time
                                            SqlDataAdapter eTimeHolder = new SqlDataAdapter("SELECT COUNT(*) FROM BookingTBL WHERE EndTime ='" + endTime.Text + "'", con);
                                            DataTable dt3 = new DataTable();
                                            eTimeHolder.Fill(dt3);

                                            if (dt3.Rows[0][0].ToString() == "1")
                                            {
                                                //occupied room
                                                MessageBox.Show("Room is occupied during this time. Choose a different start and end time");
                                            }
                                            else
                                            {
                                                //room is available for user to book
                                                MessageBox.Show("Room available");

                                                //Create SQL Command to add inputs to database at specific fields
                                                SqlCommand cmd = con.CreateCommand();
                                                //insert query to add data in the exact sequence
                                                cmd.CommandText = $"INSERT INTO BookingTBL(Date,StartTime,EndTime,UserID,RoomID) VALUES(@Date,@StartTime,@EndTime,@UserID,@RoomID)";
                                                //adding the date as a date value to the booking table
                                                cmd.Parameters.Add("@Date", SqlDbType.Date).Value = txtDate.Value.Date;
                                                //adding startTime and endTime inputs as a time value
                                                cmd.Parameters.Add("@StartTime", SqlDbType.Time).Value = startTime.Value.TimeOfDay;
                                                cmd.Parameters.Add("@EndTime", SqlDbType.Time).Value = endTime.Value.TimeOfDay;
                                                cmd.Parameters.Add("@UserID", txtUserID.Text.Trim());
                                                cmd.Parameters.Add("@RoomID", txtRoomID.Text.Trim());

                                                cmd.ExecuteNonQuery();
                                                //disconnect from the database
                                                con.Close();
                                                MessageBox.Show("Booking Successful!");
                                            }
                                        }
                                    }
                                    else
                                    {
                                        //room is available for user to book
                                        MessageBox.Show("Room available");

                                        //Create SQL Command to add inputs to database at specific fields
                                        SqlCommand cmd = con.CreateCommand();
                                        //insert query to add data in the exact sequence
                                        cmd.CommandText = $"INSERT INTO BookingTBL(Date,StartTime,EndTime,UserID,RoomID) VALUES(@Date,@StartTime,@EndTime,@UserID,@RoomID)";
                                        //adding the date as a date value to the booking table
                                        cmd.Parameters.Add("@Date", SqlDbType.Date).Value = txtDate.Value.Date;
                                        //adding startTime and endTime inputs as a time value
                                        cmd.Parameters.Add("@StartTime", SqlDbType.Time).Value = startTime.Value.TimeOfDay;
                                        cmd.Parameters.Add("@EndTime", SqlDbType.Time).Value = endTime.Value.TimeOfDay;
                                        cmd.Parameters.Add("@UserID", txtUserID.Text.Trim());
                                        cmd.Parameters.Add("@RoomID", txtRoomID.Text.Trim());

                                        cmd.ExecuteNonQuery();
                                        //disconnect from the database
                                        con.Close();
                                        MessageBox.Show("Booking Successful!");
                                    }
                                }
                                else
                                {
                                    //room is available for user to book
                                    MessageBox.Show("Room available");

                                    //Create SQL Command to add inputs to database at specific fields
                                    SqlCommand cmd = con.CreateCommand();
                                    //insert query to add data in the exact sequence
                                    cmd.CommandText = $"INSERT INTO BookingTBL(Date,StartTime,EndTime,UserID,RoomID) VALUES(@Date,@StartTime,@EndTime,@UserID,@RoomID)";
                                    //adding the date as a date value to the booking table
                                    cmd.Parameters.Add("@Date", SqlDbType.Date).Value = txtDate.Value.Date;
                                    //adding startTime and endTime inputs as a time value
                                    cmd.Parameters.Add("@StartTime", SqlDbType.Time).Value = startTime.Value.TimeOfDay;
                                    cmd.Parameters.Add("@EndTime", SqlDbType.Time).Value = endTime.Value.TimeOfDay;
                                    cmd.Parameters.Add("@UserID", txtUserID.Text.Trim());
                                    cmd.Parameters.Add("@RoomID", txtRoomID.Text.Trim());

                                    cmd.ExecuteNonQuery();
                                    //disconnect from the database
                                    con.Close();
                                    MessageBox.Show("Booking Successful!");
                                }
                            }
                        }
                    }
                    else
                    {
                        //Date isn't the same, add booking

                        //SQL Command to count the number of rows matching the specific date give
                        SqlCommand dateCheck2 = new SqlCommand("SELECT COUNT(*) FROM BookingTBL WHERE Date = @Date", con);
                        dateCheck2.Parameters.AddWithValue("@Date", Convert.ToDateTime(txtDate.Text));
                        //records the number of times the date appears in the booking table
                        int dateExist2 = (int)dateCheck2.ExecuteScalar();

                        //if the total number for specific date is greater than 1
                        if (dateExist2 > 0)
                        {
                            //Date is present in the table
                            //Needs to check if the room is also present on the same date
                            //returns no. of rows where the RoomID is equivalent to user's input
                            SqlDataAdapter roomHolder = new SqlDataAdapter("SELECT COUNT(*) FROM BookingTBL WHERE RoomID ='" + txtRoomID.Text + "'", con);
                            //held query results in a virtual table
                            DataTable dt = new DataTable();
                            roomHolder.Fill(dt);

                            if (dt.Rows[0][0].ToString() == "1")
                            {
                                //room is present in the table
                                //query run to retrieve the number of rows matching the start time give
                                SqlDataAdapter sTimeHolder = new SqlDataAdapter("SELECT COUNT(*) FROM BookingTBL WHERE StartTime ='" + startTime.Text + "'", con);
                                //query results held in virtual table
                                DataTable dt2 = new DataTable();
                                sTimeHolder.Fill(dt2);

                                if (dt2.Rows[0][0].ToString() == "1")
                                {
                                    //room is present in table at start time
                                    SqlDataAdapter eTimeHolder = new SqlDataAdapter("SELECT COUNT(*) FROM BookingTBL WHERE EndTime ='" + endTime.Text + "'", con);
                                    DataTable dt3 = new DataTable();
                                    eTimeHolder.Fill(dt3);

                                    if (dt3.Rows[0][0].ToString() == "1")
                                    {
                                        //occupied room
                                        MessageBox.Show("Room is occupied during this time. Choose a different start and end time");
                                    }
                                    else
                                    {
                                        //room is available for user to book
                                        MessageBox.Show("Room occupied during this time!");
                                    }
                                }
                                else
                                {
                                    //StartTime not present but the query run to check end time
                                    SqlDataAdapter eTimeHolder = new SqlDataAdapter("SELECT COUNT(*) FROM BookingTBL WHERE EndTime ='" + endTime.Text + "'", con);
                                    DataTable dt3 = new DataTable();
                                    eTimeHolder.Fill(dt3);

                                    if (dt3.Rows[0][0].ToString() == "1")
                                    {
                                        //occupied room
                                        MessageBox.Show("Room is occupied during this time. Choose a different start and end time");
                                    }
                                    else
                                    {
                                        //room is available for user to book
                                        MessageBox.Show("Room available");

                                        //Create SQL Command to add inputs to database at specific fields
                                        SqlCommand cmd = con.CreateCommand();
                                        //insert query to add data in the exact sequence
                                        cmd.CommandText = $"INSERT INTO BookingTBL(Date,StartTime,EndTime,UserID,RoomID) VALUES(@Date,@StartTime,@EndTime,@UserID,@RoomID)";
                                        //adding the date as a date value to the booking table
                                        cmd.Parameters.Add("@Date", SqlDbType.Date).Value = txtDate.Value.Date;
                                        //adding startTime and endTime inputs as a time value
                                        cmd.Parameters.Add("@StartTime", SqlDbType.Time).Value = startTime.Value.TimeOfDay;
                                        cmd.Parameters.Add("@EndTime", SqlDbType.Time).Value = endTime.Value.TimeOfDay;
                                        cmd.Parameters.Add("@UserID", txtUserID.Text.Trim());
                                        cmd.Parameters.Add("@RoomID", txtRoomID.Text.Trim());

                                        cmd.ExecuteNonQuery();
                                        //disconnect from the database
                                        con.Close();
                                        MessageBox.Show("Booking Successful!");
                                    }
                                }
                            }
                            else
                            {
                                //room is available for user to book
                                MessageBox.Show("Room available");

                                //Create SQL Command to add inputs to database at specific fields
                                SqlCommand cmd = con.CreateCommand();
                                //insert query to add data in the exact sequence
                                cmd.CommandText = $"INSERT INTO BookingTBL(Date,StartTime,EndTime,UserID,RoomID) VALUES(@Date,@StartTime,@EndTime,@UserID,@RoomID)";
                                //adding the date as a date value to the booking table
                                cmd.Parameters.Add("@Date", SqlDbType.Date).Value = txtDate.Value.Date;
                                //adding startTime and endTime inputs as a time value
                                cmd.Parameters.Add("@StartTime", SqlDbType.Time).Value = startTime.Value.TimeOfDay;
                                cmd.Parameters.Add("@EndTime", SqlDbType.Time).Value = endTime.Value.TimeOfDay;
                                cmd.Parameters.Add("@UserID", txtUserID.Text.Trim());
                                cmd.Parameters.Add("@RoomID", txtRoomID.Text.Trim());

                                cmd.ExecuteNonQuery();
                                //disconnect from the database
                                con.Close();
                                MessageBox.Show("Booking Successful!");
                            }
                        }
                        else
                        {
                            //room is available for user to book
                            MessageBox.Show("Room available");

                            //Create SQL Command to add inputs to database at specific fields
                            SqlCommand cmd = con.CreateCommand();
                            //insert query to add data in the exact sequence
                            cmd.CommandText = $"INSERT INTO BookingTBL(Date,StartTime,EndTime,UserID,RoomID) VALUES(@Date,@StartTime,@EndTime,@UserID,@RoomID)";
                            //adding the date as a date value to the booking table
                            cmd.Parameters.Add("@Date", SqlDbType.Date).Value = txtDate.Value.Date;
                            //adding startTime and endTime inputs as a time value
                            cmd.Parameters.Add("@StartTime", SqlDbType.Time).Value = startTime.Value.TimeOfDay;
                            cmd.Parameters.Add("@EndTime", SqlDbType.Time).Value = endTime.Value.TimeOfDay;
                            cmd.Parameters.Add("@UserID", txtUserID.Text.Trim());
                            cmd.Parameters.Add("@RoomID", txtRoomID.Text.Trim());

                            cmd.ExecuteNonQuery();
                            //disconnect from the database
                            con.Close();
                            MessageBox.Show("Booking Successful!");
                        }
                    }
                }
                else
                {
                    //UserID not found (no bookings made by user)
                    //Perform checks on occupied rooms
                    //Add bookings

                    //SQL Command to count the number of rows matching the specific date give
                    SqlCommand dateCheck3 = new SqlCommand("SELECT COUNT(*) FROM BookingTBL WHERE Date = @Date", con);
                    dateCheck3.Parameters.AddWithValue("@Date", Convert.ToDateTime(txtDate.Text));
                    //records the number of times the date appears in the booking table
                    int dateExist3 = (int)dateCheck3.ExecuteScalar();

                    //if the total number for specific date is greater than 1
                    if (dateExist3 > 0)
                    {
                        //Date is present in the table
                        //Needs to check if the room is also present on the same date
                        //returns no. of rows where the RoomID is equivalent to user's input
                        SqlDataAdapter roomHolder = new SqlDataAdapter("SELECT COUNT(*) FROM BookingTBL WHERE RoomID ='" + txtRoomID.Text + "'", con);
                        //held query results in a virtual table
                        DataTable dt = new DataTable();
                        roomHolder.Fill(dt);

                        if (dt.Rows[0][0].ToString() == "1")
                        {
                            //room is present in the table
                            //query run to retrieve the number of rows matching the start time give
                            SqlDataAdapter sTimeHolder = new SqlDataAdapter("SELECT COUNT(*) FROM BookingTBL WHERE StartTime ='" + startTime.Text + "'", con);
                            //query results held in virtual table
                            DataTable dt2 = new DataTable();
                            sTimeHolder.Fill(dt2);

                            if (dt2.Rows[0][0].ToString() == "1")
                            {
                                //room is present in table at start time
                                SqlDataAdapter eTimeHolder = new SqlDataAdapter("SELECT COUNT(*) FROM BookingTBL WHERE EndTime ='" + endTime.Text + "'", con);
                                DataTable dt3 = new DataTable();
                                eTimeHolder.Fill(dt3);

                                if (dt3.Rows[0][0].ToString() == "1")
                                {
                                    //occupied room
                                    MessageBox.Show("Room is occupied during this time. Choose a different start and end time");
                                }
                                else
                                {
                                    //room is available for user to book
                                    MessageBox.Show("Room occupied during this time!");
                                }
                            }
                            else
                            {
                                //StartTime not present but the query run to check end time
                                SqlDataAdapter eTimeHolder = new SqlDataAdapter("SELECT COUNT(*) FROM BookingTBL WHERE EndTime ='" + endTime.Text + "'", con);
                                DataTable dt3 = new DataTable();
                                eTimeHolder.Fill(dt3);

                                if (dt3.Rows[0][0].ToString() == "1")
                                {
                                    //occupied room
                                    MessageBox.Show("Room is occupied during this time. Choose a different start and end time");
                                }
                                else
                                {
                                    //room is available for user to book
                                    MessageBox.Show("Room available");

                                    //Create SQL Command to add inputs to database at specific fields
                                    SqlCommand cmd = con.CreateCommand();
                                    //insert query to add data in the exact sequence
                                    cmd.CommandText = $"INSERT INTO BookingTBL(Date,StartTime,EndTime,UserID,RoomID) VALUES(@Date,@StartTime,@EndTime,@UserID,@RoomID)";
                                    //adding the date as a date value to the booking table
                                    cmd.Parameters.Add("@Date", SqlDbType.Date).Value = txtDate.Value.Date;
                                    //adding startTime and endTime inputs as a time value
                                    cmd.Parameters.Add("@StartTime", SqlDbType.Time).Value = startTime.Value.TimeOfDay;
                                    cmd.Parameters.Add("@EndTime", SqlDbType.Time).Value = endTime.Value.TimeOfDay;
                                    cmd.Parameters.Add("@UserID", txtUserID.Text.Trim());
                                    cmd.Parameters.Add("@RoomID", txtRoomID.Text.Trim());

                                    cmd.ExecuteNonQuery();
                                    //disconnect from the database
                                    con.Close();
                                    MessageBox.Show("Booking Successful!");
                                }
                            }
                        }
                        else
                        {
                            //room is available for user to book
                            MessageBox.Show("Room available");

                            //Create SQL Command to add inputs to database at specific fields
                            SqlCommand cmd = con.CreateCommand();
                            //insert query to add data in the exact sequence
                            cmd.CommandText = $"INSERT INTO BookingTBL(Date,StartTime,EndTime,UserID,RoomID) VALUES(@Date,@StartTime,@EndTime,@UserID,@RoomID)";
                            //adding the date as a date value to the booking table
                            cmd.Parameters.Add("@Date", SqlDbType.Date).Value = txtDate.Value.Date;
                            //adding startTime and endTime inputs as a time value
                            cmd.Parameters.Add("@StartTime", SqlDbType.Time).Value = startTime.Value.TimeOfDay;
                            cmd.Parameters.Add("@EndTime", SqlDbType.Time).Value = endTime.Value.TimeOfDay;
                            cmd.Parameters.Add("@UserID", txtUserID.Text.Trim());
                            cmd.Parameters.Add("@RoomID", txtRoomID.Text.Trim());

                            cmd.ExecuteNonQuery();
                            //disconnect from the database
                            con.Close();
                            MessageBox.Show("Booking Successful!");
                        }
                    }
                    else
                    {
                        //room is available for user to book
                        MessageBox.Show("Room available");

                        //Create SQL Command to add inputs to database at specific fields
                        SqlCommand cmd = con.CreateCommand();
                        //insert query to add data in the exact sequence
                        cmd.CommandText = $"INSERT INTO BookingTBL(Date,StartTime,EndTime,UserID,RoomID) VALUES(@Date,@StartTime,@EndTime,@UserID,@RoomID)";
                        //adding the date as a date value to the booking table
                        cmd.Parameters.Add("@Date", SqlDbType.Date).Value = txtDate.Value.Date;
                        //adding startTime and endTime inputs as a time value
                        cmd.Parameters.Add("@StartTime", SqlDbType.Time).Value = startTime.Value.TimeOfDay;
                        cmd.Parameters.Add("@EndTime", SqlDbType.Time).Value = endTime.Value.TimeOfDay;
                        cmd.Parameters.Add("@UserID", txtUserID.Text.Trim());
                        cmd.Parameters.Add("@RoomID", txtRoomID.Text.Trim());

                        cmd.ExecuteNonQuery();
                        //disconnect from the database
                        con.Close();
                        MessageBox.Show("Booking Successful!");
                    }
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //define SQL connection details
            using (SqlConnection sqlCon = new SqlConnection(connectString))
            {
                //connection is established
                sqlCon.Open();
                //SqlDataAdapter provides communication with SQL database and DataTable
                SqlDataAdapter sqlDA = new SqlDataAdapter("SELECT * FROM RoomTBL", sqlCon);
                //returned results of query held in virtual table using Fill() method
                DataTable dtb1 = new DataTable();
                sqlDA.Fill(dtb1);

                //creating link between DataGridView and DataTable
                roomViewer.DataSource = dtb1;
                //disconnect from the database
                sqlCon.Close();
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            //room availability
            SqlConnection con = new SqlConnection(connectString);
            con.Open();
            //SQL query to select specified columsn of BookingTBL matching the search criteria (txtRoomID.Text)
            SqlDataAdapter sameRoom = new SqlDataAdapter("SELECT Date,StartTime,EndTime,RoomID FROM BookingTBL WHERE RoomID ='" + txtRoomID.Text + "'", con);
            DataTable liveDT = new DataTable();
            sameRoom.Fill(liveDT);

            //creating link between the DataGridView panel and DataTable
            bookViewer.DataSource = liveDT;
            con.Close();

        }

        //track reservation line of code

        private void btnTrack_Click(object sender, EventArgs e)
        {
            //SQL connection established
            SqlConnection trackCon = new SqlConnection(connectString);
            //Creating communication between the database and DataTable using an SQL query
            SqlDataAdapter userHolder = new SqlDataAdapter("SELECT COUNT(*) FROM UserTBL WHERE UserID ='" + txtTrackuser.Text + "'", trackCon);
            //New virtual table created to store results of query
            DataTable userDT = new DataTable();
            //filling the virtual table with the results
            userHolder.Fill(userDT);

            //Checks to see if a value is returned in association with the user's input
            if (userDT.Rows[0][0].ToString() == "1")
            {
                //Database connection opened
                trackCon.Open();
                //Selected columns of UserTBL stored in a virtual table
                SqlDataAdapter userDA = new SqlDataAdapter("SELECT UserID,Firstname,Surname FROM UserTBL WHERE UserID ='" + txtTrackuser.Text + "'", trackCon);
                DataTable userDisplay = new DataTable();
                //Results of the query added to new table
                userDA.Fill(userDisplay);
                //linked the gridview panel with DataTable to display contents of userDisplay
                viewerUser.DataSource = userDisplay;
                //disconnect from database
                trackCon.Close();

                //Re-open SQL connection to database
                trackCon.Open();
                //SQL query that is run to count the number of rows in the BookingTBL satisfying the criteria
                SqlDataAdapter bookHolder = new SqlDataAdapter("SELECT BookingID,Date,StartTime,EndTime,RoomID FROM BookingTBL WHERE UserID ='" + txtTrackuser.Text + "'", trackCon);
                //Results of the query stored in a virtual table and linked with the data viewer panel
                DataTable bookDisplay = new DataTable();
                bookHolder.Fill(bookDisplay);

                //data panel and virtual table linked to display the data returned
                bookingViewer.DataSource = bookDisplay;
                trackCon.Close();
            }
            else
            {
                //output to display the user credentials are invalid in association to UserID
                MessageBox.Show("User does not exist!");
            }

        }

        //update/delete bookings

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //connection details defined by calling string variable storing connection 
            SqlConnection con = new SqlConnection(connectString);
            //Connect to booking DB
            con.Open();

            //new SQL command created to return the number of records where the user's input matches the dates are in the booking table
            SqlCommand dateCheck = new SqlCommand("SELECT COUNT(*) FROM BookingTBL WHERE Date = @Date", con);
            dateCheck.Parameters.AddWithValue("@Date", Convert.ToDateTime(UpdateDate.Text));
            //counts the number of times the date appears in the DB and assigns to an integer string value
            int dateExists = (int)dateCheck.ExecuteScalar();

            //if the variable is greater than 0, it means there are dates present matching the user's input
            if (dateExists > 0)
            {
                //return the no. of rows where the room exists in the DB
                SqlDataAdapter roomHolder = new SqlDataAdapter("SELECT COUNT(*) FROM BookingTBL WHERE RoomID ='" + txtNewRoom.Text + "'", con);
                //fill DB with results of the query
                DataTable dt = new DataTable();
                roomHolder.Fill(dt);

                //if data is returned, it will need to check the start time
                if (dt.Rows[0][0].ToString() == "1")
                {
                    //SQL query to check where the start time is in the DB
                    SqlDataAdapter sTimeHolder = new SqlDataAdapter("SELECT COUNT(*) FROM BookingTBL WHERE StartTime ='" + newStartTime.Text + "'", con);
                    //fill results of query into DB
                    DataTable dt2 = new DataTable();
                    sTimeHolder.Fill(dt2);

                    //if data returned has start time in DB, check the end time
                    if (dt2.Rows[0][0].ToString() == "1")
                    {                 
                        //check no. of rows where end time exists
                        SqlDataAdapter eTimeHolder = new SqlDataAdapter("SELECT COUNT(*) FROM BookingTBL WHERE EndTime ='" + newEndTime.Text + "'", con);
                        //fill results of query in virtual table representing end time
                        DataTable dt3 = new DataTable();
                        eTimeHolder.Fill(dt3);

                        //if values returned have end time, create output message
                        if (dt3.Rows[0][0].ToString() == "1")
                        {
                            //output message to prevent booking if start and end time are there
                            MessageBox.Show("Room is occupied during this time. Choose a different start and end time");
                        }
                        else
                        {
                            //output message if start time is there but end time is different
                            MessageBox.Show("Room is occupied during this time. Choose a different end time");
                        }

                    }
                    else
                    {
                        //if start time is different, SQL query to return rows where the end time exists
                        SqlDataAdapter eTimeHolder = new SqlDataAdapter("SELECT COUNT(*) FROM BookingTBL WHERE EndTime ='" + newEndTime.Text + "'", con);
                        DataTable dt3 = new DataTable();
                        //fill table with results of qery
                        eTimeHolder.Fill(dt3);

                        //if end time is returned, return output
                        if (dt3.Rows[0][0].ToString() == "1")
                        {
                            //prevent booking as time period clashes with existing booking
                            MessageBox.Show("Room is occupied during this time. Choose a different end time");
                        }
                        else
                        {
                            MessageBox.Show("Room available");

                            //SQL command created
                            SqlCommand cmd = con.CreateCommand();
                            //SQL query to update the booking details where it matches the booking ID entered in the input field
                            cmd.CommandText = $"UPDATE BookingTBL SET Date=@Date,StartTime=@StartTime,EndTime=@EndTime,UserID=@UserID,RoomID=@RoomID WHERE BookingID=@BookingID";
                            //pass parameters & values, checking it matches the data type in the BookingTBL
                            cmd.Parameters.Add("@BookingID", txtBookingID.Text.Trim());
                            cmd.Parameters.Add("@Date", SqlDbType.Date).Value = UpdateDate.Value.Date;
                            cmd.Parameters.Add("@StartTime", SqlDbType.Time).Value = newStartTime.Value.TimeOfDay;
                            cmd.Parameters.Add("@EndTime", SqlDbType.Time).Value = newEndTime.Value.TimeOfDay;
                            cmd.Parameters.Add("@UserID", txtUser.Text.Trim());
                            cmd.Parameters.Add("@RoomID", txtNewRoom.Text.Trim());

                            //executes statement against the connection
                            cmd.ExecuteNonQuery();
                            //disconnect from DB
                            con.Close();
                            //display successful update
                            MessageBox.Show("Update successful!");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Room available");

                    //SQL command created
                    SqlCommand cmd = con.CreateCommand();
                    //SQL query to update the booking details where it matches the booking ID entered in the input field
                    cmd.CommandText = $"UPDATE BookingTBL SET Date=@Date,StartTime=@StartTime,EndTime=@EndTime,UserID=@UserID,RoomID=@RoomID WHERE BookingID=@BookingID";
                    //pass parameters & values, checking it matches the data type in the BookingTBL
                    cmd.Parameters.Add("@BookingID", txtBookingID.Text.Trim());
                    cmd.Parameters.Add("@Date", SqlDbType.Date).Value = UpdateDate.Value.Date;
                    cmd.Parameters.Add("@StartTime", SqlDbType.Time).Value = newStartTime.Value.TimeOfDay;
                    cmd.Parameters.Add("@EndTime", SqlDbType.Time).Value = newEndTime.Value.TimeOfDay;
                    cmd.Parameters.Add("@UserID", txtUser.Text.Trim());
                    cmd.Parameters.Add("@RoomID", txtNewRoom.Text.Trim());

                    //executes statement against the connection
                    cmd.ExecuteNonQuery();
                    //disconnect from DB
                    con.Close();
                    //display successful update
                    MessageBox.Show("Update successful!");
                }
            }
            else
            {
                MessageBox.Show("Room available");

                //SQL command created
                SqlCommand cmd = con.CreateCommand();
                //SQL query to update the booking details where it matches the booking ID entered in the input field
                cmd.CommandText = $"UPDATE BookingTBL SET Date=@Date,StartTime=@StartTime,EndTime=@EndTime,UserID=@UserID,RoomID=@RoomID WHERE BookingID=@BookingID";
                //pass parameters & values, checking it matches the data type in the BookingTBL
                cmd.Parameters.Add("@BookingID", txtBookingID.Text.Trim());
                cmd.Parameters.Add("@Date", SqlDbType.Date).Value = UpdateDate.Value.Date;
                cmd.Parameters.Add("@StartTime", SqlDbType.Time).Value = newStartTime.Value.TimeOfDay;
                cmd.Parameters.Add("@EndTime", SqlDbType.Time).Value = newEndTime.Value.TimeOfDay;
                cmd.Parameters.Add("@UserID", txtUser.Text.Trim());
                cmd.Parameters.Add("@RoomID", txtNewRoom.Text.Trim());

                //executes statement against the connection
                cmd.ExecuteNonQuery();
                //disconnect from DB
                con.Close();
                //display successful update
                MessageBox.Show("Update successful!");
            }
        }

        private void btnLoadBK_Click(object sender, EventArgs e)
        {
            //define SQL connection by calling string variable
            SqlConnection con = new SqlConnection(connectString);
            //open connection
            con.Open();
            //SQL query to display booking details associated with UserID
            SqlDataAdapter currentBK = new SqlDataAdapter("SELECT * FROM BookingTBL WHERE UserID ='" + txtLoadBK.Text + "'", con);
            //fill virtual table with results of query
            DataTable currentDT = new DataTable();
            currentBK.Fill(currentDT);
            //link virtual table and panel to display contents of query
            deleteViewer.DataSource = currentDT;
            //disconnect from database
            con.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Define and open SQL connection to access DB
            SqlConnection con = new SqlConnection(connectString);
            con.Open();
            //Create new SQL command to run query
            SqlCommand cmd = con.CreateCommand();
            //SQL query to delete row of data where BookingID matches user input
            cmd.CommandText = $"DELETE FROM BookingTBL WHERE BookingID ='" + txtDeleteBook.Text + "'";
            //execute statement against connection
            cmd.ExecuteNonQuery();
            //disconnect from DB
            con.Close();
            //Display message that reservation is deleted
            MessageBox.Show("Booking deleted!");
        }
    }
}
