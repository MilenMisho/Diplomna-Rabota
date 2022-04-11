using PlaneTicketsApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlaneTicketsApp.Domain
{
    public class Reserve
    {
        public int Id { get; set; }
        public int FlightId { get; set; }
        public virtual Flight Flight { get; set; }
        public string UserId { get; set; }
        public virtual ApplicationUser User { get; set; }
        public DateTime DateOfReservation { get; set; }
        public int TicketNumber { get; set; }
        public decimal Price { get; set; }
        public int Discount { get; set; }
        public decimal TotalPrice { get { return TicketNumber * Price - TicketNumber * Price * Discount / 100; ; } }
    }
}
