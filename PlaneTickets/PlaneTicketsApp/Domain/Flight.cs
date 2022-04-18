using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;

namespace PlaneTicketsApp.Domain
{
    public class Flight
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Display(Name = "Flight")]
        public int FlightNumber { get; set; }
        [Display(Name = "Start")]
        public string StartingDestination { get; set; }
        [Display(Name = "End")]
        public string EndingDestination { get; set; }
        [Display(Name = "StartDateTime")]
        public DateTime TakeOffDateAndTime { get; set; }
        [Display(Name = "EndDateTime")]
        public DateTime LandingDateAndTime { get; set; }
    
        public int PlaneId { get; set; }

        public virtual Plane Plane { get; set; }
        [Display(Name = "Price")]
        public decimal PricePerTicket { get; set; }
        public int Discount { get; set; }
       
       
        [Display(Name = "Quantity")]
        public int CountTickets { get; set; }

        public virtual IEnumerable<Reserve> Reserves { get; set; }
    }
}
