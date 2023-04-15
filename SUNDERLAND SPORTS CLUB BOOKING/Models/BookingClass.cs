using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUNDERLAND_SPORTS_CLUB_BOOKING.Models
{
    [Serializable]
    internal class BookingClass
    {   
        string bookingID;
        string contactName;
        string contactEmail;
        string activity;
        string duration;
        string startTime;

        public BookingClass(){

        }

        public BookingClass(string bookingID, string contactName, string contactEmail, string activity, string duration, string startTime)
        {
            this.bookingID = bookingID;
            this.contactName = contactName;
            this.contactEmail = contactEmail;
            this.activity = activity;
            this.duration = duration;
            this.startTime = startTime;
        }

        public string BookingID { get => bookingID; set => bookingID = value; }
        public string ContactName { get => contactName; set => contactName = value; }
        public string ContactEmail { get => contactEmail; set => contactEmail = value; }
        public string Activity { get => activity; set => activity = value; }
        public string Duration { get => duration; set => duration = value; }
        public string StartTime { get => startTime; set => startTime = value; }
    }
}
