namespace NewBookSys
{
    partial class BookingPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bookControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCurrent = new System.Windows.Forms.Label();
            this.bookViewer = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.endTime = new System.Windows.Forms.DateTimePicker();
            this.lblRoomID = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.txtRoomID = new System.Windows.Forms.TextBox();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.startTime = new System.Windows.Forms.DateTimePicker();
            this.txtDate = new System.Windows.Forms.DateTimePicker();
            this.btnBook = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.roomViewer = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblBooking = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.txtTrackuser = new System.Windows.Forms.TextBox();
            this.btnTrack = new System.Windows.Forms.Button();
            this.viewerUser = new System.Windows.Forms.DataGridView();
            this.bookingViewer = new System.Windows.Forms.DataGridView();
            this.lblTrack = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnLoadBK = new System.Windows.Forms.Button();
            this.txtDeleteBook = new System.Windows.Forms.TextBox();
            this.lbl_DeleteBooking = new System.Windows.Forms.Label();
            this.deleteViewer = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtLoadBK = new System.Windows.Forms.TextBox();
            this.lbl_DeleteUser = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtBookingID = new System.Windows.Forms.TextBox();
            this.lbl_BookingID = new System.Windows.Forms.Label();
            this.txtNewRoom = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.newEndTime = new System.Windows.Forms.DateTimePicker();
            this.newStartTime = new System.Windows.Forms.DateTimePicker();
            this.UpdateDate = new System.Windows.Forms.DateTimePicker();
            this.lbl_NewRoom = new System.Windows.Forms.Label();
            this.lbl_UserID = new System.Windows.Forms.Label();
            this.lbl_NewETime = new System.Windows.Forms.Label();
            this.lbl_newSTime = new System.Windows.Forms.Label();
            this.lbl_NewDate = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.bookControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookViewer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomViewer)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewerUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingViewer)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deleteViewer)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // bookControl
            // 
            this.bookControl.Controls.Add(this.tabPage1);
            this.bookControl.Controls.Add(this.tabPage2);
            this.bookControl.Controls.Add(this.tabPage3);
            this.bookControl.Location = new System.Drawing.Point(12, 23);
            this.bookControl.Name = "bookControl";
            this.bookControl.SelectedIndex = 0;
            this.bookControl.Size = new System.Drawing.Size(1237, 458);
            this.bookControl.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1229, 432);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Make Reservation";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.btnLoad);
            this.panel1.Controls.Add(this.lblCurrent);
            this.panel1.Controls.Add(this.bookViewer);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.endTime);
            this.panel1.Controls.Add(this.lblRoomID);
            this.panel1.Controls.Add(this.lblUserID);
            this.panel1.Controls.Add(this.txtRoomID);
            this.panel1.Controls.Add(this.txtUserID);
            this.panel1.Controls.Add(this.lblTime);
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.startTime);
            this.panel1.Controls.Add(this.txtDate);
            this.panel1.Controls.Add(this.btnBook);
            this.panel1.Controls.Add(this.lblSearch);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.roomViewer);
            this.panel1.Location = new System.Drawing.Point(26, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1187, 375);
            this.panel1.TabIndex = 0;
            // 
            // lblCurrent
            // 
            this.lblCurrent.AutoSize = true;
            this.lblCurrent.Location = new System.Drawing.Point(660, 49);
            this.lblCurrent.Name = "lblCurrent";
            this.lblCurrent.Size = new System.Drawing.Size(88, 13);
            this.lblCurrent.TabIndex = 31;
            this.lblCurrent.Text = "Current Bookings";
            // 
            // bookViewer
            // 
            this.bookViewer.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.bookViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookViewer.Location = new System.Drawing.Point(615, 94);
            this.bookViewer.Name = "bookViewer";
            this.bookViewer.Size = new System.Drawing.Size(541, 253);
            this.bookViewer.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "End Time";
            // 
            // endTime
            // 
            this.endTime.CustomFormat = "HH:mm";
            this.endTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endTime.Location = new System.Drawing.Point(128, 153);
            this.endTime.Name = "endTime";
            this.endTime.ShowUpDown = true;
            this.endTime.Size = new System.Drawing.Size(149, 20);
            this.endTime.TabIndex = 28;
            this.endTime.Value = new System.DateTime(2019, 2, 16, 12, 54, 0, 0);
            // 
            // lblRoomID
            // 
            this.lblRoomID.AutoSize = true;
            this.lblRoomID.Location = new System.Drawing.Point(38, 254);
            this.lblRoomID.Name = "lblRoomID";
            this.lblRoomID.Size = new System.Drawing.Size(35, 13);
            this.lblRoomID.TabIndex = 27;
            this.lblRoomID.Text = "Room";
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Location = new System.Drawing.Point(38, 204);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(40, 13);
            this.lblUserID.TabIndex = 26;
            this.lblUserID.Text = "UserID";
            // 
            // txtRoomID
            // 
            this.txtRoomID.Location = new System.Drawing.Point(128, 247);
            this.txtRoomID.Name = "txtRoomID";
            this.txtRoomID.Size = new System.Drawing.Size(149, 20);
            this.txtRoomID.TabIndex = 25;
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(128, 201);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(149, 20);
            this.txtUserID.TabIndex = 24;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(35, 120);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(55, 13);
            this.lblTime.TabIndex = 23;
            this.lblTime.Text = "Start Time";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(35, 76);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 22;
            this.lblDate.Text = "Date";
            // 
            // startTime
            // 
            this.startTime.CustomFormat = "HH:mm";
            this.startTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startTime.Location = new System.Drawing.Point(128, 114);
            this.startTime.Name = "startTime";
            this.startTime.ShowUpDown = true;
            this.startTime.Size = new System.Drawing.Size(149, 20);
            this.startTime.TabIndex = 21;
            this.startTime.Value = new System.DateTime(2019, 2, 16, 12, 54, 0, 0);
            // 
            // txtDate
            // 
            this.txtDate.Checked = false;
            this.txtDate.CustomFormat = "dd/MM/yyyy";
            this.txtDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtDate.Location = new System.Drawing.Point(128, 69);
            this.txtDate.MaxDate = new System.DateTime(2040, 12, 31, 0, 0, 0, 0);
            this.txtDate.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(149, 20);
            this.txtDate.TabIndex = 20;
            // 
            // btnBook
            // 
            this.btnBook.Location = new System.Drawing.Point(56, 291);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(171, 56);
            this.btnBook.TabIndex = 17;
            this.btnBook.Text = "Make Booking";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(300, 49);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(40, 13);
            this.lblSearch.TabIndex = 12;
            this.lblSearch.Text = "Rooms";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(366, 41);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(193, 28);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // roomViewer
            // 
            this.roomViewer.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.roomViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.roomViewer.Location = new System.Drawing.Point(303, 94);
            this.roomViewer.Name = "roomViewer";
            this.roomViewer.Size = new System.Drawing.Size(256, 253);
            this.roomViewer.TabIndex = 10;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1229, 432);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Track Booking";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.Controls.Add(this.lblBooking);
            this.panel2.Controls.Add(this.lblUser);
            this.panel2.Controls.Add(this.txtTrackuser);
            this.panel2.Controls.Add(this.btnTrack);
            this.panel2.Controls.Add(this.viewerUser);
            this.panel2.Controls.Add(this.bookingViewer);
            this.panel2.Controls.Add(this.lblTrack);
            this.panel2.Location = new System.Drawing.Point(173, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(888, 375);
            this.panel2.TabIndex = 1;
            // 
            // lblBooking
            // 
            this.lblBooking.AutoSize = true;
            this.lblBooking.Location = new System.Drawing.Point(131, 157);
            this.lblBooking.Name = "lblBooking";
            this.lblBooking.Size = new System.Drawing.Size(51, 13);
            this.lblBooking.TabIndex = 11;
            this.lblBooking.Text = "Bookings";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(131, 84);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(29, 13);
            this.lblUser.TabIndex = 10;
            this.lblUser.Text = "User";
            // 
            // txtTrackuser
            // 
            this.txtTrackuser.Location = new System.Drawing.Point(252, 37);
            this.txtTrackuser.Name = "txtTrackuser";
            this.txtTrackuser.Size = new System.Drawing.Size(239, 20);
            this.txtTrackuser.TabIndex = 6;
            // 
            // btnTrack
            // 
            this.btnTrack.Location = new System.Drawing.Point(593, 28);
            this.btnTrack.Name = "btnTrack";
            this.btnTrack.Size = new System.Drawing.Size(130, 37);
            this.btnTrack.TabIndex = 5;
            this.btnTrack.Text = "Track";
            this.btnTrack.UseVisualStyleBackColor = true;
            this.btnTrack.Click += new System.EventHandler(this.btnTrack_Click);
            // 
            // viewerUser
            // 
            this.viewerUser.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.viewerUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewerUser.Location = new System.Drawing.Point(210, 84);
            this.viewerUser.Name = "viewerUser";
            this.viewerUser.Size = new System.Drawing.Size(355, 67);
            this.viewerUser.TabIndex = 4;
            // 
            // bookingViewer
            // 
            this.bookingViewer.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.bookingViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookingViewer.Location = new System.Drawing.Point(210, 157);
            this.bookingViewer.Name = "bookingViewer";
            this.bookingViewer.Size = new System.Drawing.Size(513, 205);
            this.bookingViewer.TabIndex = 2;
            // 
            // lblTrack
            // 
            this.lblTrack.AutoSize = true;
            this.lblTrack.Location = new System.Drawing.Point(131, 40);
            this.lblTrack.Name = "lblTrack";
            this.lblTrack.Size = new System.Drawing.Size(68, 13);
            this.lblTrack.TabIndex = 0;
            this.lblTrack.Text = "Enter UserID";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panel3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1229, 432);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Edit/Delete Booking";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGray;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(34, 29);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1150, 391);
            this.panel3.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(781, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Delete Booking";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(211, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Update Booking";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LightGray;
            this.panel5.Controls.Add(this.btnLoadBK);
            this.panel5.Controls.Add(this.txtDeleteBook);
            this.panel5.Controls.Add(this.lbl_DeleteBooking);
            this.panel5.Controls.Add(this.deleteViewer);
            this.panel5.Controls.Add(this.btnDelete);
            this.panel5.Controls.Add(this.txtLoadBK);
            this.panel5.Controls.Add(this.lbl_DeleteUser);
            this.panel5.Location = new System.Drawing.Point(591, 57);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(533, 321);
            this.panel5.TabIndex = 1;
            // 
            // btnLoadBK
            // 
            this.btnLoadBK.Location = new System.Drawing.Point(342, 16);
            this.btnLoadBK.Name = "btnLoadBK";
            this.btnLoadBK.Size = new System.Drawing.Size(94, 32);
            this.btnLoadBK.TabIndex = 7;
            this.btnLoadBK.Text = "Load Bookings";
            this.btnLoadBK.UseVisualStyleBackColor = true;
            this.btnLoadBK.Click += new System.EventHandler(this.btnLoadBK_Click);
            // 
            // txtDeleteBook
            // 
            this.txtDeleteBook.Location = new System.Drawing.Point(129, 275);
            this.txtDeleteBook.Name = "txtDeleteBook";
            this.txtDeleteBook.Size = new System.Drawing.Size(202, 20);
            this.txtDeleteBook.TabIndex = 6;
            // 
            // lbl_DeleteBooking
            // 
            this.lbl_DeleteBooking.AutoSize = true;
            this.lbl_DeleteBooking.Location = new System.Drawing.Point(38, 283);
            this.lbl_DeleteBooking.Name = "lbl_DeleteBooking";
            this.lbl_DeleteBooking.Size = new System.Drawing.Size(85, 13);
            this.lbl_DeleteBooking.TabIndex = 5;
            this.lbl_DeleteBooking.Text = "Enter BookingID";
            // 
            // deleteViewer
            // 
            this.deleteViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.deleteViewer.Location = new System.Drawing.Point(38, 74);
            this.deleteViewer.Name = "deleteViewer";
            this.deleteViewer.Size = new System.Drawing.Size(398, 159);
            this.deleteViewer.TabIndex = 4;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(361, 272);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtLoadBK
            // 
            this.txtLoadBK.Location = new System.Drawing.Point(129, 28);
            this.txtLoadBK.Name = "txtLoadBK";
            this.txtLoadBK.Size = new System.Drawing.Size(193, 20);
            this.txtLoadBK.TabIndex = 1;
            // 
            // lbl_DeleteUser
            // 
            this.lbl_DeleteUser.AutoSize = true;
            this.lbl_DeleteUser.Location = new System.Drawing.Point(35, 31);
            this.lbl_DeleteUser.Name = "lbl_DeleteUser";
            this.lbl_DeleteUser.Size = new System.Drawing.Size(68, 13);
            this.lbl_DeleteUser.TabIndex = 0;
            this.lbl_DeleteUser.Text = "Enter UserID";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightGray;
            this.panel4.Controls.Add(this.btnUpdate);
            this.panel4.Controls.Add(this.txtBookingID);
            this.panel4.Controls.Add(this.lbl_BookingID);
            this.panel4.Controls.Add(this.txtNewRoom);
            this.panel4.Controls.Add(this.txtUser);
            this.panel4.Controls.Add(this.newEndTime);
            this.panel4.Controls.Add(this.newStartTime);
            this.panel4.Controls.Add(this.UpdateDate);
            this.panel4.Controls.Add(this.lbl_NewRoom);
            this.panel4.Controls.Add(this.lbl_UserID);
            this.panel4.Controls.Add(this.lbl_NewETime);
            this.panel4.Controls.Add(this.lbl_newSTime);
            this.panel4.Controls.Add(this.lbl_NewDate);
            this.panel4.Location = new System.Drawing.Point(28, 57);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(533, 321);
            this.panel4.TabIndex = 0;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(172, 257);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(149, 38);
            this.btnUpdate.TabIndex = 36;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtBookingID
            // 
            this.txtBookingID.Location = new System.Drawing.Point(126, 20);
            this.txtBookingID.Name = "txtBookingID";
            this.txtBookingID.Size = new System.Drawing.Size(288, 20);
            this.txtBookingID.TabIndex = 35;
            // 
            // lbl_BookingID
            // 
            this.lbl_BookingID.AutoSize = true;
            this.lbl_BookingID.Location = new System.Drawing.Point(49, 28);
            this.lbl_BookingID.Name = "lbl_BookingID";
            this.lbl_BookingID.Size = new System.Drawing.Size(57, 13);
            this.lbl_BookingID.TabIndex = 34;
            this.lbl_BookingID.Text = "BookingID";
            // 
            // txtNewRoom
            // 
            this.txtNewRoom.Location = new System.Drawing.Point(126, 213);
            this.txtNewRoom.Name = "txtNewRoom";
            this.txtNewRoom.Size = new System.Drawing.Size(288, 20);
            this.txtNewRoom.TabIndex = 33;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(126, 176);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(288, 20);
            this.txtUser.TabIndex = 32;
            // 
            // newEndTime
            // 
            this.newEndTime.CustomFormat = "HH:mm";
            this.newEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.newEndTime.Location = new System.Drawing.Point(126, 135);
            this.newEndTime.Name = "newEndTime";
            this.newEndTime.ShowUpDown = true;
            this.newEndTime.Size = new System.Drawing.Size(288, 20);
            this.newEndTime.TabIndex = 31;
            this.newEndTime.Value = new System.DateTime(2019, 2, 16, 12, 54, 0, 0);
            // 
            // newStartTime
            // 
            this.newStartTime.CustomFormat = "HH:mm";
            this.newStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.newStartTime.Location = new System.Drawing.Point(126, 96);
            this.newStartTime.Name = "newStartTime";
            this.newStartTime.ShowUpDown = true;
            this.newStartTime.Size = new System.Drawing.Size(288, 20);
            this.newStartTime.TabIndex = 30;
            this.newStartTime.Value = new System.DateTime(2019, 2, 16, 12, 54, 0, 0);
            // 
            // UpdateDate
            // 
            this.UpdateDate.Checked = false;
            this.UpdateDate.CustomFormat = "dd/MM/yyyy";
            this.UpdateDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.UpdateDate.Location = new System.Drawing.Point(126, 57);
            this.UpdateDate.MaxDate = new System.DateTime(2040, 12, 31, 0, 0, 0, 0);
            this.UpdateDate.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.UpdateDate.Name = "UpdateDate";
            this.UpdateDate.Size = new System.Drawing.Size(288, 20);
            this.UpdateDate.TabIndex = 29;
            // 
            // lbl_NewRoom
            // 
            this.lbl_NewRoom.AutoSize = true;
            this.lbl_NewRoom.Location = new System.Drawing.Point(49, 220);
            this.lbl_NewRoom.Name = "lbl_NewRoom";
            this.lbl_NewRoom.Size = new System.Drawing.Size(46, 13);
            this.lbl_NewRoom.TabIndex = 4;
            this.lbl_NewRoom.Text = "RoomID";
            // 
            // lbl_UserID
            // 
            this.lbl_UserID.AutoSize = true;
            this.lbl_UserID.Location = new System.Drawing.Point(49, 183);
            this.lbl_UserID.Name = "lbl_UserID";
            this.lbl_UserID.Size = new System.Drawing.Size(40, 13);
            this.lbl_UserID.TabIndex = 3;
            this.lbl_UserID.Text = "UserID";
            // 
            // lbl_NewETime
            // 
            this.lbl_NewETime.AutoSize = true;
            this.lbl_NewETime.Location = new System.Drawing.Point(49, 141);
            this.lbl_NewETime.Name = "lbl_NewETime";
            this.lbl_NewETime.Size = new System.Drawing.Size(49, 13);
            this.lbl_NewETime.TabIndex = 2;
            this.lbl_NewETime.Text = "EndTime";
            // 
            // lbl_newSTime
            // 
            this.lbl_newSTime.AutoSize = true;
            this.lbl_newSTime.Location = new System.Drawing.Point(49, 103);
            this.lbl_newSTime.Name = "lbl_newSTime";
            this.lbl_newSTime.Size = new System.Drawing.Size(52, 13);
            this.lbl_newSTime.TabIndex = 1;
            this.lbl_newSTime.Text = "StartTime";
            // 
            // lbl_NewDate
            // 
            this.lbl_NewDate.AutoSize = true;
            this.lbl_NewDate.Location = new System.Drawing.Point(49, 63);
            this.lbl_NewDate.Name = "lbl_NewDate";
            this.lbl_NewDate.Size = new System.Drawing.Size(30, 13);
            this.lbl_NewDate.TabIndex = 0;
            this.lbl_NewDate.Text = "Date";
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(806, 38);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(251, 31);
            this.btnLoad.TabIndex = 32;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // BookingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 504);
            this.Controls.Add(this.bookControl);
            this.Name = "BookingPage";
            this.Text = "BookingPage";
            this.Load += new System.EventHandler(this.BookingPage_Load);
            this.bookControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookViewer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomViewer)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewerUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingViewer)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deleteViewer)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl bookControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView roomViewer;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Label lblTrack;
        private System.Windows.Forms.DataGridView viewerUser;
        private System.Windows.Forms.DataGridView bookingViewer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker endTime;
        private System.Windows.Forms.Label lblRoomID;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.TextBox txtRoomID;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker startTime;
        private System.Windows.Forms.DateTimePicker txtDate;
        private System.Windows.Forms.Label lblCurrent;
        private System.Windows.Forms.DataGridView bookViewer;
        private System.Windows.Forms.Button btnTrack;
        private System.Windows.Forms.TextBox txtTrackuser;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtDeleteBook;
        private System.Windows.Forms.Label lbl_DeleteBooking;
        private System.Windows.Forms.DataGridView deleteViewer;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtLoadBK;
        private System.Windows.Forms.Label lbl_DeleteUser;
        private System.Windows.Forms.Label lbl_BookingID;
        private System.Windows.Forms.TextBox txtNewRoom;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.DateTimePicker newEndTime;
        private System.Windows.Forms.DateTimePicker newStartTime;
        private System.Windows.Forms.DateTimePicker UpdateDate;
        private System.Windows.Forms.Label lbl_NewRoom;
        private System.Windows.Forms.Label lbl_UserID;
        private System.Windows.Forms.Label lbl_NewETime;
        private System.Windows.Forms.Label lbl_newSTime;
        private System.Windows.Forms.Label lbl_NewDate;
        private System.Windows.Forms.TextBox txtBookingID;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblBooking;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Button btnLoadBK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLoad;
    }
}