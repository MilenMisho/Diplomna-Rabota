using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;

namespace PlaneTicketsApp.Domain
{
    public class Flight
    {
        public int Id { get; set; }
        public string FlightNumber { get; set; }
        
        public string StartingDestination { get; set; }
        public string EndingDestination { get; set; }
        public DateTime TakeOffDateAndTime { get; set; }
        public DateTime LandingDateAndTime { get; set; }
        public int PlaneId { get; set; }
        public virtual Plane Plane { get; set; }
        public decimal PricePerTicket { get; set; }
        public int Discount { get; set; }
    }
}
