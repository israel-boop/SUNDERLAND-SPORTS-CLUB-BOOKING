using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUNDERLAND_SPORTS_CLUB_BOOKING.Models
{
    [Serializable]
    public class BookingClasses : CollectionBase 
    {
        public BookingClasses()
        {
        }
        public void Add(BookingClass objT)
        {
            this.List.Add(objT);
        }
        //Indexer  
        public BookingClass this[int i]
        {
            get
            {
                return (BookingClass)this.List[i];
            }
            set
            {
                this.List.Add(value);
            }
        }
    }
}

