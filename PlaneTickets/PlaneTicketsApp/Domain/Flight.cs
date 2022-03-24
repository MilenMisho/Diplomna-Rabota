using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlaneTicketsApp.Domain
{
    public class Flight
    {
        public int FlightId { get; set; }
        public int FlightNumber { get; set; }
        public string StartingDestination { get; set; }
        public string EndingDestination { get; set; }
        public int TakeOffDateAndTime { get; set; }
        public int LandingDateAndTime { get; set; }
        public string Plane { get; set; }
        public int PricePerTicket { get; set; }
    }
}
