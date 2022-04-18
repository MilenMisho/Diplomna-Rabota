using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PlaneTicketsApp.Models
{
    public class OrderCreateVM
    {
        [Required]
        public int FlightId { get; set; }

        public int TicketNumber { get; set; }

    }
}
