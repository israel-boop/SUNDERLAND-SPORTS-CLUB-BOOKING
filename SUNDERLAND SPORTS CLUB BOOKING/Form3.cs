using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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


            if (string.IsNullOrEmpty(id)
                || string.IsNullOrEmpty(starttime_txtbox.Text)
                || string.IsNullOrEmpty(duration_txtbox.Text)
                || string.IsNullOrEmpty(activity_txtbox.Text)
                || string.IsNullOrEmpty(contactname_txtbox.Text)
                || string.IsNullOrEmpty(contactemail_txtbox.Text)
                )
            {
                notificationLabel.Text = " Fields cannot be empty()";

            }
            else
            {

            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            notificationLabel.Hide();
        }
    }
}
