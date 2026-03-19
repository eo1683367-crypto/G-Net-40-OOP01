using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using G_Net_40_OOP01.Enums;
using G_Net_40_OOP01.MyStructs;

namespace G_Net_40_OOP01.MyClasses
{
    internal class Ticket
    {
       
        #region Attributess
        public string MovieName { get; set; }
        public TicketType Type { get; set; }
        public SeatLocation SeatLocation { get; set; }
        private decimal Price { get; set; }
        #endregion

        #region Constructor
        public Ticket(string movieName, TicketType ticketType, SeatLocation seatLocation, decimal price)
        {
            MovieName = movieName;
            Type = ticketType;
            SeatLocation = seatLocation;
            Price = price;
        }
        public Ticket(string movieName) :this(movieName,TicketType.Standard ,new SeatLocation('A',1), 50m)
        {
          
        }
        #endregion

        #region Methods

        public double CalcTotal(double taxPercent = 14)
        {
            decimal total = Price;
            if (taxPercent > 0)
            {
                total += Price * (decimal)(taxPercent / 100);
            }
            return (double)total;
        }

        public double ApplyDiscount(ref double discountAmount)
        {
            if (discountAmount > 0 && discountAmount <= (double)Price)
            {
                Price -= (decimal)discountAmount;
                discountAmount = 0; // Reset discount amount after applying
            }
            return (double)Price;
        }

        public void PrintTicket()
        {
            Console.WriteLine("===== Ticket Info =====");
            Console.WriteLine($"Movie    : {MovieName}");
            Console.WriteLine($"Type     : {Type}");
            Console.WriteLine($"Seat     : {SeatLocation.Row}{SeatLocation.Number}");
            Console.WriteLine($"Price    : {Price:0.00}");
            Console.WriteLine($"Total (14% tax) : {CalcTotal():0.00}\n");
        }

        public void PrintAfterDiscount(double discountBefore, double discountAfter)
        {
            Console.WriteLine("===== After Discount =====");
            Console.WriteLine($"Discount Before : {discountBefore:0.00}");
            Console.WriteLine($"Discount After  : {discountAfter:0.00}");
            Console.WriteLine($"Movie    : {MovieName}");
            Console.WriteLine($"Type     : {Type}");
            Console.WriteLine($"Seat     : {SeatLocation.Row}{SeatLocation.Number}");
            Console.WriteLine($"Price    : {Price:0.00}");
            Console.WriteLine($"Total (14% tax) : {CalcTotal():0.00}");
        }
        #endregion


    }
}
