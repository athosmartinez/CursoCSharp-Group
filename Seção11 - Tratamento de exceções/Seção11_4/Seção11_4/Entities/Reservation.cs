using Seção11_4.Entities.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seção11_4.Entities
{
    internal class Reservation
    {

        public int RoomNumber { get; set; }
        public DateTime Checkin { get; set; }
        public DateTime Checkout { get; set; }

        public Reservation() { }

        public Reservation(int roomNumber, DateTime checkin, DateTime checkout)
        {

            if (checkout <= checkin )
            {
                throw new DomainException("Checkout date must be after checkin");
            }

            RoomNumber = roomNumber;
            Checkin = checkin;
            Checkout = checkout;
        }

        public int Duration()
        {
            TimeSpan duration = Checkout.Subtract(Checkin);
            return (int)duration.TotalDays;
        }

        public void UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            DateTime now = DateTime.Now;
            if (checkIn < now || checkOut < now)
            {
                throw new DomainException(" Reservation dates must be future dates");
            }
            if (checkOut <= checkIn)
            {
                throw new DomainException("Checkout date must be after checkin");
            }

            Checkin = checkIn;
            Checkout = checkOut;


        }

        public override string ToString()
        {
            return "Room: " + RoomNumber + ", Checkin: " + Checkin.ToString("dd/MM/yyyy") + " Checkout: " + Checkout.ToString("dd/MM/yyyy") + ", " + Duration() + " nights.";
        }
    }
}
