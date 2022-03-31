using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlaneTicketsApp.Domain
{
    public class Plane
    {
        public int Id { get; set; }
        public string PlaneNumber { get; set; }
        public int BrandId { get; set; }
        public Brand Brand { get; set; }
        public string picture { get; set; }
        public string HandLuggage { get; set; }
        public string BarOnBoard { get; set; }
        public int SeatsTypeBed { get; set; }
        public int PassangerSeats { get; set; }
    }
}
