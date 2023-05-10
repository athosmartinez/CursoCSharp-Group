using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seção11_3.Entities
{
    internal class Reservation
    {

        public int RoomNumber { get; set; }
        public DateTime Checkin { get; set; }
        public DateTime Checkout { get; set; }

        public Reservation() { }

        public Reservation(int roomNumber, DateTime checkin, DateTime checkout)
        {
            RoomNumber = roomNumber;
            Checkin = checkin;
            Checkout = checkout;
        }

        public int Duration()
        {
            TimeSpan duration = Checkout.Subtract(Checkin);
            return (int)duration.TotalDays;
        }

        public string UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            DateTime now = DateTime.Now;
            if (checkIn < now || checkOut < now)
            {
                return " Reservation dates must be future dates";
            }
            if (checkOut <= checkIn)
            {
                return "Checkout date must be after checkin";
            }

            Checkin = checkIn;
            Checkout = checkOut;
            return null;

        }

        public override string ToString()
        {
            return "Room: " + RoomNumber + ", Checkin: " + Checkin.ToString("dd/MM/yyyy") + " Checkout: " + Checkout.ToString("dd/MM/yyyy") + ", " + Duration() + " nights.";
        }
    }
}
