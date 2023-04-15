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
            int daysRented;
            if (int.TryParse(duration_txtbox.Text, out daysRented)) ;
            {
                if (daysRented > 4 || daysRented < 1)
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
            string activity  = activity_txtbox.Text;
            string contactName = contactname_txtbox.Text;
            string contactEmail = contactemail_txtbox.Text;


            if (string.IsNullOrEmpty(id)
                || string.IsNullOrEmpty(starttime_txtbox.Text)
                || string.IsNullOrEmpty(duration_txtbox.Text)
                || string.IsNullOrEmpty(activity_txtbox.Text)
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
    }
}
