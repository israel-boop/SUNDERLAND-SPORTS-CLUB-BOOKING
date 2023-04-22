using SUNDERLAND_SPORTS_CLUB_BOOKING.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
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


            if (string.IsNullOrEmpty(id)
                || string.IsNullOrEmpty(starttime_txtbox.Text)
                || string.IsNullOrEmpty(duration_txtbox.Text)
                || string.IsNullOrEmpty(activity_combox.Text)
                || string.IsNullOrEmpty(contactname_txtbox.Text)
                || string.IsNullOrEmpty(contactemail_txtbox.Text)
                )
            {

                notificationLabel.Show();
                notificationLabel.Text = " Fields cannot be empty";

            }
            else
            {

                BookingClass bkclass = new BookingClass(id, contactName, contactEmail, activity, duration, startTime);
                BookingClass bkclassRet = new BookingClass();

                DataTable bookingTable = new DataTable();
                bookingTable.Columns.Add("id", typeof(string));
                bookingTable.Columns.Add("contact", typeof(string));
                bookingTable.Columns.Add("contactEmail", typeof(string));
                bookingTable.Columns.Add("activity", typeof(string));
                bookingTable.Columns.Add("duration", typeof(string));
                bookingTable.Columns.Add("starttime", typeof(string));



                BinaryFormatter bf = new BinaryFormatter();

                FileStream serialiseFunc = new FileStream("booking.dat", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None);
                Console.WriteLine(serialiseFunc.Name);
                try
                {
                    using (serialiseFunc)
                    {
                        if (serialiseFunc.Length != 0)
                        {
                            bookingTable = (DataTable)bf.Deserialize(serialiseFunc);
                            bookingTable.Rows.Add(bkclassRet.BookingID, bkclassRet.ContactName, bkclassRet.ContactEmail, bkclassRet.Activity, bkclassRet.Duration, bkclassRet.StartTime);
                            bookingTable.Rows.Add(bkclass.BookingID, bkclass.ContactName, bkclass.ContactEmail, bkclass.Activity, bkclass.Duration, bkclass.StartTime);
                            bf.Serialize(serialiseFunc, bookingTable);
                        }
                        else
                        {
                            bookingTable.Rows.Add(bkclass.BookingID, bkclass.ContactName, bkclass.ContactEmail, bkclass.Activity, bkclass.Duration, bkclass.StartTime);
                            bf.Serialize(serialiseFunc, bookingTable);
                        }
                        notificationLabel.Show();
                        notificationLabel.Text = "Object Serialized";
                    }
                }
                catch (Exception ex)
                {
                    notificationLabel.Show();
                    notificationLabel.Text = ex.Message;
                }
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
