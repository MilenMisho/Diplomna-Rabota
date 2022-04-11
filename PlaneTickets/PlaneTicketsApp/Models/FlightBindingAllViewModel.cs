using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;

namespace PlaneTicketsApp.Models
{
    public class FlightBindingAllViewModel
    {
        public int Id { get; set; }
        public int FlightNumber { get; set; }
        public string StartingDestination { get; set; }
        public string EndingDestination { get; set; }
        public DateTime TakeOffDateAndTime { get; set; }
        public DateTime LandingDateAndTime { get; set; }
        public virtual Plane Plane { get; set; }
        public int PricePerTicket { get; set; }
        public decimal Discount { get; set; }
        //public Plane Plane { get; set; }
    }
}
