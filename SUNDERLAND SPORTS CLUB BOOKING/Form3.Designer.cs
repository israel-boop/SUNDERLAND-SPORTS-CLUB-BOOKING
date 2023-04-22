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
            starttime_txtbox = new TextBox();
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
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // makeBooking
            // 
            makeBooking.Location = new Point(156, 641);
            makeBooking.Name = "makeBooking";
            makeBooking.Size = new Size(98, 32);
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
            groupBox1.Controls.Add(grpbooking_rdobtn);
            groupBox1.Location = new Point(2, 292);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(309, 142);
            groupBox1.TabIndex = 60;
            groupBox1.TabStop = false;
            // 
            // coachname_lbl
            // 
            coachname_lbl.AutoSize = true;
            coachname_lbl.Location = new Point(0, 101);
            coachname_lbl.Name = "coachname_lbl";
            coachname_lbl.Size = new Size(94, 20);
            coachname_lbl.TabIndex = 69;
            coachname_lbl.Text = "Coach name:";
            // 
            // coach_combox
            // 
            coach_combox.FormattingEnabled = true;
            coach_combox.Items.AddRange(new object[] { "Yes", "No" });
            coach_combox.Location = new Point(168, 60);
            coach_combox.Name = "coach_combox";
            coach_combox.Size = new Size(125, 28);
            coach_combox.TabIndex = 68;
            coach_combox.SelectedIndexChanged += coach_combox_SelectedIndexChanged;
            // 
            // parti_txtbox
            // 
            parti_txtbox.Location = new Point(171, 27);
            parti_txtbox.Name = "parti_txtbox";
            parti_txtbox.Size = new Size(125, 27);
            parti_txtbox.TabIndex = 15;
            // 
            // coachname_txtbox
            // 
            coachname_txtbox.Location = new Point(168, 94);
            coachname_txtbox.Name = "coachname_txtbox";
            coachname_txtbox.Size = new Size(125, 27);
            coachname_txtbox.TabIndex = 17;
            // 
            // participants_lbl
            // 
            participants_lbl.AutoSize = true;
            participants_lbl.Location = new Point(0, 34);
            participants_lbl.Name = "participants_lbl";
            participants_lbl.Size = new Size(85, 20);
            participants_lbl.TabIndex = 14;
            participants_lbl.Text = "Participants";
            // 
            // coachreq_lbl
            // 
            coachreq_lbl.AutoSize = true;
            coachreq_lbl.Location = new Point(0, 68);
            coachreq_lbl.Name = "coachreq_lbl";
            coachreq_lbl.Size = new Size(113, 20);
            coachreq_lbl.TabIndex = 16;
            coachreq_lbl.Text = "Coach required:";
            // 
            // grpbooking_rdobtn
            // 
            grpbooking_rdobtn.AutoSize = true;
            grpbooking_rdobtn.Location = new Point(0, 7);
            grpbooking_rdobtn.Name = "grpbooking_rdobtn";
            grpbooking_rdobtn.Size = new Size(136, 24);
            grpbooking_rdobtn.TabIndex = 59;
            grpbooking_rdobtn.TabStop = true;
            grpbooking_rdobtn.Text = "Group bookings";
            grpbooking_rdobtn.UseVisualStyleBackColor = true;
            grpbooking_rdobtn.CheckedChanged += grpbooking_rdobtn_CheckedChanged;
            // 
            // goldcard_lbl
            // 
            goldcard_lbl.AutoSize = true;
            goldcard_lbl.Location = new Point(-3, 46);
            goldcard_lbl.Name = "goldcard_lbl";
            goldcard_lbl.Size = new Size(136, 20);
            goldcard_lbl.TabIndex = 57;
            goldcard_lbl.Text = "Gold Card Member";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(173, 57);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(261, 27);
            dateTimePicker1.TabIndex = 61;
            // 
            // contactemail_txtbox
            // 
            contactemail_txtbox.Location = new Point(177, 221);
            contactemail_txtbox.Name = "contactemail_txtbox";
            contactemail_txtbox.Size = new Size(125, 27);
            contactemail_txtbox.TabIndex = 56;
            contactemail_txtbox.TextChanged += contactemail_txtbox_TextChanged;
            // 
            // contactemail_lbl
            // 
            contactemail_lbl.AutoSize = true;
            contactemail_lbl.Location = new Point(7, 228);
            contactemail_lbl.Name = "contactemail_lbl";
            contactemail_lbl.Size = new Size(101, 20);
            contactemail_lbl.TabIndex = 55;
            contactemail_lbl.Text = "Contact email";
            // 
            // contactname_txtbox
            // 
            contactname_txtbox.Location = new Point(177, 188);
            contactname_txtbox.Name = "contactname_txtbox";
            contactname_txtbox.Size = new Size(125, 27);
            contactname_txtbox.TabIndex = 54;
            // 
            // contactname_lbl
            // 
            contactname_lbl.AutoSize = true;
            contactname_lbl.Location = new Point(7, 195);
            contactname_lbl.Name = "contactname_lbl";
            contactname_lbl.Size = new Size(101, 20);
            contactname_lbl.TabIndex = 53;
            contactname_lbl.Text = "Contact name";
            contactname_lbl.Click += contactname_lbl_Click;
            // 
            // activity_lbl
            // 
            activity_lbl.AutoSize = true;
            activity_lbl.Location = new Point(12, 162);
            activity_lbl.Name = "activity_lbl";
            activity_lbl.Size = new Size(58, 20);
            activity_lbl.TabIndex = 51;
            activity_lbl.Text = "Activity";
            // 
            // duration_txtbox
            // 
            duration_txtbox.Location = new Point(177, 121);
            duration_txtbox.Name = "duration_txtbox";
            duration_txtbox.Size = new Size(35, 27);
            duration_txtbox.TabIndex = 50;
            duration_txtbox.TextChanged += textBox4_TextChanged;
            // 
            // duration_lbl
            // 
            duration_lbl.AutoSize = true;
            duration_lbl.Location = new Point(12, 128);
            duration_lbl.Name = "duration_lbl";
            duration_lbl.Size = new Size(67, 20);
            duration_lbl.TabIndex = 49;
            duration_lbl.Text = "Duration";
            // 
            // starttime_txtbox
            // 
            starttime_txtbox.Location = new Point(177, 88);
            starttime_txtbox.Name = "starttime_txtbox";
            starttime_txtbox.Size = new Size(125, 27);
            starttime_txtbox.TabIndex = 48;
            // 
            // starttime_lbl
            // 
            starttime_lbl.AutoSize = true;
            starttime_lbl.Location = new Point(12, 95);
            starttime_lbl.Name = "starttime_lbl";
            starttime_lbl.Size = new Size(74, 20);
            starttime_lbl.TabIndex = 47;
            starttime_lbl.Text = "Start time";
            // 
            // date_lbl
            // 
            date_lbl.AutoSize = true;
            date_lbl.Location = new Point(7, 62);
            date_lbl.Name = "date_lbl";
            date_lbl.Size = new Size(41, 20);
            date_lbl.TabIndex = 46;
            date_lbl.Text = "Date";
            // 
            // id_txtbox
            // 
            id_txtbox.Location = new Point(173, 22);
            id_txtbox.Name = "id_txtbox";
            id_txtbox.Size = new Size(125, 27);
            id_txtbox.TabIndex = 45;
            // 
            // id_lbl
            // 
            id_lbl.AutoSize = true;
            id_lbl.Location = new Point(12, 29);
            id_lbl.Name = "id_lbl";
            id_lbl.Size = new Size(24, 20);
            id_lbl.TabIndex = 44;
            id_lbl.Text = "ID";
            // 
            // notificationLabel
            // 
            notificationLabel.AutoSize = true;
            notificationLabel.ForeColor = Color.Red;
            notificationLabel.Location = new Point(186, -1);
            notificationLabel.Name = "notificationLabel";
            notificationLabel.Size = new Size(50, 20);
            notificationLabel.TabIndex = 65;
            notificationLabel.Text = "label1";
            // 
            // hours_lbl
            // 
            hours_lbl.AutoSize = true;
            hours_lbl.Location = new Point(218, 128);
            hours_lbl.Name = "hours_lbl";
            hours_lbl.Size = new Size(48, 20);
            hours_lbl.TabIndex = 66;
            hours_lbl.Text = "Hours";
            hours_lbl.Click += label1_Click;
            // 
            // activity_combox
            // 
            activity_combox.FormattingEnabled = true;
            activity_combox.Items.AddRange(new object[] { "Football", "Basketball", "Table tennis", "Tennis", "Volleyball", "Handball", "Rugby" });
            activity_combox.Location = new Point(177, 154);
            activity_combox.Name = "activity_combox";
            activity_combox.Size = new Size(125, 28);
            activity_combox.TabIndex = 67;
            // 
            // goldcard_combox
            // 
            goldcard_combox.FormattingEnabled = true;
            goldcard_combox.Items.AddRange(new object[] { "Yes", "No" });
            goldcard_combox.Location = new Point(171, 38);
            goldcard_combox.Name = "goldcard_combox";
            goldcard_combox.Size = new Size(125, 28);
            goldcard_combox.TabIndex = 69;
            goldcard_combox.SelectedIndexChanged += goldcard_combox_SelectedIndexChanged;
            // 
            // memno_txtbox
            // 
            memno_txtbox.Location = new Point(171, 72);
            memno_txtbox.Name = "memno_txtbox";
            memno_txtbox.Size = new Size(125, 27);
            memno_txtbox.TabIndex = 70;
            // 
            // member_lbl
            // 
            member_lbl.AutoSize = true;
            member_lbl.Location = new Point(-3, 79);
            member_lbl.Name = "member_lbl";
            member_lbl.Size = new Size(150, 20);
            member_lbl.TabIndex = 71;
            member_lbl.Text = "Membership number:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(indvbooking_rdobtn);
            groupBox2.Controls.Add(goldcard_combox);
            groupBox2.Controls.Add(member_lbl);
            groupBox2.Controls.Add(goldcard_lbl);
            groupBox2.Controls.Add(memno_txtbox);
            groupBox2.Location = new Point(2, 470);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(309, 132);
            groupBox2.TabIndex = 72;
            groupBox2.TabStop = false;
            // 
            // indvbooking_rdobtn
            // 
            indvbooking_rdobtn.AutoSize = true;
            indvbooking_rdobtn.Location = new Point(0, 10);
            indvbooking_rdobtn.Name = "indvbooking_rdobtn";
            indvbooking_rdobtn.Size = new Size(160, 24);
            indvbooking_rdobtn.TabIndex = 73;
            indvbooking_rdobtn.TabStop = true;
            indvbooking_rdobtn.Text = "Individual bookings";
            indvbooking_rdobtn.UseVisualStyleBackColor = true;
            indvbooking_rdobtn.CheckedChanged += indvbooking_rdobtn_CheckedChanged;
            // 
            // back_btn
            // 
            back_btn.Location = new Point(2, 641);
            back_btn.Name = "back_btn";
            back_btn.Size = new Size(98, 32);
            back_btn.TabIndex = 73;
            back_btn.Text = "BACK";
            back_btn.UseVisualStyleBackColor = true;
            back_btn.Click += back_btn_Click;
            // 
            // clear_btn
            // 
            clear_btn.Location = new Point(326, 641);
            clear_btn.Name = "clear_btn";
            clear_btn.Size = new Size(98, 32);
            clear_btn.TabIndex = 74;
            clear_btn.Text = "CLEAR";
            clear_btn.UseVisualStyleBackColor = true;
            clear_btn.Click += clear_btn_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(436, 685);
            Controls.Add(clear_btn);
            Controls.Add(back_btn);
            Controls.Add(groupBox2);
            Controls.Add(activity_combox);
            Controls.Add(hours_lbl);
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
            Controls.Add(starttime_txtbox);
            Controls.Add(starttime_lbl);
            Controls.Add(date_lbl);
            Controls.Add(id_txtbox);
            Controls.Add(id_lbl);
            FormBorderStyle = FormBorderStyle.FixedSingle;
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
        private TextBox starttime_txtbox;
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
    }
}