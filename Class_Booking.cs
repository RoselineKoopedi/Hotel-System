using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming281_Project
{
    class Class_Booking
    {
        private string bookingID;
        private DateTime bookingDate;
        private string customer;
        private string room;
        private DateTime proposedCheckInDate;
        private DateTime actualChackInDate;
        private DateTime proposedCheckOutDate;
        private DateTime actualChackOutDate;
        private DateTime cancellationDate;
        private string cancellationReason;

        public string BookingID
        {
            get
            {
                return bookingID;
            }

            set
            {
                bookingID = value;
            }
        }

        public DateTime BookingDate
        {
            get
            {
                return bookingDate;
            }

            set
            {
                bookingDate = value;
            }
        }

        public string Customer
        {
            get
            {
                return customer;
            }

            set
            {
                customer = value;
            }
        }

        public string Room
        {
            get
            {
                return room;
            }

            set
            {
                room = value;
            }
        }

        public DateTime ProposedCheckInDate
        {
            get
            {
                return proposedCheckInDate;
            }

            set
            {
                proposedCheckInDate = value;
            }
        }

        public DateTime ActualChackInDate
        {
            get
            {
                return actualChackInDate;
            }

            set
            {
                actualChackInDate = value;
            }
        }

        public DateTime ProposedCheckOutDate
        {
            get
            {
                return proposedCheckOutDate;
            }

            set
            {
                proposedCheckOutDate = value;
            }
        }

        public DateTime ActualChackOutDate
        {
            get
            {
                return actualChackOutDate;
            }

            set
            {
                actualChackOutDate = value;
            }
        }

        public DateTime CancellationDate
        {
            get
            {
                return cancellationDate;
            }

            set
            {
                cancellationDate = value;
            }
        }

        public string CancellationReason
        {
            get
            {
                return cancellationReason;
            }

            set
            {
                cancellationReason = value;
            }
        }
        public Class_Booking()
        {

        }
        public Class_Booking(string id,DateTime bookingD,string cust,string rooms,DateTime PCID,DateTime ACID,DateTime PCOD,DateTime ACOD,DateTime CD, string reason)
        {
            bookingID = id;
            bookingDate = bookingD;
            Customer = cust;
            room = rooms;
            proposedCheckInDate = PCID;
            actualChackInDate = ACID;
            ProposedCheckOutDate = PCOD;
            ActualChackOutDate = ACOD;
            cancellationDate = CD;
            CancellationReason = reason;
        }
        public override string ToString()
        {
            return string.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9}", bookingID, bookingDate, room, proposedCheckInDate, actualChackInDate, proposedCheckOutDate, ActualChackOutDate, cancellationDate, CancellationReason);
        }
        public void CheckIn(DateTime date)
        {

        }
        public void CheckOut(DateTime date)
        {

        }
    }
}
