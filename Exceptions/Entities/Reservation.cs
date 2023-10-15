using System;
using System.Text;
using ExceptionsCourse.Entities.Exceptions;

namespace ExceptionsCourse.Entities
{
    public class Reservation
    {
        private int RoomNumber { get; set; }
        private DateTime CheckIng { get; set; }
        private DateTime CheckOut { get; set; }

        public Reservation(int roomNumber, DateTime checkIng, DateTime checkOut)
        {
            if (checkOut <= checkIng)
            {
                throw new DomainException("Reservation dates for update must be future dates");
            }

            RoomNumber = roomNumber;
            CheckIng = checkIng;
            CheckOut = checkOut;
        }
        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIng);
            return (int)duration.TotalDays;
        }
        public void UpdateDates(DateTime checkIng, DateTime checkOut)
        {

            if (checkIng < DateTime.Now || checkOut < DateTime.Now)
            {
                throw new DomainException("Reservation dates for update must be future dates");
            }
            if (checkOut <= checkIng)
            {
                throw new DomainException("Reservation dates for update must be future dates");
            }

            CheckIng = checkIng;
            CheckOut = checkOut;
        }
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Reservation: Room {RoomNumber}, check-in: {CheckIng.ToString("dd/MM/yyyy")}, " +
                                     $"check-out: {CheckOut.ToString("dd/MM/yyyy")}, {Duration()} nights");
            return stringBuilder.ToString();
        }
    }
}
