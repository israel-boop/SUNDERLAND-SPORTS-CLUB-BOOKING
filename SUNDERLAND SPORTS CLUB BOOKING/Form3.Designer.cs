namespace SUNDERLAND_SPORTS_CLUB_BOOKING
{
    partial class Form3
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
            makeBooking = new Button();
            groupBox1 = new GroupBox();
            coachname_lbl = new Label();
            coach_combox = new ComboBox();
            parti_txtbox = new TextBox();
            coachname_txtbox = new TextBox();
            participants_lbl = new Label();
            coachreq_lbl = new Label();
            grpbooking_rdobtn = new RadioButton();
            goldcard_lbl = new Label();
            dateTimePicker1 = new DateTimePicker();
            contactemail_txtbox = new TextBox();
            contactemail_lbl = new Label();
            contactname_txtbox = new TextBox();
            contactname_lbl = new Label();
            activity_lbl = new Label();
            duration_txtbox = new TextBox();
            duration_lbl = new Label();
            starttime_lbl = new Label();
            date_lbl = new Label();
            id_txtbox = new TextBox();
            id_lbl = new Label();
            notificationLabel = new Label();
            hours_lbl = new Label();
            activity_combox = new ComboBox();
            goldcard_combox = new ComboBox();
            memno_txtbox = new TextBox();
            member_lbl = new Label();
            groupBox2 = new GroupBox();
            indvbooking_rdobtn = new RadioButton();
            back_btn = new Button();
            clear_btn = new Button();
            starttime_txtbox = new DateTimePicker();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // makeBooking
            // 
            makeBooking.Location = new Point(136, 481);
            makeBooking.Margin = new Padding(3, 2, 3, 2);
            makeBooking.Name = "makeBooking";
            makeBooking.Size = new Size(86, 24);
            makeBooking.TabIndex = 62;
            makeBooking.Text = "BOOK IN";
            makeBooking.UseVisualStyleBackColor = true;
            makeBooking.Click += makeBooking_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(coachname_lbl);
            groupBox1.Controls.Add(coach_combox);
            groupBox1.Controls.Add(parti_txtbox);
            groupBox1.Controls.Add(coachname_txtbox);
            groupBox1.Controls.Add(participants_lbl);
            groupBox1.Controls.Add(coachreq_lbl);
            groupBox1.Location = new Point(33, 219);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(270, 106);
            groupBox1.TabIndex = 60;
            groupBox1.TabStop = false;
            // 
            // coachname_lbl
            // 
            coachname_lbl.AutoSize = true;
            coachname_lbl.Location = new Point(0, 76);
            coachname_lbl.Name = "coachname_lbl";
            coachname_lbl.Size = new Size(77, 15);
            coachname_lbl.TabIndex = 69;
            coachname_lbl.Text = "Coach name:";
            // 
            // coach_combox
            // 
            coach_combox.FormattingEnabled = true;
            coach_combox.Items.AddRange(new object[] { "Yes", "No" });
            coach_combox.Location = new Point(147, 45);
            coach_combox.Margin = new Padding(3, 2, 3, 2);
            coach_combox.Name = "coach_combox";
            coach_combox.Size = new Size(110, 23);
            coach_combox.TabIndex = 68;
            coach_combox.SelectedIndexChanged += coach_combox_SelectedIndexChanged;
            // 
            // parti_txtbox
            // 
            parti_txtbox.Location = new Point(150, 20);
            parti_txtbox.Margin = new Padding(3, 2, 3, 2);
            parti_txtbox.Name = "parti_txtbox";
            parti_txtbox.Size = new Size(110, 23);
            parti_txtbox.TabIndex = 15;
            // 
            // coachname_txtbox
            // 
            coachname_txtbox.Location = new Point(147, 70);
            coachname_txtbox.Margin = new Padding(3, 2, 3, 2);
            coachname_txtbox.Name = "coachname_txtbox";
            coachname_txtbox.Size = new Size(110, 23);
            coachname_txtbox.TabIndex = 17;
            // 
            // participants_lbl
            // 
            participants_lbl.AutoSize = true;
            participants_lbl.Location = new Point(0, 26);
            participants_lbl.Name = "participants_lbl";
            participants_lbl.Size = new Size(69, 15);
            participants_lbl.TabIndex = 14;
            participants_lbl.Text = "Participants";
            // 
            // coachreq_lbl
            // 
            coachreq_lbl.AutoSize = true;
            coachreq_lbl.Location = new Point(0, 51);
            coachreq_lbl.Name = "coachreq_lbl";
            coachreq_lbl.Size = new Size(91, 15);
            coachreq_lbl.TabIndex = 16;
            coachreq_lbl.Text = "Coach required:";
            // 
            // grpbooking_rdobtn
            // 
            grpbooking_rdobtn.AutoSize = true;
            grpbooking_rdobtn.Location = new Point(33, 206);
            grpbooking_rdobtn.Margin = new Padding(3, 2, 3, 2);
            grpbooking_rdobtn.Name = "grpbooking_rdobtn";
            grpbooking_rdobtn.Size = new Size(110, 19);
            grpbooking_rdobtn.TabIndex = 59;
            grpbooking_rdobtn.TabStop = true;
            grpbooking_rdobtn.Text = "Group bookings";
            grpbooking_rdobtn.UseVisualStyleBackColor = true;
            grpbooking_rdobtn.CheckedChanged += grpbooking_rdobtn_CheckedChanged;
            // 
            // goldcard_lbl
            // 
            goldcard_lbl.AutoSize = true;
            goldcard_lbl.Location = new Point(-3, 34);
            goldcard_lbl.Name = "goldcard_lbl";
            goldcard_lbl.Size = new Size(108, 15);
            goldcard_lbl.TabIndex = 57;
            goldcard_lbl.Text = "Gold Card Member";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(151, 40);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(229, 23);
            dateTimePicker1.TabIndex = 61;
            // 
            // contactemail_txtbox
            // 
            contactemail_txtbox.Location = new Point(155, 166);
            contactemail_txtbox.Margin = new Padding(3, 2, 3, 2);
            contactemail_txtbox.Name = "contactemail_txtbox";
            contactemail_txtbox.Size = new Size(110, 23);
            contactemail_txtbox.TabIndex = 56;
            contactemail_txtbox.TextChanged += contactemail_txtbox_TextChanged;
            // 
            // contactemail_lbl
            // 
            contactemail_lbl.AutoSize = true;
            contactemail_lbl.Location = new Point(6, 171);
            contactemail_lbl.Name = "contactemail_lbl";
            contactemail_lbl.Size = new Size(81, 15);
            contactemail_lbl.TabIndex = 55;
            contactemail_lbl.Text = "Contact email";
            // 
            // contactname_txtbox
            // 
            contactname_txtbox.Location = new Point(155, 141);
            contactname_txtbox.Margin = new Padding(3, 2, 3, 2);
            contactname_txtbox.Name = "contactname_txtbox";
            contactname_txtbox.Size = new Size(110, 23);
            contactname_txtbox.TabIndex = 54;
            // 
            // contactname_lbl
            // 
            contactname_lbl.AutoSize = true;
            contactname_lbl.Location = new Point(6, 146);
            contactname_lbl.Name = "contactname_lbl";
            contactname_lbl.Size = new Size(82, 15);
            contactname_lbl.TabIndex = 53;
            contactname_lbl.Text = "Contact name";
            contactname_lbl.Click += contactname_lbl_Click;
            // 
            // activity_lbl
            // 
            activity_lbl.AutoSize = true;
            activity_lbl.Location = new Point(10, 122);
            activity_lbl.Name = "activity_lbl";
            activity_lbl.Size = new Size(47, 15);
            activity_lbl.TabIndex = 51;
            activity_lbl.Text = "Activity";
            // 
            // duration_txtbox
            // 
            duration_txtbox.Location = new Point(155, 91);
            duration_txtbox.Margin = new Padding(3, 2, 3, 2);
            duration_txtbox.Name = "duration_txtbox";
            duration_txtbox.Size = new Size(31, 23);
            duration_txtbox.TabIndex = 50;
            duration_txtbox.TextChanged += textBox4_TextChanged;
            // 
            // duration_lbl
            // 
            duration_lbl.AutoSize = true;
            duration_lbl.Location = new Point(10, 96);
            duration_lbl.Name = "duration_lbl";
            duration_lbl.Size = new Size(53, 15);
            duration_lbl.TabIndex = 49;
            duration_lbl.Text = "Duration";
            // 
            // starttime_lbl
            // 
            starttime_lbl.AutoSize = true;
            starttime_lbl.Location = new Point(10, 71);
            starttime_lbl.Name = "starttime_lbl";
            starttime_lbl.Size = new Size(58, 15);
            starttime_lbl.TabIndex = 47;
            starttime_lbl.Text = "Start time";
            // 
            // date_lbl
            // 
            date_lbl.AutoSize = true;
            date_lbl.Location = new Point(6, 46);
            date_lbl.Name = "date_lbl";
            date_lbl.Size = new Size(31, 15);
            date_lbl.TabIndex = 46;
            date_lbl.Text = "Date";
            // 
            // id_txtbox
            // 
            id_txtbox.Location = new Point(151, 16);
            id_txtbox.Margin = new Padding(3, 2, 3, 2);
            id_txtbox.Name = "id_txtbox";
            id_txtbox.Size = new Size(110, 23);
            id_txtbox.TabIndex = 45;
            // 
            // id_lbl
            // 
            id_lbl.AutoSize = true;
            id_lbl.Location = new Point(10, 22);
            id_lbl.Name = "id_lbl";
            id_lbl.Size = new Size(18, 15);
            id_lbl.TabIndex = 44;
            id_lbl.Text = "ID";
            // 
            // notificationLabel
            // 
            notificationLabel.AutoSize = true;
            notificationLabel.ForeColor = Color.Red;
            notificationLabel.Location = new Point(163, -1);
            notificationLabel.Name = "notificationLabel";
            notificationLabel.Size = new Size(38, 15);
            notificationLabel.TabIndex = 65;
            notificationLabel.Text = "label1";
            // 
            // hours_lbl
            // 
            hours_lbl.AutoSize = true;
            hours_lbl.Location = new Point(191, 96);
            hours_lbl.Name = "hours_lbl";
            hours_lbl.Size = new Size(39, 15);
            hours_lbl.TabIndex = 66;
            hours_lbl.Text = "Hours";
            hours_lbl.Click += label1_Click;
            // 
            // activity_combox
            // 
            activity_combox.FormattingEnabled = true;
            activity_combox.Items.AddRange(new object[] { "Football", "Basketball", "Table tennis", "Tennis", "Volleyball", "Handball", "Rugby" });
            activity_combox.Location = new Point(155, 116);
            activity_combox.Margin = new Padding(3, 2, 3, 2);
            activity_combox.Name = "activity_combox";
            activity_combox.Size = new Size(110, 23);
            activity_combox.TabIndex = 67;
            // 
            // goldcard_combox
            // 
            goldcard_combox.FormattingEnabled = true;
            goldcard_combox.Items.AddRange(new object[] { "Yes", "No" });
            goldcard_combox.Location = new Point(150, 28);
            goldcard_combox.Margin = new Padding(3, 2, 3, 2);
            goldcard_combox.Name = "goldcard_combox";
            goldcard_combox.Size = new Size(110, 23);
            goldcard_combox.TabIndex = 69;
            goldcard_combox.SelectedIndexChanged += goldcard_combox_SelectedIndexChanged;
            // 
            // memno_txtbox
            // 
            memno_txtbox.Location = new Point(150, 54);
            memno_txtbox.Margin = new Padding(3, 2, 3, 2);
            memno_txtbox.Name = "memno_txtbox";
            memno_txtbox.Size = new Size(110, 23);
            memno_txtbox.TabIndex = 70;
            // 
            // member_lbl
            // 
            member_lbl.AutoSize = true;
            member_lbl.Location = new Point(-3, 59);
            member_lbl.Name = "member_lbl";
            member_lbl.Size = new Size(122, 15);
            member_lbl.TabIndex = 71;
            member_lbl.Text = "Membership number:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(goldcard_combox);
            groupBox2.Controls.Add(member_lbl);
            groupBox2.Controls.Add(goldcard_lbl);
            groupBox2.Controls.Add(memno_txtbox);
            groupBox2.Location = new Point(33, 352);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(270, 99);
            groupBox2.TabIndex = 72;
            groupBox2.TabStop = false;
            // 
            // indvbooking_rdobtn
            // 
            indvbooking_rdobtn.AutoSize = true;
            indvbooking_rdobtn.Location = new Point(30, 341);
            indvbooking_rdobtn.Margin = new Padding(3, 2, 3, 2);
            indvbooking_rdobtn.Name = "indvbooking_rdobtn";
            indvbooking_rdobtn.Size = new Size(129, 19);
            indvbooking_rdobtn.TabIndex = 73;
            indvbooking_rdobtn.TabStop = true;
            indvbooking_rdobtn.Text = "Individual bookings";
            indvbooking_rdobtn.UseVisualStyleBackColor = true;
            indvbooking_rdobtn.CheckedChanged += indvbooking_rdobtn_CheckedChanged;
            // 
            // back_btn
            // 
            back_btn.Location = new Point(2, 481);
            back_btn.Margin = new Padding(3, 2, 3, 2);
            back_btn.Name = "back_btn";
            back_btn.Size = new Size(86, 24);
            back_btn.TabIndex = 73;
            back_btn.Text = "BACK";
            back_btn.UseVisualStyleBackColor = true;
            back_btn.Click += back_btn_Click;
            // 
            // clear_btn
            // 
            clear_btn.Location = new Point(285, 481);
            clear_btn.Margin = new Padding(3, 2, 3, 2);
            clear_btn.Name = "clear_btn";
            clear_btn.Size = new Size(86, 24);
            clear_btn.TabIndex = 74;
            clear_btn.Text = "CLEAR";
            clear_btn.UseVisualStyleBackColor = true;
            clear_btn.Click += clear_btn_Click;
            // 
            // starttime_txtbox
            // 
            starttime_txtbox.Location = new Point(151, 64);
            starttime_txtbox.Margin = new Padding(3, 2, 3, 2);
            starttime_txtbox.Name = "starttime_txtbox";
            starttime_txtbox.Size = new Size(229, 23);
            starttime_txtbox.TabIndex = 75;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 514);
            Controls.Add(starttime_txtbox);
            Controls.Add(indvbooking_rdobtn);
            Controls.Add(clear_btn);
            Controls.Add(back_btn);
            Controls.Add(groupBox2);
            Controls.Add(activity_combox);
            Controls.Add(hours_lbl);
            Controls.Add(grpbooking_rdobtn);
            Controls.Add(notificationLabel);
            Controls.Add(makeBooking);
            Controls.Add(groupBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(contactemail_txtbox);
            Controls.Add(contactemail_lbl);
            Controls.Add(contactname_txtbox);
            Controls.Add(contactname_lbl);
            Controls.Add(activity_lbl);
            Controls.Add(duration_txtbox);
            Controls.Add(duration_lbl);
            Controls.Add(starttime_lbl);
            Controls.Add(date_lbl);
            Controls.Add(id_txtbox);
            Controls.Add(id_lbl);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BOOKING FORM";
            Load += Form3_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button makeBooking;
        private GroupBox groupBox1;
        private TextBox parti_txtbox;
        private Label participants_lbl;
        private Label coachreq_lbl;
        private RadioButton grpbooking_rdobtn;
        private Label goldcard_lbl;
        private DateTimePicker dateTimePicker1;
        private TextBox contactemail_txtbox;
        private Label contactemail_lbl;
        private TextBox contactname_txtbox;
        private Label contactname_lbl;
        private Label activity_lbl;
        private TextBox duration_txtbox;
        private Label duration_lbl;
        private Label starttime_lbl;
        private Label date_lbl;
        private TextBox id_txtbox;
        private Label id_lbl;
        private Label notificationLabel;
        private Label hours_lbl;
        private ComboBox activity_combox;
        private ComboBox coach_combox;
        private TextBox coachname_txtbox;
        private ComboBox goldcard_combox;
        private Label coachname_lbl;
        private TextBox memno_txtbox;
        private Label member_lbl;
        private GroupBox groupBox2;
        private RadioButton indvbooking_rdobtn;
        private Button back_btn;
        private Button clear_btn;
        private DateTimePicker starttime_txtbox;
    }
}