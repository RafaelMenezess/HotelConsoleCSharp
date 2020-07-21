using System;
using Hotel.Entities;
using Hotel.Entities.Excepetions;

namespace Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {


                Console.Write("Room number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Check-in date (dd/MM/yyyy): ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());


                Reservation reservation = new Reservation(number, checkIn, checkOut);
                Console.WriteLine("Reservation: " + reservation);

                Console.WriteLine();
                Console.WriteLine("Enter data to update the reservation: ");
                Console.Write("Check-in date (dd/MM/yyyy): ");
                DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                DateTime.Parse(Console.ReadLine());

                reservation.Upadates(checkIn, checkOut);
                Console.WriteLine("Reservation: " + reservation);
            }
            catch(DomainExcepetion e)
            {
                Console.WriteLine("Error in reservation: " + e.Message);
            }
            catch(FormatException e)
            {
                Console.WriteLine("Format erros: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected errror: " + e.Message);
            }
        }
    }
}

