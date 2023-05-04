using SUNDERLAND_SPORTS_CLUB_BOOKING.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SUNDERLAND_SPORTS_CLUB_BOOKING
{
    public partial class BookingManager : Form
    {
        public BookingManager()
        {
            InitializeComponent();
        }

        private void BookingManager_Load(object sender, EventArgs e)
        {

            BookingClass bkclass = new BookingClass();
            BinaryFormatter bf = new BinaryFormatter();

            DataTable bookingTable = new DataTable();
            bookingTable.Columns.Add("id", typeof(string));
            bookingTable.Columns.Add("contact Name", typeof(string));
            bookingTable.Columns.Add("contact Email", typeof(string));
            bookingTable.Columns.Add("activity", typeof(string));
            bookingTable.Columns.Add("duration", typeof(string));
            bookingTable.Columns.Add("starttime", typeof(string));
            bookingTable.Columns.Add("booking Type", typeof(string));
            bookingTable.Columns.Add("date", typeof(string));


            /*     FileStream deSerialiseFunc = new FileStream("booking.dat", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None);
                 try
                 {
                     using (deSerialiseFunc)
                     {
                         bookingTable = (DataTable)bf.Deserialize(deSerialiseFunc);
                         managerNotificationLabel.Text = "Object Deserialized";


                         BookingsList.DataSource = bookingTable;
                         BookingsList.Refresh();

                     }
                 }
                 catch
                 {
                     managerNotificationLabel.Text = "An error has occured";
                 }*/
            SerializeDeserialize dr = new SerializeDeserialize();



            List<BookingClass> res = dr.Deserialize("booking.dat");

            foreach (BookingClass bookingClass in res)
            {
                bookingTable.Rows.Add(bookingClass.BookingID, bookingClass.ContactName, bookingClass.ContactEmail, bookingClass.Activity, bookingClass.Duration, bookingClass.StartTime, bookingClass.BkType, bookingClass.Date);
            }

            BookingsList.DataSource = bookingTable;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form2 go = new Form2();
            go.Show();
            this.Hide();
        }
    }
}
