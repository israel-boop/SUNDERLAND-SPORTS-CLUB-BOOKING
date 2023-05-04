using SUNDERLAND_SPORTS_CLUB_BOOKING.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Reflection.Emit;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace SUNDERLAND_SPORTS_CLUB_BOOKING
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            indvbooking_rdobtn.Checked = true;
            starttime_txtbox.Format = DateTimePickerFormat.Custom;
            starttime_txtbox.CustomFormat = "HH:mm:tt";
            starttime_txtbox.ShowUpDown = true;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //try and parse to make sure input is within allowed range
            int hoursRented;
            if (int.TryParse(duration_txtbox.Text, out hoursRented))
            {
                if (hoursRented > 4 || hoursRented < 1)
                {
                    MessageBox.Show("Please Pick between 1 to 4 Hours");
                }
            }
        }

        private void makeBooking_Click(object sender, EventArgs e)
        {
            string id = id_txtbox.Text;
            string duration = duration_txtbox.Text;
            string startTime = starttime_txtbox.Text;
            string activity = activity_combox.Text;
            string contactName = contactname_txtbox.Text;
            string contactEmail = contactemail_txtbox.Text;
            string date = dateTimePicker1.Text;

            Classes classes = new Classes();

            if (string.IsNullOrEmpty(id)
                || string.IsNullOrEmpty(starttime_txtbox.Text)
                || string.IsNullOrEmpty(duration_txtbox.Text)
                || string.IsNullOrEmpty(activity_combox.Text)
                || string.IsNullOrEmpty(contactname_txtbox.Text)
                || string.IsNullOrEmpty(contactemail_txtbox.Text)
                || string.IsNullOrEmpty(dateTimePicker1.Text)
                )
            {

                notificationLabel.Show();
                notificationLabel.Text = " Fields cannot be empty";

            }
            else if (int.TryParse(id_txtbox.Text, out int n) == false)
            {
                notificationLabel.Show();
                notificationLabel.Text = "id must be a number";

            }
            else if (classes.IsEmailValid(contactemail_txtbox.Text) == false)
            {
                notificationLabel.Show();
                notificationLabel.Text = "email is not valid";
            }
            else
            {

                string bkType;
                if (grpbooking_rdobtn.Checked == true)
                {
                    if (coach_combox.SelectedItem.ToString() == "Yes")
                    {
                        bkType = "group / " + parti_txtbox.Text + " Person/s / Coach Needed";
                    }
                   else
                    {
                        bkType = "group / " + parti_txtbox.Text + " Person/s / No Coach";
                    }
                }
                else
                {
                    if (goldcard_combox.SelectedItem.ToString() == "Yes")
                    {
                        bkType = "Individual / Gold Card Member / " + memno_txtbox.Text;
                    }
                    else
                    {
                        bkType = "Individual / non-member ";
                    }
                }

                var bookings = new List<BookingClass>();
                bookings.Add(new BookingClass() { BookingID = id, Duration = duration, StartTime = startTime, ContactEmail = contactEmail, ContactName = contactName, Activity = activity, Date = date, BkType = bkType });
                SerializeDeserialize serializeDeserialize = new SerializeDeserialize();
                serializeDeserialize.Serialize(bookings, "booking.dat");
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            notificationLabel.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void contactname_lbl_Click(object sender, EventArgs e)
        {

        }

        private void grpbooking_rdobtn_CheckedChanged(object sender, EventArgs e)
        {
            {
                if (grpbooking_rdobtn.Checked)
                {
                    groupBox2.Enabled = false;
                    indvbooking_rdobtn.Checked = false;
                }
                else
                {
                    groupBox2.Enabled = true;
                }
            }

        }

        private void indvbooking_rdobtn_CheckedChanged(object sender, EventArgs e)
        {
            {
                if (indvbooking_rdobtn.Checked)
                {
                    groupBox1.Enabled = false;
                    grpbooking_rdobtn.Checked = false;
                }
                else
                {
                    groupBox1.Enabled = true;
                }
            }

        }

        private void contactemail_txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Form2 go = new Form2();
            go.Show();
            this.Hide();
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            {
                id_txtbox.Text = "";
                dateTimePicker1.Text = "";
                starttime_txtbox.Text = "";
                duration_txtbox.Text = "";
                activity_combox.SelectedIndex = -1;
                contactname_txtbox.Text = "";
                contactemail_txtbox.Text = "";
                grpbooking_rdobtn.Checked = false;
                parti_txtbox.Text = "";
                coach_combox.SelectedIndex = -1;
                coachname_txtbox.Text = "";
                indvbooking_rdobtn.Checked = false;
                goldcard_combox.SelectedIndex = -1;
                memno_txtbox.Text = "";
                //
            }

        }

        private void coach_combox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (coach_combox.SelectedItem.ToString() == "Yes")
            {
                coachname_txtbox.Visible = true;
                coachname_lbl.Visible = true;
            }
            else
            {
                coachname_txtbox.Visible = false;
                coachname_lbl.Visible = false;
            }

        }

        private void goldcard_combox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (goldcard_combox.SelectedItem.ToString() == "Yes")
            {
                memno_txtbox.Visible = true;
                member_lbl.Visible = true;
            }
            else
            {
                memno_txtbox.Visible = false;
                member_lbl.Visible = false;
            }

        }
    }
}
