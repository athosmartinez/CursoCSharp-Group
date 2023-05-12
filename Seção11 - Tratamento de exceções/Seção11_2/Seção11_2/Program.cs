using Seção11_2.Entities;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Room number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Checkin Date (dd/MM/yyyy): ");
            DateTime checkIn = DateTime.Parse(Console.ReadLine());
            Console.Write("Checkout Date (dd/MM/yyyy): ");
            DateTime checkOut = DateTime.Parse(Console.ReadLine());


            if (checkOut <= checkIn)
            {
                Console.WriteLine("Error in reservation: Checkout date must be after checkin");
            }
            else
            {
                Reservation reservation = new Reservation(number, checkIn, checkOut);
                Console.WriteLine("Reservation: " + reservation);


                Console.WriteLine();

                Console.WriteLine("Enter data to update the reservation: ");
                Console.Write("Checkin Date (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Checkout Date (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());
                //Atualizar reserva
                DateTime now = DateTime.Now;
                if (checkIn < now || checkOut < now)
                {
                    Console.WriteLine("Error in reservation: Reservation dates must be future dates");
                }
                else if (checkOut <= checkIn)
                {
                    Console.WriteLine("Error in reservation: Checkout date must be after checkin");
                }
                else
                {
                    reservation.UpdateDates(checkIn, checkOut);
                    Console.WriteLine("Reservetion: " + reservation);
                }

            }


        }
    }
}