using Seção11_4.Entities;
using Seção11_4.Entities.Exceptions;
using System;
using System.ComponentModel;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Console.Write("Room number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Checkin Date (dd/MM/yyyy): ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Checkout Date (dd/MM/yyyy): ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());

                Reservation reservation = new Reservation(number, checkIn, checkOut);
                Console.WriteLine("Reservation: " + reservation);


                Console.WriteLine();

                Console.WriteLine("Enter data to update the reservation: ");
                Console.Write("Checkin Date (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Checkout Date (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());
                //Atualizar reserva

                reservation.UpdateDates(checkIn, checkOut);

                Console.WriteLine("Reservetion: " + reservation);

            }
            catch (DomainException e)
            {
                Console.WriteLine("Error in reservation: " + e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Format error: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected error: " + e.Message);
            }

        }


    }
}
