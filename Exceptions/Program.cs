using ExceptionsCourse.Entities;
using ExceptionsCourse.Entities.Exceptions;
using System;

namespace ExceptionCourse
{
    public class Program
    {
        static void Main()
        {
            try
            {
                Console.Write("Room number: ");
                int roomNumber = int.Parse(Console.ReadLine());

                Console.Write("Check-in date (dd/MM/yyyy): ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());

                Console.Write("Check-Out date (dd/MM/yyyy): ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());

                List<Reservation> reservations = new List<Reservation>();
                reservations.Add(new Reservation(roomNumber, checkIn, checkOut));

                foreach (var reservation in reservations)
                {
                    Console.WriteLine(reservation.ToString());
                }
                Console.WriteLine("Enter data to update the reservation:");
                Console.Write("Check-in date (dd/MM/yyyy): ");
                DateTime checkInUpdate = DateTime.Parse(Console.ReadLine());

                Console.Write("Check-Out date (dd/MM/yyyy): ");
                DateTime checkOutUpdate = DateTime.Parse(Console.ReadLine());

                foreach (var reservation in reservations)
                {
                    reservation.UpdateDates(checkInUpdate, checkOutUpdate);
                    Console.WriteLine(reservation.ToString());
                }
            }
            catch (DomainException error)
            {
                Console.WriteLine($"Error in reservation: {error}");
            }
        }
    }
}