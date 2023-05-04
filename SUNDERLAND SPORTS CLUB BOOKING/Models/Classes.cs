using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SUNDERLAND_SPORTS_CLUB_BOOKING.Models
{
    internal class Classes
    {
        public Classes() { }


        //method to filter the items in the data table of the booking manager
        public bool IsEmailValid(string emailaddress)
        {
            try
            {
                MailAddress m = new MailAddress(emailaddress);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
    }
}
