using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SUNDERLAND_SPORTS_CLUB_BOOKING.Models
{
    [Serializable]
    public class BookingClass 
    {   
        string bookingID;
        string contactName;
        string contactEmail;
        string activity;
        string duration;
        string startTime;
        string date;
        string bkType;

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

        public BookingClass(string bookingID, string contactName, string contactEmail, string activity, string duration, string startTime, string date, string bkType)
        {
            this.bookingID = bookingID;
            this.contactName = contactName;
            this.contactEmail = contactEmail;
            this.activity = activity;
            this.duration = duration;
            this.startTime = startTime;
            this.date = date;
            this.bkType = bkType;
        }

        public string BookingID { get => bookingID; set => bookingID = value; }
        public string ContactName { get => contactName; set => contactName = value; }
        public string ContactEmail { get => contactEmail; set => contactEmail = value; }
        public string Activity { get => activity; set => activity = value; }
        public string Duration { get => duration; set => duration = value; }
        public string StartTime { get => startTime; set => startTime = value; }
        public string Date { get => date; set => date = value; }
        public string BkType { get => bkType; set => bkType = value; }

    }
}
