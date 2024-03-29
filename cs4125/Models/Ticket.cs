﻿namespace cs4125.Models
{
    /// <summary>
    /// Class <c> Ticket </c> models a purchasable ticket for an event.
    /// </summary>
    public class Ticket
    {
        public double BasePrice { get; set; }
        public Seat Seat { get; set; }
        public bool Purchased { get; set; }

        public Ticket(double p, Seat s)
        {
            BasePrice = p;
            Seat = s;
            Purchased = false;
        }

        public static Ticket createTicket(double price, Seat s) { 
            return new Ticket(price, s);
        }
    }
}
